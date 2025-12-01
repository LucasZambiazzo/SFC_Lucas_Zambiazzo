Imports System.ComponentModel.Design
Imports System.Data.SqlClient


Public Class frmVenta
    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Dim tabla As New DataTable
        Dim cadenaSQL As String = "SELECT idCliente, RTRIM(Apellido) + ',' + RTRIM(Nombre) AS NombreCompleto FROM Clientes_farmacia where Activo = 1 ORDER BY Apellido"
        Recuperar(cadenaSQL, tabla)

        cmbClientes.DataSource = tabla
        cmbClientes.DisplayMember = "NombreCompleto"
        cmbClientes.ValueMember = "idCliente"
        cmbClientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbClientes.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbClientes.DropDownStyle = ComboBoxStyle.DropDown


        cadenaSQL = "SELECT * FROM Medicamentos where Activo = 1 ORDER BY Medicamento"
        tabla = New DataTable
        Recuperar(cadenaSQL, tabla)

        cmbMedicamentos.DataSource = tabla
        cmbMedicamentos.DisplayMember = "Medicamento"
        cmbMedicamentos.ValueMember = "idMedicamento"
        cmbMedicamentos.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbMedicamentos.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbMedicamentos.DropDownStyle = ComboBoxStyle.DropDown

        cadenaSQL = "SELECT * from Metodos_de_pago ORDER BY Metodo"
        tabla = New DataTable
        Recuperar(cadenaSQL, tabla)

        cmbMetodos.DataSource = tabla
        cmbMetodos.DisplayMember = "Metodo"
        cmbMetodos.ValueMember = "idMetodo"
        cmbMetodos.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMetodos.SelectedIndex = 0

        dgvDetalleVenta.Columns.Add("Codigo", "Código")
        dgvDetalleVenta.Columns.Add("Medicamento", "Medicamento")
        dgvDetalleVenta.Columns.Add("Precio", "Precio Unitario")
        dgvDetalleVenta.Columns.Add("Cantidad", "Cantidad")
        dgvDetalleVenta.Columns.Add("Subtotal", "Subtotal")

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cmbMedicamentos.SelectedIndex = -1 Then
            MsgBox("Seleccione un medicamento", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbMedicamentos.Focus()
            Return
        End If

        Dim idMedicamento As Integer = cmbMedicamentos.SelectedValue
        Dim cantidad As Integer = nudCantidad.Value
        Dim tabla As New DataTable

        Recuperar("SELECT Codigo, Medicamento, Precio FROM Medicamentos WHERE idMedicamento = " & idMedicamento, tabla)

        If tabla.Rows.Count > 0 Then
            Dim Codigo As String = tabla.Rows(0)("Codigo").ToString
            Dim nombre As String = tabla.Rows(0)("Medicamento").ToString()
            Dim precio As Decimal = Convert.ToDecimal(tabla.Rows(0)("Precio"))
            Dim subtotal As Decimal = precio * cantidad

            dgvDetalleVenta.Rows.Add(Codigo, nombre, precio.ToString("0.00"), cantidad, subtotal.ToString("0.00"))
        End If
    End Sub

    Private Function ObtenerDescuentoPorCliente(idCliente As Integer) As Decimal
        Dim tabla As New DataTable
        Dim descuento As Decimal = 0

        Dim cadenaSQL As String = "SELECT p.PorcentajeDescuento " &
                          "FROM Clientes_farmacia c " &
                          "INNER JOIN Planes_obra_social p ON c.idPlan = p.idPlan " &
                          "WHERE c.idCliente = " & idCliente

        Recuperar(cadenaSQL, tabla)

        If tabla.Rows.Count > 0 Then
            descuento = Convert.ToDecimal(tabla.Rows(0)("PorcentajeDescuento"))
        End If

        Return descuento

    End Function

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        ' 1. Validar que haya medicamentos cargados
        If dgvDetalleVenta.Rows.Count = 0 Then
            MsgBox("Debe agregar al menos un medicamento para confirmar la venta.", vbExclamation)
            Return
        End If

        ' 2.Calcular total sin descuentos
        Dim totalSinDescuento As Decimal = 0

        For Each fila As DataGridViewRow In dgvDetalleVenta.Rows
            If Not fila.IsNewRow AndAlso fila.Cells("Subtotal").Value IsNot Nothing Then
                totalSinDescuento += Convert.ToDecimal(fila.Cells("Subtotal").Value)
            End If
        Next

        '3. Calcular el descuento por obra social (si aplica)'
        Dim descuentoMonto As Decimal = 0
        Dim idCliente As Integer = cmbClientes.SelectedValue

        If cmbClientes.SelectedIndex <> -1 Then
            Dim descuentoPorcentaje As Decimal = ObtenerDescuentoPorCliente(idCliente)
            descuentoMonto = totalSinDescuento * (descuentoPorcentaje / 100D)
        End If
        Dim totalConDescuento As Decimal = totalSinDescuento - descuentoMonto

        Dim recargoMonto As Decimal = 0
        'Verificamos el texto seleccionado en el ComboBox de métodos de pago'
        If cmbMetodos.Text = "Tarjeta de crédito" Then
            recargoMonto = totalConDescuento * 0.1D
        End If

        Dim totalFinal As Decimal = totalConDescuento + recargoMonto


        ' Confirmar con el usuario
        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("RESUMEN DE LA VENTA")
        sb.AppendLine("---------------------------------")
        sb.AppendLine("Subtotal: $" & totalSinDescuento.ToString("0.00"))
        If descuentoMonto > 0 Then
            sb.AppendLine("Descuento Obra Social: -$" & descuentoMonto.ToString("0.00"))
        End If
        If recargoMonto > 0 Then
            sb.AppendLine("Recargo Tarjeta de Crédito (10%): +$" & recargoMonto.ToString("0.00"))
        End If
        sb.AppendLine("---------------------------------")
        sb.AppendLine("TOTAL A PAGAR : $" & totalFinal.ToString("0.00"))
        sb.AppendLine()
        sb.AppendLine("¿Desea confirmar la venta?")

        If MessageBox.Show(sb.ToString(), "Confirmar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If


        ' Insertar en tabla Ventas
        Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        Dim cadenaSQL As String = "INSERT INTO Ventas (fecha, monto, idCliente, idUsuario, idMetodo) VALUES (" &
                              "'" & fecha & "', " &
                              totalFinal.ToString().Replace(",", ".") & ", " &
                              idCliente & ", " & IdUsuarioLog & ", " &
                              cmbMetodos.SelectedValue & ")"

        Ejecutar(cadenaSQL)

        ' Obtener ID de la venta recién insertada
        Dim tabla As New DataTable
        Recuperar("SELECT MAX(idVenta) AS UltimaVenta FROM Ventas", tabla)
        Dim idVenta As Integer = Convert.ToInt32(tabla.Rows(0)("UltimaVenta"))

        ' Procesar cada medicamento
        For Each fila As DataGridViewRow In dgvDetalleVenta.Rows
            If Not fila.IsNewRow AndAlso fila.Cells("Codigo").Value IsNot Nothing Then
                Dim codigo As String = fila.Cells("Codigo").Value.ToString()
                Dim cantidad As Integer = Convert.ToInt32(fila.Cells("Cantidad").Value)

                ' Buscar idMedicamento por código
                Dim tablaMed As New DataTable
                Recuperar("SELECT idMedicamento, Stock FROM Medicamentos WHERE Codigo = '" & codigo & "'", tablaMed)

                If tablaMed.Rows.Count > 0 Then
                    Dim idMedicamento As Integer = Convert.ToInt32(tablaMed.Rows(0)("idMedicamento"))
                    Dim stockActual As Integer = Convert.ToInt32(tablaMed.Rows(0)("Stock"))
                    Dim nuevoStock As Integer = stockActual - cantidad

                    ' Insertar en tabla Ventas_medicamentos
                    Dim sqlDetalle As String = "INSERT INTO Ventas_medicamentos (idVenta, idMedicamento, cantidad) VALUES (" &
                                           idVenta & ", " & idMedicamento & ", " & cantidad & ")"
                    Ejecutar(sqlDetalle)

                    ' Actualizar stock
                    Dim sqlStock As String = "UPDATE Medicamentos SET Stock = " & nuevoStock & " WHERE idMedicamento = " & idMedicamento
                    Ejecutar(sqlStock)
                End If
            End If
        Next

        MsgBox("Venta registrada correctamente.", vbInformation)
        dgvDetalleVenta.Rows.Clear()
        txtTotal.Text = ""
    End Sub

    Private Function ObtenerIdMedicamentoPorCodigo(codigo As String) As Integer
        Dim tabla As New DataTable
        Recuperar("SELECT idMedicamento FROM Medicamentos WHERE Codigo = '" & codigo & "'", tabla)
        If tabla.Rows.Count > 0 Then
            Return Convert.ToInt32(tabla.Rows(0)("idMedicamento"))
        Else
            Throw New Exception("No se encontró el medicamento con código: " & codigo)
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If dgvDetalleVenta.Rows.Count > 0 Then
            If MessageBox.Show("¿Seguro que desea cancelar la venta actual y borrar todos los datos?",
                               "Cancelar Venta",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) = DialogResult.No Then
                Return
            End If
        End If


        dgvDetalleVenta.Rows.Clear()
        cmbClientes.SelectedIndex = -1
        cmbMedicamentos.SelectedIndex = -1
        cmbMetodos.SelectedIndex = 0
        nudCantidad.Value = 1
        cmbClientes.Focus()
    End Sub
End Class
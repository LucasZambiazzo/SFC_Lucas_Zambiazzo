Public Class frmMedicamentos

    Private Sub Medicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(Operacion) Then
            Operacion = "ALTA"
        End If
        Me.CenterToScreen()

        Dim cadenaSQL As String
        Dim Tabla As DataTable = New DataTable

        cadenaSQL = "select * from Proveedores order by RazonSocial asc"
        Tabla = New DataTable
        Recuperar(cadenaSQL, Tabla)
        cmbProveedor.DataSource = Tabla
        cmbProveedor.DisplayMember = "RazonSocial"
        cmbProveedor.ValueMember = "idProveedor"
        cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProveedor.SelectedIndex = 0


        If Operacion = "MODIFICAR" Then
            cadenaSQL = "Select * from Medicamentos where idMedicamento = " & IdMedicamentoSelec
            Recuperar(cadenaSQL, Tabla)
            mskCodigo.Text = Tabla.Rows(0)("Codigo").ToString()
            txtMedicamento.Text = Tabla.Rows(0)("Medicamento").ToString()
            txtCantidad.Text = Tabla.Rows(0)("Cantidad").ToString()
            txtStock.Text = Tabla.Rows(0)("Stock").ToString()
            txtLote.Text = Tabla.Rows(0)("Lote").ToString()
            txtPrecio.Text = Tabla.Rows(0)("Precio").ToString
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        txtStock.Text = txtCantidad.Text
    End Sub

    Private Function GenerarCodigoMedicamento() As String
        Dim tabla As New DataTable
        Dim codigoNuevo As String = "MED-1000"

        Recuperar("SELECT MAX(CAST(SUBSTRING(Codigo, 4, LEN(Codigo)) AS INT)) AS UltimoCodigo FROM Medicamentos", tabla)

        If tabla.Rows.Count > 0 AndAlso Not IsDBNull(tabla.Rows(0)("UltimoCodigo")) Then
            Dim numero As Integer = CInt(tabla.Rows(0)("UltimoCodigo"))
            codigoNuevo = "MED" & (numero + 1).ToString()
        End If

        Return codigoNuevo
    End Function
    Private Function Validar() As Boolean
        Dim Ok As Boolean


        If txtMedicamento.Text.Trim <> String.Empty Then
            If txtCantidad.Text.Trim <> String.Empty Then
                If txtStock.Text.Trim <> String.Empty Then
                    If txtLote.Text.Trim <> String.Empty Then
                        If txtPrecio.Text.Trim <> String.Empty Then
                            Ok = True
                        Else

                            MessageBox.Show("Debe ingresar el precio del medicamento", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show("Debe ingresar el lote del medicamento", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Se debe ingresar el stock del medicamento", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Debe ingresar la cantidad recibida del producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Debe ingresar el nombre del medicamento recibido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


        Return Ok
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCantidad.Clear()
        txtLote.Clear()
        txtMedicamento.Clear()
        txtPrecio.Clear()
        txtStock.Clear()
        mskCodigo.Clear()
        cmbProveedor.SelectedIndex = 0
        txtMedicamento.Focus()
    End Sub

    Private Sub btnRegistrar_Click_1(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim cadenaSQL As String

        If Validar() Then
            If Operacion = "ALTA" Then
                mskCodigo.Text = GenerarCodigoMedicamento()
                cadenaSQL = "insert into Medicamentos (Codigo, Medicamento, Cantidad, Stock, Lote, Precio, idProveedor)"
                cadenaSQL &= " values('" & mskCodigo.Text & "','" & txtMedicamento.Text & "','" & txtCantidad.Text & "','" & txtStock.Text & "',"
                cadenaSQL &= "'" & txtLote.Text & "','" & txtPrecio.Text & "'," & cmbProveedor.SelectedValue & ")"
                Ejecutar(cadenaSQL)
                MessageBox.Show("Registro de medicamento exitoso", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCantidad.Clear()
                txtMedicamento.Clear()
                txtLote.Clear()
                txtPrecio.Clear()
                txtStock.Clear()
                cmbProveedor.SelectedIndex = 0
                mskCodigo.Text = GenerarCodigoMedicamento()

            ElseIf Operacion = "MODIFICAR" Then
                cadenaSQL = "Update Medicamentos set Codigo = '" & mskCodigo.Text & "',"
                cadenaSQL &= "Medicamento = '" & txtMedicamento.Text & "',"
                cadenaSQL &= "Cantidad = '" & txtCantidad.Text & "',"
                cadenaSQL &= "Stock = '" & txtStock.Text & "',"
                cadenaSQL &= "Lote = '" & txtLote.Text & "',"
                cadenaSQL &= "Precio = '" & txtPrecio.Text & "'"
                cadenaSQL &= " where IdMedicamento = " & IdMedicamentoSelec
                Ejecutar(cadenaSQL)
                MessageBox.Show("Medicamento actualizado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Limpieza de campos
                txtCantidad.Clear()
                txtMedicamento.Clear()
                txtLote.Clear()
                txtPrecio.Clear()
                txtStock.Clear()
                cmbProveedor.SelectedIndex = 0
                mskCodigo.Text = GenerarCodigoMedicamento()
                Me.Close()
            End If
        End If
    End Sub
End Class
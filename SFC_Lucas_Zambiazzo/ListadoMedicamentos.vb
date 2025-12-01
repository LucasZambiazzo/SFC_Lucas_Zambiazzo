Public Class ListadoMedicamentos


    Private Sub ListadoMedicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        CargarGrilla()
    End Sub
    Private Sub CargarGrilla()
        Dim cadenaSQL As String
        Dim tabla As DataTable = New DataTable


        If txtFiltro.Text.Trim = String.Empty Then
            ' CASO 1: Sin filtro (Muestra todo)
            ' Usamos tu estilo: tablas separadas por comas y condición de unión en el WHERE
            cadenaSQL = "SELECT M.idMedicamento, M.Codigo, M.Medicamento, M.Cantidad, M.Stock, M.Lote, M.Precio, P.RazonSocial AS Proveedor " &
                    "FROM Medicamentos M, Proveedores P " &
                    "WHERE M.idProveedor = P.idProveedor " &
                    "AND M.Activo = 1 " &
                    "ORDER BY M.Medicamento ASC"
        Else
            ' CASO 2: Con filtro (Búsqueda por nombre)
            ' Agregamos el AND para filtrar por texto, manteniendo la unión de tablas
            cadenaSQL = "SELECT M.idMedicamento, M.Codigo, M.Medicamento, M.Cantidad, M.Stock, M.Lote, M.Precio, P.Nombre AS Proveedor " &
                    "FROM Medicamentos M, Proveedores P " &
                    "WHERE M.idProveedor = P.idProveedor " &
                    "AND M.Activo = 1 " &  ' 
                    "AND M.Medicamento LIKE '" & txtFiltro.Text.Trim() & "%' " &
                    "ORDER BY M.Medicamento ASC"
        End If

        sqlinformes = cadenaSQL
        Recuperar(cadenaSQL, tabla)
        dgvMedicamentos.DataSource = tabla
        dgvMedicamentos.Columns(0).Visible = False
        dgvMedicamentos.AllowUserToAddRows = False
        dgvMedicamentos.AllowUserToDeleteRows = False
        dgvMedicamentos.ReadOnly = True
        dgvMedicamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub



    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        CargarGrilla()
    End Sub

    Private Sub mnuNueva_Click(sender As Object, e As EventArgs) Handles mnuNueva.Click
        Operacion = "ALTA"
        frmMedicamentos.ShowDialog()
    End Sub

    Private Sub mnuModificar_Click(sender As Object, e As EventArgs) Handles mnuModificar.Click
        If Not dgvMedicamentos.CurrentRow Is Nothing Then
            Operacion = "MODIFICAR"
            IdMedicamentoSelec = dgvMedicamentos.CurrentRow.Cells(0).Value
            frmMedicamentos.ShowDialog()
        End If
    End Sub

    Private Sub mnuImprimir_Click(sender As Object, e As EventArgs) Handles mnuImprimir.Click
        InformeMedicamentos.ShowDialog()

    End Sub
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuEliminar.Click
        If Not dgvMedicamentos.CurrentRow Is Nothing Then

            If MessageBox.Show("¿Está seguro de eliminar este medicamento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    ' EN LUGAR DE DELETE, HACEMOS UPDATE
                    ' Lo marcamos con Activo = 0
                    IdMedicamentoSelec = dgvMedicamentos.CurrentRow.Cells("idMedicamento").Value

                    Dim sql As String = "UPDATE Medicamentos SET Activo = 0 WHERE idMedicamento = " & IdMedicamentoSelec
                    Ejecutar(sql)

                    MsgBox("Medicamento eliminado correctamente.", MsgBoxStyle.Information)
                    CargarGrilla()

                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            End If
        End If
    End Sub
End Class
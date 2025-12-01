Public Class ListadoClientes
    Private Sub ListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrilla()
        Me.CenterToScreen()
    End Sub

    Private Sub CargarGrilla()
        Dim cadenaSQL As String
        Dim tabla As DataTable = New DataTable


        If txtFiltrado.Text.Trim = String.Empty Then
            ' CASO 1: Sin filtro (Muestra todo)
            ' Tablas separadas por comas y uniones en el WHERE
            cadenaSQL = "SELECT C.idCliente, C.Nombre, C.Apellido, C.Telefono, C.Email, " &
                    "OS.ObraSocial AS ObraSocial, P.NombrePlan AS PlanObra " &
                    "FROM Clientes_farmacia C, Obras_Sociales OS, Planes_obra_social P " &
                    "WHERE C.idObra_Social = OS.idObraSocial " &
                    "AND C.idPlan = P.idPlan " &
                    "ORDER BY C.Apellido ASC"
        Else
            ' CASO 2: Con filtro (Búsqueda por Apellido)
            ' Mantenemos las uniones y agregamos el filtro con AND
            cadenaSQL = "SELECT C.idCliente, C.Nombre, C.Apellido, C.Telefono, C.Email, " &
                    "OS.ObraSocial AS ObraSocial, P.NombrePlan AS PlanObra " &
                    "FROM Clientes_farmacia C, Obras_Sociales OS, Planes_obra_social P " &
                    "WHERE C.idObra_Social = OS.idObraSocial " &
                    "AND C.idPlan = P.idPlan " &
                    "AND C.Apellido LIKE '" & txtFiltrado.Text.Trim() & "%' " &
                    "ORDER BY C.Apellido ASC"
        End If


        sqlinformes = cadenaSQL
        Recuperar(cadenaSQL, tabla)
        dgvClientes.DataSource = tabla
        dgvClientes.Columns(0).Visible = False
        dgvClientes.AllowUserToAddRows = False
        dgvClientes.AllowUserToDeleteRows = False
        dgvClientes.ReadOnly = True
        dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        CargarGrilla()
    End Sub

    Private Sub mnuNuevo_Click(sender As Object, e As EventArgs) Handles mnuNuevo.Click
        Operacion = "ALTA"
        frmClientes.ShowDialog()
    End Sub

    Private Sub mnuModificar_Click(sender As Object, e As EventArgs) Handles mnuModificar.Click
        If Not dgvClientes.CurrentRow Is Nothing Then
            Operacion = "MODIFICAR"
            IdClienteSelec = dgvClientes.CurrentRow.Cells("IdCliente").Value
            frmClientes.ShowDialog()

        End If
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuImprimir.Click
        InformeClientes.ShowDialog()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuEliminar.Click
        Dim cadenaSQL As String

        If Not dgvClientes.CurrentRow Is Nothing Then
            Operacion = "ELIMINAR"
            IdClienteSelec = dgvClientes.CurrentRow.Cells("IdCliente").Value
            cadenaSQL = "DELETE FROM Clientes_farmacia WHERE IdCliente = " & IdClienteSelec
            Ejecutar(cadenaSQL)
        End If
    End Sub


End Class
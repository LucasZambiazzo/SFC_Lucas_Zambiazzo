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
                    "AND C.Activo = 1 " &  ' <--- FILTRO CLAVE
                    "ORDER BY C.Apellido ASC"
        Else
            ' CASO 2: Con filtro (Búsqueda por Apellido)
            ' Mantenemos las uniones y agregamos el filtro con AND
            cadenaSQL = "SELECT C.idCliente, C.Nombre, C.Apellido, C.Telefono, C.Email, " &
                    "OS.ObraSocial AS ObraSocial, P.NombrePlan AS PlanObra " &
                    "FROM Clientes_farmacia C, Obras_Sociales OS, Planes_obra_social P " &
                    "WHERE C.idObra_Social = OS.idObraSocial " &
                    "AND C.idPlan = P.idPlan " &
                    "AND C.Activo = 1 " &  ' <--- FILTRO CLAVE
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
        If Not dgvClientes.CurrentRow Is Nothing Then

            If MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    ' CAMBIO CLAVE: EN LUGAR DE DELETE, HACEMOS UPDATE
                    IdClienteSelec = dgvClientes.CurrentRow.Cells("idCliente").Value

                    ' Lo marcamos con Activo = 0 (Baja Lógica)
                    Dim sql As String = "UPDATE Clientes_farmacia SET Activo = 0 WHERE idCliente = " & IdClienteSelec
                    Ejecutar(sql)

                    MsgBox("Cliente eliminado correctamente.", MsgBoxStyle.Information)
                    CargarGrilla()

                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            End If
        End If
    End Sub

End Class
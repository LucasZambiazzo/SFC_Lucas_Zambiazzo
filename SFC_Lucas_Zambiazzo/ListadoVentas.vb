Public Class ListadoVentas


    Private Sub ListadoVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrilla()
    End Sub
    Private Sub CargarGrilla()
        Dim cadenaSQL As String
        Dim tabla As DataTable = New DataTable

        If txtFiltrado.Text.Trim = String.Empty Then
            ' CASO 1: Sin filtro (Trae las últimas ventas primero)
            cadenaSQL = "SELECT V.idVenta AS [Nro Ticket], " &
                        "V.Fecha, " &
                        "(C.Apellido + ', ' + C.Nombre) AS Cliente, " &
                        "M.Metodo AS [Forma Pago], " &
                        "U.Usuario AS Vendedor, " &
                        "V.Monto AS Total " &
                        "FROM Ventas V, Clientes_farmacia C, Usuarios U, Metodos_de_pago M " &
                        "WHERE V.idCliente = C.idCliente " &
                        "AND V.idUsuario = U.idUsuario " &
                        "AND V.idMetodo = M.idMetodo " &
                        "ORDER BY V.Fecha DESC"
        Else
            ' CASO 2: Filtrando por Apellido del Cliente
            cadenaSQL = "SELECT V.idVenta AS [Nro Ticket], " &
                        "V.Fecha, " &
                        "(C.Apellido + ', ' + C.Nombre) AS Cliente, " &
                        "M.Metodo AS [Forma Pago], " &
                        "U.Usuario AS Vendedor, " &
                        "V.Monto AS Total " &
                        "FROM Ventas V, Clientes_farmacia C, Usuarios U, Metodos_de_pago M " &
                        "WHERE V.idCliente = C.idCliente " &
                        "AND V.idUsuario = U.idUsuario " &
                        "AND V.idMetodo = M.idMetodo " &
                        "AND C.Apellido LIKE '" & txtFiltrado.Text.Trim() & "%' " &
                        "ORDER BY V.Fecha DESC"
        End If

        sqlinformes = cadenaSQL
        Recuperar(cadenaSQL, tabla)
        dgvVentas.DataSource = tabla
        dgvVentas.Columns(0).Visible = False
        dgvVentas.AllowUserToAddRows = False
        dgvVentas.AllowUserToDeleteRows = False
        dgvVentas.ReadOnly = True
        dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        CargarGrilla()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Operacion = "ALTA"
        frmVenta.ShowDialog()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        If Not dgvVentas.CurrentRow Is Nothing Then
            Operacion = "MODIFICAR"
            IdVentaSelec = dgvVentas.CurrentRow.Cells(0).Value
            frmVenta.ShowDialog()
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim cadenaSQL As String

        If Not dgvVentas.CurrentRow Is Nothing Then
            Operacion = "ELIMINAR"
            IdVentaSelec = dgvVentas.CurrentRow.Cells(0).Value
            cadenaSQL = "DELETE From Ventas where idVenta = " & IdVentaSelec
            Ejecutar(cadenaSQL)
        End If
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        InformeVentas.ShowDialog()
    End Sub
End Class
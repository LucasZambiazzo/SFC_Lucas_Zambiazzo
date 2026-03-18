Public Class ListadoUsuarios
    Private Sub ListadoUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        CargarGrilla()

    End Sub

    Private Sub CargarGrilla()
        Dim cadenaSQL As String
        Dim tabla As DataTable = New DataTable()

        If txtBuscar.Text.Trim = String.Empty Then
            cadenaSQL = "SELECT * FROM Usuarios ORDER BY usuario ASC"
        Else
            cadenaSQL = "SELECT * FROM Usuarios WHERE usuario LIKE '" & txtBuscar.Text.Trim & "%' ORDER BY usuario ASC"
        End If

        sqlinformes = cadenaSQL
        Recuperar(cadenaSQL, tabla)

        ' Configurar el DataGridView
        dgvUsuarios.DataSource = tabla
        dgvUsuarios.Columns(0).Visible = False
        dgvUsuarios.AllowUserToAddRows = False
        dgvUsuarios.AllowUserToDeleteRows = False
        dgvUsuarios.ReadOnly = True
        dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub



    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuNuevo.Click
        Operacion = "ALTA"

        frmUsuarios.txtUsuario.Clear()
        frmUsuarios.txtApellido.Clear()
        frmUsuarios.txtNombre.Clear()
        frmUsuarios.txtContraseña.Clear()
        frmUsuarios.txtConfirmarContraseña.Clear()
        frmUsuarios.chkActivo.Checked = False
        frmUsuarios.cmbGrupo.SelectedIndex = 0

        frmUsuarios.ShowDialog()
    End Sub

    Private Sub mnuModificar_Click(sender As Object, e As EventArgs) Handles mnuModificar.Click
        If Not dgvUsuarios.CurrentRow Is Nothing Then
            Operacion = "MODIFICAR"
            IdUsuarioSelec = dgvUsuarios.CurrentRow.Cells(0).Value
            frmUsuarios.ShowDialog()
        End If
    End Sub

    Private Sub mnuEliminar_Click(sender As Object, e As EventArgs) Handles mnuEliminar.Click
        Dim cadenaSQL As String

        If Not dgvUsuarios.CurrentRow Is Nothing Then
            Operacion = "ELIMINAR"
            IdUsuarioSelec = dgvUsuarios.CurrentRow.Cells(0).Value
            cadenaSQL = "DELETE FROM Usuarios WHERE IdUsuario= " & IdUsuarioSelec
            Ejecutar(cadenaSQL)
            CargarGrilla()
        End If
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        InformeUsuarios.ShowDialog()
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        CargarGrilla()
    End Sub
End Class
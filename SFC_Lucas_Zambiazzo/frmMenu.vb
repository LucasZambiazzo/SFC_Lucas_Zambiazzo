Imports System.Runtime.Versioning

Public Class frmMenu
    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click

    End Sub

    Private Sub AltaClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaClientesToolStripMenuItem.Click
        Dim frm As New frmClientes()
        frm.MdiParent = Me  ' <-- 1. Le asigna este menú como "Padre"
        frm.Show()
    End Sub

    Private Sub AltaMedicamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaMedicamentosToolStripMenuItem.Click
        Dim frm As New frmMedicamentos()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AltaUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaUsuariosToolStripMenuItem.Click
        Dim frm As New frmUsuarios()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ListadoClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoClientesToolStripMenuItem.Click
        Dim frm As New ListadoClientes()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ListadoMedicamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoMedicamentosToolStripMenuItem.Click
        Dim frm As New ListadoMedicamentos()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ListadoUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoUsuariosToolStripMenuItem.Click
        Dim frm As New ListadoUsuarios()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ' Validar si el usuario es un usuario común
        If AccesoLog = 2 Then ' Suponiendo 1 = Admin, 2 = Usuario común
            ' Deshabilitar opciones que solo debe ver el administrador
            AltaMedicamentosToolStripMenuItem.Visible = False
            AltaUsuariosToolStripMenuItem.Visible = False
            ListadoUsuariosToolStripMenuItem.Visible = False
            ProveedoresToolStripMenuItem.Visible = False
        End If
        Dim cadenaSQL As String
        Dim tabla As DataTable

        cadenaSQL = "Select Usuario from Usuarios where idUsuario = " & IdUsuarioLog
        tabla = New DataTable
        Recuperar(cadenaSQL, tabla)

        Dim nombreUsuario As String = tabla.Rows(0)("Usuario").ToString
        lblUsuarioStatus.Text = nombreUsuario
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim frm As New frmProveedores()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub VentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaToolStripMenuItem.Click
        Dim frm As New frmVenta()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblFechaHoraStatus.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub OrganizarEnCascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrganizarEnCascadaToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MosaicoHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MosaicoHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub MosaicoVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MosaicoVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub ListadoVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoVentasToolStripMenuItem.Click
        Dim frm As New ListadoVentas()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
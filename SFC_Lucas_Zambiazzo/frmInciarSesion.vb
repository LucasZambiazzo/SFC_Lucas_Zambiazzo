
Public Class frmInciarSesion
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim cadenasql As String
        Dim Tabla As DataTable = New DataTable
        Dim HashPass As String

        If txtUsuario.Text.Trim <> String.Empty And txtUsuario.Text.Trim.Length >= 5 Then
            If txtContraseña.Text.Trim <> String.Empty And txtContraseña.Text.Trim.Length >= 5 Then
                cadenasql = "select * from Usuarios where Usuario = '" & txtUsuario.Text.Trim & "'"
                Tabla = New DataTable
                Recuperar(cadenasql, Tabla)
                If Tabla.Rows.Count = 1 Then
                    HashPass = GenerarHash256(txtContraseña.Text)
                    If HashPass = Tabla.Rows(0)("Contraseña").ToString().Trim() Then
                        If Tabla.Rows(0)("Activo") Then
                            IdUsuarioLog = Tabla.Rows(0)("IdUsuario")
                            cadenasql = "select * from Grupos where IdGrupo = " & Tabla.Rows(0)("IdGrupo")
                            Tabla = New DataTable
                            Recuperar(cadenasql, Tabla)
                            AccesoLog = Tabla.Rows(0)("Acceso")
                            frmMenu.Show()
                        Else
                            MessageBox.Show("El Usuario no se encuentra Activo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show("El Logueo es incorrecto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("El Logueo es incorrecto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("El password debe contener 5 o mas caracteres", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("El Usuario debe contener 5 o mas caracteres", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        frmUsuarios.ShowDialog()
    End Sub

    Private Sub frmInciarSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class
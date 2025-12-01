Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmProveedores
    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Function Validar()
        Dim ok As Boolean
        If txtRazonSocial.Text <> String.Empty Then
            If txtCUIT.Text <> String.Empty Then
                If txtTelefono.Text <> String.Empty Then
                    If txtEmail.Text <> String.Empty Then
                        ok = True
                    Else
                        MessageBox.Show("Debe ingresar un email", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Debe ingresar un telefono", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Debe ingresar un CUIT", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Debe ingresar una razón social", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Return ok
    End Function

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim cadenaSQL As String

        If Validar() Then
            cadenaSQL = "insert into Proveedores (RazonSocial, CUIT, telefono, email)"
            cadenaSQL = cadenaSQL & " values ('" & txtRazonSocial.Text & "', '" & txtCUIT.Text & "', '" & txtTelefono.Text & "', '" & txtEmail.Text & "')"
            Ejecutar(cadenaSQL)
            MessageBox.Show("Proveedor registrado con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtRazonSocial.Clear()
            txtCUIT.Clear()
            txtTelefono.Clear()
            txtEmail.Clear()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtCUIT.Clear()
        txtEmail.Clear()
        txtRazonSocial.Clear()
        txtTelefono.Clear()
        txtRazonSocial.Focus()

    End Sub
End Class
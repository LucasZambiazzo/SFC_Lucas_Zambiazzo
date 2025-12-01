Public Class frmUsuarios
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(Operacion) Then
            Operacion = "ALTA"
        End If
        Me.CenterToScreen()
        Dim tabla As DataTable
        Dim Cadenasql


        Cadenasql = "select * from grupos order by acceso asc"
        tabla = New DataTable
        Recuperar(Cadenasql, tabla)
        cmbGrupo.DataSource = tabla
        cmbGrupo.DisplayMember = "Grupo"
        cmbGrupo.ValueMember = "IdGrupo"
        cmbGrupo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGrupo.SelectedIndex = 0

        If Operacion = "MODIFICAR" Then
            Cadenasql = "select * from Usuarios where IdUsuario = " & IdUsuarioSelec.ToString()
            tabla = New DataTable
            Recuperar(Cadenasql, tabla)
            txtUsuario.Text = tabla.Rows(0)("Usuario").ToString()
            txtApellido.Text = tabla.Rows(0)("Apellido").ToString()
            txtNombre.Text = tabla.Rows(0)("Nombre").ToString()
            cmbGrupo.SelectedValue = Integer.Parse(tabla.Rows(0)("IdGrupo").ToString)
            chkActivo.Checked = tabla.Rows(0)("Activo")
            chkActivo.Visible = True
            lblActivo.Visible = True
            lblContraseña.Visible = False
            txtContraseña.Visible = False
            lblConfirmarContraseña.Visible = False
            txtConfirmarContraseña.Visible = False
        End If
    End Sub
    Private Function Validar() As Boolean
        Dim CadenaSQL As String
        Dim Tabla As DataTable
        Dim Ok As Boolean

        Ok = False
        If txtUsuario.Text.Trim <> String.Empty And txtUsuario.Text.Trim.Length >= 5 Then
            If txtApellido.Text.Trim <> String.Empty Then
                If txtNombre.Text.Trim <> String.Empty Then
                    If Operacion = "ALTA" Then
                        If txtContraseña.Text.Trim <> String.Empty And txtContraseña.Text.Trim.Length >= 5 Then
                            If txtContraseña.Text.Trim = txtConfirmarContraseña.Text.Trim Then
                                CadenaSQL = "select * from Usuarios where Usuario = '" & txtUsuario.Text.Trim & "'"
                                Tabla = New DataTable
                                Recuperar(CadenaSQL, Tabla)
                                If Tabla.Rows.Count = 0 Then
                                    Ok = True
                                Else
                                    MessageBox.Show("El usuario ingresado ya se encuentra asignado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If
                            Else
                                MessageBox.Show("La contraseña ingresada y su confirmacion no coinciden.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        Else
                            MessageBox.Show("La contraseña debe contener 5 o mas caracteres", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        CadenaSQL = "Select * from Usuarios where Usuario = '" & txtUsuario.Text.Trim & "'"
                        CadenaSQL = CadenaSQL & "and IdUsuario <> " & IdUsuarioSelec
                        Tabla = New DataTable
                        Recuperar(CadenaSQL, Tabla)
                        If Tabla.Rows.Count = 0 Then
                            Ok = True
                        Else
                            MessageBox.Show("El usuario ingresado ya se encuentra asignado.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                Else
                    MessageBox.Show("Debe ingresar el Nombre", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Debe ingresar el Apellido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("El Usuario debe contener 5 o mas caracteres", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return Ok
    End Function



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtApellido.Clear()
        txtConfirmarContraseña.Clear()
        txtContraseña.Clear()
        txtNombre.Clear()
        txtUsuario.Clear()
        cmbGrupo.SelectedIndex = 0
        chkActivo.Checked = False
    End Sub

    Private Sub btnRegistrar_Click_1(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim cadenaSQL As String

        If Validar() Then
            If Operacion = "ALTA" Then
                cadenaSQL = "insert into Usuarios (Apellido,Nombre,Idgrupo,Activo,Usuario,Contraseña)"
                cadenaSQL = cadenaSQL & "values ('" & txtApellido.Text.Trim & "', '" & txtNombre.Text & "',"
                cadenaSQL = cadenaSQL & cmbGrupo.SelectedValue & ",1, '" & txtUsuario.Text.Trim & "',"
                cadenaSQL = cadenaSQL & "'" & GenerarHash256(txtContraseña.Text) & "')"
                Ejecutar(cadenaSQL)
                MessageBox.Show("Operacion Realizada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Limpiar Campos
                txtApellido.Clear()
                txtNombre.Clear()
                chkActivo.Checked = False
                Me.Close()
            End If

        ElseIf Operacion = "MODIFICAR" Then
            cadenaSQL = "UPDATE Usuarios SET "
            cadenaSQL &= "Apellido = '" & txtApellido.Text.Trim & "', "
            cadenaSQL &= "Nombre = '" & txtNombre.Text.Trim & "', "
            cadenaSQL &= "IdGrupo = " & cmbGrupo.SelectedValue & ", "
            cadenaSQL &= "Activo = " & IIf(chkActivo.Checked, 1, 0) & ", "
            cadenaSQL &= "Usuario = '" & txtUsuario.Text.Trim & "' "
            cadenaSQL &= "WHERE IdUsuario = " & IdUsuarioSelec
            Ejecutar(cadenaSQL)
            MessageBox.Show("Usuario actualizado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class
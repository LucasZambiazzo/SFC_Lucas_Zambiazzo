Public Class frmClientes
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim cadenaSQL As String


        If Validar() Then
            If Operacion = "ALTA" Then

                cadenaSQL = "insert into Clientes_farmacia (Nombre,apellido,telefono,email,idObra_Social,idPlan) "
                cadenaSQL = cadenaSQL & "values('" & txtNombre.Text & "','" & txtApellido.Text & "',"
                cadenaSQL = cadenaSQL & "'" & txtTelefono.Text & "','" & txtEmail.Text & "',"
                cadenaSQL = cadenaSQL & cmbObras.SelectedValue & "," & cmbPlanes.SelectedValue & ")"
                Ejecutar(cadenaSQL)

                MessageBox.Show("Registro de cliente exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Limpiar campos
                txtApellido.Clear()
                txtNombre.Clear()
                txtEmail.Clear()
                txtTelefono.Clear()
                cmbObras.SelectedIndex = 0
                cmbPlanes.SelectedIndex = 0

            ElseIf Operacion = "MODIFICAR" Then
                cadenaSQL = "update Clientes_farmacia set Nombre= '" & txtNombre.Text & "',"
                cadenaSQL = cadenaSQL & "Apellido = '" & txtApellido.Text.Trim & "',"
                cadenaSQL = cadenaSQL & "Telefono = '" & txtTelefono.Text.Trim & "',"
                cadenaSQL = cadenaSQL & "Email = '" & txtEmail.Text.Trim & "',"
                cadenaSQL = cadenaSQL & "idObra_Social = '" & cmbObras.SelectedValue & "',"
                cadenaSQL = cadenaSQL & "idPlan = '" & cmbPlanes.SelectedValue & "'"
                cadenaSQL = cadenaSQL & "where IdCliente = " & IdClienteSelec
                Ejecutar(cadenaSQL)
                MessageBox.Show("Modificacion Exitosa", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Limpiar campos
                txtApellido.Clear()
                txtNombre.Clear()
                txtEmail.Clear()
                txtTelefono.Clear()
                cmbObras.SelectedIndex = 0
                cmbPlanes.SelectedIndex = 0
                Me.Close()
            End If
        End If
    End Sub

    Private Function Validar()
        Dim ok As Boolean
        If txtNombre.Text <> String.Empty Then
            If txtApellido.Text <> String.Empty Then
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
                    MessageBox.Show("Debe ingresar un apellido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Debe ingresar un nombre", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return ok
    End Function

    Private Sub cmbObras_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cmbObras.SelectedValue IsNot Nothing Then
            Dim idObraSocial As Integer = CInt(cmbObras.SelectedValue)
            CargarPlanes(idObraSocial)
        End If
    End Sub

    Private Sub CargarPlanes(idObraSocial As Integer)
        Dim cadenaSQL As String = "SELECT idPlan, nombrePlan FROM Planes_Obra_Social WHERE idObraSocial = " & idObraSocial
        Dim tabla As New DataTable()
        Recuperar(cadenaSQL, tabla)

        cmbPlanes.DataSource = tabla
        cmbPlanes.DisplayMember = "nombrePlan"
        cmbPlanes.ValueMember = "idPlan"
        cmbPlanes.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If String.IsNullOrEmpty(Operacion) Then
            Operacion = "ALTA"
        End If
        Me.CenterToScreen()

        Dim cadenaSQL As String
        Dim tabla As DataTable

        cadenaSQL = "select * from Obras_sociales order by ObraSocial asc"
        tabla = New DataTable
        Recuperar(cadenaSQL, tabla)
        cmbObras.DataSource = tabla
        cmbObras.DisplayMember = "ObraSocial"
        cmbObras.ValueMember = "idObraSocial"
        cmbObras.DropDownStyle = ComboBoxStyle.DropDownList
        cmbObras.SelectedIndex = 0
        AddHandler cmbObras.SelectedIndexChanged, AddressOf cmbObras_SelectedIndexChanged
        If cmbObras.SelectedValue IsNot Nothing Then
            CargarPlanes(CInt(cmbObras.SelectedValue))
        End If


        If Operacion = "MODIFICAR" Then
            cadenaSQL = "select * from Clientes_farmacia where IdCliente= " & IdClienteSelec
            Recuperar(cadenaSQL, tabla)
            txtNombre.Text = tabla.Rows(0)("Nombre").ToString()
            txtApellido.Text = tabla.Rows(0)("Apellido").ToString()
            txtTelefono.Text = tabla.Rows(0)("Telefono").ToString()
            txtEmail.Text = tabla.Rows(0)("Email").ToString()
            cmbObras.SelectedValue = tabla.Rows(0)("idObra_Social").ToString()
            CargarPlanes(CInt(cmbObras.SelectedValue))
            cmbPlanes.SelectedValue = tabla.Rows(0)("idPlan").ToString()

        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtApellido.Clear()
        txtNombre.Clear()
        txtEmail.Clear()
        txtTelefono.Clear()
        cmbObras.SelectedIndex = 0
        cmbPlanes.SelectedIndex = 0
    End Sub
End Class
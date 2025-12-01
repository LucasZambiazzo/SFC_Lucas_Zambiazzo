<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.cmbPlanes = New System.Windows.Forms.ComboBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cmbObras = New System.Windows.Forms.ComboBox()
        Me.lblPlanObra = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblObraSocial = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.cmbPlanes)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.lblApellido)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.cmbObras)
        Me.GroupBox1.Controls.Add(Me.lblPlanObra)
        Me.GroupBox1.Controls.Add(Me.lblTelefono)
        Me.GroupBox1.Controls.Add(Me.lblObraSocial)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(77, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(631, 224)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(121, 77)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(5)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(132, 25)
        Me.txtApellido.TabIndex = 25
        '
        'cmbPlanes
        '
        Me.cmbPlanes.FormattingEnabled = True
        Me.cmbPlanes.Location = New System.Drawing.Point(384, 163)
        Me.cmbPlanes.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbPlanes.Name = "cmbPlanes"
        Me.cmbPlanes.Size = New System.Drawing.Size(159, 25)
        Me.cmbPlanes.TabIndex = 29
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(16, 35)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblNombre.TabIndex = 18
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(16, 81)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(60, 17)
        Me.lblApellido.TabIndex = 19
        Me.lblApellido.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(121, 31)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(132, 25)
        Me.txtNombre.TabIndex = 24
        '
        'cmbObras
        '
        Me.cmbObras.FormattingEnabled = True
        Me.cmbObras.Location = New System.Drawing.Point(384, 73)
        Me.cmbObras.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbObras.Name = "cmbObras"
        Me.cmbObras.Size = New System.Drawing.Size(159, 25)
        Me.cmbObras.TabIndex = 28
        '
        'lblPlanObra
        '
        Me.lblPlanObra.AutoSize = True
        Me.lblPlanObra.Location = New System.Drawing.Point(381, 122)
        Me.lblPlanObra.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPlanObra.Name = "lblPlanObra"
        Me.lblPlanObra.Size = New System.Drawing.Size(119, 17)
        Me.lblPlanObra.TabIndex = 23
        Me.lblPlanObra.Text = "Plan de Cobertura"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(14, 127)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(62, 17)
        Me.lblTelefono.TabIndex = 20
        Me.lblTelefono.Text = "Telefono"
        '
        'lblObraSocial
        '
        Me.lblObraSocial.AutoSize = True
        Me.lblObraSocial.Location = New System.Drawing.Point(381, 32)
        Me.lblObraSocial.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblObraSocial.Name = "lblObraSocial"
        Me.lblObraSocial.Size = New System.Drawing.Size(78, 17)
        Me.lblObraSocial.TabIndex = 22
        Me.lblObraSocial.Text = "Obra Social"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(121, 169)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(132, 25)
        Me.txtEmail.TabIndex = 27
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(121, 123)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(132, 25)
        Me.txtTelefono.TabIndex = 26
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(16, 173)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblEmail.TabIndex = 21
        Me.lblEmail.Text = "Email"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancelar.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources._1492790846_9cancel_84247
        Me.btnCancelar.Location = New System.Drawing.Point(438, 393)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(127, 41)
        Me.btnCancelar.TabIndex = 19
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnEnviar.FlatAppearance.BorderSize = 0
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEnviar.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.save_file_disk_open_searsh_loading_clipboard_15131
        Me.btnEnviar.Location = New System.Drawing.Point(223, 392)
        Me.btnEnviar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(136, 42)
        Me.btnEnviar.TabIndex = 16
        Me.btnEnviar.Text = "Registrar"
        Me.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(773, 475)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEnviar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmClientes"
        Me.Text = "Registro de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEnviar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents cmbPlanes As ComboBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cmbObras As ComboBox
    Friend WithEvents lblPlanObra As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblObraSocial As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents btnCancelar As Button
End Class

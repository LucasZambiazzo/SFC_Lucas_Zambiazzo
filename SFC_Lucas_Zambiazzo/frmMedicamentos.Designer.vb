<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedicamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedicamentos))
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblMedicamento = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.mskCodigo = New System.Windows.Forms.MaskedTextBox()
        Me.txtMedicamento = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(10, 38)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "Codigo"
        '
        'lblMedicamento
        '
        Me.lblMedicamento.AutoSize = True
        Me.lblMedicamento.Location = New System.Drawing.Point(10, 81)
        Me.lblMedicamento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMedicamento.Name = "lblMedicamento"
        Me.lblMedicamento.Size = New System.Drawing.Size(92, 17)
        Me.lblMedicamento.TabIndex = 2
        Me.lblMedicamento.Text = "Medicamento"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(10, 124)
        Me.lblCantidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(63, 17)
        Me.lblCantidad.TabIndex = 3
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(391, 34)
        Me.lblStock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(41, 17)
        Me.lblStock.TabIndex = 5
        Me.lblStock.Text = "Stock"
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.Location = New System.Drawing.Point(391, 89)
        Me.lblLote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(35, 17)
        Me.lblLote.TabIndex = 6
        Me.lblLote.Text = "Lote"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(391, 144)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(46, 17)
        Me.lblPrecio.TabIndex = 7
        Me.lblPrecio.Text = "Precio"
        '
        'mskCodigo
        '
        Me.mskCodigo.Location = New System.Drawing.Point(129, 33)
        Me.mskCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.mskCodigo.Mask = "LLL0000"
        Me.mskCodigo.Name = "mskCodigo"
        Me.mskCodigo.ReadOnly = True
        Me.mskCodigo.Size = New System.Drawing.Size(43, 25)
        Me.mskCodigo.TabIndex = 1
        '
        'txtMedicamento
        '
        Me.txtMedicamento.Location = New System.Drawing.Point(129, 78)
        Me.txtMedicamento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMedicamento.Name = "txtMedicamento"
        Me.txtMedicamento.Size = New System.Drawing.Size(132, 25)
        Me.txtMedicamento.TabIndex = 2
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(129, 123)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(132, 25)
        Me.txtCantidad.TabIndex = 3
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(445, 30)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(132, 25)
        Me.txtStock.TabIndex = 5
        '
        'txtLote
        '
        Me.txtLote.Location = New System.Drawing.Point(445, 87)
        Me.txtLote.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(132, 25)
        Me.txtLote.TabIndex = 6
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(445, 144)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(132, 25)
        Me.txtPrecio.TabIndex = 7
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Location = New System.Drawing.Point(10, 167)
        Me.lblProveedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(71, 17)
        Me.lblProveedor.TabIndex = 4
        Me.lblProveedor.Text = "Proveedor"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(129, 168)
        Me.cmbProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(160, 25)
        Me.cmbProveedor.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.lblCodigo)
        Me.GroupBox1.Controls.Add(Me.cmbProveedor)
        Me.GroupBox1.Controls.Add(Me.lblMedicamento)
        Me.GroupBox1.Controls.Add(Me.lblProveedor)
        Me.GroupBox1.Controls.Add(Me.lblCantidad)
        Me.GroupBox1.Controls.Add(Me.lblStock)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.lblLote)
        Me.GroupBox1.Controls.Add(Me.txtLote)
        Me.GroupBox1.Controls.Add(Me.lblPrecio)
        Me.GroupBox1.Controls.Add(Me.txtStock)
        Me.GroupBox1.Controls.Add(Me.mskCodigo)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.txtMedicamento)
        Me.GroupBox1.Location = New System.Drawing.Point(71, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(631, 224)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Medicamento"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancelar.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources._1492790846_9cancel_84247
        Me.btnCancelar.Location = New System.Drawing.Point(431, 389)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(127, 41)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnRegistrar.FlatAppearance.BorderSize = 0
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRegistrar.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.save_file_disk_open_searsh_loading_clipboard_15131
        Me.btnRegistrar.Location = New System.Drawing.Point(216, 388)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(136, 42)
        Me.btnRegistrar.TabIndex = 20
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'frmMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(773, 475)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMedicamentos"
        Me.Text = "Registro de Medicamentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblMedicamento As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents lblLote As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents mskCodigo As MaskedTextBox
    Friend WithEvents txtMedicamento As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtLote As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblProveedor As Label
    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnRegistrar As Button
End Class

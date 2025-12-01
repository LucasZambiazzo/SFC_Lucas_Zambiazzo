<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvDetalleVenta = New System.Windows.Forms.DataGridView()
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.cmbMedicamentos = New System.Windows.Forms.ComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblMedicamento = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMetodos = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMetodo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        CType(Me.dgvDetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDetalleVenta
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvDetalleVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalleVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleVenta.EnableHeadersVisualStyles = False
        Me.dgvDetalleVenta.Location = New System.Drawing.Point(18, 203)
        Me.dgvDetalleVenta.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvDetalleVenta.Name = "dgvDetalleVenta"
        Me.dgvDetalleVenta.Size = New System.Drawing.Size(560, 288)
        Me.dgvDetalleVenta.TabIndex = 0
        '
        'cmbClientes
        '
        Me.cmbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(105, 31)
        Me.cmbClientes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(207, 23)
        Me.cmbClientes.TabIndex = 1
        '
        'cmbMedicamentos
        '
        Me.cmbMedicamentos.FormattingEnabled = True
        Me.cmbMedicamentos.Location = New System.Drawing.Point(105, 77)
        Me.cmbMedicamentos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbMedicamentos.Name = "cmbMedicamentos"
        Me.cmbMedicamentos.Size = New System.Drawing.Size(179, 23)
        Me.cmbMedicamentos.TabIndex = 2
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(11, 31)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(44, 15)
        Me.lblCliente.TabIndex = 4
        Me.lblCliente.Text = "Cliente"
        '
        'lblMedicamento
        '
        Me.lblMedicamento.AutoSize = True
        Me.lblMedicamento.Location = New System.Drawing.Point(11, 80)
        Me.lblMedicamento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMedicamento.Name = "lblMedicamento"
        Me.lblMedicamento.Size = New System.Drawing.Size(86, 15)
        Me.lblMedicamento.TabIndex = 5
        Me.lblMedicamento.Text = "Medicamentos"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(492, -169)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(215, 23)
        Me.txtTotal.TabIndex = 8
        '
        'nudCantidad
        '
        Me.nudCantidad.Location = New System.Drawing.Point(307, 77)
        Me.nudCantidad.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nudCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(54, 23)
        Me.nudCantidad.TabIndex = 9
        Me.nudCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(307, 103)
        Me.lblCantidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(55, 15)
        Me.lblCantidad.TabIndex = 11
        Me.lblCantidad.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 533)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 13
        '
        'cmbMetodos
        '
        Me.cmbMetodos.FormattingEnabled = True
        Me.cmbMetodos.Location = New System.Drawing.Point(32, 533)
        Me.cmbMetodos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbMetodos.Name = "cmbMetodos"
        Me.cmbMetodos.Size = New System.Drawing.Size(140, 23)
        Me.cmbMetodos.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.cmbClientes)
        Me.GroupBox1.Controls.Add(Me.lblCliente)
        Me.GroupBox1.Controls.Add(Me.cmbMedicamentos)
        Me.GroupBox1.Controls.Add(Me.lblMedicamento)
        Me.GroupBox1.Controls.Add(Me.lblCantidad)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.nudCantidad)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 130)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Venta"
        '
        'lblMetodo
        '
        Me.lblMetodo.AutoSize = True
        Me.lblMetodo.Location = New System.Drawing.Point(55, 515)
        Me.lblMetodo.Name = "lblMetodo"
        Me.lblMetodo.Size = New System.Drawing.Size(95, 15)
        Me.lblMetodo.TabIndex = 16
        Me.lblMetodo.Text = "Metodo de Pago"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources._error
        Me.Button1.Location = New System.Drawing.Point(378, 525)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 35)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Cancelar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.carro
        Me.btnAgregar.Location = New System.Drawing.Point(403, 77)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(91, 27)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnConfirmar.FlatAppearance.BorderSize = 0
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.Color.White
        Me.btnConfirmar.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.carrito_de_compras
        Me.btnConfirmar.Location = New System.Drawing.Point(230, 525)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(126, 35)
        Me.btnConfirmar.TabIndex = 7
        Me.btnConfirmar.Text = " Confirmar"
        Me.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(664, 583)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblMetodo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbMetodos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.dgvDetalleVenta)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmVenta"
        Me.Text = "Registrar Venta"
        CType(Me.dgvDetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDetalleVenta As DataGridView
    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents cmbMedicamentos As ComboBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblMedicamento As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents nudCantidad As NumericUpDown
    Friend WithEvents lblCantidad As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbMetodos As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblMetodo As Label
    Friend WithEvents Button1 As Button
End Class

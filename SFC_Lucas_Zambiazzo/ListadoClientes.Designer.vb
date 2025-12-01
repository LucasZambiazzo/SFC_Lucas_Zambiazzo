<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoClientes
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoClientes))
        Me.gpFiltrado = New System.Windows.Forms.GroupBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.txtFiltrado = New System.Windows.Forms.TextBox()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.idCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnuOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.SFCDataSet1 = New SFC_Lucas_Zambiazzo.SFCDataSet()
        Me.SFCDataSet = New SFC_Lucas_Zambiazzo.SFCDataSet()
        Me.Clientes_farmaciaTableAdapter = New SFC_Lucas_Zambiazzo.SFCDataSetTableAdapters.Clientes_farmaciaTableAdapter()
        Me.gpFiltrado.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuOpciones.SuspendLayout()
        CType(Me.SFCDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SFCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpFiltrado
        '
        Me.gpFiltrado.BackColor = System.Drawing.Color.Gainsboro
        Me.gpFiltrado.Controls.Add(Me.btnFiltrar)
        Me.gpFiltrado.Controls.Add(Me.txtFiltrado)
        Me.gpFiltrado.Location = New System.Drawing.Point(37, 12)
        Me.gpFiltrado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpFiltrado.Name = "gpFiltrado"
        Me.gpFiltrado.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpFiltrado.Size = New System.Drawing.Size(434, 73)
        Me.gpFiltrado.TabIndex = 0
        Me.gpFiltrado.TabStop = False
        Me.gpFiltrado.Text = "Filtrar Clientes"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnFiltrar.FlatAppearance.BorderSize = 0
        Me.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrar.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.lupa1
        Me.btnFiltrar.Location = New System.Drawing.Point(320, 16)
        Me.btnFiltrar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(106, 35)
        Me.btnFiltrar.TabIndex = 1
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFiltrar.UseVisualStyleBackColor = False
        '
        'txtFiltrado
        '
        Me.txtFiltrado.Location = New System.Drawing.Point(8, 23)
        Me.txtFiltrado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFiltrado.Name = "txtFiltrado"
        Me.txtFiltrado.Size = New System.Drawing.Size(252, 23)
        Me.txtFiltrado.TabIndex = 0
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCliente})
        Me.dgvClientes.ContextMenuStrip = Me.mnuOpciones
        Me.dgvClientes.EnableHeadersVisualStyles = False
        Me.dgvClientes.Location = New System.Drawing.Point(37, 91)
        Me.dgvClientes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(744, 412)
        Me.dgvClientes.TabIndex = 1
        '
        'idCliente
        '
        Me.idCliente.DataPropertyName = "idCliente"
        Me.idCliente.HeaderText = "idCliente"
        Me.idCliente.Name = "idCliente"
        Me.idCliente.ReadOnly = True
        '
        'mnuOpciones
        '
        Me.mnuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNuevo, Me.mnuModificar, Me.mnuImprimir, Me.mnuEliminar})
        Me.mnuOpciones.Name = "mnuOpciones"
        Me.mnuOpciones.Size = New System.Drawing.Size(126, 92)
        '
        'mnuNuevo
        '
        Me.mnuNuevo.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.agregar_usuario1
        Me.mnuNuevo.Name = "mnuNuevo"
        Me.mnuNuevo.Size = New System.Drawing.Size(125, 22)
        Me.mnuNuevo.Text = "Nuevo"
        '
        'mnuModificar
        '
        Me.mnuModificar.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.editar
        Me.mnuModificar.Name = "mnuModificar"
        Me.mnuModificar.Size = New System.Drawing.Size(125, 22)
        Me.mnuModificar.Text = "Modificar"
        '
        'mnuImprimir
        '
        Me.mnuImprimir.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.imprimir
        Me.mnuImprimir.Name = "mnuImprimir"
        Me.mnuImprimir.Size = New System.Drawing.Size(125, 22)
        Me.mnuImprimir.Text = "Imprimir"
        '
        'mnuEliminar
        '
        Me.mnuEliminar.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.basura
        Me.mnuEliminar.Name = "mnuEliminar"
        Me.mnuEliminar.Size = New System.Drawing.Size(125, 22)
        Me.mnuEliminar.Text = "Eliminar"
        '
        'SFCDataSet1
        '
        Me.SFCDataSet1.DataSetName = "SFCDataSet"
        Me.SFCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SFCDataSet
        '
        Me.SFCDataSet.DataSetName = "SFCDataSet"
        Me.SFCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Clientes_farmaciaTableAdapter
        '
        Me.Clientes_farmaciaTableAdapter.ClearBeforeFill = True
        '
        'ListadoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(818, 564)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.gpFiltrado)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ListadoClientes"
        Me.Text = "Listado de Clientes"
        Me.gpFiltrado.ResumeLayout(False)
        Me.gpFiltrado.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuOpciones.ResumeLayout(False)
        CType(Me.SFCDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SFCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpFiltrado As GroupBox
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents txtFiltrado As TextBox
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents mnuOpciones As ContextMenuStrip
    Friend WithEvents mnuNuevo As ToolStripMenuItem
    Friend WithEvents mnuModificar As ToolStripMenuItem
    Friend WithEvents mnuImprimir As ToolStripMenuItem
    Friend WithEvents mnuEliminar As ToolStripMenuItem
    Friend WithEvents SFCDataSet As SFCDataSet
    Friend WithEvents idCliente As DataGridViewTextBoxColumn
    Friend WithEvents SFCDataSet1 As SFCDataSet
    Friend WithEvents Clientes_farmaciaTableAdapter As SFCDataSetTableAdapters.Clientes_farmaciaTableAdapter
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdObraSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdPlanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

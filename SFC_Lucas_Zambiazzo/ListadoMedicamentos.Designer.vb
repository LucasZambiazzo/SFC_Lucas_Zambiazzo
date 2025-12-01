<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoMedicamentos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoMedicamentos))
        Me.gpFiltrado = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.dgvMedicamentos = New System.Windows.Forms.DataGridView()
        Me.mnuOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SFCDataSet1 = New SFC_Lucas_Zambiazzo.SFCDataSet1()
        Me.MedicamentosTableAdapter = New SFC_Lucas_Zambiazzo.SFCDataSet1TableAdapters.MedicamentosTableAdapter()
        Me.mnuNueva = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.gpFiltrado.SuspendLayout()
        CType(Me.dgvMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuOpciones.SuspendLayout()
        CType(Me.SFCDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpFiltrado
        '
        Me.gpFiltrado.BackColor = System.Drawing.Color.Gainsboro
        Me.gpFiltrado.Controls.Add(Me.btnFiltrar)
        Me.gpFiltrado.Controls.Add(Me.txtFiltro)
        Me.gpFiltrado.Location = New System.Drawing.Point(27, 14)
        Me.gpFiltrado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpFiltrado.Name = "gpFiltrado"
        Me.gpFiltrado.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.gpFiltrado.Size = New System.Drawing.Size(506, 84)
        Me.gpFiltrado.TabIndex = 0
        Me.gpFiltrado.TabStop = False
        Me.gpFiltrado.Text = "Filtrar Medicamentos"
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(8, 31)
        Me.txtFiltro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(293, 23)
        Me.txtFiltro.TabIndex = 0
        '
        'dgvMedicamentos
        '
        Me.dgvMedicamentos.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvMedicamentos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMedicamentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedicamentos.ContextMenuStrip = Me.mnuOpciones
        Me.dgvMedicamentos.EnableHeadersVisualStyles = False
        Me.dgvMedicamentos.Location = New System.Drawing.Point(27, 105)
        Me.dgvMedicamentos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvMedicamentos.Name = "dgvMedicamentos"
        Me.dgvMedicamentos.Size = New System.Drawing.Size(835, 400)
        Me.dgvMedicamentos.TabIndex = 1
        '
        'mnuOpciones
        '
        Me.mnuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNueva, Me.mnuModificar, Me.mnuEliminar, Me.mnuImprimir})
        Me.mnuOpciones.Name = "mnuOpciones"
        Me.mnuOpciones.Size = New System.Drawing.Size(126, 92)
        '
        'SFCDataSet1
        '
        Me.SFCDataSet1.DataSetName = "SFCDataSet1"
        Me.SFCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicamentosTableAdapter
        '
        Me.MedicamentosTableAdapter.ClearBeforeFill = True
        '
        'mnuNueva
        '
        Me.mnuNueva.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.medicamento
        Me.mnuNueva.Name = "mnuNueva"
        Me.mnuNueva.Size = New System.Drawing.Size(125, 22)
        Me.mnuNueva.Text = "Nuevo"
        '
        'mnuModificar
        '
        Me.mnuModificar.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.editar_texto
        Me.mnuModificar.Name = "mnuModificar"
        Me.mnuModificar.Size = New System.Drawing.Size(125, 22)
        Me.mnuModificar.Text = "Modificar"
        '
        'mnuEliminar
        '
        Me.mnuEliminar.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.basura
        Me.mnuEliminar.Name = "mnuEliminar"
        Me.mnuEliminar.Size = New System.Drawing.Size(125, 22)
        Me.mnuEliminar.Text = "Eliminar"
        '
        'mnuImprimir
        '
        Me.mnuImprimir.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.imprimir
        Me.mnuImprimir.Name = "mnuImprimir"
        Me.mnuImprimir.Size = New System.Drawing.Size(125, 22)
        Me.mnuImprimir.Text = "Imprimir"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnFiltrar.FlatAppearance.BorderSize = 0
        Me.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrar.Image = Global.SFC_Lucas_Zambiazzo.My.Resources.Resources.lupa1
        Me.btnFiltrar.Location = New System.Drawing.Point(362, 22)
        Me.btnFiltrar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(124, 40)
        Me.btnFiltrar.TabIndex = 1
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFiltrar.UseVisualStyleBackColor = False
        '
        'ListadoMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(881, 532)
        Me.Controls.Add(Me.dgvMedicamentos)
        Me.Controls.Add(Me.gpFiltrado)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ListadoMedicamentos"
        Me.Text = "ListadoMedicamentos"
        Me.gpFiltrado.ResumeLayout(False)
        Me.gpFiltrado.PerformLayout()
        CType(Me.dgvMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuOpciones.ResumeLayout(False)
        CType(Me.SFCDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpFiltrado As GroupBox
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents dgvMedicamentos As DataGridView
    Friend WithEvents mnuOpciones As ContextMenuStrip
    Friend WithEvents mnuNueva As ToolStripMenuItem
    Friend WithEvents mnuModificar As ToolStripMenuItem
    Friend WithEvents mnuEliminar As ToolStripMenuItem
    Friend WithEvents mnuImprimir As ToolStripMenuItem
    Friend WithEvents SFCDataSet1 As SFCDataSet1
    Friend WithEvents MedicamentosTableAdapter As SFCDataSet1TableAdapters.MedicamentosTableAdapter
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

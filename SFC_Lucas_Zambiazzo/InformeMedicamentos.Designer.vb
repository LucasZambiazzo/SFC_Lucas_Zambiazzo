<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeMedicamentos
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformeMedicamentos))
        Me.MedicamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SFCDataSet1 = New SFC_Lucas_Zambiazzo.SFCDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MedicamentosTableAdapter = New SFC_Lucas_Zambiazzo.SFCDataSet1TableAdapters.MedicamentosTableAdapter()
        CType(Me.MedicamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SFCDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MedicamentosBindingSource
        '
        Me.MedicamentosBindingSource.DataMember = "Medicamentos"
        Me.MedicamentosBindingSource.DataSource = Me.SFCDataSet1
        '
        'SFCDataSet1
        '
        Me.SFCDataSet1.DataSetName = "SFCDataSet1"
        Me.SFCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetMedicamentos"
        ReportDataSource1.Value = Me.MedicamentosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SFC_Lucas_Zambiazzo.InformeMedicamentos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1106, 666)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'MedicamentosTableAdapter
        '
        Me.MedicamentosTableAdapter.ClearBeforeFill = True
        '
        'InformeMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 666)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InformeMedicamentos"
        Me.Text = "InformeMedicamentos"
        CType(Me.MedicamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SFCDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SFCDataSet1 As SFCDataSet1
    Friend WithEvents MedicamentosBindingSource As BindingSource
    Friend WithEvents MedicamentosTableAdapter As SFCDataSet1TableAdapters.MedicamentosTableAdapter
End Class

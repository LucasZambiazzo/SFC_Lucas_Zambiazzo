Public Class InformeMedicamentos
    Private Sub InformeMedicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SFCDataSet1.Medicamentos' Puede moverla o quitarla según sea necesario.
        Me.MedicamentosTableAdapter.Fill(Me.SFCDataSet1.Medicamentos)
        Dim tabla As DataTable
        Dim sql As String

        sql = "select * from Medicamentos order by medicamento asc"
        Recuperar(sqlinformes, tabla)

        ReportViewer1.LocalReport.ReportPath = "C:\Users\Lucas Zambiazzo\source\repos\SFC_Lucas_Zambiazzo\SFC_Lucas_Zambiazzo\InformeMedicamentos.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSetMedicamentos", tabla))

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class
Public Class InformeUsuarios
    Private Sub InformeUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SFCDataSet2.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.SFCDataSet2.Usuarios)
        Dim tabla As DataTable
        Dim sql As String

        sql = "select * from Usuarios order by usuario asc"
        Recuperar(sqlinformes, tabla)

        ReportViewer1.LocalReport.ReportPath = "C:\Users\Lucas Zambiazzo\source\repos\SFC_Lucas_Zambiazzo\SFC_Lucas_Zambiazzo\InformeUsuarios.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSetUsuarios", tabla))

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
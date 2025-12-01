Public Class InformeClientes
    Private Sub InformeClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SFCDataSet.Clientes_farmacia' Puede moverla o quitarla según sea necesario.
        Me.Clientes_farmaciaTableAdapter.Fill(Me.SFCDataSet.Clientes_farmacia)

        Dim tabla As DataTable
        Dim sql As String

        sql = "select * from Clientes_farmacia order by apellido asc"
        Recuperar(sqlinformes, tabla)

        ReportViewer1.LocalReport.ReportPath = "C:\Users\Lucas Zambiazzo\source\repos\SFC_Lucas_Zambiazzo\SFC_Lucas_Zambiazzo\InformeClientes.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSetClientes", tabla))

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class
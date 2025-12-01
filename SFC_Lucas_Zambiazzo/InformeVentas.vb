Imports Microsoft.Reporting.WinForms
Public Class InformeVentas
    Private Sub InformeVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        ' 1. Definimos TU consulta SQL personalizada (Igual a la del listado)
        Dim sql As String = "SELECT V.idVenta, V.Fecha, (C.Apellido + ', ' + C.Nombre) AS Cliente, " &
                            "M.Metodo AS FormaPago, U.Usuario AS Vendedor, V.Monto AS Total " &
                            "FROM Ventas V, Clientes_farmacia C, Usuarios U, Metodos_de_pago M " &
                            "WHERE V.idCliente = C.idCliente " &
                            "AND V.idUsuario = U.idUsuario " &
                            "AND V.idMetodo = M.idMetodo " &
                            "ORDER BY V.Fecha DESC"

        ' 2. Llenamos una tabla con esos datos
        Dim tabla As New DataTable()
        Recuperar(sql, tabla)

        ' 3. Limpiamos cualquier dato viejo del reporte
        ReportViewer1.LocalReport.DataSources.Clear()

        ' 4. Conectamos TU tabla con el Reporte
        ' IMPORTANTE: "DataSet1" es el nombre por defecto. 
        ' Si tu reporte no carga, verifica en el diseño del .rdlc cómo se llama el conjunto de datos (a la izquierda).
        Dim rds As New ReportDataSource("DataSetVentas", tabla)

        ReportViewer1.LocalReport.DataSources.Add(rds)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
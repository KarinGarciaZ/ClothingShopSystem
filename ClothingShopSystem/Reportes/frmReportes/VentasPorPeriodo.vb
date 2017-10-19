Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class VentasPorPeriodo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CONEXION = openConnection()
        CONEXION.Open()

        If rbEfectivo.Checked Then
            Dim cmd As New SqlCommand("VentasContadoPorPeriodo", CONEXION)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter()
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = CONEXION
            adaptador.SelectCommand.CommandText = "VentasContadoPorPeriodo"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@FECHA1", SqlDbType.Date)
            Dim param2 = New SqlParameter("@FECHA2", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(DateTimePicker1.Text)
            param2.Value = CDate(DateTimePicker2.Text)
            adaptador.SelectCommand.Parameters.Add(param1)
            adaptador.SelectCommand.Parameters.Add(param2)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("FECHA1", CDate(DateTimePicker1.Text))
            Dim p2 As New ReportParameter("FECHA2", CDate(DateTimePicker2.Text))
            Reporte.Reportito.LocalReport.DataSources.Clear()
            Reporte.Reportito.LocalReport.DataSources.Add(datasource)
            Reporte.Reportito.LocalReport.ReportPath = obtenerRutaReportes() & "\ReporteVentasContadoPeriodo.rdlc"
            Reporte.Reportito.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            Reporte.Reportito.RefreshReport()
            Reporte.ShowDialog()
        Else
            Dim cmd As New SqlCommand("VentasCreditoPorPeriodo", CONEXION)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter()
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = CONEXION
            adaptador.SelectCommand.CommandText = "VentasCreditoPorPeriodo"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@FECHA1", SqlDbType.Date)
            Dim param2 = New SqlParameter("@FECHA2", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(DateTimePicker1.Text)
            param2.Value = CDate(DateTimePicker2.Text)
            adaptador.SelectCommand.Parameters.Add(param1)
            adaptador.SelectCommand.Parameters.Add(param2)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("FECHA1", CDate(DateTimePicker1.Text))
            Dim p2 As New ReportParameter("FECHA2", CDate(DateTimePicker2.Text))
            Reporte.Reportito.LocalReport.DataSources.Clear()
            Reporte.Reportito.LocalReport.DataSources.Add(datasource)
            Reporte.Reportito.LocalReport.ReportPath = obtenerRutaReportes() & "\ReporteVentasCreditoPeriodo.rdlc"
            Reporte.Reportito.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            Reporte.Reportito.RefreshReport()
            Reporte.ShowDialog()
        End If
        CONEXION.Close()
    End Sub
End Class
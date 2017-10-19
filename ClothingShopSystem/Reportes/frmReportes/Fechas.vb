Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class Fechas
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim Conexion As SqlConnection = openConnection()
        Conexion.Open()

        Dim Adaptador As New SqlDataAdapter

        Adaptador.SelectCommand = New SqlCommand
        Adaptador.SelectCommand.Connection = Conexion
        Adaptador.SelectCommand.CommandText = "ReporteDevolucionesPeriodo"
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim param1 = New SqlParameter("@p1", SqlDbType.Date)
        Dim param2 = New SqlParameter("@p2", SqlDbType.Date)

        param1.Direction = ParameterDirection.Input
        param2.Direction = ParameterDirection.Input
        param1.Value = CDate(dtpFecha1.Text)
        param2.Value = CDate(dtpFecha2.Text)
        Adaptador.SelectCommand.Parameters.Add(param1)
        Adaptador.SelectCommand.Parameters.Add(param2)

        Dim Data As New DataSet

        Adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))

        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)
        Dim p1 As New ReportParameter("p1", CDate(dtpFecha1.Text))
        Dim p2 As New ReportParameter("p2", CDate(dtpFecha2.Text))

        Reporte.Reportito.LocalReport.DataSources.Clear()
        Reporte.Reportito.LocalReport.DataSources.Add(Datasource)
        Reporte.Reportito.LocalReport.ReportPath = obtenerRutaReportes() & "\ReporteDevolucion.rdlc"
        Reporte.Reportito.LocalReport.SetParameters(New ReportParameter() {p1, p2})

        Reporte.Reportito.RefreshReport()
        Reporte.Show()
        Conexion.Close()
    End Sub
End Class
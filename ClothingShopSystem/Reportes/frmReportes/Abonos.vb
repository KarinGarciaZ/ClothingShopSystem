Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Abonos
    Dim conexion = openConnection()
    Dim comando As SqlCommand = conexion.CreateCommand()
    Dim lector As SqlDataReader

    Private Sub Abonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbClientes.Items.Clear()

        conexion.open()
        comando.CommandText = "SELECT nombre FROM Clientes WHERE idCliente <> 1"
        lector = comando.ExecuteReader()

        While lector.Read
            cbClientes.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub apartados(id)
        Dim adaptador As New SqlDataAdapter()

        adaptador.SelectCommand = New SqlCommand
        adaptador.SelectCommand.Connection = conexion
        adaptador.SelectCommand.CommandText = "ReporteAbonosApartados"
        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim param1 As New SqlParameter("@cliente", SqlDbType.VarChar)
        param1.Direction = ParameterDirection.Input
        param1.Value = id
        adaptador.SelectCommand.Parameters.Add(param1)


        Dim Data As New DataSet

        adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))

        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)
        Dim p1 As New ReportParameter("cliente", cbClientes.Text)

        Reporte.Reportito.LocalReport.DataSources.Clear()
        Reporte.Reportito.LocalReport.DataSources.Add(Datasource)
        Reporte.Reportito.LocalReport.ReportPath = obtenerRutaReportes() & "\ReporteAbonosApartados.rdlc"
        Reporte.Reportito.LocalReport.SetParameters(New ReportParameter() {p1})

        Reporte.Reportito.RefreshReport()
        Reporte.Show()
        conexion.Close()
    End Sub

    Private Sub ventas(id)
        Dim adaptador As New SqlDataAdapter()

        adaptador.SelectCommand = New SqlCommand
        adaptador.SelectCommand.Connection = conexion
        adaptador.SelectCommand.CommandText = "ReporteAbonosVentas"
        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim param1 As New SqlParameter("@cliente", SqlDbType.VarChar)
        param1.Direction = ParameterDirection.Input
        param1.Value = id
        adaptador.SelectCommand.Parameters.Add(param1)


        Dim Data As New DataSet

        adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))

        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)
        Dim p1 As New ReportParameter("cliente", cbClientes.Text)

        Reporte.Reportito.LocalReport.DataSources.Clear()
        Reporte.Reportito.LocalReport.DataSources.Add(Datasource)
        Reporte.Reportito.LocalReport.ReportPath = obtenerRutaReportes() & "\ReporteAbonosVentas.rdlc"
        Reporte.Reportito.LocalReport.SetParameters(New ReportParameter() {p1})

        Reporte.Reportito.RefreshReport()
        Reporte.Show()
        conexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        comando.CommandText = "SELECT idCliente FROM Clientes WHERE nombre = '" & cbClientes.Text & "'"
        lector = comando.ExecuteReader()
        Dim id As Integer = 0
        If lector.Read Then
            id = lector(0)
        End If
        lector.Close()

        If rbApartado.Checked Then
            apartados(id)
        Else
            ventas(id)
        End If
    End Sub
End Class
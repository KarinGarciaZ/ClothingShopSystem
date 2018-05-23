Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class ComprasPorProveedor

    Dim conexion = openConnection()
    Dim comando As SqlCommand = conexion.CreateCommand()
    Dim lector As SqlDataReader

    Private Sub ComprasPorProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbProveedores.Items.Clear()

        conexion.open()
        comando.CommandText = "SELECT nombre FROM Proveedores"
        lector = comando.ExecuteReader()

        While lector.Read
            cbProveedores.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim adaptador As New SqlDataAdapter()

        adaptador.SelectCommand = New SqlCommand
        adaptador.SelectCommand.Connection = conexion
        adaptador.SelectCommand.CommandText = "ComprasPorProveedor3"
        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim param1 As New SqlParameter("@proveedor", SqlDbType.VarChar)
        param1.Direction = ParameterDirection.Input
        param1.Value = cbProveedores.Text
        adaptador.SelectCommand.Parameters.Add(param1)


        Dim Data As New DataSet

        adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))

        datasource.Name = "DataSet1"
        datasource.Value = Data.Tables(0)
        Dim p1 As New ReportParameter("proveedor", cbProveedores.Text)

        Reporte.Reportito.LocalReport.DataSources.Clear()
        Reporte.Reportito.LocalReport.DataSources.Add(datasource)
        Reporte.Reportito.LocalReport.ReportPath = obtenerRutaReportes() & "\ComprasPorProveedor3.rdlc"
        Reporte.Reportito.LocalReport.SetParameters(New ReportParameter() {p1})

        Reporte.Reportito.RefreshReport()
        Reporte.Show()
        conexion.Close()
    End Sub
End Class
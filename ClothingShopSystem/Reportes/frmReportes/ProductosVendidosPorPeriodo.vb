Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class ProductosVendidosPorPeriodo

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection = openConnection()
        Dim command As SqlCommand = connection.CreateCommand()
        Dim lector As SqlDataReader
        connection.Open()
        command.CommandText = "DELETE from auxProductosVendidosPeriodo"
        Command.ExecuteNonQuery()

        Command.CommandText = "SELECT DetalleVentas.idProducto, Productos.nombre, DetalleVentas.cantidad FROM DetalleVentas inner join Ventas on DetalleVentas.idVenta = Ventas.idVenta inner join Productos on Productos.idProducto = DetalleVentas.idProducto where Ventas.fecha >= '" & DateTimePicker1.Value.Date & "' and Ventas.fecha <= '" & DateTimePicker2.Value.Date & "'"
        lector = Command.ExecuteReader
        Dim id As Integer
        Dim nom As String
        Dim cant As Integer
        Dim ban As Boolean = False
        While lector.Read
            id = lector(0)
            nom = lector(1)
            cant = lector(2)
            If dg.RowCount > 0 Then
                ban = False
                For x = 0 To dg.RowCount - 1
                    If id = CInt(dg.Item(0, x).Value) Then
                        dg.Item(2, x).Value += cant
                        ban = True
                    End If
                Next
                If Not ban Then
                    dg.Rows.Add(id, nom, cant)
                End If
            Else
                dg.Rows.Add(id, nom, cant)
            End If
        End While
        lector.Close()

        For x = 0 To dg.RowCount - 1
            Command.CommandText = "INSERT INTO auxProductosVendidosPeriodo VALUES (" & dg.Item(0, x).Value & ",'" & dg.Item(1, x).Value & "'," & dg.Item(2, x).Value & ")"
            Command.ExecuteNonQuery()
        Next



        Dim Cmd As New SqlCommand("ReporteProductosVendidosPeriodo", connection)

        Cmd.CommandType = CommandType.StoredProcedure

        Dim Adaptador As New SqlDataAdapter(Cmd)
        Dim Data As New Data.DataSet

        Adaptador.Fill(Data)
        Data.DataSetName = "DataSet1"

        Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))

        Reporte.Reportito.LocalReport.DataSources.Clear()
        Reporte.Reportito.LocalReport.DataSources.Add(Reportes)
        Reporte.Reportito.LocalReport.ReportPath = "C:\Users\elektramovil\Desktop\7mo semestre\Raquel\Programa\ClothingShopSystem\ClothingShopSystem\Reportes\ReportesLibros\ReporteProductosPeriodo.rdlc"
        Reporte.Reportito.RefreshReport()
        Reporte.Show()
        connection.Close()
    End Sub

End Class
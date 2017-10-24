Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class IngresosDiarios
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection = openConnection()
        Dim command As SqlCommand = connection.CreateCommand()
        Dim lector As SqlDataReader
        connection.Open()
        command.CommandText = "DELETE from auxIngresosDiarios"
        command.ExecuteNonQuery()

        If DateTimePicker1.Value < DateTimePicker2.Value Then
            Dim x As Double = 0
            While DateTimePicker1.Value.AddDays(x) < DateTimePicker2.Value
                dg.Rows.Add(DateTimePicker1.Value.AddDays(x).ToString, 0, 0, 0, 0)
                x += 1
            End While
            command.CommandText = "SELECT subtotal + iva, fecha FROM Ventas where fecha >= '" & DateTimePicker1.Value.Date & "' and fecha <= '" & DateTimePicker2.Value.Date & "' and condicion = 'Efectivo'"
            lector = command.ExecuteReader
            Dim fecha As Date
            While lector.Read
                For y = 0 To dg.RowCount - 1
                    fecha = CDate(dg.Item(0, y).Value).Date
                    If lector(1) = fecha Then
                        dg.Item(1, y).Value += lector(0)
                    End If
                Next
            End While
            lector.Close()

            command.CommandText = "SELECT importe, fecha FROM AbonosCreditos where fecha >= '" & DateTimePicker1.Value.Date & "' and fecha <= '" & DateTimePicker2.Value.Date & "'"
            lector = command.ExecuteReader
            While lector.Read
                For y = 0 To dg.RowCount - 1
                    fecha = CDate(dg.Item(0, y).Value).Date
                    If lector(1) = fecha Then
                        dg.Item(2, y).Value += lector(0)
                    End If
                Next
            End While
            lector.Close()

            command.CommandText = "SELECT pago, fecha FROM AbonosApartados where fecha >= '" & DateTimePicker1.Value.Date & "' and fecha <= '" & DateTimePicker2.Value.Date & "'"
            lector = command.ExecuteReader
            While lector.Read
                For y = 0 To dg.RowCount - 1
                    fecha = CDate(dg.Item(0, y).Value).Date
                    If lector(1) = fecha Then
                        dg.Item(3, y).Value += lector(0)
                    End If
                Next
            End While
            lector.Close()

            For y = 0 To dg.RowCount - 1
                dg.Item(4, y).Value = CDbl(dg.Item(2, y).Value) + CDbl(dg.Item(3, y).Value) + CDbl(dg.Item(1, y).Value)
            Next

            For z = 0 To dg.RowCount - 1
                command.CommandText = "INSERT INTO auxIngresosDiarios VALUES ('" & CDate(dg.Item(0, z).Value).Date & "'," & dg.Item(1, z).Value & "," & dg.Item(2, z).Value & "," & dg.Item(3, z).Value & "," & dg.Item(4, z).Value & ")"
                command.ExecuteNonQuery()
            Next
            dg.Rows.Clear()


            Dim Cmd As New SqlCommand("ReporteIngresosDiarios", connection)

            Cmd.CommandType = CommandType.StoredProcedure

            Dim Adaptador As New SqlDataAdapter(Cmd)
            Dim Data As New Data.DataSet

            Adaptador.Fill(Data)
            Data.DataSetName = "DataSet1"

            Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))
            Dim p1 As New ReportParameter("p1", CDate(DateTimePicker1.Text))
            Dim p2 As New ReportParameter("p2", CDate(DateTimePicker2.Text))
            Reporte.Reportito.LocalReport.DataSources.Clear()
            Reporte.Reportito.LocalReport.DataSources.Add(Reportes)
            Reporte.Reportito.LocalReport.ReportPath = obtenerRutaReportes() & "\ReporteIngresosDiarios.rdlc"
            Reporte.Reportito.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            Reporte.Reportito.RefreshReport()
            Reporte.Show()
        Else
            MsgBox("La fecha inicial debe ser menor a la fecha final.")
        End If


        connection.Close()
    End Sub
End Class
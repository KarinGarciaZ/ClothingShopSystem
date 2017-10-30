Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmClientes
    Dim conexion = openConnection()
    Dim comando As SqlCommand = conexion.CreateCommand()
    Dim lector As SqlDataReader

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbCliente.Items.Clear()
        txtDomicilio.Text = String.Empty
        txtIdCliente.Text = String.Empty
        txtTelefono.Text = String.Empty
        txtSaldo.Text = String.Empty

        conexion.open()
        comando.CommandText = "SELECT nombre FROM Clientes WHERE idCliente <> 1"
        lector = comando.ExecuteReader()

        While lector.Read
            cbCliente.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub cbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCliente.SelectedIndexChanged
        comando.CommandText = "SELECT * FROM Clientes WHERE nombre = '" & cbCliente.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()

        txtIdCliente.Text = lector(0).ToString
        txtDomicilio.Text = lector(2).ToString
        txtTelefono.Text = lector(6).ToString
        txtSaldo.Text = lector(7).ToString
        lector.Close()
    End Sub

    Private Sub frmClientes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        comando.CommandText = "DELETE FROM auxEstadoCuenta"
        comando.ExecuteNonQuery()

        conexion = cerrarConexion()
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        Tabla1()
        Dim Adaptador As New SqlDataAdapter

        Adaptador.SelectCommand = New SqlCommand
        Adaptador.SelectCommand.Connection = conexion
        Adaptador.SelectCommand.CommandText = "ReporteEstadoCuentaDeudor2"
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim Data As New DataSet

        Adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))

        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)
        Dim p1 As New ReportParameter("nombre", cbCliente.Text)
        Dim p2 As New ReportParameter("tipo", "Reporte Estado de Cuenta.")

        Reporte.Reportito.LocalReport.DataSources.Clear()
        Reporte.Reportito.LocalReport.DataSources.Add(Datasource)
        Reporte.Reportito.LocalReport.ReportPath = obtenerRutaReportes() & "\ReporteEstadoCuentaDeudor.rdlc"
        Reporte.Reportito.LocalReport.SetParameters(New ReportParameter() {p1, p2})

        Reporte.Reportito.RefreshReport()
        Reporte.Show()
    End Sub

    Private Sub btnConsultaD_Click(sender As Object, e As EventArgs) Handles btnConsultaD.Click
        Tabla2()
        Dim Adaptador As New SqlDataAdapter

        Adaptador.SelectCommand = New SqlCommand
        Adaptador.SelectCommand.Connection = conexion
        Adaptador.SelectCommand.CommandText = "ReporteEstadoCuentaDeudor2"
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim Data As New DataSet

        Adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))

        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)
        Dim p1 As New ReportParameter("nombre", cbCliente.Text)
        Dim p2 As New ReportParameter("tipo", "Reporte Estado de Cuenta Deudor.")

        Reporte.Reportito.LocalReport.DataSources.Clear()
        Reporte.Reportito.LocalReport.DataSources.Add(Datasource)
        Reporte.Reportito.LocalReport.ReportPath = obtenerRutaReportes() & "\ReporteEstadoCuentaDeudor.rdlc"
        Reporte.Reportito.LocalReport.SetParameters(New ReportParameter() {p1, p2})

        Reporte.Reportito.RefreshReport()
        Reporte.Show()
    End Sub

    Private Sub Tabla1()
        Dim ah As Integer = 0
        comando.CommandText = "SELECT COUNT(*) FROM Apartados WHERE idCliente = " & txtIdCliente.Text
        ah = comando.ExecuteScalar() - 1

        Dim arrLargo(ah) As Integer
        Dim cont As Integer = 0
        Dim id As Integer = 1

        comando.CommandText = "SELECT idApartado FROM Apartados WHERE idCliente = " & txtIdCliente.Text
        lector = comando.ExecuteReader()
        While lector.Read
            arrLargo(cont) = lector(0)
            cont = +1
        End While
        lector.Close()

        For x = 0 To ah
            'primero 
            comando.CommandText = "SELECT idApartado, fecha, total FROM Apartados WHERE idApartado = " & arrLargo(x)
            lector = comando.ExecuteReader()
            lector.Read()
            DataGridView1.Rows.Add(id, "Apartado", "", lector(0), lector(1), lector(2), 0)
            id += 1
            lector.Close()

            'abonosApartados
            comando.CommandText = "SELECT idAbonoA, fecha, pago FROM AbonosApartados WHERE idApartado = " & arrLargo(x)
            lector = comando.ExecuteReader()
            While lector.Read()
                DataGridView1.Rows.Add(id, "", "Abono Apartado", lector(0), lector(1), 0, lector(2))
                id += 1
            End While
            lector.Close()
        Next

        ah = 0
        comando.CommandText = "SELECT COUNT(*) FROM Ventas WHERE condicion = 'Credito' and idCliente = " & txtIdCliente.Text
        ah = comando.ExecuteScalar() - 1

        Dim arrLargo2(ah) As Integer
        cont = 0

        comando.CommandText = "SELECT idVenta FROM Ventas WHERE condicion = 'Credito' and idCliente = " & txtIdCliente.Text
        lector = comando.ExecuteReader()
        While lector.Read
            arrLargo2(cont) = lector(0)
            cont = +1
        End While
        lector.Close()

        For x = 0 To ah
            'primero 
            comando.CommandText = "SELECT idVenta, fecha, subtotal + iva FROM Ventas WHERE idVenta = " & arrLargo2(x)
            lector = comando.ExecuteReader()
            lector.Read()
            DataGridView1.Rows.Add(id, "Venta", "", lector(0), lector(1), lector(2), 0)
            id += 1
            lector.Close()

            'abonosApartados
            comando.CommandText = "SELECT idAbonoC, fecha, importe FROM AbonosCreditos WHERE idVenta = " & arrLargo2(x)
            lector = comando.ExecuteReader()
            While lector.Read()
                DataGridView1.Rows.Add(id, "", "Abono Venta", lector(0), lector(1), 0, lector(2))
                id += 1
            End While
            lector.Close()
        Next



        For x = 0 To DataGridView1.RowCount - 1
            Dim id2 As Integer = DataGridView1.Item(0, x).Value
            Dim tipo As String = DataGridView1.Item(1, x).Value
            Dim tipo2 As String = DataGridView1.Item(2, x).Value
            Dim idTipo As Integer = DataGridView1.Item(3, x).Value
            Dim fecha As Date = DataGridView1.Item(4, x).Value
            Dim cargo As Double = DataGridView1.Item(5, x).Value
            Dim abono As Double = DataGridView1.Item(6, x).Value

            comando.CommandText = "INSERT INTO auxEstadoCuenta VALUES (" & id2 & ",'" & tipo & "','" & tipo2 & "'," & idTipo & ", '" & fecha &
                "'," & cargo & "," & abono & ")"
            comando.ExecuteNonQuery()

        Next
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub Tabla2()
        Dim ah As Integer = 0
        comando.CommandText = "SELECT COUNT(*) FROM Apartados WHERE abono < total and idCliente = " & txtIdCliente.Text
        ah = comando.ExecuteScalar() - 1

        Dim arrLargo(ah) As Integer
        Dim cont As Integer = 0
        Dim id As Integer = 1

        comando.CommandText = "SELECT idApartado FROM Apartados WHERE abono < total and idCliente = " & txtIdCliente.Text
        lector = comando.ExecuteReader()
        While lector.Read
            arrLargo(cont) = lector(0)
            cont = +1
        End While
        lector.Close()

        For x = 0 To ah
            'primero 
            comando.CommandText = "SELECT idApartado, fecha, total FROM Apartados WHERE idApartado = " & arrLargo(x)
            lector = comando.ExecuteReader()
            lector.Read()
            DataGridView1.Rows.Add(id, "Apartado", "", lector(0), lector(1), lector(2), 0)
            id += 1
            lector.Close()

            'abonosApartados
            comando.CommandText = "SELECT idAbonoA, fecha, pago FROM AbonosApartados WHERE idApartado = " & arrLargo(x)
            lector = comando.ExecuteReader()
            While lector.Read()
                DataGridView1.Rows.Add(id, "", "Abono Apartado", lector(0), lector(1), 0, lector(2))
                id += 1
            End While
            lector.Close()
        Next

        ah = 0
        comando.CommandText = "SELECT COUNT(*) FROM Ventas WHERE condicion = 'Credito' and abonado < subtotal + iva and idCliente = " & txtIdCliente.Text
        ah = comando.ExecuteScalar() - 1

        Dim arrLargo2(ah) As Integer
        cont = 0

        comando.CommandText = "SELECT idVenta FROM Ventas WHERE condicion = 'Credito' and abonado < subtotal + iva and idCliente = " & txtIdCliente.Text
        lector = comando.ExecuteReader()
        While lector.Read
            arrLargo2(cont) = lector(0)
            cont = +1
        End While
        lector.Close()

        For x = 0 To ah
            'primero 
            comando.CommandText = "SELECT idVenta, fecha, subtotal + iva FROM Ventas WHERE idVenta = " & arrLargo2(x)
            lector = comando.ExecuteReader()
            lector.Read()
            DataGridView1.Rows.Add(id, "Venta", "", lector(0), lector(1), lector(2), 0)
            id += 1
            lector.Close()

            'abonosApartados
            comando.CommandText = "SELECT idAbonoC, fecha, importe FROM AbonosCreditos WHERE idVenta = " & arrLargo2(x)
            lector = comando.ExecuteReader()
            While lector.Read()
                DataGridView1.Rows.Add(id, "", "Abono Venta", lector(0), lector(1), 0, lector(2))
                id += 1
            End While
            lector.Close()
        Next



        For x = 0 To DataGridView1.RowCount - 1
            Dim id2 As Integer = DataGridView1.Item(0, x).Value
            Dim tipo As String = DataGridView1.Item(1, x).Value
            Dim tipo2 As String = DataGridView1.Item(2, x).Value
            Dim idTipo As Integer = DataGridView1.Item(3, x).Value
            Dim fecha As Date = DataGridView1.Item(4, x).Value
            Dim cargo As Double = DataGridView1.Item(5, x).Value
            Dim abono As Double = DataGridView1.Item(6, x).Value

            comando.CommandText = "INSERT INTO auxEstadoCuenta VALUES (" & id2 & ",'" & tipo & "','" & tipo2 & "'," & idTipo & ", '" & fecha &
                "'," & cargo & "," & abono & ")"
            comando.ExecuteNonQuery()

        Next
        DataGridView1.Rows.Clear()

    End Sub
End Class
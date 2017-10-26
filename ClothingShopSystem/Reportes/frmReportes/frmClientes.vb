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
        Adaptador.SelectCommand.CommandText = "ReporteEstadoCuenta"
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim Data As New DataSet

        Adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))

        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)
        Dim p1 As New ReportParameter("nombre", cbCliente.Text)

        Reporte.Reportito.LocalReport.DataSources.Clear()
        Reporte.Reportito.LocalReport.DataSources.Add(Datasource)
        Reporte.Reportito.LocalReport.ReportPath = obtenerRutaReportes() & "\ReporteEstadoCuenta.rdlc"
        Reporte.Reportito.LocalReport.SetParameters(New ReportParameter() {p1})

        Reporte.Reportito.RefreshReport()
        Reporte.Show()
    End Sub

    Private Sub btnConsultaD_Click(sender As Object, e As EventArgs) Handles btnConsultaD.Click
        Tabla2()
        Dim Adaptador As New SqlDataAdapter

        Adaptador.SelectCommand = New SqlCommand
        Adaptador.SelectCommand.Connection = conexion
        Adaptador.SelectCommand.CommandText = "ReporteEstadoCuentaDeudor"
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim Data As New DataSet

        Adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))

        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)
        Dim p1 As New ReportParameter("nombre", cbCliente.Text)

        Reporte.Reportito.LocalReport.DataSources.Clear()
        Reporte.Reportito.LocalReport.DataSources.Add(Datasource)
        Reporte.Reportito.LocalReport.ReportPath = obtenerRutaReportes() & "\ReporteEstadoCuentaDeudor.rdlc"
        Reporte.Reportito.LocalReport.SetParameters(New ReportParameter() {p1})

        Reporte.Reportito.RefreshReport()
        Reporte.Show()
    End Sub

    Private Sub Tabla1()
        'apartados
        comando.CommandText = "SELECT Apartados.idApartado, Apartados.fecha, Apartados.total FROM Clientes join Apartados on Apartados.idCliente = Clientes.idCliente WHERE clientes.idCliente = " & txtIdCliente.Text
        lector = comando.ExecuteReader()

        While lector.Read()
            DataGridView1.Rows.Add("Apartados", lector(0), lector(1), lector(2), 0)
        End While
        lector.Close()

        'AbonosApartados
        comando.CommandText = "SELECT AbonosCreditos.idAbonoC, AbonosCreditos.fecha, AbonosCreditos.importe FROM AbonosCreditos join Ventas on Ventas.idVenta = AbonosCreditos.idVenta WHERE Ventas.idCliente = " & txtIdCliente.Text
        lector = comando.ExecuteReader()

        While lector.Read()
            DataGridView1.Rows.Add("Apartados Abonos", lector(0), lector(1), 0, lector(2))
        End While
        lector.Close()

        'ventas
        comando.CommandText = "SELECT Ventas.idVenta, ventas.fecha, Ventas.subtotal + Ventas.iva FROM Ventas WHERE Ventas.idCliente = " & txtIdCliente.Text

        lector = comando.ExecuteReader()

        While lector.Read()
            DataGridView1.Rows.Add("Ventas", lector(0), lector(1), lector(2), 0)
        End While

        lector.Close()

        'abonosVENTAS
        comando.CommandText = "SELECT AbonosCreditos.idAbonoC, AbonosCreditos.fecha, AbonosCreditos.importe FROM AbonosCreditos join Ventas on Ventas.idVenta = AbonosCreditos.idVenta WHERE Ventas.idCliente = " & txtIdCliente.Text
        lector = comando.ExecuteReader()

        While lector.Read()
            DataGridView1.Rows.Add("Ventas Abonos", lector(0), lector(1), 0, lector(2))
        End While
        lector.Close()

        For x = 0 To DataGridView1.RowCount - 1
            Dim tipo As String = DataGridView1.Item(0, x).Value
            Dim idTipo As Integer = DataGridView1.Item(1, x).Value
            Dim fechaTipo As Date = DataGridView1.Item(2, x).Value
            Dim cargo As Double = DataGridView1.Item(3, x).Value
            Dim abono As Double = DataGridView1.Item(4, x).Value

            comando.CommandText = "INSERT INTO auxEstadoCuenta VALUES ('" & tipo & "', " & idTipo &
                ",'" & fechaTipo & "'," & cargo & "," & abono & ")"
            comando.ExecuteNonQuery()
        Next

        DataGridView1.Rows.Clear()
    End Sub

    Private Sub Tabla2()
        'apartados
        comando.CommandText = "SELECT Apartados.idApartado, Apartados.fecha, Apartados.total FROM Clientes join Apartados on Apartados.idCliente = Clientes.idCliente WHERE Apartados.abono <> Apartados.total and clientes.idCliente = " & txtIdCliente.Text
        lector = comando.ExecuteReader()

        While lector.Read()
            DataGridView1.Rows.Add("Apartados", lector(0), lector(1), lector(2), 0)
        End While
        lector.Close()

        'abonosApartados
        comando.CommandText = "SELECT AbonosApartados.idAbonoA, AbonosApartados.fecha, AbonosApartados.pago FROM Clientes join Apartados on Apartados.idCliente = Clientes.idCliente join AbonosApartados on Apartados.idApartado = AbonosApartados.idApartado WHERE clientes.idCliente = " & txtIdCliente.Text & " and Apartados.total <> Apartados.abono"
        lector = comando.ExecuteReader()

        While lector.Read()
            DataGridView1.Rows.Add("Apartados Abonos", lector(0), lector(1), 0, lector(2))
        End While
        lector.Close()

        'ventas
        comando.CommandText = "SELECT idVenta, fecha, (subtotal + iva) - descuento as TotalVenta FROM Ventas WHERE estado <> 1 and abonado <> (subtotal + iva) - descuento  and idCliente = " & txtIdCliente.Text

        lector = comando.ExecuteReader()

        While lector.Read()
            DataGridView1.Rows.Add("Ventas", lector(0), lector(1), lector(2), 0)
        End While
        lector.Close()

        'ventas
        comando.CommandText = "SELECT AbonosCreditos.idAbonoC, AbonosCreditos.fecha, AbonosCreditos.importe FROM AbonosCreditos join Ventas on Ventas.idVenta = AbonosCreditos.idVenta join Clientes on Clientes.idCliente = Ventas.idCliente WHERE Ventas.estado <> 1 and Ventas.abonado <> (ventas.subtotal + ventas.iva) - ventas.descuento  and ventas.idCliente = " & txtIdCliente.Text

        lector = comando.ExecuteReader()

        While lector.Read()
            DataGridView1.Rows.Add("Ventas Abono", lector(0), lector(1), 0, lector(2))
        End While
        lector.Close()

        For x = 0 To DataGridView1.RowCount - 1
            Dim tipo As String = DataGridView1.Item(0, x).Value
            Dim idTipo As Integer = DataGridView1.Item(1, x).Value
            Dim fecha As Date = DataGridView1.Item(2, x).Value
            Dim cargo As Double = DataGridView1.Item(3, x).Value
            Dim abono As Double = DataGridView1.Item(4, x).Value

            comando.CommandText = "INSERT INTO auxEstadoCuenta VALUES ('" & tipo & "'," & idTipo & ", '" & fecha &
                "'," & cargo & "," & abono & ")"
            comando.ExecuteNonQuery()

        Next
        DataGridView1.Rows.Clear()

    End Sub
End Class
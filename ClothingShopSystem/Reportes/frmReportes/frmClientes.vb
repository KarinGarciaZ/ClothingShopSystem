Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmClientes
    Dim conexion = openConnection()
    Dim comando As SqlCommand = conexion.CreateCommand()
    Dim lector As SqlDataReader

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Close()
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
        Close()
    End Sub

    Private Sub Tabla1()
        'apartados
        comando.CommandText = "SELECT Apartados.idApartado, Apartados.fecha, AbonosApartados.idAbonoA, AbonosApartados.fecha, AbonosApartados.pago, Apartados.total FROM Clientes inner join Apartados on Apartados.idCliente = Clientes.idCliente inner join AbonosApartados on AbonosApartados.idApartado = Apartados.idApartado WHERE '" & Now.Date & "' <=  Apartados.fechaVencimiento and clientes.idCliente = " & txtIdCliente.Text
        lector = comando.ExecuteReader()

        While lector.Read()
            DataGridView1.Rows.Add("Apartados", "", lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
        End While
        lector.Close()

        'ventas
        comando.CommandText = "SELECT Ventas.idVenta, ventas.condicion, ventas.fecha, AbonosCreditos.idAbonoC, AbonosCreditos.fecha, 
                                      AbonosCreditos.importe, (Ventas.subtotal + Ventas.iva) - Ventas.descuento as TotalVenta FROM Clientes inner join Ventas on Clientes.idcliente = Ventas.idCliente inner join AbonosCreditos on AbonosCreditos.idVenta = Ventas.idVenta WHERE GETDATE() <=  Ventas.fechaVencimiento and Ventas.estado <> 1  and clientes.idCliente = " & txtIdCliente.Text

        lector = comando.ExecuteReader()

        While lector.Read()
            DataGridView1.Rows.Add("Ventas", lector(1), lector(0), lector(2), lector(3), lector(4), lector(5), lector(6))
        End While
        lector.Close()

        For x = 0 To DataGridView1.RowCount - 1
            Dim tipo As String = DataGridView1.Item(0, x).Value
            Dim condicion As String = DataGridView1.Item(1, x).Value
            Dim idtipo As Integer = DataGridView1.Item(2, x).Value
            Dim FechaTipo As Date = DataGridView1.Item(3, x).Value
            Dim idAbono As Integer = DataGridView1.Item(4, x).Value
            Dim FechaAbono As Date = DataGridView1.Item(5, x).Value
            Dim importe As Double = DataGridView1.Item(6, x).Value
            Dim totalTipo As Double = DataGridView1.Item(7, x).Value


            comando.CommandText = "INSERT INTO auxEstadoCuenta VALUES ('" & tipo & "','" & condicion & "', " & idtipo &
                ",'" & FechaTipo & "'," & idAbono & ",'" & FechaAbono & "'," & importe & "," & totalTipo & ")"
            comando.ExecuteNonQuery()
        Next

        DataGridView1.Rows.Clear()
    End Sub

    Private Sub Tabla2()
        comando.CommandText = "	SELECT Apartados.idApartado, Apartados.fechaVencimiento, AbonosApartados.idAbonoA, 
                                AbonosApartados.fecha, AbonosApartados.pago, Apartados.total
	                            FROM Clientes join Apartados on Apartados.idCliente = Clientes.idCliente join AbonosApartados on AbonosApartados.idApartado = Apartados.idApartado WHERE GETDATE() >=  Apartados.fechaVencimiento and clientes.idCliente = " & txtIdCliente.Text
        lector = comando.ExecuteReader()

        While lector.Read()
            DataGridView1.Rows.Add("Apartados", "", lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
        End While
        lector.Close()

        'ventas
        comando.CommandText = "SELECT Ventas.idVenta, Ventas.condicion, ventas.fechaVencimiento,  AbonosCreditos.idAbonoC, AbonosCreditos.fecha, AbonosCreditos.importe, Ventas.abonado, (Ventas.subtotal + Ventas.iva) - Ventas.descuento as TotalVenta
	                            FROM Clientes join Ventas on Clientes.idcliente = Ventas.idCliente join AbonosCreditos on AbonosCreditos.idVenta = Ventas.idVenta WHERE GETDATE() >=   Ventas.fechaVencimiento and Ventas.estado <> 1  and clientes.idCliente = " & txtIdCliente.Text

        lector = comando.ExecuteReader()

        While lector.Read()
            DataGridView1.Rows.Add("Ventas", lector(1), lector(0), lector(2), lector(3), lector(4), lector(5), lector(6))
        End While
        lector.Close()

        For x = 0 To DataGridView1.RowCount - 1
            Dim tipo As String = DataGridView1.Item(0, x).Value
            Dim condicion As String = DataGridView1.Item(1, x).Value
            Dim idtipo As Integer = DataGridView1.Item(2, x).Value
            Dim FechaTipo As Date = DataGridView1.Item(3, x).Value
            Dim idAbono As Integer = DataGridView1.Item(4, x).Value
            Dim FechaAbono As Date = DataGridView1.Item(5, x).Value
            Dim importe As Double = DataGridView1.Item(6, x).Value
            Dim totalTipo As Double = DataGridView1.Item(7, x).Value


            comando.CommandText = "INSERT INTO auxEstadoCuenta VALUES ('" & tipo & "','" & condicion & "', " & idtipo &
                ",'" & FechaTipo & "'," & idAbono & ",'" & FechaAbono & "'," & importe & "," & totalTipo & ")"
            comando.ExecuteNonQuery()

        Next
        DataGridView1.Rows.Clear()

    End Sub
End Class
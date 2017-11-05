Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Public Class Form1
    Dim Conexion As SqlConnection

    Dim conexionBitacora = OpenBitacora()
    Dim BitacoraComando As SqlCommand = conexionBitacora.CreateCommand()
    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Productos.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Proveedores.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Clientes.ShowDialog()
    End Sub

    Private Sub MarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcasToolStripMenuItem.Click
        Marcas.ShowDialog()
    End Sub

    Private Sub TiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposToolStripMenuItem.Click
        Tipos.ShowDialog()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        Categorias.ShowDialog()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Usuarios.ShowDialog()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        Compras.ShowDialog()
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        consultaCompras.ShowDialog()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Ventas.ShowDialog()
    End Sub

    Private Sub ConsultaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem1.Click
        ConsultaVenta.ShowDialog()
    End Sub

    Private Sub ApartadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApartadosToolStripMenuItem.Click
        frmApartados.ShowDialog()
    End Sub

    Private Sub ConsultaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem2.Click
        ConsultaApartados.ShowDialog()
    End Sub

    Private Sub AbonoCreditoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbonoCreditoToolStripMenuItem.Click
        AbonoCredito.ShowDialog()
    End Sub

    Private Sub ConsultaToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem3.Click
        ConsultaAbonoCredito.ShowDialog()
    End Sub

    Private Sub AbonoApartadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbonoApartadoToolStripMenuItem.Click
        frmAbonosApartados.ShowDialog()
    End Sub

    Private Sub ConsultaToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem4.Click
        ConsultaAbonosA.ShowDialog()
    End Sub

    Private Sub DevolucionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolucionesToolStripMenuItem.Click
        Devoluciones.ShowDialog()
    End Sub

    Private Sub ConsultaToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem5.Click
        ConsultaDevoluciones.ShowDialog()
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
        ConsultaProductos.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        ConsultaClientes.ShowDialog()
    End Sub

    Private Sub ApartadosPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApartadosPorClienteToolStripMenuItem.Click
        conexionBitacora.Open()

        Try
            Conexion = openConnection()

            Conexion.Open()

            Dim Cmd As New SqlCommand("ReporteClientesApartados", Conexion)

            Cmd.CommandType = CommandType.StoredProcedure

            Dim Adaptador As New SqlDataAdapter(Cmd)
            Dim Data As New Data.DataSet

            Adaptador.Fill(Data)
            Data.DataSetName = "DataSet1"

            Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))

            Reporte.Reportito.LocalReport.DataSources.Clear()
            Reporte.Reportito.LocalReport.DataSources.Add(Reportes)
            Reporte.Reportito.LocalReport.ReportPath = obtenerRutaReportes() & "\ReporteClientesApartados.rdlc"
            Reporte.Reportito.RefreshReport()
            Reporte.Text = "Reporte de Devoluciones"
            Reporte.Show()
            Conexion.Close()
        Catch ex As Exception
            MsgBox("Error reporte")
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(18, '" & ex.Message & "', 'Prncipal.ApartadosPorCliente','" & Now.Date & "'," & Err.Number & ")"
            BitacoraComando.ExecuteNonQuery()

            conexionBitacora = cerrarBitacora()
        End Try
    End Sub

    Private Sub ProductosVendidosPorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosVendidosPorPeriodoToolStripMenuItem.Click
        ProductosVendidosPorPeriodo.ShowDialog()
    End Sub

    Private Sub ProductosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem2.Click
        conexionBitacora.open()
        Try
            Conexion = openConnection()

            Conexion.Open()

            Dim Cmd As New SqlCommand("ReporteClasificacionDeProductos", Conexion)

            Cmd.CommandType = CommandType.StoredProcedure

            Dim Adaptador As New SqlDataAdapter(Cmd)
            Dim Data As New Data.DataSet

            Adaptador.Fill(Data)
            Data.DataSetName = "DataSet1"

            Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))

            Reporte.Reportito.LocalReport.DataSources.Clear()
            Reporte.Reportito.LocalReport.DataSources.Add(Reportes)
            Reporte.Reportito.LocalReport.ReportPath = obtenerRutaReportes() & "\ReporteProductos.rdlc"
            Reporte.Reportito.RefreshReport()
            Reporte.Show()
            Conexion.Close()
        Catch ex As Exception
            MsgBox("Error reporte")
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(18, '" & ex.Message & "', 'Prncipal.ApartadosPorCliente','" & Now.Date & "'," & Err.Number & ")"
            BitacoraComando.ExecuteNonQuery()

            conexionBitacora = cerrarBitacora()
        End Try
    End Sub

    Private Sub ClientesDeudoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesDeudoresToolStripMenuItem.Click
        conexionBitacora.open()
        Try
            Conexion = openConnection()

            Conexion.Open()

            Dim Cmd As New SqlCommand("ReporteClientesDeudores", Conexion)

            Cmd.CommandType = CommandType.StoredProcedure

            Dim Adaptador As New SqlDataAdapter(Cmd)
            Dim Data As New Data.DataSet

            Adaptador.Fill(Data)
            Data.DataSetName = "DataSet1"

            Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))

            Reporte.Reportito.LocalReport.DataSources.Clear()
            Reporte.Reportito.LocalReport.DataSources.Add(Reportes)
            Reporte.Reportito.LocalReport.ReportPath = obtenerRutaReportes() & "\ReporteClientesDeudores.rdlc"
            Reporte.Reportito.RefreshReport()
            Reporte.Show()
            Conexion.Close()
        Catch ex As Exception
            MsgBox("Error reporte")
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(18, '" & ex.Message & "', 'Prncipal.ApartadosPorCliente','" & Now.Date & "'," & Err.Number & ")"
            BitacoraComando.ExecuteNonQuery()

            conexionBitacora = cerrarBitacora()
        End Try
    End Sub

    Private Sub VentasPorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasPorPeriodoToolStripMenuItem.Click
        VentasPorPeriodo.ShowDialog()
    End Sub

    Private Sub ComprasPorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasPorPeriodoToolStripMenuItem.Click
        ComprasPorPeriodo.ShowDialog()
    End Sub

    Private Sub ApartadosNoPagadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApartadosNoPagadosToolStripMenuItem.Click
        conexionBitacora.open()
        Try
            Conexion = openConnection()

            Conexion.Open()

            Dim Cmd As New SqlCommand("ReporteNoApartados", Conexion)

            Cmd.CommandType = CommandType.StoredProcedure

            Dim Adaptador As New SqlDataAdapter(Cmd)
            Dim Data As New Data.DataSet

            Adaptador.Fill(Data)
            Data.DataSetName = "DataSet1"

            Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))

            Reporte.Reportito.LocalReport.DataSources.Clear()
            Reporte.Reportito.LocalReport.DataSources.Add(Reportes)
            Reporte.Reportito.LocalReport.ReportPath = obtenerRutaReportes() & "\ReporteNoApartados.rdlc"
            Reporte.Reportito.RefreshReport()
            Reporte.Show()
            Conexion.Close()
        Catch ex As Exception
            MsgBox("Error reporte")
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(18, '" & ex.Message & "', 'Prncipal.ApartadosPorCliente','" & Now.Date & "'," & Err.Number & ")"
            BitacoraComando.ExecuteNonQuery()

            conexionBitacora = cerrarBitacora()
        End Try
    End Sub

    Private Sub DevolucionesPorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolucionesPorPeriodoToolStripMenuItem.Click
        Fechas.Text = "Reporte de Devoluciones"
        Fechas.ShowDialog()
    End Sub

    Private Sub EstadoDeCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoDeCuentaToolStripMenuItem.Click
        frmClientes.btnConsulta.Visible = True
        frmClientes.btnConsultaD.Visible = False
        frmClientes.ShowDialog()
    End Sub

    Private Sub EstadoDeCuentaDeudorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoDeCuentaDeudorToolStripMenuItem.Click
        frmClientes.btnConsulta.Visible = False
        frmClientes.btnConsultaD.Visible = True
        frmClientes.ShowDialog()
    End Sub

    Private Sub IngresosDiariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosDiariosToolStripMenuItem.Click
        IngresosDiarios.ShowDialog()
    End Sub

    Private Sub RestaurarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaurarToolStripMenuItem.Click
        SqlConnection.ClearAllPools()
        Dim res As DialogResult
        res = OpenFileDialog1.ShowDialog()
        If res = DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName
            Conexion = openConnection()
            Conexion.Open()
            Dim command As New SqlCommand
            command.Connection = Conexion
            command.CommandText = "use master restore database dboClothingShopSystem FROM disk = '" & path & "' WITH REPLACE"
            command.ExecuteNonQuery()
            Conexion.Close()
        End If
    End Sub

    Private Sub RespaldarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RespaldarToolStripMenuItem.Click
        SqlConnection.ClearAllPools()
        Dim res As DialogResult
        SaveFileDialog1.FileName = ".bak"
        res = SaveFileDialog1.ShowDialog()
        If res = DialogResult.OK Then
            Dim path As String = SaveFileDialog1.FileName
            Conexion = openConnection()
            Conexion.Open()
            Dim command As New SqlCommand
            command.Connection = Conexion
            command.CommandText = "backup Database dboClothingShopSystem to disk = '" & path & "' with format "
            command.ExecuteNonQuery()
            Conexion.Close()
        End If
    End Sub

    Private Sub BitacoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BitacoraToolStripMenuItem.Click

    End Sub
End Class

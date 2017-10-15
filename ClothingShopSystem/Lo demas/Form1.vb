Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Public Class Form1
    Dim Conexion As SqlConnection
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
        Conexion = openConnection()

        Conexion.Open()

        Dim Cmd As New SqlCommand("ReporteClientesApartados", Conexion)

        Cmd.CommandType = CommandType.StoredProcedure

        Dim Adaptador As New SqlDataAdapter(Cmd)
        Dim Data As New Data.DataSet

        Adaptador.Fill(Data)
        Data.DataSetName = "DataSetSistema"

        Dim Reportes As New ReportDataSource("DataSetSistema", Data.Tables(0))

        Reporte.Reportito.LocalReport.DataSources.Clear()
        Reporte.Reportito.LocalReport.DataSources.Add(Reportes)
        Reporte.Reportito.LocalReport.ReportPath = obtenerRutaReportes() & "\ReporteClientesApartados.rdlc"
        Reporte.Reportito.RefreshReport()
        Reporte.Show()
        Conexion.Close()
    End Sub

    Private Sub ProductosVendidosPorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosVendidosPorPeriodoToolStripMenuItem.Click
        ProductosVendidosPorPeriodo.ShowDialog()
    End Sub

    Private Sub ProductosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem2.Click
        Conexion = openConnection()

        Conexion.Open()

        Dim Cmd As New SqlCommand("ReporteClasificacionProductos", Conexion)

        Cmd.CommandType = CommandType.StoredProcedure

        Dim Adaptador As New SqlDataAdapter(Cmd)
        Dim Data As New Data.DataSet

        Adaptador.Fill(Data)
        Data.DataSetName = "DataSetSistema"

        Dim Reportes As New ReportDataSource("DataSetSistema", Data.Tables(0))

        Reporte.Reportito.LocalReport.DataSources.Clear()
        Reporte.Reportito.LocalReport.DataSources.Add(Reportes)
        Reporte.Reportito.LocalReport.ReportPath = obtenerRutaReportes() & "\ReporteClaProductos.rdlc"
        Reporte.Reportito.RefreshReport()
        Reporte.Show()
        Conexion.Close()
    End Sub
End Class

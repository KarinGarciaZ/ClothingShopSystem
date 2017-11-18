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
            conexionBitacora.Open()

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
            conexionBitacora.open()

            MsgBox("Error reporte")
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(18, '" & ex.Message & "', 'Prncipal.ApartadosPorCliente','" & Now.Date & "'," & Err.Number & ")"
            BitacoraComando.ExecuteNonQuery()

            conexionBitacora = cerrarBitacora()
        End Try
    End Sub

    Private Sub ClientesDeudoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesDeudoresToolStripMenuItem.Click
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
            conexionBitacora.open()

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
            conexionBitacora.open()

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
        Try
            Dim res As DialogResult
            res = OpenFileDialog1.ShowDialog()
            If res = DialogResult.OK Then
                Dim path As String = OpenFileDialog1.FileName
                Conexion = OpenMaster()
                Conexion.Open()
                Dim command As New SqlCommand
                command.Connection = Conexion
                command.CommandText = "ALTER DATABASE dboClothingShopSystem SET SINGLE_USER WITH ROLLBACK IMMEDIATE"
                command.ExecuteNonQuery()
                command.CommandText = "ALTER DATABASE dboClothingShopSystem SET MULTI_USER"
                command.ExecuteNonQuery()
                command.CommandText = "restore database dboClothingShopSystem FROM disk = '" & path & "' WITH REPLACE"
                command.ExecuteNonQuery()
                MsgBox("La restauración se hizo exitosamente.")
                Conexion.Close()
            End If
        Catch ex As Exception
            conexionBitacora.open()

            MsgBox("Error al restaurar")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(27, '" & errMessage & "', 'Form1.Restaurar','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()

            conexionBitacora = cerrarBitacora()
        End Try

    End Sub

    Private Sub RespaldarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RespaldarToolStripMenuItem.Click
        Try
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
                MsgBox("El respaldo se hizo exitosamente.")
                Conexion.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al respaldar")
            Dim errMessage As String = quitarComillas(ex.Message)
            conexionBitacora.open
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(27, '" & errMessage & "', 'Form1.Respaldar','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
            conexionBitacora = cerrarBitacora()
        End Try

    End Sub

    Private Sub BitacoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BitacoraToolStripMenuItem.Click
        Bitacora.ShowDialog()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        System.Diagnostics.Process.Start("C:\Users\elektramovil\Documents\GitHub\ClothingShopSystem\Ayuda.chm")
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            System.Diagnostics.Process.Start("C:\Users\elektramovil\Documents\GitHub\ClothingShopSystem\Ayuda.chm")
        End If
    End Sub

    Private Sub TraspasoHistoricoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraspasoHistoricoToolStripMenuItem.Click
        Dim conexionH = OpenHistorico()
        Dim commandH As SqlCommand = conexionH.CreateCommand()
        Dim conexion = openConnection()
        Dim command As SqlCommand = conexion.CreateCommand()
        Dim lector As SqlDataReader
        conexion.open()
        conexionH.open()

        'TRASPASO HISTORICO DE MOVIMIENTOS Y DETALLES
        'Pasa compras
        command.CommandText = "select * from Compras"
        lector = command.ExecuteReader()
        While lector.Read()
            commandH.CommandText = "insert into Compras values(" & lector(0) & "," & lector(1) & ", '" & lector(2) & "','" & lector(3) & "'," & lector(4) & ")"
            commandH.ExecuteNonQuery()
        End While
        lector.Close()

        'Pasa Devoluciones
        command.CommandText = "select * from Devoluciones"
        lector = command.ExecuteReader()
        While lector.Read()
            commandH.CommandText = "insert into Devoluciones values(" & lector(0) & "," & lector(1) & ", '" & lector(2) & "','" & lector(3) & "')"
            commandH.ExecuteNonQuery()
        End While
        lector.Close()

        'Pasa Abonos Credito
        command.CommandText = "select * from AbonosCreditos"
        lector = command.ExecuteReader()
        While lector.Read()
            commandH.CommandText = "insert into AbonosCreditos values(" & lector(0) & "," & lector(1) & ", '" & lector(2) & "'," & lector(3) & ")"
            commandH.ExecuteNonQuery()
        End While
        lector.Close()

        'Pasa Abonos Apartados
        command.CommandText = "select * from AbonosApartados"
        lector = command.ExecuteReader()
        While lector.Read()
            commandH.CommandText = "insert into AbonosApartados values(" & lector(0) & "," & lector(1) & ", '" & lector(2) & "'," & lector(3) & ")"
            commandH.ExecuteNonQuery()
        End While
        lector.Close()

        'Pasa ventas
        command.CommandText = "select count(*) from Ventas where condicion = 'Efectivo'"
        Dim len = command.ExecuteScalar
        command.CommandText = "select count(*) from Ventas where condicion = 'Credito' and abonado >= subtotal + iva"
        Dim len2 = command.ExecuteScalar
        Dim y As Integer = 0
        Dim idVentas(len + len2) As Integer
        Dim lec As Integer = 0
        command.CommandText = "select * from Ventas where condicion = 'Efectivo'"
        lector = command.ExecuteReader()
        While lector.Read()
            If Not lector(9) Then
                lec = 0
            Else
                lec = 1
            End If
            idVentas(y) = lector(0)
            y += 1
            commandH.CommandText = "insert into Ventas values(" & lector(0) & "," & lector(1) & ", '" & lector(2) & "','" & lector(3) & "','" & lector(4) & "'," & lector(5) & "," & lector(6) & "," & lector(7) & "," & lector(8) & "," & lec & ")"
            commandH.ExecuteNonQuery()
        End While
        lector.Close()
        command.CommandText = "select * from Ventas where condicion = 'Credito' and abonado >= subtotal + iva"
        lector = command.ExecuteReader()
        While lector.Read()
            If Not lector(9) Then
                lec = 0
            Else
                lec = 1
            End If
            idVentas(y) = lector(0)
            y += 1
            commandH.CommandText = "insert into Ventas values(" & lector(0) & "," & lector(1) & ", '" & lector(2) & "','" & lector(3) & "','" & lector(4) & "'," & lector(5) & "," & lector(6) & "," & lector(7) & "," & lector(8) & "," & lec & ")"
            commandH.ExecuteNonQuery()
        End While
        lector.Close()

        'Pasa detalle ventas
        command.CommandText = "select DetalleVentas.idVenta, DetalleVentas.idProducto, DetalleVentas.cantidad, DetalleVentas.precio from DetalleVentas inner join Ventas on Ventas.idVenta = DetalleVentas.idVenta  where Ventas.condicion  = 'Efectivo'"
        lector = command.ExecuteReader()
        While lector.Read()
            commandH.CommandText = "insert into DetalleVentas values(" & lector(0) & "," & lector(1) & ", " & lector(2) & "," & lector(3) & ")"
            commandH.ExecuteNonQuery()
        End While
        lector.Close()
        command.CommandText = "select DetalleVentas.idVenta, DetalleVentas.idProducto, DetalleVentas.cantidad, DetalleVentas.precio from DetalleVentas inner join Ventas on Ventas.idVenta = DetalleVentas.idVenta  where Ventas.condicion  = 'Credito' and Ventas.abonado >= Ventas.subtotal + Ventas.iva"
        lector = command.ExecuteReader()
        While lector.Read()
            commandH.CommandText = "insert into DetalleVentas values(" & lector(0) & "," & lector(1) & ", " & lector(2) & "," & lector(3) & ")"
            commandH.ExecuteNonQuery()
        End While
        lector.Close()

        'Pasa Apartados
        command.CommandText = "select count(*) from Apartados where abono >= total"
        Dim l = command.ExecuteScalar
        Dim x As Integer = 0
        Dim idApartados(l) As Integer
        command.CommandText = "select * from Apartados where abono >= total"
        lector = command.ExecuteReader()
        While lector.Read()
            idApartados(x) = lector(1)
            x += 1
            commandH.CommandText = "insert into Apartados values(" & lector(0) & "," & lector(1) & ", " & lector(2) & "," & lector(3) & ",'" & lector(4) & "','" & lector(5) & "')"
            commandH.ExecuteNonQuery()
        End While
        lector.Close()

        'Pasa Detalle Apartados
        command.CommandText = "select DetalleApartados.idApartado, DetalleApartados.idProducto, DetalleApartados.cantidad, DetalleApartados.precio from DetalleApartados inner join Apartados on Apartados.idApartado = DetalleApartados.idApartado  where abono >= total"
        lector = command.ExecuteReader()
        While lector.Read()
            commandH.CommandText = "insert into DetalleApartados values(" & lector(0) & "," & lector(1) & ", " & lector(2) & "," & lector(3) & ")"
            commandH.ExecuteNonQuery()
        End While
        lector.Close()

        'Pasa Detalle Compras
        command.CommandText = "select * from DetalleCompras"
        lector = command.ExecuteReader()
        While lector.Read()
            commandH.CommandText = "insert into DetalleCompras values(" & lector(0) & "," & lector(1) & ", " & lector(2) & "," & lector(3) & ")"
            commandH.ExecuteNonQuery()
        End While
        lector.Close()

        'Borrar datos de tablas
        command.CommandText = "delete from Ventas where condicion = 'Efectivo'"
        command.ExecuteNonQuery()
        command.CommandText = "delete from Ventas where condicion = 'Credito' and abonado >= subtotal + iva"
        command.ExecuteNonQuery()
        command.CommandText = "delete from Apartados where abono >= total"
        command.ExecuteNonQuery()
        command.CommandText = "delete from AbonosApartados"
        command.ExecuteNonQuery()
        command.CommandText = "delete from AbonosCreditos"
        command.ExecuteNonQuery()
        command.CommandText = "delete from Compras"
        command.ExecuteNonQuery()
        command.CommandText = "delete from Devoluciones"
        command.ExecuteNonQuery()
        command.CommandText = "delete from DetalleCompras"
        command.ExecuteNonQuery()
        For w = 0 To idApartados.Length - 1
            command.CommandText = "delete from DetalleApartados where idApartado = " & idApartados(w)
            command.ExecuteNonQuery()
        Next
        For w = 0 To idVentas.Length - 1
            command.CommandText = "delete from DetalleVentas where idVenta = " & idVentas(w)
            command.ExecuteNonQuery()
        Next




    End Sub
End Class

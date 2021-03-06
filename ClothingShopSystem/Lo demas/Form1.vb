﻿Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Imports System
Imports System.IO
Imports System.Collections
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
        System.Diagnostics.Process.Start("C:\Users\NETXBAX\Proyects\visualBasic\ClothingShopSystem\Ayuda.chm")
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            System.Diagnostics.Process.Start("C:\Users\oscar\Documents\GitHub\ClothingShopSystem\Ayuda.chm")
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

        'TRASPASO HISTORICO CATALOGOS
        'Pasa categorias
        commandH.CommandText = "DELETE Categorias"
        commandH.ExecuteNonQuery()

        command.CommandText = "SELECT * FROM Categorias"
        lector = command.ExecuteReader()
        While lector.Read
            commandH.CommandText = "INSERT INTO Categorias VALUES(" & lector(0) & ", '" & lector(0) & "')"
            commandH.ExecuteNonQuery()
        End While
        lector.Close()


        'Pasa clientes
        commandH.CommandText = "TRUNCATE TABLE Clientes"
        commandH.ExecuteNonQuery()
        command.CommandText = "SELECT * FROM Clientes"
        lector = command.ExecuteReader()
        While lector.Read
            commandH.CommandText = "INSERT INTO Clientes VALUES(@idCliente, @nombre, @domicilio, @colonia, @ciudad, @CP, @telefono, @saldo, @limiteCredito)"
            commandH.Parameters.AddWithValue("@idCliente", lector(0))
            commandH.Parameters.AddWithValue("@nombre", lector(1))
            commandH.Parameters.AddWithValue("@domicilio", lector(2))
            commandH.Parameters.AddWithValue("@colonia", lector(3))
            commandH.Parameters.AddWithValue("@ciudad", lector(4))
            commandH.Parameters.AddWithValue("@CP", lector(5))
            commandH.Parameters.AddWithValue("@telefono", lector(6))
            commandH.Parameters.AddWithValue("@saldo", lector(7))
            commandH.Parameters.AddWithValue("@limiteCredito", lector(8))

            commandH.ExecuteNonQuery()
            commandH.Parameters.Clear()
        End While
        lector.Close()

        'Pasa Marcas
        commandH.CommandText = "TRUNCATE TABLE Marcas"
        commandH.ExecuteNonQuery()
        command.CommandText = "SELECT * FROM Marcas"
        lector = command.ExecuteReader()
        While lector.Read
            commandH.CommandText = "INSERT INTO Marcas VALUES(@idMarca, @nombre)"
            commandH.Parameters.AddWithValue("@idMarca", lector(0))
            commandH.Parameters.AddWithValue("@nombre", lector(1))

            commandH.ExecuteNonQuery()
            commandH.Parameters.Clear()

        End While
        lector.Close()

        'Pasa Productos
        commandH.CommandText = "TRUNCATE TABLE Productos"
        commandH.ExecuteNonQuery()
        command.CommandText = "SELECT * FROM Productos"
        lector = command.ExecuteReader()
        While lector.Read
            commandH.CommandText = "INSERT INTO Productos VALUES(@idProducto, @idTipo, @idCategoria, @idMarca, @codigoBarras, @nombre, @costo, @precio1, @precio2, @precio3, @existencias, @apartados, @ultimaFechaCompra)"
            commandH.Parameters.AddWithValue("@idProducto", lector(0))
            commandH.Parameters.AddWithValue("@idTipo", lector(1))
            commandH.Parameters.AddWithValue("@idCategoria", lector(2))
            commandH.Parameters.AddWithValue("@idMarca", lector(3))
            commandH.Parameters.AddWithValue("@codigoBarras", lector(4))
            commandH.Parameters.AddWithValue("@nombre", lector(5))
            commandH.Parameters.AddWithValue("@costo", lector(6))
            commandH.Parameters.AddWithValue("@precio1", lector(7))
            commandH.Parameters.AddWithValue("@precio2", lector(8))
            commandH.Parameters.AddWithValue("@precio3", lector(9))
            commandH.Parameters.AddWithValue("@existencias", lector(10))
            commandH.Parameters.AddWithValue("@apartados", lector(11))
            commandH.Parameters.AddWithValue("@ultimaFechaCompra", lector(12))

            commandH.ExecuteNonQuery()
            commandH.Parameters.Clear()

        End While
        lector.Close()

        'Pasa Proveedores
        commandH.CommandText = "TRUNCATE TABLE Proveedores"
        commandH.ExecuteNonQuery()
        command.CommandText = "SELECT * FROM Proveedores"
        lector = command.ExecuteReader()
        While lector.Read
            commandH.CommandText = "INSERT INTO Proveedores VALUES(@idProveedor, @nombre, @telefono, @domicilio, @ciudad, @email)"
            commandH.Parameters.AddWithValue("@idProveedor", lector(0))
            commandH.Parameters.AddWithValue("@nombre", lector(1))
            commandH.Parameters.AddWithValue("@telefono", lector(2))
            commandH.Parameters.AddWithValue("@domicilio", lector(3))
            commandH.Parameters.AddWithValue("@ciudad", lector(4))
            commandH.Parameters.AddWithValue("@email", lector(5))

            commandH.ExecuteNonQuery()
            commandH.Parameters.Clear()

        End While
        lector.Close()


        'Pasa Tipos
        commandH.CommandText = "TRUNCATE TABLE Tipos"
        commandH.ExecuteNonQuery()
        command.CommandText = "SELECT * FROM Tipos"
        lector = command.ExecuteReader()
        While lector.Read
            commandH.CommandText = "INSERT INTO Tipos VALUES(@idTipo, @nombre)"
            commandH.Parameters.AddWithValue("@idTipo", lector(0))
            commandH.Parameters.AddWithValue("@nombre", lector(1))
            commandH.ExecuteNonQuery()
            commandH.Parameters.Clear()

        End While
        lector.Close()


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

        MsgBox("Finalizado!")


    End Sub

    Private Sub RestaurarDesdeArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaurarDesdeArchivoToolStripMenuItem.Click
        Dim conexion = openConnection()
        Dim command As SqlCommand = conexion.CreateCommand()
        Dim lector As SqlDataReader
        conexion.open()
        Dim linia As String
        Dim arrText As New ArrayList
        Dim campo() As String
        Try
            Dim res As DialogResult
            res = OpenFileDialog1.ShowDialog()
            If res = DialogResult.OK Then
                Dim path As String = OpenFileDialog1.FileName
                MsgBox(path)
                Dim objReader As New StreamReader(path)
                Do
                    linia = objReader.ReadLine
                    If Not linia Is Nothing Then
                        arrText.Add(linia)
                    End If
                Loop Until linia Is Nothing
                objReader.Close()
                Dim ban As Boolean = False
                For Each linia In arrText

                    campo = linia.Split(",")
                    If ban Then
                        command.CommandText = "insert into Productos values(" & Val(campo(0)) & "," & Val(campo(1)) & ", " & Val(campo(2)) & "," & Val(campo(3)) & ",'" & campo(4) & "', '" & campo(5) & "','" & campo(6) & campo(7) & "', '" & campo(8) & "','" & campo(8) & "','" & campo(9) & "', '" & campo(10) & "','" & campo(11) & "','" & campo(12) & "')"
                        command.ExecuteNonQuery()
                    End If
                    ban = True
                Next
                MsgBox("Se añadieron Productos")
            End If
        Catch ex As Exception
            conexionBitacora.open()

            MsgBox("Error al abrir el archivo")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(27, '" & errMessage & "', 'Form1.Restaurar','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()

            conexionBitacora = cerrarBitacora()
        End Try
    End Sub
End Class

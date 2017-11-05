Imports System.Data.SqlClient
Public Class ConsultaVenta
    Dim connection = openConnection()
    Dim command As SqlCommand = connection.CreateCommand()
    Dim lector As SqlDataReader

    Dim conexionBitacora = OpenBitacora()
    Dim BitacoraComando As SqlCommand = conexionBitacora.CreateCommand()
    Private Sub rbVenta_CheckedChanged(sender As Object, e As EventArgs) Handles rbVenta.CheckedChanged
        txtBusquedaVenta.Visible = True
        cbBusquedaCliente.Visible = False
        dtpBusquedaFecha.Visible = False
        cbVentas.Visible = False
        lblVentas.Visible = False
    End Sub

    Private Sub rbCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliente.CheckedChanged
        txtBusquedaVenta.Visible = False
        cbBusquedaCliente.Visible = True
        dtpBusquedaFecha.Visible = False
        llenarClientes()
    End Sub

    Private Sub llenarClientes()
        Try
            cbBusquedaCliente.Items.Clear()
            command.CommandText = "SELECT nombre FROM Clientes"
            lector = command.ExecuteReader

            While lector.Read
                cbBusquedaCliente.Items.Add(lector(0))
            End While
            lector.Close()
        Catch ex As Exception
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(2, '" & errMessage & "', 'ConsultaVenta.llenarClientes','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub rbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbFecha.CheckedChanged
        txtBusquedaVenta.Visible = False
        cbBusquedaCliente.Visible = False
        dtpBusquedaFecha.Visible = True
    End Sub

    Private Sub buscarEfectivo(parameter As Integer)
        lblAbonado.Visible = False
        lblDeuda.Visible = False
        dtpFechaVen.Visible = False
        lblVen.Visible = False
        lblAbo.Visible = False
        lblDeu.Visible = False
        Dim publico As Integer = 1

        Try
            command.CommandText = "SELECT fecha, subtotal, iva, descuento, idCliente FROM Ventas WHERE idVenta = " & parameter & ""
            lector = command.ExecuteReader
            If lector.Read() Then
                dtpFecha.Value = lector(0)
                lblSubtotal.Text = lector(1)
                lblIVA.Text = lector(2)
                lblDescuento.Text = lector(3)
                publico = lector(4)
                lblTotal.Text = CDbl(lblSubtotal.Text) + CDbl(lblIVA.Text)
                If Not publico = 1 Then
                    gbCliente.Visible = True
                    lblPublico.Visible = False
                    lector.Close()
                    command.CommandText = "SELECT nombre, telefono, domicilio, saldo FROM Clientes WHERE idCliente = " & publico & ""
                    lector = command.ExecuteReader
                    lector.Read()
                    txtIdCliente.Text = publico
                    txtCliente.Text = lector(0)
                    txtTelefono.Text = lector(1)
                    txtDomicilio.Text = lector(2)
                    txtSaldo.Text = lector(3)
                Else
                    gbCliente.Visible = False
                    lblPublico.Visible = True
                End If
            Else
                MsgBox("No existe la venta.")
            End If
            lector.Close()
        Catch ex As Exception
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(23, '" & errMessage & "', 'ConsultaVentas.buscarEfectivo','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub buscarCredito(parameter As Integer)
        gbCliente.Visible = True
        lblPublico.Visible = False
        lblAbonado.Visible = True
        lblDeuda.Visible = True
        dtpFechaVen.Visible = True
        lblVen.Visible = True
        lblAbo.Visible = True
        lblDeu.Visible = True

        Try
            command.CommandText = "SELECT Ventas.fecha, Ventas.fechaVencimiento, Ventas.subtotal, Ventas.iva, Ventas.descuento, Ventas.abonado, Clientes.idCliente, Clientes.nombre, Clientes.telefono, Clientes.domicilio, Clientes.saldo  FROM Ventas inner join Clientes on Clientes.idCliente = Ventas.idCliente WHERE idVenta = " & parameter & ""
            lector = command.ExecuteReader
            lector.Read()
            dtpFecha.Value = lector(0)
            dtpFechaVen.Value = lector(1)
            lblSubtotal.Text = lector(2)
            lblIVA.Text = lector(3)
            lblDescuento.Text = lector(4)
            lblAbonado.Text = lector(5)
            txtIdCliente.Text = lector(6)
            txtCliente.Text = lector(7)
            txtTelefono.Text = lector(8)
            txtDomicilio.Text = lector(9)
            txtSaldo.Text = lector(10)
            lblTotal.Text = CDbl(lblSubtotal.Text) + CDbl(lblIVA.Text)
            lblDeuda.Text = CDbl(lblTotal.Text) - CDbl(lblAbonado.Text)
            lector.Close()
        Catch ex As Exception
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(24, '" & errMessage & "', 'ConsultaVentas.buscarCredito','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub llenarRejilla(parameter As Integer)
        dgAgregar.Rows.Clear()
        Dim importe As Double

        Try
            command.CommandText = "SELECT DetalleVentas.idProducto, DetalleVentas.cantidad, DetalleVentas.precio, Productos.nombre, Productos.codigoBarras FROM DetalleVentas inner join Productos on DetalleVentas.idProducto = Productos.idProducto WHERE idVenta = " & parameter & ""
            lector = command.ExecuteReader
            While lector.Read
                importe = lector(1) * lector(2)
                dgAgregar.Rows.Add(lector(0), lector(3), lector(4), lector(1), lector(2), importe)
            End While
            lector.Close()
        Catch ex As Exception
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(25, '" & errMessage & "', 'ConsultaVentas.llenarRejilla','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub txtBusquedaVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusquedaVenta.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                command.CommandText = "SELECT condicion FROM Ventas WHERE estado = 0 and idVenta = " & txtBusquedaVenta.Text & ""
                lector = command.ExecuteReader
                If lector.Read() Then
                    txtCondicion.Text = lector(0)
                    txtIdVenta.Text = txtBusquedaVenta.Text
                    lector.Close()
                    If txtCondicion.Text.Equals("Efectivo") Then
                        buscarEfectivo(CInt(txtBusquedaVenta.Text))
                    Else
                        buscarCredito(CInt(txtBusquedaVenta.Text))
                    End If
                    llenarRejilla(CInt(txtBusquedaVenta.Text))
                Else
                    MsgBox("No existe esa venta")
                End If
                lector.Close()
            End If
        Catch ex As Exception
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(12, '" & errMessage & "', 'ConsultaVentas.txtBusquedaVenta_KeyPress','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub ConsultaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionBitacora.open
            connection.Open()

        Catch ex As Exception
            MsgBox("Error al iniciar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(9, '" & errMessage & "', 'ConsultaVenta.Load','" & Now.Date & "',172, '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub cbBusquedaCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBusquedaCliente.SelectedIndexChanged
        cbVentas.Items.Clear()

        Try
            command.CommandText = "SELECT Ventas.idVenta from Clientes inner join Ventas on Clientes.idCliente = Ventas.idCliente where nombre = '" & cbBusquedaCliente.Text & "'"
            lector = command.ExecuteReader
            While lector.Read
                cbVentas.Items.Add(lector(0))
            End While
            lector.Close()
        Catch ex As Exception
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(21, '" & errMessage & "', 'ConsultaVentas.cbBusquedaCliente_SelectedIndexChanged','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try

        cbVentas.Visible = True
        lblVentas.Visible = True
    End Sub

    Private Sub cbVentas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVentas.SelectedIndexChanged
        Try
            command.CommandText = "SELECT condicion FROM Ventas WHERE estado = 0 and idVenta = " & cbVentas.Text & ""
            lector = command.ExecuteReader
            If lector.Read() Then
                txtCondicion.Text = lector(0)
                txtIdVenta.Text = cbVentas.Text
                lector.Close()
                If txtCondicion.Text.Equals("Efectivo") Then
                    buscarEfectivo(CInt(cbVentas.Text))
                Else
                    buscarCredito(CInt(cbVentas.Text))
                End If
                llenarRejilla(CInt(cbVentas.Text))
            Else
                MsgBox("No existe esa venta.")
            End If
            lector.Close()
        Catch ex As Exception
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(12, '" & errMessage & "', 'ConsultaVentas.cbVentas_SelectedIndexChanged','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub dtpBusquedaFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpBusquedaFecha.ValueChanged
        cbVentas.Items.Clear()

        Try
            command.CommandText = "SELECT idVenta from Ventas  where fecha = '" & dtpBusquedaFecha.Value.Date & "'"
            lector = command.ExecuteReader
            While lector.Read
                cbVentas.Items.Add(lector(0))
            End While
            lector.Close()
            cbVentas.Visible = True
            lblVentas.Visible = True
        Catch ex As Exception
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(26, '" & errMessage & "', 'ConsultaVentas.dtpBusquedaFecha_ValueChanged','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub ConsultaVenta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            connection = cerrarConexion()
            conexionBitacora = cerrarBitacora()
        Catch ex As Exception
            MsgBox("Error al cerrar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(8, '" & errMessage & "', 'ConsultaVentas.FormClosing','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub
End Class
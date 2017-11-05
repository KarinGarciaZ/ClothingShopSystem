Imports System.Data.SqlClient

Public Class consultaCompras
    Dim connection = openConnection()
    Dim command As SqlCommand = connection.CreateCommand()
    Dim lector As SqlDataReader

    Dim conexionBitacora = OpenBitacora()
    Dim BitacoraComando As SqlCommand = conexionBitacora.CreateCommand()
    Private Sub consultaCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.Open()
            conexionBitacora.open
            command.CommandText = "SELECT * FROM Proveedores"
            lector = command.ExecuteReader()

            While lector.Read
                cbProveedores.Items.Add(lector(1))
            End While

            lector.Close()
        Catch ex As Exception
            MsgBox("Error al iniciar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(9, '" & errMessage & "', 'consultaCompras.Load','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub cbProveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProveedores.SelectedIndexChanged
        cbFecha.Items.Clear()

        Try
            command.CommandText = "SELECT * FROM Proveedores WHERE nombre = '" & cbProveedores.Text & "'"
            lector = command.ExecuteReader
            lector.Read()

            txtIdProveedor.Text = lector(0)
            txtTelefono.Text = lector(2).ToString
            txtDomicilio.Text = lector(3).ToString
            lector.Close()

            GroupBox1.Visible = True
            cbFecha.Visible = True
            cbFecha.Enabled = True

            command.CommandText = "SELECT idCompra FROM Compras WHERE idProveedor = " & txtIdProveedor.Text
            lector = command.ExecuteReader
            While lector.Read()
                cbFecha.Items.Add(lector(0))
            End While
            lector.Close()
        Catch ex As Exception
            MsgBox("Error buscar proveedor")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(10, '" & errMessage & "', 'consultaCompras.cbProveedores_SelectedIndexChanged','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try

        'If cbFecha.Items.Count <> 0 Then
        '    MsgBox("No hay datos almacenados")
        'ElseIf cbIdCompra.Items.Count <> 0 Then
        '    MsgBox("No hay datos almacenados")
        'End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        cbFecha.Items.Clear()
        txtidCompra.Text = ""
        txtFactura.Text = ""
        txtDomicilio.Text = ""
        txtTelefono.Text = ""
        txtIdProveedor.Text = ""
        dgAgregar.Rows.Clear()
        GroupBox1.Visible = False
        lblIVA.Text = "0.0"
        lblSubtotal.Text = "0.0"
        lblTotal.Text = "0.0"
    End Sub

    Private Sub cbFecha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFecha.SelectedIndexChanged
        dgAgregar.Rows.Clear()

        Dim importe As Double
        Dim subtotal As Double = 0

        Try
            command.CommandText = "SELECT * FROM Compras WHERE idCompra = " & cbFecha.Text & ""
            lector = command.ExecuteReader
            lector.Read()

            txtidCompra.Text = lector(2).ToString
            txtFactura.Text = lector(3).ToString
            lector.Close()

            command.CommandText = "SELECT DetalleCompras.idCompra, Productos.nombre, Productos.codigoBarras, DetalleCompras.cantidad, DetalleCompras.percio FROM DetalleCompras inner join Productos On Productos.idProducto = DetalleCompras.idProducto WHERE DetalleCompras.idCompra = " & cbFecha.Text
            lector = command.ExecuteReader

            While lector.Read
                importe = lector(3) * lector(4)
                dgAgregar.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), importe)
                subtotal = subtotal + importe
            End While

            lector.Close()
        Catch ex As Exception
            MsgBox("Error buscar idCompra")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(22, '" & errMessage & "', 'consultaCompras.cbFecha_SelectedIndexChanged','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try

        lblSubtotal.Text = subtotal
        lblIVA.Text = subtotal * 0.16
        lblTotal.Text = CDbl(lblIVA.Text) + CDbl(lblSubtotal.Text)
    End Sub

    Private Sub consultaCompras_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            connection = cerrarConexion()
            conexionBitacora = cerrarBitacora()
        Catch ex As Exception
            MsgBox("Error al cerrar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(8, '" & errMessage & "', 'ConsultaCompras.FormClosing','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try

        cbFecha.Items.Clear()
        txtidCompra.Text = ""
        txtFactura.Text = ""
        txtDomicilio.Text = ""
        txtTelefono.Text = ""
        txtIdProveedor.Text = ""
        dgAgregar.Rows.Clear()
        GroupBox1.Visible = False
        lblIVA.Text = "0.0"
        lblSubtotal.Text = "0.0"
        lblTotal.Text = "0.0"
        cbProveedores.Items.Clear()
    End Sub
End Class
Imports System.Data.SqlClient
Public Class ConsultaApartados
    Dim conexion = openConnection()
    Dim lector As SqlDataReader
    Dim comando As SqlCommand = conexion.CreateCommand()

    Dim conexionBitacora = OpenBitacora()
    Dim BitacoraComando As SqlCommand = conexionBitacora.CreateCommand()
    Private Sub ConsultaApartados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.Open()
            conexionBitacora.open()

            comando.CommandText = "SELECT nombre FROM Clientes"
            lector = comando.ExecuteReader

            While lector.Read
                cbClientes.Items.Add(lector(0))
            End While
            lector.Close()

        Catch ex As Exception
            MsgBox("Error al iniciar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(9, '" & errMessage & "', 'ConsultaApartados.Load','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub cbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClientes.SelectedIndexChanged
        cbFecha.Items.Clear()

        Try
            comando.CommandText = "SELECT * FROM Clientes WHERE nombre = '" & cbClientes.Text & "'"
            lector = comando.ExecuteReader
            lector.Read()

            txtColonia.Text = lector(3).ToString
            txtDomicilio.Text = lector(2).ToString
            txtIdCliente.Text = lector(0).ToString
            txtTelefono.Text = lector(6).ToString
            lector.Close()

            GroupBox1.Visible = True
            cbFecha.Enabled = True

            comando.CommandText = "SELECT idApartado FROM Apartados WHERE idCliente = " & txtIdCliente.Text
            lector = comando.ExecuteReader

            While lector.Read()
                cbFecha.Items.Add(lector(0))
            End While
            lector.Close()
        Catch ex As Exception
            MsgBox("Error seleccionar cliente")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(21, '" & errMessage & "', 'ConsultaApartados.cbClientes_SelectedIndexChanged','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try

    End Sub

    Private Sub ConsultaApartados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            conexion = cerrarConexion()
            conexionBitacora = cerrarBitacora()
        Catch ex As Exception
            MsgBox("Error al cerrar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(8, '" & errMessage & "', 'ConsultaApartados.FormClosing','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try

        dgAgregar.Rows.Clear()
        GroupBox1.Visible = False
        lblTotal.Text = "00.00"

        cbClientes.Items.Clear()
        txtColonia.Text = ""
        txtDomicilio.Text = ""
        txtTelefono.Text = ""
        txtIdCliente.Text = ""

        cbFecha.Items.Clear()
        txtidApartado.Text = ""
        txtAbonos.Text = ""
        txtFechaV.Text = ""
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        dgAgregar.Rows.Clear()
        GroupBox1.Visible = False
        lblTotal.Text = "00.00"

        cbClientes.Text = ""
        txtColonia.Text = ""
        txtDomicilio.Text = ""
        txtTelefono.Text = ""
        txtIdCliente.Text = ""

        cbFecha.Text = ""
        txtidApartado.Text = ""
        txtAbonos.Text = ""
        txtFechaV.Text = ""
    End Sub

    Private Sub cbFecha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFecha.SelectedIndexChanged
        dgAgregar.Rows.Clear()

        Dim importe As Double = 0
        Try
            comando.CommandText = "SELECT * FROM Apartados WHERE  idApartado = " & cbFecha.Text
            lector = comando.ExecuteReader

            lector.Read()
            txtFechaV.Text = lector(5)
            txtidApartado.Text = lector(4)
            lblTotal.Text = lector(2)
            txtAbonos.Text = lector(3)
            lector.Close()

            comando.CommandText = "SELECT DetalleApartados.idProducto, Productos.nombre, Productos.codigoBarras, DetalleApartados.cantidad, DetalleApartados.precio FROM DetalleApartados inner join Productos on Productos.idProducto = DetalleApartados.idProducto WHERE DetalleApartados.idApartado = " & cbFecha.Text
            lector = comando.ExecuteReader

            While lector.Read
                importe = lector(3) * lector(4)
                dgAgregar.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), importe)
            End While
            lector.Close()
        Catch ex As Exception
            MsgBox("Error seleccionar idApartado")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(13, '" & errMessage & "', 'ConsultaApartados.cbFecha_SelectedIndexChanged','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub
End Class
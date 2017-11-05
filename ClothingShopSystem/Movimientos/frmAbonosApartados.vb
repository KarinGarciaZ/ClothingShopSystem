Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class frmAbonosApartados
    Dim conexion As SqlConnection = openConnection()
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim transaccion As SqlTransaction

    Dim conexionBitacora = OpenBitacora()
    Dim BitacoraComando As SqlCommand = conexionBitacora.CreateCommand()
    Private Sub frmAbonosApartados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionBitacora.open()
            conexion.Open()
            comando.CommandText = "SELECT nombre FROM Clientes where idCliente > 1"
            lector = comando.ExecuteReader()

            While lector.Read
                cbClientes.Items.Add(lector(0))
            End While
            lector.Close()
        Catch ex As Exception
            MsgBox("Error al iniciar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(9, '" & errMessage & "', 'AbonosApartado.Load','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub frmAbonosApartados_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            conexion = cerrarConexion()
            conexionBitacora = cerrarBitacora()
        Catch ex As Exception
            MsgBox("Error al cerrar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(8, '" & errMessage & "', 'AbonosApartado.FormClosing','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
        btnGrabar.Enabled = False
        btnNuevo.Enabled = True

        txtAbono.Enabled = False
        txtAbono.Text = "00.00"
        txtIdApartado.Text = ""
        txtFechaVencimiento.Text = ""
        txtFecha.Text = ""
        txtAbonos.Text = ""

        txtIdAbonoApartado.Text = ""

        lblTotal.Text = "00.00"
        lblRestante.Text = "00.00"
        dgAgregar.Rows.Clear()
        cbClientes.Enabled = False
        cbApartados.Enabled = False
        cbApartados.Visible = False
        Label2.Visible = False
        cbClientes.Items.Clear()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            comando.CommandText = "SELECT COUNT(*) FROM AbonosApartados"
            txtIdAbonoApartado.Text = comando.ExecuteScalar + 1

            cbClientes.Enabled = True
            dtpFecha.Value = Now.Date
            txtAbono.Enabled = True
            btnGrabar.Enabled = True
            btnNuevo.Enabled = False
        Catch ex As Exception
            MsgBox("Error en el botón Nuevo")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(3, '" & errMessage & "', 'AbonosApartados.Nuevo','" & Now.Date & "',63, '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub cbApartados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbApartados.SelectedIndexChanged
        dgAgregar.Rows.Clear()

        Dim importe As Double = 0
        Dim restante As Double

        Try
            txtIdApartado.Text = cbApartados.Text

            comando.CommandText = "SELECT fecha, fechaVencimiento, abono, total FROM Apartados WHERE idApartado = " & txtIdApartado.Text
            lector = comando.ExecuteReader

            lector.Read()
            txtFecha.Text = CDate(lector(0))
            txtFechaVencimiento.Text = CDate(lector(1))
            txtAbonos.Text = lector(2)
            lblTotal.Text = lector(3)

            restante = CDbl(lector(3)) - CDbl(lector(2))
            lector.Close()

            comando.CommandText = "SELECT DetalleApartados.idProducto, Productos.nombre, Productos.codigoBarras, DetalleApartados.cantidad, DetalleApartados.precio FROM DetalleApartados inner join Productos on Productos.idProducto = DetalleApartados.idProducto WHERE DetalleApartados.idApartado = " & txtIdApartado.Text
            lector = comando.ExecuteReader

            While lector.Read
                importe = CDbl(lector(3)) * CDbl(lector(4))
                dgAgregar.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), importe)
            End While
            lector.Close()

            lblRestante.Text = restante
        Catch ex As Exception
            MsgBox("Error seleccionar apartado")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(13, '" & errMessage & "', 'AbonosApartados.ApartadosSelectedIndexChanged','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub cbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClientes.SelectedIndexChanged
        cbApartados.Items.Clear()
        Try
            comando.CommandText = "SELECT idApartado FROM Apartados inner join Clientes on Clientes.idCliente = Apartados.idCliente WHERE Clientes.nombre = '" & cbClientes.Text & "'"
            lector = comando.ExecuteReader

            While lector.Read
                cbApartados.Items.Add(lector(0))
            End While
            lector.Close()
        Catch ex As Exception
            MsgBox("Error seleccionar cliente")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(4, '" & errMessage & "', 'AbonosApartados.ClienteSelectedIndexChanged','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try

        cbApartados.Visible = True
        Label2.Visible = True
        cbApartados.Enabled = True
    End Sub

    Private Sub txtAbono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAbono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtAbono.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            ' Iniciar una transacción local
            transaccion = conexion.BeginTransaction("SampleTransaction")

            comando.Connection = conexion
            comando.Transaction = transaccion
            Try
                comando.CommandText = "INSERT INTO AbonosApartados VALUES (" & txtIdAbonoApartado.Text & "," & txtIdApartado.Text & ",'" & dtpFecha.Value.Date & "'," & txtAbono.Text & ")"
                comando.ExecuteNonQuery()

                comando.CommandText = "UPDATE Apartados SET abono = abono + " & txtAbono.Text & "WHERE idApartado = " & txtIdApartado.Text
                comando.ExecuteNonQuery()

                If Date.Compare(dtpFecha.Value, CDate(txtFechaVencimiento.Text)) = 1 Then
                    MessageBox.Show("¡Se ha pasado de la fecha de limite! Se le aumentará un 7%", "Fecha de Vencimiento", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Dim total As Double

                    total = CDbl(lblTotal.Text) * 0.17
                    comando.CommandText = "UPDATE Apartados SET total = total + " & total
                End If

                If MsgBox("¿Desea ejecutar abonar $" & txtAbono.Text & "?", MsgBoxStyle.YesNo, "ejecutar") = MsgBoxResult.Yes Then
                    transaccion.Commit()
                    MsgBox("¡Abonado!")
                Else
                    transaccion.Rollback()
                    MsgBox("Transacción cancelada")
                    dgAgregar.Rows.Clear()
                End If
            Catch ex As Exception
                MsgBox("Commit Exception Type: {0}no se pudo insertar por error")
                Try
                    transaccion.Rollback()
                Catch ex2 As Exception
                    MsgBox("Error Rollback")
                End Try
            End Try
        Catch ex As Exception
            MsgBox("Error Grabar")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(7, '" & errMessage & "', 'AbonosApartados.Grabar','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try

        btnGrabar.Enabled = False
        btnNuevo.Enabled = True

        txtAbono.Enabled = False
        txtAbono.Text = "00.00"
        txtIdApartado.Text = ""
        txtFechaVencimiento.Text = ""
        txtFecha.Text = ""
        txtAbonos.Text = ""

        txtIdAbonoApartado.Text = ""

        lblTotal.Text = "00.00"
        lblRestante.Text = "00.00"
        dgAgregar.Rows.Clear()
        cbClientes.Enabled = False
        cbApartados.Enabled = False
        cbApartados.Visible = False
        Label2.Visible = False
    End Sub
End Class
Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class ConsultaAbonosA
    Dim conexion As SqlConnection = openConnection()
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader

    Dim conexionBitacora = OpenBitacora()
    Dim BitacoraComando As SqlCommand = conexionBitacora.CreateCommand()
    Private Sub ConsultaAbonosA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbClientes.Items.Clear()

        Try
            conexion.Open()
            conexionBitacora.open()
            comando.CommandText = "SELECT nombre FROM Clientes WHERE idCliente > 1"
        lector = comando.ExecuteReader

        While lector.Read
            cbClientes.Items.Add(lector(0))
        End While
            lector.Close()

        Catch ex As Exception
            MsgBox("Error al iniciar la conexión")
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(9, '" & ex.Message & "', 'ConsultaAbonosA.Load','" & Now.Date & "'," & Err.Number & ")"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub cbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClientes.SelectedIndexChanged
        dgAgregar.Rows.Clear()
        Try
            comando.CommandText = "SELECT AbonosApartados.idAbonoA, AbonosApartados.fecha, Apartados.idApartado, Apartados.fecha, Apartados.fechaVencimiento, AbonosApartados.pago, Clientes.nombre, Apartados.total FROM AbonosApartados inner join Apartados on Apartados.idApartado = AbonosApartados.idApartado inner join Clientes on Clientes.idCliente = Apartados.idCliente WHERE Clientes.nombre = '" & cbClientes.Text & "'"
            lector = comando.ExecuteReader

            While lector.Read
                dgAgregar.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(7) - lector(5))
            End While
            lector.Close()
        Catch ex As Exception
            MsgBox("Error seleccionar clientes")
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(21, '" & ex.Message & "', 'ConsultaAbonosA.Load','" & Now.Date & "'," & Err.Number & ")"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub ConsultaAbonosA_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            conexion.Close()
            conexionBitacora = cerrarBitacora()
        Catch ex As Exception
            MsgBox("Error al cerrar la conexión")
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(8, '" & ex.Message & "', 'ConsultaAbonosA.FormClosing','" & Now.Date & "',51)"
            BitacoraComando.ExecuteNonQuery()
        End Try
        dgAgregar.Rows.Clear()
        cbClientes.Items.Clear()
    End Sub
End Class
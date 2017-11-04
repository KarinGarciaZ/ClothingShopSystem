Imports System.Data.SqlClient
Public Class ConsultaDevoluciones
    Dim connection = openConnection()
    Dim command As SqlCommand = connection.CreateCommand()
    Dim lector As SqlDataReader

    Dim conexionBitacora = OpenBitacora()
    Dim BitacoraComando As SqlCommand = conexionBitacora.CreateCommand()
    Private Sub ConsultaDevoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgAgregar.Rows.Clear()
        Try
            conexionBitacora.Open
            connection.open
            command.CommandText = "SELECT Devoluciones.idDevolucion, Devoluciones.idVenta, Clientes.nombre, Devoluciones.concepto, Devoluciones.fecha FROM Devoluciones inner join Ventas on Devoluciones.idVenta = Ventas.idVenta inner join Clientes on Ventas.idCliente = Clientes.idCliente"
            lector = command.ExecuteReader
            While lector.Read
                dgAgregar.Rows.Add(lector(0).ToString, lector(1).ToString, lector(2).ToString, lector(3).ToString, lector(4).ToString)
            End While
            lector.Close()
        Catch ex As Exception
            MsgBox("Error al iniciar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(9, '" & errMessage & "', 'ConsultaDevoluciones.Load','" & Now.Date & "'," & Err.Number & ")"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub ConsultaDevoluciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            conexionBitacora = cerrarBitacora()
            connection = cerrarConexion()
        Catch ex As Exception
            MsgBox("Error al cerrar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(8, '" & errMessage & "', 'ConsultaCompras.FormClosing','" & Now.Date & "'," & Err.Number & ")"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub
End Class
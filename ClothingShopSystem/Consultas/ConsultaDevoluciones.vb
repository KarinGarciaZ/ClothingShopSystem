Imports System.Data.SqlClient
Public Class ConsultaDevoluciones
    Dim connection = openConnection()
    Dim command As SqlCommand = connection.CreateCommand()
    Dim lector As SqlDataReader
    Private Sub ConsultaDevoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.open
        dgAgregar.Rows.Clear()
        command.CommandText = "SELECT Devoluciones.idDevolucion, Devoluciones.idVenta, Clientes.nombre, Devoluciones.concepto, Devoluciones.fecha FROM Devoluciones inner join Ventas on Devoluciones.idVenta = Ventas.idVenta inner join Clientes on Ventas.idCliente = Clientes.idCliente"
        lector = command.ExecuteReader
        While lector.Read
            dgAgregar.Rows.Add(lector(0).ToString, lector(1).ToString, lector(2).ToString, lector(3).ToString, lector(4).ToString)
        End While
        lector.Close()
    End Sub
End Class
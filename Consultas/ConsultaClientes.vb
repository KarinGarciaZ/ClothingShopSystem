Imports System.Data.SqlClient
Public Class ConsultaClientes
    Dim connection = openConnection()
    Dim command As SqlCommand = connection.CreateCommand()
    Dim lector As SqlDataReader
    Private Sub txtCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCliente.TextChanged
        dgAgregar.Rows.Clear()
        command.CommandText = "select * from Clientes WHERE nombre like '%" & txtCliente.Text & "%'"
        lector = command.ExecuteReader
        While lector.Read()
            dgAgregar.Rows.Add(lector(0).ToString, lector(1).ToString, lector(2).ToString, lector(3).ToString, lector(4).ToString, lector(5).ToString, lector(6).ToString, lector(7).ToString, lector(8).ToString)
        End While
        lector.Close()
    End Sub

    Private Sub ConsultaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.open

        command.CommandText = "SELECT * from Clientes"
        lector = command.ExecuteReader
        dgAgregar.Rows.Clear()
        While lector.Read()
            dgAgregar.Rows.Add(lector(0).ToString, lector(1).ToString, lector(2).ToString, lector(3).ToString, lector(4).ToString, lector(5).ToString, lector(6).ToString, lector(7).ToString, lector(8).ToString)
        End While
        lector.Close()
    End Sub

    Private Sub txtCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCliente.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub ConsultaClientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        dgAgregar.Rows.Clear()
        connection = cerrarConexion()
    End Sub
End Class
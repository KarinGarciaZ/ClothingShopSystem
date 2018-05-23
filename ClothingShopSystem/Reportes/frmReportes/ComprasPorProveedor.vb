Imports System.Data.SqlClient

Public Class ComprasPorProveedor

    Dim conexion = openConnection()
    Dim comando As SqlCommand = conexion.CreateCommand()
    Dim lector As SqlDataReader

    Private Sub ComprasPorProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbProveedores.Items.Clear()

        conexion.open()
        comando.CommandText = "SELECT nombre FROM Proveedores"
        lector = comando.ExecuteReader()

        While lector.Read
            cbProveedores.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub
End Class
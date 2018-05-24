Imports System.Data.SqlClient
Imports System.IO

Public Class ImportarTxt
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion = openConnection()
        Dim command As SqlCommand = conexion.CreateCommand()
        Dim lector As SqlDataReader
        Dim resQuery As String = String.Empty
        conexion.open()
        Dim linia As String
        Dim arrText As New ArrayList
        Dim campo() As String
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
                    command.CommandText = "select IdProducto from Productos where idProducto= " & Val(campo(0))
                    resQuery = command.ExecuteScalar
                    If resQuery = String.Empty Then
                        command.CommandText = "insert into Productos values(" & Val(campo(0)) & "," & Val(campo(1)) & ", " & Val(campo(2)) & "," & Val(campo(3)) & ",'" & campo(4) & "', '" & campo(5) & "','" & campo(6) & campo(7) & "', '" & campo(8) & "','" & campo(8) & "','" & campo(9) & "', '" & campo(10) & "','" & campo(11) & "','" & campo(12) & "')"
                        command.ExecuteNonQuery()
                    Else
                        command.CommandText = "update Productos set idTipo = " & Val(campo(1)) & ", idCategoria =" & Val(campo(2)) & ", idMarca =" & Val(campo(3)) & ", codigoBarras ='" & campo(4) & "', nombre ='" & campo(5) & "', costo = '" & campo(6) & "', precio1 ='" & campo(7) & "', precio2 = '" & campo(8) & "', precio3 = '" & campo(9) & "', existencia = '" & campo(10) & "', apartados ='" & campo(11) & "', ultimaFechaCompra ='" & campo(12) & "' where idProducto = " & Val(campo(0))
                        command.ExecuteNonQuery()
                    End If

                End If
                ban = True
            Next
            MsgBox("Se añadieron Productos")
        End If

    End Sub
End Class
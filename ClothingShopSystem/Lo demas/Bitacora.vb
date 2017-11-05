Imports System.Data.SqlClient
Public Class Bitacora

    Dim conexionBitacora = OpenBitacora()
    Dim BitacoraComando As SqlCommand = conexionBitacora.CreateCommand()
    Dim lector As SqlDataReader
    Private Sub Bitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgAgregar.Rows.Clear()
        Try
            conexionBitacora.Open
            BitacoraComando.CommandText = "select * from bitacora order by idError desc"
            lector = BitacoraComando.ExecuteReader
            While lector.Read
                dgAgregar.Rows.Add(lector(0).ToString, lector(1).ToString, lector(2).ToString, lector(3).ToString, lector(4).ToString, lector(5).ToString, lector(6).ToString)
            End While
            lector.Close()
        Catch ex As Exception
            MsgBox("Error al iniciar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(9, '" & errMessage & "', 'Bitacora.Load','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub Bitacora_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            conexionBitacora = cerrarBitacora()
        Catch ex As Exception
            MsgBox("Error al cerrar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(8, '" & errMessage & "', 'Bitacora.FormClosing','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub
End Class
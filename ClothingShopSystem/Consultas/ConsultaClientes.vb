Imports System.Data.SqlClient
Public Class ConsultaClientes
    Dim connection = openConnection()
    Dim command As SqlCommand = connection.CreateCommand()
    Dim lector As SqlDataReader

    Dim conexionBitacora = OpenBitacora()
    Dim BitacoraComando As SqlCommand = conexionBitacora.CreateCommand()
    Private Sub txtCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCliente.TextChanged
        dgAgregar.Rows.Clear()
        Try
            command.CommandText = "select * from Clientes WHERE nombre like '%" & txtCliente.Text & "%'"
            lector = command.ExecuteReader
            While lector.Read()
                dgAgregar.Rows.Add(lector(0).ToString, lector(1).ToString, lector(2).ToString, lector(3).ToString, lector(4).ToString, lector(5).ToString, lector(6).ToString, lector(7).ToString, lector(8).ToString)
            End While
            lector.Close()
        Catch ex As Exception
            MsgBox("Error buscar cliente")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(4, '" & errMessage & "', 'ConsultaClientes.Load','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub ConsultaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionBitacora.open()
            connection.open()

            command.CommandText = "SELECT * from Clientes"
            lector = command.ExecuteReader
            dgAgregar.Rows.Clear()
            While lector.Read()
                dgAgregar.Rows.Add(lector(0).ToString, lector(1).ToString, lector(2).ToString, lector(3).ToString, lector(4).ToString, lector(5).ToString, lector(6).ToString, lector(7).ToString, lector(8).ToString)
            End While
            lector.Close()
        Catch ex As Exception
            MsgBox("Error al iniciar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(9, '" & errMessage & "', 'ConsultaClientes.Load','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
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
        Try
            connection = cerrarConexion()
            conexionBitacora = cerrarBitacora()
        Catch ex As Exception
            MsgBox("Error al cerrar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(8, '" & errMessage & "', 'ConsultaClientes.FormClosing','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub txtIdCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdCliente.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            dgAgregar.Rows.Clear()
            command.CommandText = "select * from Clientes WHERE idCliente like '%" & txtIdCliente.Text & "%'"
            lector = command.ExecuteReader
            If lector.Read() Then
                dgAgregar.Rows.Add(lector(0).ToString, lector(1).ToString, lector(2).ToString, lector(3).ToString, lector(4).ToString, lector(5).ToString, lector(6).ToString, lector(7).ToString, lector(8).ToString)
            Else
                MsgBox("No existe este producto")
            End If
            lector.Close()
        End If
    End Sub
End Class
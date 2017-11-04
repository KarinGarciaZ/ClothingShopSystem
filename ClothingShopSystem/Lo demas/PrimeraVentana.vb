Imports System.Data.SqlClient
Public Class PrimeraVentana

    Dim conexionsql As SqlConnection = openConnection()
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader

    Dim conexionBitacora = OpenBitacora()
    Dim BitacoraComando As SqlCommand = conexionBitacora.CreateCommand()

    Private Sub PrimeraVentana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionsql.Open()
            conexionBitacora.open()
        Catch ex As Exception
            MsgBox("Error al iniciar la conexión")
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(1, '" & ex.Message & "', 'PrimeraVentana.Load','" & Now.Date & "'," & Err.Number & ")"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub confirmarCuenta()
        Try
            comando.CommandText = "select contrasena, puesto from Usuarios where nombre = '" & txtNombre.Text & "'"
            lector = comando.ExecuteReader
            If lector.Read Then
                If txtConfirmar.Text.Equals(lector(0)) Then
                    If Not lector(1).ToString.Equals("Empleado") Then
                        Me.Hide()
                        Form1.ShowDialog()
                        Me.Dispose()
                    Else
                        Me.Hide()
                        PrincipaUsuarios.ShowDialog()
                        Me.Dispose()
                    End If
                Else
                    MsgBox("No coinside la contraseña")
                End If
            Else
                MsgBox("Usuario no existente")
            End If
            lector.Close()
            conexionsql = cerrarConexion()
            conexionBitacora = cerrarBitacora()
        Catch ex As Exception
            MsgBox("Error corfirmarCuenta")
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(19, '" & ex.Message & "', 'PrimeraVentana.Load','" & Now.Date & "'," & Err.Number & ")"
            BitacoraComando.ExecuteNonQuery()

        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        confirmarCuenta()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub txtConfirmar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConfirmar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            confirmarCuenta()
        End If
    End Sub
End Class
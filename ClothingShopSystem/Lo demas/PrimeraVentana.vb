Imports System.Data.SqlClient
Public Class PrimeraVentana

    Dim conexionsql As SqlConnection = openConnection()
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader

    Private Sub PrimeraVentana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
    End Sub

    Private Sub confirmarCuenta()
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
Imports System.Data.SqlClient

Public Class Usuarios
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlDataAdapter1.Fill(DataSet11.Usuarios)
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        UsuariosBindingSource.MoveFirst()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        UsuariosBindingSource.MovePrevious()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        UsuariosBindingSource.MoveNext()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        UsuariosBindingSource.MoveLast()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer = UsuariosBindingSource.Count + 1
        UsuariosBindingSource.AddNew()
        txtId.Text = n
        txtNombre.Enabled = True
        txtContrase.Enabled = True
        txtConfirmar.Enabled = True
        cbPuesto.Enabled = True

        btnAnterior.Enabled = False
        btnPrimero.Enabled = False
        btnSiguiente.Enabled = False
        btnUltimo.Enabled = False
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnAceptar.Enabled = True
        btnCancelar.Enabled = True
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim contra As String = InputBox("Ingrese su contraseña actual")
        If contra = UsuariosBindingSource.Current(2) Then
            txtNombre.Enabled = True
            txtConfirmar.Enabled = True
            txtContrase.Enabled = True
            cbPuesto.Enabled = True
            txtConfirmar.Text = UsuariosBindingSource.Current(2)

            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnAceptar.Enabled = True
            btnCancelar.Enabled = True
            btnAnterior.Enabled = False
            btnPrimero.Enabled = False
            btnSiguiente.Enabled = False
            btnUltimo.Enabled = False
        Else
            MsgBox("Contraseñas no coinsiden")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtNombre.Enabled = False
        txtConfirmar.Enabled = False
        txtContrase.Enabled = False
        cbPuesto.Enabled = False

        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False
        btnAnterior.Enabled = True
        btnPrimero.Enabled = True
        btnSiguiente.Enabled = True
        btnUltimo.Enabled = True
        UsuariosBindingSource.CancelEdit()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtConfirmar.Text.Equals(txtContrase.Text) Then
            txtNombre.Enabled = False
            txtContrase.Enabled = False
            txtConfirmar.Enabled = False
            cbPuesto.Enabled = False

            btnNuevo.Enabled = True
            btnModificar.Enabled = True
            btnAceptar.Enabled = False
            btnCancelar.Enabled = False
            btnAnterior.Enabled = True
            btnPrimero.Enabled = True
            btnSiguiente.Enabled = True
            btnUltimo.Enabled = True
            txtConfirmar.Text = ""

            UsuariosBindingSource.EndEdit()
            Me.SqlDataAdapter1.Update(Me.DataSet11.Usuarios)
            DataSet11.Clear()
            SqlDataAdapter1.Fill(DataSet11.Usuarios)
        Else
            MsgBox("Contraseñas no coinsiden")
        End If
    End Sub

    Private Sub Usuarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        UsuariosBindingSource.CancelEdit()
        Me.Dispose()
    End Sub

    Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlRowUpdatedEventArgs) Handles SqlDataAdapter1.RowUpdated
        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message & vbCrLf &
            e.Row.Item("NOMBRE", DataRowVersion.Original) & vbCrLf &
            e.Row.Item("NOMBRE", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub
End Class
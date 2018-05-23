Public Class Calles
    Private Sub SqlConnection1_InfoMessage(sender As Object, e As SqlClient.SqlInfoMessageEventArgs) Handles SqlConnection1.InfoMessage

    End Sub

    Private Sub Calles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlDataAdapter1.Fill(DataSet11.Calles)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer = CallesBindingSource.Count + 1
        CallesBindingSource.AddNew()
        txtId.Text = n
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        CallesBindingSource.EndEdit()
        Me.SqlDataAdapter1.Update(Me.DataSet11.Calles)
        DataSet11.Clear()
        SqlDataAdapter1.Fill(DataSet11.Calles)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        CallesBindingSource.CancelEdit()
    End Sub
End Class
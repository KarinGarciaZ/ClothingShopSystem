Imports System.Data.SqlClient

Public Class Marcas
    Private Sub Marcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlDataAdapter1.Fill(DataSet11.Marcas)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer = MarcasBindingSource.Count + 1
        MarcasBindingSource.AddNew()
        txtId.Text = n
        txtNombre.Enabled = True
        btnAnterior.Enabled = False
        btnPrimero.Enabled = False
        btnSiguiente.Enabled = False
        btnUltimo.Enabled = False
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnAceptar.Enabled = True
        btnCancelar.Enabled = True
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        txtNombre.Enabled = False
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False
        btnAnterior.Enabled = True
        btnPrimero.Enabled = True
        btnSiguiente.Enabled = True
        btnUltimo.Enabled = True

        MarcasBindingSource.EndEdit()
        Me.SqlDataAdapter1.Update(Me.DataSet11.Marcas)
        DataSet11.Clear()
        SqlDataAdapter1.Fill(DataSet11.Marcas)
    End Sub



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtNombre.Enabled = False
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False
        btnAnterior.Enabled = True
        btnPrimero.Enabled = True
        btnSiguiente.Enabled = True
        btnUltimo.Enabled = True
        MarcasBindingSource.CancelEdit()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtNombre.Enabled = True
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnAceptar.Enabled = True
        btnCancelar.Enabled = True
        btnAnterior.Enabled = False
        btnPrimero.Enabled = False
        btnSiguiente.Enabled = False
        btnUltimo.Enabled = False
    End Sub

    Private Sub Marcas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MarcasBindingSource.CancelEdit()
        Me.Dispose()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        MarcasBindingSource.MovePrevious()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        MarcasBindingSource.MoveNext()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        MarcasBindingSource.MoveLast()
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        MarcasBindingSource.MoveFirst()
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
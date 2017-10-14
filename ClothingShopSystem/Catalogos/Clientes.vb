Imports System.Data.SqlClient

Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlDataAdapter1.Fill(DataSet11.Clientes)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer = ClientesBindingSource.Count + 1
        ClientesBindingSource.AddNew()
        txtId.Text = n
        txtNombre.Enabled = True
        txtTelefono.Enabled = True
        txtCiudad.Enabled = True
        txtCP.Enabled = True
        txtDomicilio.Enabled = True
        txtLimite.Enabled = True
        txtColonia.Enabled = True
        txtSaldo.Text = "0"
        txtSaldo.Enabled = False
        btnAnterior.Enabled = False
        btnPrimero.Enabled = False
        btnSiguiente.Enabled = False
        btnUltimo.Enabled = False
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnBuscar.Enabled = False
        btnAceptar.Enabled = True
        btnCancelar.Enabled = True
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        txtNombre.Enabled = False
        txtTelefono.Enabled = False
        txtCiudad.Enabled = False
        txtCP.Enabled = False
        txtDomicilio.Enabled = False
        txtLimite.Enabled = False
        txtColonia.Enabled = False
        txtSaldo.Enabled = False
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnBuscar.Enabled = True
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False
        btnAnterior.Enabled = True
        btnPrimero.Enabled = True
        btnSiguiente.Enabled = True
        btnUltimo.Enabled = True

        ClientesBindingSource.EndEdit()
        Me.SqlDataAdapter1.Update(Me.DataSet11.Clientes)
        DataSet11.Clear()
        SqlDataAdapter1.Fill(DataSet11.Clientes)
    End Sub



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtNombre.Enabled = False
        txtTelefono.Enabled = False
        txtSaldo.Enabled = False
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnBuscar.Enabled = True
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False
        btnAnterior.Enabled = True
        btnPrimero.Enabled = True
        btnSiguiente.Enabled = True
        btnUltimo.Enabled = True
        ClientesBindingSource.CancelEdit()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtNombre.Enabled = True
        txtCiudad.Enabled = True
        txtCP.Enabled = True
        txtDomicilio.Enabled = True
        txtLimite.Enabled = True
        txtColonia.Enabled = True
        txtTelefono.Enabled = True
        txtSaldo.Enabled = True
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnBuscar.Enabled = False
        btnAceptar.Enabled = True
        btnCancelar.Enabled = True
        btnAnterior.Enabled = False
        btnPrimero.Enabled = False
        btnSiguiente.Enabled = False
        btnUltimo.Enabled = False
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        ClientesBindingSource.MoveFirst()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        ClientesBindingSource.MovePrevious()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        ClientesBindingSource.MoveNext()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        ClientesBindingSource.MoveLast()
    End Sub

    Private Sub Clientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ClientesBindingSource.CancelEdit()
        Me.Dispose()
    End Sub

    Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlRowUpdatedEventArgs)
        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message & vbCrLf &
            e.Row.Item("NOMBRE", DataRowVersion.Original) & vbCrLf &
            e.Row.Item("NOMBRE", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub

    Private Sub txtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCP.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtLimite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLimite.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtLimite.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ConsultaClientes.ShowDialog()
    End Sub
End Class
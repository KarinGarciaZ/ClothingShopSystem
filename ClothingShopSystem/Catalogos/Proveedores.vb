Imports System.Data.SqlClient
Public Class Proveedores

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer = ProveedoresBindingSource.Count + 1
        ProveedoresBindingSource.AddNew()
        txtId.Text = n
        txtNombre.Enabled = True
        txtTelefono.Enabled = True
        txtDomicilio.Enabled = True
        txtEmail.Enabled = True
        txtCiudad.Enabled = True
        btnAnterior.Enabled = False
        btnPrimero.Enabled = False
        btnSiguiente.Enabled = False
        btnUltimo.Enabled = False
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnAceptar.Enabled = True
        btnCancelar.Enabled = True
    End Sub

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet11.Proveedores' Puede moverla o quitarla según sea necesario.
        SqlDataAdapter1.Fill(DataSet11.Proveedores)
        'Me.ProveedoresTableAdapter.Fill(Me.DataSet11.Proveedores)

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        txtNombre.Enabled = False
        txtTelefono.Enabled = False
        txtDomicilio.Enabled = False
        txtEmail.Enabled = False
        txtCiudad.Enabled = False
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False
        btnAnterior.Enabled = True
        btnPrimero.Enabled = True
        btnSiguiente.Enabled = True
        btnUltimo.Enabled = True
        ProveedoresBindingSource.EndEdit()
        Me.SqlDataAdapter1.Update(Me.DataSet11.Proveedores)
        DataSet11.Clear()
        SqlDataAdapter1.Fill(DataSet11.Proveedores)
    End Sub



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtNombre.Enabled = False
        txtTelefono.Enabled = False
        txtDomicilio.Enabled = False
        txtEmail.Enabled = False
        txtCiudad.Enabled = False
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False
        btnAnterior.Enabled = True
        btnPrimero.Enabled = True
        btnSiguiente.Enabled = True
        btnUltimo.Enabled = True
        ProveedoresBindingSource.CancelEdit()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtNombre.Enabled = True
        txtTelefono.Enabled = True
        txtDomicilio.Enabled = True
        txtEmail.Enabled = True
        txtCiudad.Enabled = True
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnAceptar.Enabled = True
        btnCancelar.Enabled = True
        btnAnterior.Enabled = False
        btnPrimero.Enabled = False
        btnSiguiente.Enabled = False
        btnUltimo.Enabled = False
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        ProveedoresBindingSource.MoveFirst()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        ProveedoresBindingSource.MovePrevious()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        ProveedoresBindingSource.MoveNext()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        ProveedoresBindingSource.MoveLast()
    End Sub

    Private Sub Proveedores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ProveedoresBindingSource.CancelEdit()
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

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



    '    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
    '        comando.CommandText = "INSERT INTO Proveedores VALUES(" & txtId.Text & ",'" & txtNombre.Text & "','" & txtTelefono.Text & "','" & txtDomicilio.Text & "','" & txtCiudad.Text & "','" & txtEmail.Text & "')"
    '        comando.ExecuteNonQuery()

    '        txtCiudad.Text = ""
    '        txtId.Text = ""
    '        txtNombre.Text = ""
    '        txtDomicilio.Text = ""
    '        txtEmail.Text = ""
    '        txtTelefono.Text = ""
    '        txtEmail.Enabled = False
    '        txtNombre.Enabled = False
    '        txtCiudad.Enabled = False
    '        txtTelefono.Enabled = False
    '        txtDomicilio.Enabled = False
    '        btnNuevo.Enabled = True
    '        btnModificar.Enabled = True
    '        btnBorrar.Enabled = True
    '        btnBuscar.Enabled = True
    '        btnAceptar.Enabled = False
    '        btnCancelar.Enabled = False
    '    End Sub
End Class
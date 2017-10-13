Public Class Productos
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Productos' Puede moverla o quitarla según sea necesario.
        SqlDataAdapter4.Fill(DataSet11.Productos1)
        SqlDataAdapter1.Fill(DataSet11.Tipos1)
        SqlDataAdapter2.Fill(DataSet11.Categorias1)
        SqlDataAdapter3.Fill(DataSet11.Marcas1)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer = Productos1BindingSource.Count + 1
        Productos1BindingSource.AddNew()
        txtId.Text = n
        txtNombre.Enabled = True
        txtCodigoBarras.Enabled = True
        cbCategoria.Enabled = True
        cbMarca.Enabled = True
        cbTipo.Enabled = True
        dtpFecha.Enabled = True
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True

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
        txtCodigoBarras.Enabled = False
        cbCategoria.Enabled = False
        cbMarca.Enabled = False
        cbTipo.Enabled = False
        dtpFecha.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False


        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnBuscar.Enabled = True
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False
        btnAnterior.Enabled = True
        btnPrimero.Enabled = True
        btnSiguiente.Enabled = True
        btnUltimo.Enabled = True

        Productos1BindingSource.Current(1) = cbTipo.SelectedValue
        Productos1BindingSource.Current(2) = cbCategoria.SelectedValue
        Productos1BindingSource.Current(3) = cbMarca.SelectedValue
        Productos1BindingSource.Current(12) = dtpFecha.Value.Date

        Productos1BindingSource.EndEdit()
        Me.SqlDataAdapter4.Update(DataSet11.Productos1)
        DataSet11.Clear()
        SqlDataAdapter4.Fill(DataSet11.Productos1)
        SqlDataAdapter1.Fill(DataSet11.Tipos1)
        SqlDataAdapter2.Fill(DataSet11.Categorias1)
        SqlDataAdapter3.Fill(DataSet11.Marcas1)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtNombre.Enabled = False
        txtCodigoBarras.Enabled = False
        cbCategoria.Enabled = False
        cbMarca.Enabled = False
        cbTipo.Enabled = False
        dtpFecha.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False

        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnBuscar.Enabled = True
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False
        btnAnterior.Enabled = True
        btnPrimero.Enabled = True
        btnSiguiente.Enabled = True
        btnUltimo.Enabled = True
        Productos1BindingSource.CancelEdit()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtNombre.Enabled = True
        txtCodigoBarras.Enabled = True
        txtCosto.Enabled = True
        cbCategoria.Enabled = True
        cbMarca.Enabled = True
        cbTipo.Enabled = True
        dtpFecha.Enabled = True
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True

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

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        Productos1BindingSource.MoveFirst()

        cbTipo.SelectedValue = Productos1BindingSource.Current(1)
        cbCategoria.SelectedValue = Productos1BindingSource.Current(2)
        cbMarca.SelectedValue = Productos1BindingSource.Current(3)
        'falta esto dice que esta fuera del indice
        dtpFecha.Value = Productos1BindingSource.Current(12)
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Productos1BindingSource.MovePrevious()

        cbTipo.SelectedValue = Productos1BindingSource.Current(1)
        cbCategoria.SelectedValue = Productos1BindingSource.Current(2)
        cbMarca.SelectedValue = Productos1BindingSource.Current(3)
        dtpFecha.Value = Productos1BindingSource.Current(12)
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Productos1BindingSource.MoveNext()

        cbTipo.SelectedValue = Productos1BindingSource.Current(1)
        cbCategoria.SelectedValue = Productos1BindingSource.Current(2)
        cbMarca.SelectedValue = Productos1BindingSource.Current(3)
        dtpFecha.Value = Productos1BindingSource.Current(12)
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Productos1BindingSource.MoveLast()

        cbTipo.SelectedValue = Productos1BindingSource.Current(1)
        cbCategoria.SelectedValue = Productos1BindingSource.Current(2)
        cbMarca.SelectedValue = Productos1BindingSource.Current(3)
        dtpFecha.Value = Productos1BindingSource.Current(12)
    End Sub

    Private Sub Productos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Productos1BindingSource.CancelEdit()
        Me.Dispose()
    End Sub

    Private Sub txtPrecio1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtPrecio1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecio2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtPrecio2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecio3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtPrecio3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtCosto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtExistencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExistencia.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtApartados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApartados.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ConsultaProductos.ShowDialog()
    End Sub
End Class
Imports System.Data.SqlClient
Public Class Compras
    Dim connection = openConnection()
    Dim command As SqlCommand = connection.CreateCommand()
    Dim transaction As SqlTransaction
    Dim lector As SqlDataReader

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        command.CommandText = "SELECT COUNT(*) FROM Compras"
        txtIdCompra.Text = command.ExecuteScalar + 1

        btnGrabar.Enabled = True
        btnNuevo.Enabled = False
        dtpFecha.Text = Now.Date
        txtFactura.Enabled = True
        cbProveedores.Enabled = True
        dtpFecha.Enabled = True
        'txtCodigoBarras.Enabled = True

        cbProducto.Enabled = True
        txtCostoNuevo.Enabled = True
        txtCantidad.Enabled = True
        btnAgregar.Enabled = True
    End Sub

    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()

        command.CommandText = "SELECT nombre FROM Proveedores"
        lector = command.ExecuteReader

        While lector.Read
            cbProveedores.Items.Add(lector(0))
        End While
        lector.Close()

        command.CommandText = "SELECT nombre FROM Productos"
        lector = command.ExecuteReader

        While lector.Read
            cbProducto.Items.Add(lector(0))
        End While
        lector.Close()

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dgAgregar.RowCount <> 0 Then
            ' Iniciar una transacción local
            transaction = connection.BeginTransaction("SampleTransaction")
            'Debe asignar el objeto de la transacción y la conexión
            'A un objeto comando para una transación local pendiente.
            command.Connection = connection
            command.Transaction = transaction
            Try
                command.CommandText = "INSERT INTO Compras VALUES (" & txtIdCompra.Text & "," & txtIdProveedor.Text & ",'" & dtpFecha.Value.Date & "','" & txtFactura.Text & "'," & lblTotal.Text & ")"
                command.ExecuteNonQuery()

                For x = 0 To dgAgregar.RowCount - 1
                    command.CommandText = "INSERT INTO DetalleCompras VALUES (" & txtIdCompra.Text & "," & dgAgregar.Item(0, x).Value & "," & dgAgregar.Item(3, x).Value & "," & dgAgregar.Item(4, x).Value & ")"
                    command.ExecuteNonQuery()

                    command.CommandText = "UPDATE Productos SET costo = " & dgAgregar.Item(4, x).Value & ", existencia = existencia + " & dgAgregar.Item(3, x).Value & ", ultimaFechaCompra = '" & dtpFecha.Value & "' WHERE idProducto = " & dgAgregar.Item(0, x).Value
                    command.ExecuteNonQuery()
                Next

                ' Aquí pueden ir n comandos ExecuteNonQuery….
                ' Intenta ejecutar la transacción.
                If MsgBox("¿Desea ejecutar esta compra?", MsgBoxStyle.YesNo, "ejecutar") = MsgBoxResult.Yes Then
                    transaction.Commit()
                    MsgBox("¡Listo!")
                Else
                    transaction.Rollback()
                    MsgBox("Transacción cancelada")
                    dgAgregar.Rows.Clear()
                End If
            Catch ex As Exception
                MsgBox("Commit Exception Type: {0}no se pudo insertar por error")
                Try
                    transaction.Rollback()
                Catch ex2 As Exception
                    MsgBox("Error Rollback")
                End Try
            End Try

            btnAgregar.Enabled = False
            btnGrabar.Enabled = False
            btnNuevo.Enabled = True
            txtFactura.Enabled = False
            txtCantidad.Enabled = False
            txtCosto.Enabled = False
            txtCantidad.Text = ""
            txtCodigoBarras.Text = ""
            txtCosto.Text = ""
            txtCostoNuevo.Text = ""
            txtDomicilio.Text = ""
            txtExistencia.Text = ""
            txtFactura.Text = ""
            txtIdCompra.Text = ""
            txtIdProducto.Text = ""
            txtIdProveedor.Text = ""
            txtTelefono.Text = ""
            lblIVA.Text = "0.0"
            lblSubtotal.Text = "0.0"
            lblTotal.Text = "0.0"
            dgAgregar.Rows.Clear()
            cbProducto.Enabled = False
            cbProveedores.Enabled = False
        Else
            MessageBox.Show("Sin datos en rejilla, revise sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cbProveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProveedores.SelectedIndexChanged
        command.CommandText = "SELECT idProveedor, telefono, domicilio FROM Proveedores WHERE nombre = '" & cbProveedores.Text & "'"
        lector = command.ExecuteReader
        lector.Read()

        txtIdProveedor.Text = lector(0)
        txtTelefono.Text = lector(1).ToString
        txtDomicilio.Text = lector(2).ToString

        lector.Close()
    End Sub

    Private Sub cbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProducto.SelectedIndexChanged
        command.CommandText = "SELECT idProducto, codigoBarras, costo, existencia, ultimaFechaCompra FROM Productos WHERE nombre = '" & cbProducto.Text & "'"
        lector = command.ExecuteReader
        lector.Read()

        txtIdProducto.Text = lector(0)
        txtCodigoBarras.Text = lector(1).ToString
        txtCosto.Text = lector(2).ToString
        txtExistencia.Text = lector(3).ToString
        dtpUltimaCompra.Text = lector(4).ToString
        lector.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtCantidad.Text <> "" And txtCostoNuevo.Text <> "" Then
            Dim id As Integer = Val(txtIdProducto.Text)
            Dim cantidad As Integer = txtCantidad.Text
            Dim costo As Double = CDbl(txtCostoNuevo.Text)
            Dim ban As Boolean = False
            Dim y As Integer
            Dim importe As Double = 0

            For x = 0 To dgAgregar.RowCount - 1
                If id = dgAgregar.Item(0, x).Value Then
                    ban = True
                    y = x
                End If
            Next

            If ban = False Then
                dgAgregar.Rows.Add(id, cbProducto.Text, txtCodigoBarras.Text, cantidad, costo, cantidad * costo)

            Else
                dgAgregar.Item(3, y).Value = dgAgregar.Item(3, y).Value + cantidad
                dgAgregar.Item(4, y).Value = costo
                dgAgregar.Item(5, y).Value = dgAgregar.Item(3, y).Value * costo
            End If

            For i = 0 To dgAgregar.RowCount - 1
                importe += dgAgregar.Item(5, i).Value
            Next

            lblSubtotal.Text = importe
            lblIVA.Text = Val(lblSubtotal.Text) * 0.16
            lblTotal.Text = Val(lblSubtotal.Text) + Val(lblIVA.Text)

            txtCostoNuevo.Text = ""
            txtCantidad.Text = ""
        Else
            MessageBox.Show("Revise sus datos, hay un campo vacio", "Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Compras_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        connection = cerrarConexion()
        btnAgregar.Enabled = False
        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        txtCantidad.Text = ""
        txtCodigoBarras.Text = ""
        txtCosto.Text = ""
        txtCostoNuevo.Text = ""
        txtDomicilio.Text = ""
        txtExistencia.Text = ""
        txtFactura.Text = ""
        txtIdCompra.Text = ""
        txtIdProducto.Text = ""
        txtIdProveedor.Text = ""
        txtTelefono.Text = ""
        lblIVA.Text = "0.0"
        lblSubtotal.Text = "0.0"
        lblTotal.Text = "0.0"
        cbProducto.Items.Clear()
        cbProveedores.Items.Clear()
        dgAgregar.Rows.Clear()
        dtpFecha.Enabled = False
        cbProducto.Enabled = False
        cbProveedores.Enabled = False
        txtCostoNuevo.Enabled = False
        txtCantidad.Enabled = False
        txtFactura.Enabled = False
    End Sub

    Private Sub txtCostoNuevo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostoNuevo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtCostoNuevo.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
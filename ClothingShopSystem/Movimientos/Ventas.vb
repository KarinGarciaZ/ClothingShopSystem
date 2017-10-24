Imports System.Data.SqlClient
Public Class Ventas
    Dim connection = openConnection()
    Dim command As SqlCommand = connection.CreateCommand()
    Dim transaction As SqlTransaction
    Dim lector As SqlDataReader

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()
        rbEfectivo.Checked = True
    End Sub

    Private Sub llenarClientes()
        command.CommandText = "SELECT nombre FROM Clientes where idCliente > 1"
        lector = command.ExecuteReader

        While lector.Read
            cbCliente.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub llenarProductos()
        command.CommandText = "SELECT nombre FROM Productos where idProducto > 0"
        lector = command.ExecuteReader

        While lector.Read
            cbProducto.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        command.CommandText = "SELECT COUNT(*) FROM Ventas"
        txtIdVenta.Text = command.ExecuteScalar + 1

        btnGrabar.Enabled = True
        btnNuevo.Enabled = False
        dtpFecha.Text = Now.Date
        rbCredito.Enabled = True
        rbEfectivo.Enabled = True
        cbProducto.Enabled = True
        dtpFecha.Enabled = True
        'txtCodigoBarras.Enabled = True
        llenarClientes()
        llenarProductos()
        txtDescuento.Enabled = True
        btnAgregar.Enabled = True
    End Sub

    Private Sub rbCredito_CheckedChanged(sender As Object, e As EventArgs) Handles rbCredito.CheckedChanged
        cbCliente.Enabled = True
        dtpFechaVen.Visible = True
        lblVen.Visible = True
    End Sub

    Private Sub cbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCliente.SelectedIndexChanged
        command.CommandText = "SELECT idCliente, telefono, domicilio, saldo, limiteCredito FROM Clientes WHERE nombre = '" & cbCliente.Text & "'"
        lector = command.ExecuteReader
        lector.Read()

        txtIdCliente.Text = lector(0)
        txtTelefono.Text = lector(1).ToString
        txtDomicilio.Text = lector(2).ToString
        txtSaldo.Text = lector(3).ToString
        txtLimite.Text = lector(4).ToString

        lector.Close()
    End Sub

    Private Sub cbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProducto.SelectedIndexChanged
        command.CommandText = "SELECT idProducto, codigoBarras, existencia, apartados, precio1 FROM Productos WHERE nombre = '" & cbProducto.Text & "'"
        lector = command.ExecuteReader
        lector.Read()

        txtIdProducto.Text = lector(0)
        txtCodigoBarras.Text = lector(1).ToString
        txtExistencia.Text = (lector(2) - lector(3)).ToString
        txtPrecio.Text = lector(4)
        lector.Close()
        cbTipoPrecio.Text = "Precio1"
        cbTipoPrecio.Enabled = True
        txtCantidad.Enabled = True

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtCantidad.Text = "" Then
            MessageBox.Show("Revise sus datos, hay un campo vacio", "Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim id As Integer = Val(txtIdProducto.Text)
            Dim cantidad As Integer = txtCantidad.Text
            Dim existencia As Integer = txtExistencia.Text
            Dim precio As Double = txtPrecio.Text
            Dim ban As Boolean = False
            Dim ejecutar As Boolean = True
            Dim y As Integer
            Dim importe As Double = 0

            If cantidad > existencia Then
                If Not MsgBox("Las existencias del producto son menores de lo que desea vender, ¿Desea continuar?", MsgBoxStyle.YesNo, "ejecutar") = MsgBoxResult.Yes Then
                    ejecutar = False
                End If
            End If

            If ejecutar Then
                For x = 0 To dgAgregar.RowCount - 1
                    If id = dgAgregar.Item(0, x).Value Then
                        ban = True
                        y = x
                    End If
                Next

                If ban = False Then
                    dgAgregar.Rows.Add(id, cbProducto.Text, txtCodigoBarras.Text, cantidad, precio, cantidad * precio)
                Else
                    Dim suma As Integer = dgAgregar.Item(3, y).Value + cantidad
                    If suma > existencia Then
                        If MsgBox("Las existencias del producto son menores de lo que desea vender, ¿Desea continuar?", MsgBoxStyle.YesNo, "ejecutar") = MsgBoxResult.Yes Then
                            dgAgregar.Item(3, y).Value = dgAgregar.Item(3, y).Value + cantidad
                            dgAgregar.Item(4, y).Value = precio
                            dgAgregar.Item(5, y).Value = dgAgregar.Item(3, y).Value * precio
                        End If
                    Else
                        dgAgregar.Item(3, y).Value = dgAgregar.Item(3, y).Value + cantidad
                        dgAgregar.Item(4, y).Value = precio
                        dgAgregar.Item(5, y).Value = dgAgregar.Item(3, y).Value * precio
                    End If
                End If

                For i = 0 To dgAgregar.RowCount - 1
                    importe += dgAgregar.Item(5, i).Value
                Next

                lblImporte.Text = importe
                lblSubtotal.Text = importe
                lblSubtotal.Text = CDbl(lblSubtotal.Text) - CDbl(txtDescuento.Text)
                lblIVA.Text = CDbl(lblSubtotal.Text) * 0.16
                lblTotal.Text = CDbl(lblSubtotal.Text) + CDbl(lblIVA.Text)
            End If


            cbProducto.Items.Clear()
            cbProducto.Text = ""
            txtIdProducto.Text = ""
            txtCodigoBarras.Text = ""
            txtPrecio.Text = ""
            txtExistencia.Text = ""
            txtCantidad.Text = ""
            cbTipoPrecio.Enabled = False
            txtExistencia.Enabled = False
            txtPrecio.Enabled = False
            txtCantidad.Enabled = False
            llenarProductos()
        End If
    End Sub

    Private Sub cbTipoPrecio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoPrecio.SelectedIndexChanged
        command.CommandText = "SELECT precio1, precio2, precio3 FROM Productos WHERE idProducto = " & txtIdProducto.Text & ""
        lector = command.ExecuteReader
        lector.Read()
        If cbTipoPrecio.SelectedItem.Equals("Precio1") Then
            txtPrecio.Text = lector(0).ToString
        End If
        If cbTipoPrecio.SelectedItem.Equals("Precio2") Then
            txtPrecio.Text = lector(1)
        End If
        If cbTipoPrecio.SelectedItem.Equals("Precio3") Then
            txtPrecio.Text = lector(2)
        End If
        lector.Close()
    End Sub

    Private Sub rbEfectivo_CheckedChanged(sender As Object, e As EventArgs) Handles rbEfectivo.CheckedChanged
        cbCliente.Enabled = False
        lblVen.Visible = False
        dtpFechaVen.Visible = False
    End Sub

    Private Sub txtDescuento_TextChanged(sender As Object, e As EventArgs) Handles txtDescuento.TextChanged
        Dim contenido As String = txtDescuento.Text
        Dim chars As Integer = 0

        If contenido.Length > 0 Then
            For j = 0 To contenido.Length - 1
                If txtDescuento.Text.Chars(j) = "." Then
                    chars += 1
                End If
            Next
        End If

        If Not txtDescuento.Text.Contains("'") And txtDescuento.TextLength > 0 Then
            If (Not Char.IsNumber(txtDescuento.Text.Chars(txtDescuento.TextLength - 1)) And Not txtDescuento.Text.Chars(txtDescuento.TextLength - 1) = ".") Or chars > 1 Or txtDescuento.Text.Chars(0) = "." Then
                MessageBox.Show("Solo números.")
                txtDescuento.Text = ""
            Else
                If lblImporte.Text.Equals("") Then
                    lblImporte.Text = "00.00"
                End If
                lblSubtotal.Text = lblImporte.Text
                lblSubtotal.Text = CDbl(lblSubtotal.Text) - CDbl(txtDescuento.Text)
                lblIVA.Text = CDbl(lblSubtotal.Text) * 0.16
                lblTotal.Text = CDbl(lblSubtotal.Text) + CDbl(lblIVA.Text)
            End If
        Else
            Dim cadena As String = ""
            For i = 0 To txtDescuento.Text.Length - 2
                cadena += txtDescuento.Text.Chars(i)
            Next
            txtDescuento.Text = cadena
        End If

        If txtDescuento.Text.Length = 0 Then
            lblSubtotal.Text = lblImporte.Text
            lblIVA.Text = CDbl(lblSubtotal.Text) * 0.16
            lblTotal.Text = CDbl(lblSubtotal.Text) + CDbl(lblIVA.Text)
        End If

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim total As Double = lblTotal.Text
        Dim ban As Boolean = True

        If dgAgregar.RowCount <> 0 Then
            ' Iniciar una transacción local
            transaction = connection.BeginTransaction("SampleTransaction")
            'Debe asignar el objeto de la transacción y la conexión
            'A un objeto comando para una transación local pendiente.
            command.Connection = connection
            command.Transaction = transaction
            Try
                If rbCredito.Checked Then
                    Dim saldo As Double = txtSaldo.Text
                    Dim limite As Double = txtLimite.Text

                    If limite < total + saldo Then
                        If Not MsgBox("CUIDADO: El límite de crédito del cliente es de $ " & limite & "  y su saldo sería de $" & total + saldo & ". ¿Desea ejecutar transacción?", MsgBoxStyle.YesNo, "ejecutar") = MsgBoxResult.Yes Then
                            ban = False
                        End If
                    End If

                    If ban Then
                        command.CommandText = "INSERT INTO Ventas VALUES (" & txtIdVenta.Text & "," & txtIdCliente.Text & ",'" & dtpFecha.Value.Date & "','" & dtpFechaVen.Value.Date & "','Credito'," & lblSubtotal.Text & "," & lblIVA.Text & "," & txtDescuento.Text & ",0,0)"
                        command.ExecuteNonQuery()
                        command.CommandText = "UPDATE Clientes SET Saldo += " & lblTotal.Text & " WHERE idCliente = " & txtIdCliente.Text
                        command.ExecuteNonQuery()

                        For x = 0 To dgAgregar.RowCount - 1
                            command.CommandText = "INSERT INTO DetalleVentas VALUES (" & txtIdVenta.Text & "," & dgAgregar.Item(0, x).Value & "," & dgAgregar.Item(3, x).Value & "," & dgAgregar.Item(4, x).Value & ")"
                            command.ExecuteNonQuery()
                            command.CommandText = "UPDATE Productos SET existencia -= " & dgAgregar.Item(3, x).Value & " WHERE idProducto = " & dgAgregar.Item(0, x).Value
                            command.ExecuteNonQuery()
                        Next
                    End If
                Else
                    Dim idCliente As Integer = 1
                    If Not txtIdCliente.Text = "" Then
                        idCliente = txtIdCliente.Text
                    End If
                    command.CommandText = "INSERT INTO Ventas VALUES (" & txtIdVenta.Text & "," & idCliente & ",'" & dtpFecha.Value.Date & "','31-12-9999','Efectivo'," & lblSubtotal.Text & "," & lblIVA.Text & "," & txtDescuento.Text & ",0,0)"
                    command.ExecuteNonQuery()
                    For x = 0 To dgAgregar.RowCount - 1
                        command.CommandText = "INSERT INTO DetalleVentas VALUES (" & txtIdVenta.Text & "," & dgAgregar.Item(0, x).Value & "," & dgAgregar.Item(3, x).Value & "," & dgAgregar.Item(4, x).Value & ")"
                        command.ExecuteNonQuery()
                        command.CommandText = "UPDATE Productos SET existencia -= " & dgAgregar.Item(3, x).Value & " WHERE idProducto = " & dgAgregar.Item(0, x).Value
                        command.ExecuteNonQuery()
                    Next
                End If
                ' Aquí pueden ir n comandos ExecuteNonQuery….
                ' Intenta ejecutar la transacción.
                If MsgBox("¿Desea ejecutar transacción?", MsgBoxStyle.YesNo, "ejecutar") = MsgBoxResult.Yes Then
                    transaction.Commit()
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
                    ' Este bloque de catch manejará los errores
                    ' que pueden ser ocurridos en el servidor y que
                    'podrían causar el rollback tal como una conexión cerrada.
                    MsgBox("Error Rollback")
                End Try
            End Try
            btnAgregar.Enabled = False
            btnGrabar.Enabled = False
            btnNuevo.Enabled = True
            txtCantidad.Enabled = False
            txtDomicilio.Text = ""
            txtTelefono.Text = ""
            txtIdVenta.Text = ""
            txtIdCliente.Text = ""
            txtDescuento.Text = "0.00"
            lblIVA.Text = "0.0"
            lblSubtotal.Text = "0.0"
            lblTotal.Text = "0.0"
            cbCliente.Text = ""
            txtSaldo.Text = ""
            rbEfectivo.Enabled = False
            rbCredito.Enabled = False
            rbEfectivo.Checked = True
            txtDescuento.Enabled = False
            dtpFecha.Enabled = False
            cbProducto.Enabled = False
            cbCliente.Items.Clear()
            cbProducto.Items.Clear()
            dgAgregar.Rows.Clear()
        Else
            MessageBox.Show("Sin datos en rejilla, revise sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Ventas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        connection = cerrarConexion()
        btnAgregar.Enabled = False
        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        txtCantidad.Enabled = False
        txtDomicilio.Text = ""
        txtTelefono.Text = ""
        txtIdCliente.Text = ""
        txtSaldo.Text = ""
        txtIdProducto.Text = ""
        txtCodigoBarras.Text = ""
        txtPrecio.Text = ""
        txtExistencia.Text = ""
        txtCantidad.Text = ""
        txtIdVenta.Text = ""

        txtDescuento.Text = "0.00"
        lblIVA.Text = "0.0"
        lblSubtotal.Text = "0.0"
        lblTotal.Text = "0.0"
        cbCliente.Enabled = False
        rbEfectivo.Enabled = False
        dtpFecha.Enabled = False
        cbProducto.Enabled = False
        txtDescuento.Enabled = False
        lblVen.Visible = False
        dtpFechaVen.Visible = False
        rbCredito.Enabled = False
        rbEfectivo.Checked = True
        cbCliente.Items.Clear()
        cbProducto.Items.Clear()
        dgAgregar.Rows.Clear()
    End Sub

    Private Sub Ventas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
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
        ElseIf e.KeyChar = "." And Not txtCantidad.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        dtpFechaVen.Value = Now.AddDays(30)
    End Sub

End Class
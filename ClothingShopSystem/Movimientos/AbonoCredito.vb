Imports System.Data.SqlClient

Public Class AbonoCredito
    Dim connection = openConnection()
    Dim command As SqlCommand = connection.CreateCommand()
    Dim transaction As SqlTransaction
    Dim lector As SqlDataReader

    Private Sub AbonoCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()
    End Sub

    Private Sub llenarClientes()
        command.CommandText = "SELECT nombre FROM Clientes where idCliente > 1"
        lector = command.ExecuteReader

        While lector.Read
            cbCliente.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub dgAgregar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAgregar.CellClick
        If e.ColumnIndex = 5 Then
            Dim idVenta As Integer = dgAgregar.CurrentRow.Cells(0).Value
            ConsultaVentaAbono.txtIdVenta.Text = idVenta
            command.CommandText = "SELECT Ventas.fecha, Ventas.fechaVencimiento, Ventas.subtotal, Ventas.iva, Ventas.descuento, Ventas.abonado, Clientes.idCliente, Clientes.nombre, Clientes.telefono, Clientes.domicilio, Clientes.saldo  FROM Ventas inner join Clientes on Clientes.idCliente = Ventas.idCliente WHERE estado = 0 and idVenta = " & idVenta & ""
            lector = command.ExecuteReader
            If lector.Read() Then
                ConsultaVentaAbono.dtpFecha.Value = lector(0)
                ConsultaVentaAbono.dtpFechaVen.Value = lector(1)
                ConsultaVentaAbono.lblSubtotal.Text = lector(2)
                ConsultaVentaAbono.lblIVA.Text = lector(3)
                ConsultaVentaAbono.lblDescuento.Text = lector(4)
                ConsultaVentaAbono.lblAbonado.Text = lector(5)
                ConsultaVentaAbono.txtIdCliente.Text = lector(6)
                ConsultaVentaAbono.txtCliente.Text = lector(7)
                ConsultaVentaAbono.txtTelefono.Text = lector(8).ToString
                ConsultaVentaAbono.txtDomicilio.Text = lector(9).ToString
                ConsultaVentaAbono.txtSaldo.Text = lector(10)
                ConsultaVentaAbono.lblTotal.Text = CDbl(ConsultaVentaAbono.lblSubtotal.Text) + CDbl(ConsultaVentaAbono.lblIVA.Text)
                ConsultaVentaAbono.lblDeuda.Text = CDbl(ConsultaVentaAbono.lblTotal.Text) - CDbl(ConsultaVentaAbono.lblAbonado.Text)
                lector.Close()
                ConsultaVentaAbono.dgAgregar.Rows.Clear()
                Dim importe As Double
                command.CommandText = "SELECT DetalleVentas.idProducto, DetalleVentas.cantidad, DetalleVentas.precio, Productos.nombre, Productos.codigoBarras FROM DetalleVentas inner join Productos on DetalleVentas.idProducto = Productos.idProducto WHERE idVenta = " & idVenta & ""
                lector = command.ExecuteReader
                While lector.Read
                    importe = lector(1) * lector(2)
                    ConsultaVentaAbono.dgAgregar.Rows.Add(lector(0), lector(3), lector(4), lector(1), lector(2), importe)
                End While
                ConsultaVentaAbono.ShowDialog()
            Else
                MsgBox("La venta fue cancelada")
            End If
            lector.Close()

        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        command.CommandText = "SELECT COUNT(*) FROM AbonosCreditos"
        txtIdAbo.Text = command.ExecuteScalar + 1

        btnGrabar.Enabled = True
        btnNuevo.Enabled = False
        cbVentas.Enabled = True
        dtpFecha.Text = Now.Date
        dtpFecha.Enabled = True
        'txtCodigoBarras.Enabled = True
        llenarClientes()
        cbCliente.Enabled = True
    End Sub

    Private Sub cbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCliente.SelectedIndexChanged
        command.CommandText = "SELECT idCliente, telefono, domicilio, saldo FROM Clientes WHERE nombre = '" & cbCliente.Text & "'"
        lector = command.ExecuteReader
        lector.Read()

        txtIdCliente.Text = lector(0)
        txtTelefono.Text = lector(1).ToString
        txtDomicilio.Text = lector(2).ToString
        txtSaldo.Text = lector(3).ToString
        lector.Close()

        lblDeuda.Text = txtSaldo.Text

        llenarVentas()
    End Sub

    Private Sub llenarVentas()
        cbVentas.Items.Clear()
        dgAgregar.Rows.Clear()
        command.CommandText = "SELECT idVenta, fecha, fechaVencimiento, subtotal + iva, subtotal + iva - abonado FROM Ventas WHERE idCliente = " & txtIdCliente.Text & " and (abonado < subtotal + iva - descuento)"
        lector = command.ExecuteReader
        While lector.Read()
            dgAgregar.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), "Ver")
        End While
        lector.Close()

        For x = 0 To dgAgregar.RowCount - 1
            cbVentas.Items.Add(dgAgregar.Item(0, x).Value)
        Next
    End Sub

    Private Sub cbVentas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVentas.SelectedIndexChanged
        txtImporte.Enabled = True
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        command.CommandText = "SELECT subtotal + iva - abonado FROM Ventas WHERE idVenta = " & cbVentas.Text & ""
        lector = command.ExecuteReader
        lector.Read()
        If lector(0) >= CDbl(txtImporte.Text) Then
            lector.Close()
            ' Iniciar una transacción local
            transaction = connection.BeginTransaction("SampleTransaction")
            'Debe asignar el objeto de la transacción y la conexión
            'A un objeto comando para una transación local pendiente.
            command.Connection = connection
            command.Transaction = transaction
            Try
                command.CommandText = "INSERT INTO AbonosCreditos VALUES (" & txtIdAbo.Text & "," & cbVentas.Text & ",'" & dtpFecha.Value.Date & "'," & txtImporte.Text & ")"
                command.ExecuteNonQuery()

                command.CommandText = "UPDATE Ventas SET abonado += " & txtImporte.Text & " where idVenta = " & cbVentas.Text & ""
                command.ExecuteNonQuery()

                command.CommandText = "UPDATE Clientes SET saldo -= " & txtImporte.Text & " where idCliente = " & txtIdCliente.Text & ""
                command.ExecuteNonQuery()

                ' Aquí pueden ir n comandos ExecuteNonQuery….
                ' Intenta ejecutar la transacción.
                If MsgBox("¿Desea ejecutar transacción?", MsgBoxStyle.YesNo, "ejecutar") = MsgBoxResult.Yes Then
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
                    ' Este bloque de catch manejará los errores
                    ' que pueden ser ocurridos en el servidor y que
                    'podrían causar el rollback tal como una conexión cerrada.
                    MsgBox("Error Rollback")
                End Try
            End Try

            btnGrabar.Enabled = False
            btnNuevo.Enabled = True
            dtpFecha.Enabled = False
            cbVentas.Enabled = False
            txtImporte.Enabled = False
            cbCliente.Enabled = False
            txtDomicilio.Text = ""
            txtTelefono.Text = ""
            txtIdCliente.Text = ""
            txtSaldo.Text = ""
            txtIdAbo.Text = ""
            txtImporte.Text = ""
            lblDeuda.Text = "00.00"
            cbVentas.Items.Clear()
            dgAgregar.Rows.Clear()
            cbCliente.Items.Clear()
        Else
            lector.Close()
            MsgBox("El abono es mayor a la deuda de la venta")
        End If
    End Sub

    Private Sub AbonoCredito_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        connection = cerrarConexion()
        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        dtpFecha.Enabled = False
        cbVentas.Enabled = False
        cbCliente.Enabled = False
        txtImporte.Enabled = False
        txtDomicilio.Text = ""
        txtTelefono.Text = ""
        txtIdCliente.Text = ""
        txtSaldo.Text = ""
        txtIdAbo.Text = ""
        txtImporte.Text = ""
        lblDeuda.Text = "00.00"
        cbVentas.Items.Clear()
        dgAgregar.Rows.Clear()
        cbCliente.Items.Clear()
    End Sub

    Private Sub txtImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporte.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtImporte.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
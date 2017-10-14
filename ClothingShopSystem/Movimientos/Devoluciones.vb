Imports System.Data.SqlClient
Public Class Devoluciones
    Dim connection = openConnection()
    Dim command As SqlCommand = connection.CreateCommand()
    Dim lector As SqlDataReader
    Dim transaction As SqlTransaction

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        command.CommandText = "SELECT COUNT(*) FROM Devoluciones"
        txtIdDevolucion.Text = command.ExecuteScalar() + 1
        txtIdVenta.Enabled = True
        txtConcepto.Enabled = True
        btnNuevo.Enabled = False
        btnGrabar.Enabled = True

    End Sub

    Private Sub Devoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.open
    End Sub

    Private Sub txtIdVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdVenta.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtIdVenta.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            command.CommandText = "SELECT fecha, subtotal, descuento, iva FROM Ventas where estado = 0 and condicion = 'Efectivo' and idVenta = " & txtIdVenta.Text & ""
            lector = command.ExecuteReader
            If lector.Read() Then
                dtpFecha.Value = lector(0).ToString
                lblSubtotal.Text = lector(1).ToString
                lblDescuento.Text = lector(2).ToString
                lblIVA.Text = lector(3).ToString
                lector.Close()
                lblTotal.Text = CDbl(lblSubtotal.Text) + CDbl(lblIVA.Text)
                dgAgregar.Rows.Clear()
                command.CommandText = "SELECT DetalleVentas.idProducto, Productos.codigoBarras, Productos.nombre, DetalleVentas.cantidad, DetalleVentas.precio FROM DetalleVentas inner join Productos on DetalleVentas.idProducto = Productos.idProducto WHERE idVenta = " & txtIdVenta.Text & ""
                lector = command.ExecuteReader
                While lector.Read
                    dgAgregar.Rows.Add(lector(0).ToString, lector(1).ToString, lector(2).ToString, lector(3).ToString, lector(4).ToString, (lector(3) * lector(4).ToString))
                End While
            Else
                MsgBox("No existe esa venta")
            End If
            lector.Close()
        End If
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        transaction = connection.BeginTransaction("SampleTransaction")

        command.Connection = connection
        command.Transaction = transaction
        Try
            command.CommandText = "update Ventas set estado = 1 where idVenta = " & txtIdVenta.Text & ""
            command.ExecuteNonQuery()

            command.CommandText = "insert into Devoluciones values(" & txtIdDevolucion.Text & ", " & txtIdVenta.Text & ", '" & txtConcepto.Text & "', '" & dtpFechaD.Value.Date & "')"
            command.ExecuteNonQuery()

            For x = 0 To dgAgregar.RowCount - 1
                command.CommandText = "UPDATE Productos SET existencia += " & dgAgregar.Item(3, x).Value & " WHERE idProducto = " & dgAgregar.Item(0, x).Value
                command.ExecuteNonQuery()
            Next

            If MsgBox("¿Desea ejecutar la devolución?", MsgBoxStyle.YesNo, "ejecutar") = MsgBoxResult.Yes Then
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
                MsgBox("Error Rollback")
            End Try
        End Try
        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        dtpFechaD.Enabled = False
        txtIdVenta.Text = ""
        txtConcepto.Text = ""
        txtIdDevolucion.Text = ""
        txtConcepto.Enabled = False
        txtIdDevolucion.Enabled = False
        txtIdVenta.Enabled = False
        lblDescuento.Text = "00.00"
        lblIVA.Text = "00.00"
        lblSubtotal.Text = "00.00"
        lblTotal.Text = "00.00"
        dgAgregar.Rows.Clear()
    End Sub

    Private Sub Devoluciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        connection = cerrarConexion()
        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        dtpFechaD.Enabled = False
        txtIdVenta.Text = ""
        txtConcepto.Text = ""
        txtIdDevolucion.Text = ""
        txtConcepto.Enabled = False
        txtIdDevolucion.Enabled = False
        txtIdVenta.Enabled = False
        lblDescuento.Text = "00.00"
        lblIVA.Text = "00.00"
        lblSubtotal.Text = "00.00"
        lblTotal.Text = "00.00"
        dgAgregar.Rows.Clear()

    End Sub
End Class
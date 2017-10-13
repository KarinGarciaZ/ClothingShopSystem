Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class frmAbonosApartados
    Dim conexion As SqlConnection = openConnection()
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim transaccion As SqlTransaction
    Private Sub frmAbonosApartados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando.CommandText = "SELECT nombre FROM Clientes where idCliente > 1"
        lector = comando.ExecuteReader()

        While lector.Read
            cbClientes.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub frmAbonosApartados_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        conexion = cerrarConexion()
        btnGrabar.Enabled = False
        btnNuevo.Enabled = True

        txtAbono.Enabled = False
        txtAbono.Text = "00.00"
        txtIdApartado.Text = ""
        txtFechaVencimiento.Text = ""
        txtFecha.Text = ""
        txtAbonos.Text = ""

        txtIdAbonoApartado.Text = ""

        lblTotal.Text = "00.00"
        lblRestante.Text = "00.00"
        dgAgregar.Rows.Clear()
        cbClientes.Enabled = False
        cbApartados.Enabled = False
        cbApartados.Visible = False
        Label2.Visible = False
        cbClientes.Items.Clear()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        comando.CommandText = "SELECT COUNT(*) FROM AbonosApartados"
        txtIdAbonoApartado.Text = comando.ExecuteScalar + 1

        cbClientes.Enabled = True
        dtpFecha.Value = Now.Date
        txtAbono.Enabled = True
        btnGrabar.Enabled = True
        btnNuevo.Enabled = False
    End Sub

    Private Sub cbApartados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbApartados.SelectedIndexChanged
        dgAgregar.Rows.Clear()

        Dim importe As Double = 0
        Dim restante As Double
        txtIdApartado.Text = cbApartados.Text

        comando.CommandText = "SELECT fecha, fechaVencimiento, abono, total FROM Apartados WHERE idApartado = " & txtIdApartado.Text
        lector = comando.ExecuteReader

        lector.Read()
        txtFecha.Text = CDate(lector(0))
        txtFechaVencimiento.Text = CDate(lector(1))
        txtAbonos.Text = lector(2)
        lblTotal.Text = lector(3)

        restante = CDbl(lector(3)) - CDbl(lector(2))
        lector.Close()

        comando.CommandText = "SELECT DetalleApartados.idProducto, Productos.nombre, Productos.codigoBarras, DetalleApartados.cantidad, DetalleApartados.precio FROM DetalleApartados inner join Productos on Productos.idProducto = DetalleApartados.idProducto WHERE DetalleApartados.idApartado = " & txtIdApartado.Text
        lector = comando.ExecuteReader

        While lector.Read
            importe = CDbl(lector(3)) * CDbl(lector(4))
            dgAgregar.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), importe)
        End While
        lector.Close()

        lblRestante.Text = restante
    End Sub

    Private Sub cbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClientes.SelectedIndexChanged
        cbApartados.Items.Clear()
        comando.CommandText = "SELECT idApartado FROM Apartados inner join Clientes on Clientes.idCliente = Apartados.idCliente WHERE Clientes.nombre = '" & cbClientes.Text & "'"
        lector = comando.ExecuteReader

        While lector.Read
            cbApartados.Items.Add(lector(0))
        End While
        lector.Close()

        cbApartados.Visible = True
        Label2.Visible = True
        cbApartados.Enabled = True
    End Sub

    Private Sub txtAbono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAbono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtAbono.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        ' Iniciar una transacción local
        transaccion = conexion.BeginTransaction("SampleTransaction")
        'Debe asignar el objeto de la transacción y la conexión
        'A un objeto comando para una transación local pendiente.
        comando.Connection = conexion
        comando.Transaction = transaccion
        Try
            comando.CommandText = "INSERT INTO AbonosApartados VALUES (" & txtIdAbonoApartado.Text & "," & txtIdApartado.Text & ",'" & dtpFecha.Value.Date & "'," & txtAbono.Text & ")"
            comando.ExecuteNonQuery()

            comando.CommandText = "UPDATE Apartados SET abono = abono + " & txtAbono.Text & "WHERE idApartado = " & txtIdApartado.Text
            comando.ExecuteNonQuery()

            If Date.Compare(dtpFecha.Value, CDate(txtFechaVencimiento.Text)) = 1 Then
                MessageBox.Show("¡Se ha pasado de la fecha de limite! Se le aumentará un 7%", "Fecha de Vencimiento", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Dim total As Double

                total = CDbl(lblTotal.Text) * 0.17
                comando.CommandText = "UPDATE Apartados SET total = total + " & total
            End If

            If MsgBox("¿Desea ejecutar abonar $" & txtAbono.Text & "?", MsgBoxStyle.YesNo, "ejecutar") = MsgBoxResult.Yes Then
                transaccion.Commit()
                MsgBox("¡Abonado!")
            Else
                transaccion.Rollback()
                MsgBox("Transacción cancelada")
                dgAgregar.Rows.Clear()
            End If
        Catch ex As Exception
            MsgBox("Commit Exception Type: {0}no se pudo insertar por error")
            Try
                transaccion.Rollback()
            Catch ex2 As Exception
                ' Este bloque de catch manejará los errores
                ' que pueden ser ocurridos en el servidor y que
                'podrían causar el rollback tal como una conexión cerrada.
                MsgBox("Error Rollback")
            End Try
        End Try

        btnGrabar.Enabled = False
        btnNuevo.Enabled = True

        txtAbono.Enabled = False
        txtAbono.Text = "00.00"
        txtIdApartado.Text = ""
        txtFechaVencimiento.Text = ""
        txtFecha.Text = ""
        txtAbonos.Text = ""

        txtIdAbonoApartado.Text = ""

        lblTotal.Text = "00.00"
        lblRestante.Text = "00.00"
        dgAgregar.Rows.Clear()
        cbClientes.Enabled = False
        cbApartados.Enabled = False
        cbApartados.Visible = False
        Label2.Visible = False
    End Sub
End Class
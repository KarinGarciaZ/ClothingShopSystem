Imports System.Data.SqlClient
Public Class Compras
    Dim connection = openConnection()
    Dim command As SqlCommand = connection.CreateCommand()
    Dim transaction As SqlTransaction
    Dim lector As SqlDataReader

    Dim conexionBitacora = OpenBitacora()
    Dim BitacoraComando As SqlCommand = conexionBitacora.CreateCommand()

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            command.CommandText = "select IDENT_CURRENT ('Compras')"
            txtIdCompra.Text = command.ExecuteScalar + 1

            btnGrabar.Enabled = True
            btnNuevo.Enabled = False
            dtpFecha.Text = Now.Date
            txtFactura.Enabled = True
            cbProveedores.Enabled = True
            dtpFecha.Enabled = True

            cbProducto.Enabled = True
            txtCostoNuevo.Enabled = True
            txtCantidad.Enabled = True
            btnAgregar.Enabled = True
        Catch ex As Exception
            MsgBox("Error en el botón Nuevo")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(3, '" & errMessage & "', 'Compras.Nuevo','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.Open()
            conexionBitacora.open()

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

        Catch ex As Exception
            MsgBox("Error al iniciar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(9, '" & errMessage & "', 'Compras.Load','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"

            BitacoraComando.ExecuteNonQuery()
        End Try

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            If dgAgregar.RowCount <> 0 Then
                ' Iniciar una transacción local
                transaction = connection.BeginTransaction("SampleTransaction")

                command.Connection = connection
                command.Transaction = transaction
                Try
                    command.CommandText = "INSERT INTO Compras VALUES (" & txtIdProveedor.Text & ",'" & dtpFecha.Value.Date & "','" & txtFactura.Text & "'," & lblTotal.Text & ")"
                    command.ExecuteNonQuery()

                    For x = 0 To dgAgregar.RowCount - 1
                        command.CommandText = "INSERT INTO DetalleCompras VALUES (" & txtIdCompra.Text & "," & dgAgregar.Item(0, x).Value & "," & dgAgregar.Item(3, x).Value & "," & dgAgregar.Item(4, x).Value & ")"
                        command.ExecuteNonQuery()

                        command.CommandText = "UPDATE Productos SET costo = " & dgAgregar.Item(4, x).Value & ", existencia = existencia + " & dgAgregar.Item(3, x).Value & ", ultimaFechaCompra = '" & dtpFecha.Value & "' WHERE idProducto = " & dgAgregar.Item(0, x).Value
                        command.ExecuteNonQuery()
                    Next

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
            Else
                MessageBox.Show("Sin datos en rejilla, revise sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox("Error Grabar")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(7, '" & errMessage & "', 'Compras.Grabar','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
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
    End Sub

    Private Sub cbProveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProveedores.SelectedIndexChanged
        Try
            command.CommandText = "SELECT idProveedor, telefono, domicilio FROM Proveedores WHERE nombre = '" & cbProveedores.Text & "'"
            lector = command.ExecuteReader
            lector.Read()

            txtIdProveedor.Text = lector(0)
            txtTelefono.Text = lector(1).ToString
            txtDomicilio.Text = lector(2).ToString

            lector.Close()
        Catch ex As Exception
            MsgBox("Error cargar proveedor")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(10, '" & errMessage & "', 'Compras.ProveedorSelectChanged','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub cbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProducto.SelectedIndexChanged
        Try
            command.CommandText = "SELECT idProducto, codigoBarras, costo, existencia, ultimaFechaCompra FROM Productos WHERE nombre = '" & cbProducto.Text & "'"
            lector = command.ExecuteReader
            lector.Read()

            txtIdProducto.Text = lector(0)
            txtCodigoBarras.Text = lector(1).ToString
            txtCosto.Text = lector(2).ToString
            txtExistencia.Text = lector(3).ToString
            dtpUltimaCompra.Text = lector(4).ToString
            lector.Close()
        Catch ex As Exception
            MsgBox("Error cargar Producto")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(11, '" & errMessage & "', 'Compras.ProductoSelectChanged','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
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
        Try
            connection = cerrarConexion()
            conexionBitacora = cerrarBitacora()
        Catch ex As Exception
            MsgBox("Error al cerrar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(8, '" & errMessage & "', 'Compras.FormClosing','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try

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
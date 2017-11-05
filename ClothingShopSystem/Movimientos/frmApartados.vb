Imports System.Data.SqlClient
Public Class frmApartados
    Dim conexion = openConnection()
    Dim comando As SqlCommand = conexion.CreateCommand()
    Dim lector As SqlDataReader
    Dim transaction As SqlTransaction

    Dim conexionBitacora = OpenBitacora()
    Dim BitacoraComando As SqlCommand = conexionBitacora.CreateCommand()
    Private Sub frmApartados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionBitacora.open()
            conexion.open()

            comando.CommandText = "SELECT nombre FROM Clientes where idCliente > 1"
            lector = comando.ExecuteReader
            While lector.Read
                cbClientes.Items.Add(lector(0))
            End While
            lector.Close()

            comando.CommandText = "SELECT nombre FROM Productos"
            lector = comando.ExecuteReader
            While lector.Read
                cbProducto.Items.Add(lector(0))
            End While
            lector.Close()
        Catch ex As Exception
            MsgBox("Error al iniciar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(9, '" & errMessage & "', 'Apartados.Load','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try

        dtpFecha.Value = Now.Date
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dtpFecha.Value = Now.Date
        dtpFechaVencimiento.Value = Now.AddDays(30)
        cbClientes.Enabled = True
        cbProducto.Enabled = True

        Try
            comando.CommandText = "SELECT COUNT(*) FROM Apartados"
            txtIdApartado.Text = comando.ExecuteScalar() + 1
        Catch ex As Exception
            MsgBox("Error en el botón Nuevo")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(3, '" & errMessage & "', 'Apartados.Nuevo','" & Now.Date & "', 44, '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try

        txtCantidad.Enabled = True
        btnGrabar.Enabled = True
        btnAgregar.Enabled = True
        btnNuevo.Enabled = False
    End Sub

    Private Sub cbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProducto.SelectedIndexChanged
        Try
            comando.CommandText = "SELECT Productos.idProducto, Productos.codigoBarras, Tipos.nombre, Categorias.nombre, Marcas.nombre, Productos.costo, Productos.existencia FROM Productos inner join Tipos on Tipos.idTipo = Productos.idTipo inner join Categorias on Categorias.idCategoria = Productos.idCategoria inner join Marcas on Marcas.idMarca = Productos.idMarca WHERE Productos.nombre = '" & cbProducto.Text & "'"
            lector = comando.ExecuteReader
            lector.Read()

            txtIdProducto.Text = lector(0)
            txtCodigoBarras.Text = lector(1).ToString
            txtTipo.Text = lector(2).ToString
            txtCategoria.Text = lector(3).ToString
            txtMarca.Text = lector(4).ToString
            txtCosto.Text = lector(5).ToString
            txtExistencia.Text = lector(6).ToString

            lector.Close()
        Catch ex As Exception
            MsgBox("Error seleccionar producto")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(11, '" & errMessage & "', 'Apartados.ProductoSelectedIndexChanged','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim id As Integer = Val(txtIdProducto.Text)
        Dim cantidad As Integer = txtCantidad.Text
        Dim costo As Double = CDbl(txtCosto.Text)
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
            dgAgregar.Item(5, y).Value = dgAgregar.Item(3, y).Value * costo
        End If

        For i = 0 To dgAgregar.RowCount - 1
            importe = importe + dgAgregar.Item(5, i).Value
        Next

        lblTotal.Text = importe

        txtCantidad.Text = ""
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

    Private Sub frmApartados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            conexion = cerrarConexion()
            conexionBitacora = cerrarBitacora()
        Catch ex As Exception
            MsgBox("Error al cerrar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(8, '" & errMessage & "', 'Apartado.FormClosing','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try

        btnAgregar.Enabled = False
        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        txtCantidad.Text = ""
        txtCodigoBarras.Text = ""
        txtCosto.Text = ""
        txtDomicilio.Text = ""
        txtMarca.Text = ""
        txtTipo.Text = ""
        txtCategoria.Text = ""
        txtColonia.Text = ""
        txtExistencia.Text = ""
        dtpFechaVencimiento.Value = Now.Date
        txtIdApartado.Text = ""
        txtIdProducto.Text = ""
        txtIdCliente.Text = ""
        txtTelefono.Text = ""
        lblTotal.Text = "0.0"
        cbClientes.Text = ""
        cbProducto.Text = ""
        cbProducto.Items.Clear()
        cbClientes.Items.Clear()
        dgAgregar.Rows.Clear()
        dtpFecha.Enabled = False
        cbProducto.Enabled = False
        cbClientes.Enabled = False
        txtCantidad.Enabled = False
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            transaction = conexion.BeginTransaction("SampleTransaction")

            comando.Connection = conexion
            comando.Transaction = transaction
            Try
                comando.CommandText = "INSERT INTO Apartados VALUES (" & txtIdApartado.Text & "," & txtIdCliente.Text & "," & CDbl(lblTotal.Text) & ", 0.0 ,'" & dtpFecha.Value & "','" & dtpFechaVencimiento.Value.Date & "')"
                comando.ExecuteNonQuery()

                For x = 0 To dgAgregar.RowCount - 1
                    comando.CommandText = "INSERT INTO DetalleApartados VALUES (" & txtIdApartado.Text & "," & dgAgregar.Item(0, x).Value & "," & dgAgregar.Item(3, x).Value & "," & dgAgregar.Item(4, x).Value & ")"
                    comando.ExecuteNonQuery()

                    comando.CommandText = "UPDATE Productos SET apartados = apartados + " & dgAgregar.Item(3, x).Value & " WHERE idProducto = " & dgAgregar.Item(0, x).Value
                    comando.ExecuteNonQuery()
                Next

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
                    MsgBox("Error Rollback")
                End Try
            End Try
        Catch ex As Exception
            MsgBox("Error Grabar")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(7, '" & errMessage & "', 'Apartados.Grabar','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try

        btnAgregar.Enabled = False
        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        txtCantidad.Enabled = False
        txtCantidad.Text = ""
        txtCodigoBarras.Text = ""
        txtMarca.Text = ""
        txtTipo.Text = ""
        txtCategoria.Text = ""
        txtCosto.Text = ""
        txtExistencia.Text = ""

        txtColonia.Text = ""
        txtDomicilio.Text = ""

        dtpFechaVencimiento.Text = Now.Date
        dtpFecha.Value = Now.Date
        txtIdApartado.Text = ""
        txtIdProducto.Text = ""
        txtIdCliente.Text = ""
        txtTelefono.Text = ""
        lblTotal.Text = "0.0"
        dgAgregar.Rows.Clear()
        cbProducto.Enabled = False
        cbClientes.Enabled = False
    End Sub

    Private Sub cbClientes_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbClientes.SelectedIndexChanged
        Try
            comando.CommandText = "SELECT * FROM Clientes WHERE nombre = '" & cbClientes.Text & "'"
            lector = comando.ExecuteReader
            lector.Read()

            txtIdCliente.Text = lector(0)
            txtDomicilio.Text = lector(2)
            txtColonia.Text = lector(3)
            txtTelefono.Text = lector(6)

            lector.Close()
        Catch ex As Exception
            MsgBox("Error seleccionar cliente")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(4, '" & errMessage & "', 'Apartados.ClienteSelectedIndexChanged','" & Now.Date & "'," & Err.Number & ", '" & moduloUsuario & "')"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub
End Class
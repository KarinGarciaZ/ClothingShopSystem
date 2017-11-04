Imports System.Data.SqlClient
Public Class ConsultaProductos
    Dim connection = openConnection()
    Dim command As SqlCommand = connection.CreateCommand()
    Dim lector As SqlDataReader

    Dim conexionBitacora = OpenBitacora()
    Dim BitacoraComando As SqlCommand = conexionBitacora.CreateCommand()
    Private Sub ConsultaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionBitacora.Open
            connection.open

            command.CommandText = "SELECT idProducto, nombre, existencia, Precio1, Precio2, Precio3, codigoBarras, ultimaFechaCompra from Productos"
            lector = command.ExecuteReader
            dgAgregar.Rows.Clear()
            While lector.Read()
                dgAgregar.Rows.Add(lector(0).ToString, lector(1).ToString, lector(2).ToString, lector(3).ToString, lector(4).ToString, lector(5).ToString, lector(6).ToString, lector(7).ToString)
            End While
            lector.Close()

            command.CommandText = "SELECT nombre FROM Categorias where idCategoria > 0"
            lector = command.ExecuteReader

            While lector.Read
                cbCategoria.Items.Add(lector(0).ToString)
            End While
            lector.Close()

            command.CommandText = "SELECT nombre FROM Tipos where idTipo > 0"
            lector = command.ExecuteReader

            While lector.Read
                cbTipo.Items.Add(lector(0).ToString)
            End While
            lector.Close()

            command.CommandText = "SELECT nombre FROM Marcas where idMarca > 0"
            lector = command.ExecuteReader

            While lector.Read
                cbMarca.Items.Add(lector(0).ToString)
            End While
            lector.Close()
        Catch ex As Exception
            MsgBox("Error al iniciar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(9, '" & errMessage & "', 'ConsultaProductos.Load','" & Now.Date & "'," & Err.Number & ")"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub txtBarras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBarras.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                command.CommandText = "SELECT nombre, existencia, Precio1, Precio2, Precio3, codigoBarras, ultimaFechaCompra, idProducto FROM Productos WHERE codigoBarras = '" & txtBarras.Text & "'"
                lector = command.ExecuteReader
                If lector.Read() Then
                    dgAgregar.Rows.Clear()
                    txtBarras.Text = ""
                    dgAgregar.Rows.Add(lector(7).ToString, lector(0).ToString, lector(1).ToString, lector(2).ToString, lector(3).ToString, lector(4).ToString, lector(5).ToString, lector(6).ToString)
                Else
                    MsgBox("No existe este producto")
                End If
                lector.Close()
            End If
        Catch ex As Exception
            MsgBox("Error buscar codigo barra")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(16, '" & errMessage & "', 'ConsultaProductos.txtBarras_KeyPress','" & Now.Date & "'," & Err.Number & ")"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub txtIdProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdProducto.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                command.CommandText = "SELECT nombre, existencia, Precio1, Precio2, Precio3, codigoBarras, ultimaFechaCompra FROM Productos WHERE idProducto = " & txtIdProducto.Text & ""
                lector = command.ExecuteReader
                If lector.Read() Then
                    dgAgregar.Rows.Clear()
                    dgAgregar.Rows.Add(txtIdProducto.Text, lector(0).ToString, lector(1).ToString, lector(2).ToString, lector(3).ToString, lector(4).ToString, lector(5).ToString, lector(6).ToString)
                    txtIdProducto.Text = ""
                Else
                    MsgBox("No existe este producto")
                End If
                lector.Close()
            End If
        Catch ex As Exception
            MsgBox("Error buscar idProducto")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(22, '" & errMessage & "', 'ConsultaProductos.txtIdProducto_KeyPress','" & Now.Date & "'," & Err.Number & ")"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub ConsultaProductos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        dgAgregar.Rows.Clear()
        cbCategoria.Items.Clear()
        cbMarca.Items.Clear()
        cbTipo.Items.Clear()
        Try
            connection = cerrarConexion()
            conexionBitacora = cerrarBitacora()
        Catch ex As Exception
            MsgBox("Error al cerrar la conexión")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(8, '" & errMessage & "', 'ConsultaCompras.FormClosing','" & Now.Date & "'," & Err.Number & ")"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        dgAgregar.Rows.Clear()

        Try
            command.CommandText = "SELECT nombre, existencia, Precio1, Precio2, Precio3, codigoBarras, ultimaFechaCompra, idProducto FROM Productos WHERE nombre like '%" & txtNombre.Text & "%'"
            lector = command.ExecuteReader
            While lector.Read()
                dgAgregar.Rows.Add(lector(7).ToString, lector(0).ToString, lector(1).ToString, lector(2).ToString, lector(3).ToString, lector(4).ToString, lector(5).ToString, lector(6).ToString)
            End While
            lector.Close()
        Catch ex As Exception
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(11, '" & errMessage & "', 'ConsultaProductos.txtNombre_TextChanged','" & Now.Date & "'," & Err.Number & ")"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub cbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMarca.SelectedIndexChanged
        dgAgregar.Rows.Clear()

        Try
            command.CommandText = "SELECT Productos.nombre, existencia, Precio1, Precio2, Precio3, codigoBarras, ultimaFechaCompra, idProducto FROM Marcas inner join Productos on Productos.idMarca = Marcas.idMarca WHERE Marcas.nombre = '" & cbMarca.Text & "'"
            lector = command.ExecuteReader
            While lector.Read()
                dgAgregar.Rows.Add(lector(7).ToString, lector(0).ToString, lector(1).ToString, lector(2).ToString, lector(3).ToString, lector(4).ToString, lector(5).ToString, lector(6).ToString)
            End While
            lector.Close()
        Catch ex As Exception
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(11, '" & errMessage & "', 'ConsultaProductos.cbMarca_SelectedIndexChanged','" & Now.Date & "'," & Err.Number & ")"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub cbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipo.SelectedIndexChanged
        dgAgregar.Rows.Clear()

        Try
            command.CommandText = "SELECT Productos.nombre, existencia, Precio1, Precio2, Precio3, codigoBarras, ultimaFechaCompra, idProducto FROM Tipos inner join Productos on Productos.idTipo = Tipos.idTipo WHERE Tipos.nombre = '" & cbTipo.Text & "'"
            lector = command.ExecuteReader
            While lector.Read()
                dgAgregar.Rows.Add(lector(7).ToString, lector(0).ToString, lector(1).ToString, lector(2).ToString, lector(3).ToString, lector(4).ToString, lector(5).ToString, lector(6).ToString)
            End While
            lector.Close()
        Catch ex As Exception
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(11, '" & errMessage & "', 'ConsultaProductos.cbTipo_SelectedIndexChanged','" & Now.Date & "'," & Err.Number & ")"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

    Private Sub cbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoria.SelectedIndexChanged
        dgAgregar.Rows.Clear()

        Try
            command.CommandText = "SELECT Productos.nombre, existencia, Precio1, Precio2, Precio3, codigoBarras, ultimaFechaCompra, idProducto FROM Categorias inner join Productos  on Productos.idCategoria = Categorias.idCategoria WHERE Categorias.nombre = '" & cbCategoria.Text & "'"
            lector = command.ExecuteReader
            While lector.Read()
                dgAgregar.Rows.Add(lector(7).ToString, lector(0).ToString, lector(1).ToString, lector(2).ToString, lector(3).ToString, lector(4).ToString, lector(5).ToString, lector(6).ToString)
            End While
            lector.Close()
        Catch ex As Exception
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "INSERT INTO bitacora VALUES(11, '" & errMessage & "', 'ConsultaProductos.cbCategoria_SelectedIndexChanged','" & Now.Date & "'," & Err.Number & ")"
            BitacoraComando.ExecuteNonQuery()
        End Try
    End Sub

End Class
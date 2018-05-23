Imports System.Data.SqlClient
Public Class ExportarExcel

    Dim connection = openConnection()
    Dim command As SqlCommand = connection.CreateCommand()
    Dim transaction As SqlTransaction
    Dim lector As SqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        llenarExcel(DataGridView1)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Dim coli As New DataGridViewTextBoxColumn
            coli.DataPropertyName = "ID"
            coli.HeaderText = "ID"
            coli.Name = "ID"
            DataGridView1.Columns.Add(coli)
            command.CommandText = "SELECT idProducto from Productos"
            lector = command.ExecuteReader
            'Dim cont As Integer = 0
            While lector.Read
                'DataGridView1.Rows(cont).Cells(DataGridView1.ColumnCount - 1) = lector(0)
                'cont = cont + 1
                DataGridView1.Rows.Add(lector(0))
            End While
            lector.Close()
            CheckBox1.Enabled = False
        End If
    End Sub

    Private Sub ExportarExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Dim coli As New DataGridViewTextBoxColumn
            coli.DataPropertyName = "Nombre"
            coli.HeaderText = "Nombre"
            coli.Name = "Nombre"
            DataGridView1.Columns.Add(coli)
            command.CommandText = "SELECT nombre from Productos"
            lector = command.ExecuteReader
            Dim cont As Integer = 0
            While lector.Read
                DataGridView1.Rows(cont).Cells(DataGridView1.ColumnCount - 1).Value = lector(0)
                cont = cont + 1
            End While
            lector.Close()
            CheckBox2.Enabled = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            Dim coli As New DataGridViewTextBoxColumn
            coli.DataPropertyName = "CodigoBarras"
            coli.HeaderText = "CodigoBarras"
            coli.Name = "CodigoBarras"
            DataGridView1.Columns.Add(coli)
            command.CommandText = "SELECT codigoBarras from Productos"
            lector = command.ExecuteReader
            Dim cont As Integer = 0
            While lector.Read
                DataGridView1.Rows(cont).Cells(DataGridView1.ColumnCount - 1).Value = lector(0)
                cont = cont + 1
            End While
            lector.Close()
            CheckBox3.Enabled = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            Dim coli As New DataGridViewTextBoxColumn
            coli.DataPropertyName = "Costo"
            coli.HeaderText = "Costo"
            coli.Name = "Costo"
            DataGridView1.Columns.Add(coli)
            command.CommandText = "SELECT costo from Productos"
            lector = command.ExecuteReader
            Dim cont As Integer = 0
            While lector.Read
                DataGridView1.Rows(cont).Cells(DataGridView1.ColumnCount - 1).Value = lector(0)
                cont = cont + 1
            End While
            lector.Close()
            CheckBox4.Enabled = False
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked Then
            Dim coli As New DataGridViewTextBoxColumn
            coli.DataPropertyName = "Precio"
            coli.HeaderText = "Precio"
            coli.Name = "Precio"
            DataGridView1.Columns.Add(coli)
            command.CommandText = "SELECT precio1 from Productos"
            lector = command.ExecuteReader
            Dim cont As Integer = 0
            While lector.Read
                DataGridView1.Rows(cont).Cells(DataGridView1.ColumnCount - 1).Value = lector(0)
                cont = cont + 1
            End While
            lector.Close()
            CheckBox8.Enabled = False
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked Then
            Dim coli As New DataGridViewTextBoxColumn
            coli.DataPropertyName = "Existencia"
            coli.HeaderText = "Existencia"
            coli.Name = "Existencia"
            DataGridView1.Columns.Add(coli)
            command.CommandText = "SELECT existencia from Productos"
            lector = command.ExecuteReader
            Dim cont As Integer = 0
            While lector.Read
                DataGridView1.Rows(cont).Cells(DataGridView1.ColumnCount - 1).Value = lector(0)
                cont = cont + 1
            End While
            lector.Close()
            CheckBox9.Enabled = False
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked Then
            Dim coli As New DataGridViewTextBoxColumn
            coli.DataPropertyName = "Apartados"
            coli.HeaderText = "Apartados"
            coli.Name = "Apartados"
            DataGridView1.Columns.Add(coli)
            command.CommandText = "SELECT apartados from Productos"
            lector = command.ExecuteReader
            Dim cont As Integer = 0
            While lector.Read
                DataGridView1.Rows(cont).Cells(DataGridView1.ColumnCount - 1).Value = lector(0)
                cont = cont + 1
            End While
            lector.Close()
            CheckBox7.Enabled = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked Then
            Dim coli As New DataGridViewTextBoxColumn
            coli.DataPropertyName = "Fecha"
            coli.HeaderText = "Fecha"
            coli.Name = "Fecha"
            DataGridView1.Columns.Add(coli)
            command.CommandText = "SELECT ultimaFechaCompra from Productos"
            lector = command.ExecuteReader
            Dim cont As Integer = 0
            While lector.Read
                DataGridView1.Rows(cont).Cells(DataGridView1.ColumnCount - 1).Value = lector(0)
                cont = cont + 1
            End While
            lector.Close()
            CheckBox6.Enabled = False
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked Then
            Dim coli As New DataGridViewTextBoxColumn
            coli.DataPropertyName = "ID Marca"
            coli.HeaderText = "ID Marca"
            coli.Name = "ID Marca"
            DataGridView1.Columns.Add(coli)
            command.CommandText = "SELECT idMarca from Productos"
            lector = command.ExecuteReader
            Dim cont As Integer = 0
            While lector.Read
                DataGridView1.Rows(cont).Cells(DataGridView1.ColumnCount - 1).Value = lector(0)
                cont = cont + 1
            End While
            lector.Close()
            CheckBox10.Enabled = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            Dim coli As New DataGridViewTextBoxColumn
            coli.DataPropertyName = "Nombre Marca"
            coli.HeaderText = "Nombre Marca"
            coli.Name = "Nombre Marca"
            DataGridView1.Columns.Add(coli)
            command.CommandText = "SELECT Marcas.nombre from Productos inner join Marcas on Productos.idMarca = Marcas.idMarca"
            lector = command.ExecuteReader
            Dim cont As Integer = 0
            While lector.Read
                DataGridView1.Rows(cont).Cells(DataGridView1.ColumnCount - 1).Value = lector(0)
                cont = cont + 1
            End While
            lector.Close()
            CheckBox5.Enabled = False
        End If
    End Sub

    Private Sub ExportarExcel_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        connection = cerrarConexion()
    End Sub
End Class
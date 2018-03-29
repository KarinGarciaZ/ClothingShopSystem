<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Marcas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Marcas))
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New ClothingShopSystem.DataSet1()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdMarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcasBindingSource, "nombre", True))
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(133, 41)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombre.MaxLength = 40
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(376, 22)
        Me.txtNombre.TabIndex = 15
        '
        'MarcasBindingSource
        '
        Me.MarcasBindingSource.DataMember = "Marcas"
        Me.MarcasBindingSource.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre"
        '
        'txtId
        '
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcasBindingSource, "idMarca", True))
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(12, 41)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(91, 22)
        Me.txtId.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Id"
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(111, 92)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(88, 34)
        Me.btnAnterior.TabIndex = 48
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(207, 92)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(88, 34)
        Me.btnSiguiente.TabIndex = 47
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(303, 92)
        Me.btnUltimo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(88, 34)
        Me.btnUltimo.TabIndex = 46
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(15, 92)
        Me.btnPrimero.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(88, 34)
        Me.btnPrimero.TabIndex = 45
        Me.btnPrimero.Text = "<<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(111, 134)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(88, 62)
        Me.btnModificar.TabIndex = 43
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(15, 134)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(88, 62)
        Me.btnNuevo.TabIndex = 41
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Tomato
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(303, 135)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 62)
        Me.btnCancelar.TabIndex = 50
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(419, 111)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(107, 86)
        Me.btnAceptar.TabIndex = 49
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(519, 73)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        Marcas.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Marcas"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=LAPTOP-JHARA789\KARINSPC;Initial Catalog=dboClothingShopSystem;Integr" &
    "ated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [Marcas] ([idMarca], [nombre]) VALUES (@idMarca, @nombre);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT id" &
    "Marca, nombre FROM Marcas WHERE (idMarca = @idMarca)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@idMarca", System.Data.SqlDbType.Int, 0, "idMarca"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.NVarChar, 0, "nombre")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@idMarca", System.Data.SqlDbType.Int, 0, "idMarca"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.NVarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@Original_idMarca", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idMarca", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [Marcas] WHERE (([idMarca] = @Original_idMarca) AND ((@IsNull_nombre " &
    "= 1 AND [nombre] IS NULL) OR ([nombre] = @Original_nombre)))"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_idMarca", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idMarca", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Marcas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("idMarca", "idMarca"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMarcaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MarcasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(541, 12)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(375, 185)
        Me.DataGridView1.TabIndex = 52
        '
        'IdMarcaDataGridViewTextBoxColumn
        '
        Me.IdMarcaDataGridViewTextBoxColumn.DataPropertyName = "idMarca"
        Me.IdMarcaDataGridViewTextBoxColumn.HeaderText = "idMarca"
        Me.IdMarcaDataGridViewTextBoxColumn.Name = "IdMarcaDataGridViewTextBoxColumn"
        Me.IdMarcaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdMarcaDataGridViewTextBoxColumn.Width = 50
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 180
        '
        'Marcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 206)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnPrimero)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Marcas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Marcas"
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents MarcasBindingSource As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdMarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calles
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
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CallesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New ClothingShopSystem.DataSet1()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CallesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Calles.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     Calles"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [Calles] ([id], [nombre]) VALUES (@id, @nombre);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT id, nombre F" &
    "ROM Calles WHERE (id = @id)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 0, "id"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE [Calles] SET [id] = @id, [nombre] = @nombre WHERE (([id] = @Original_id) A" &
    "ND ([nombre] = @Original_nombre));" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT id, nombre FROM Calles WHERE (id = @i" &
    "d)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 0, "id"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [Calles] WHERE (([id] = @Original_id) AND ([nombre] = @Original_nombr" &
    "e))"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Calles", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=LAPTOP-JHARA789\KARINSPC;Initial Catalog=dboClothingShopSystem;Integr" &
    "ated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CallesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(26, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(369, 127)
        Me.DataGridView1.TabIndex = 0
        '
        'CallesBindingSource
        '
        Me.CallesBindingSource.DataMember = "Calles"
        Me.CallesBindingSource.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 200
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(520, 73)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CallesBindingSource, "nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(135, 41)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.MaxLength = 40
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(376, 22)
        Me.txtNombre.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre"
        '
        'txtId
        '
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CallesBindingSource, "id", True))
        Me.txtId.Location = New System.Drawing.Point(13, 41)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(91, 22)
        Me.txtId.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Id"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Tomato
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(424, 176)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(88, 68)
        Me.btnCancelar.TabIndex = 88
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(520, 176)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(88, 71)
        Me.btnAceptar.TabIndex = 87
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(520, 106)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(88, 62)
        Me.btnModificar.TabIndex = 86
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(424, 106)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(88, 62)
        Me.btnNuevo.TabIndex = 85
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Calles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 277)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Calles"
        Me.Text = "Calles"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CallesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CallesBindingSource As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
End Class

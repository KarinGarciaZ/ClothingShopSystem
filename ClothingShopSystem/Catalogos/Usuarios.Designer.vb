<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtConfirmar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbPuesto = New System.Windows.Forms.ComboBox()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New ClothingShopSystem.DataSet1()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContrase = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtConfirmar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbPuesto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtContrase)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(608, 155)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        '
        'txtConfirmar
        '
        Me.txtConfirmar.Enabled = False
        Me.txtConfirmar.Location = New System.Drawing.Point(317, 103)
        Me.txtConfirmar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtConfirmar.MaxLength = 16
        Me.txtConfirmar.Name = "txtConfirmar"
        Me.txtConfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmar.Size = New System.Drawing.Size(216, 22)
        Me.txtConfirmar.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(313, 84)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Confirmar Contraseña"
        '
        'cbPuesto
        '
        Me.cbPuesto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.UsuariosBindingSource, "puesto", True))
        Me.cbPuesto.Enabled = False
        Me.cbPuesto.FormattingEnabled = True
        Me.cbPuesto.Items.AddRange(New Object() {"Empleado", "Encargado o dueño"})
        Me.cbPuesto.Location = New System.Drawing.Point(425, 32)
        Me.cbPuesto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbPuesto.Name = "cbPuesto"
        Me.cbPuesto.Size = New System.Drawing.Size(160, 24)
        Me.cbPuesto.TabIndex = 19
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(421, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Puesto"
        '
        'txtContrase
        '
        Me.txtContrase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "contrasena", True))
        Me.txtContrase.Enabled = False
        Me.txtContrase.Location = New System.Drawing.Point(37, 103)
        Me.txtContrase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContrase.MaxLength = 16
        Me.txtContrase.Name = "txtContrase"
        Me.txtContrase.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrase.Size = New System.Drawing.Size(193, 22)
        Me.txtContrase.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 82)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Contraseña"
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "nombre", True))
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(8, 32)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombre.MaxLength = 40
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(376, 22)
        Me.txtNombre.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre Usuario"
        '
        'txtId
        '
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "idUsuario", True))
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(503, 32)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(91, 22)
        Me.txtId.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Id"
        Me.Label1.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Tomato
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(512, 209)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(99, 85)
        Me.btnCancelar.TabIndex = 83
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(405, 209)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(99, 85)
        Me.btnAceptar.TabIndex = 82
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(115, 260)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(88, 34)
        Me.btnAnterior.TabIndex = 81
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(211, 260)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(88, 34)
        Me.btnSiguiente.TabIndex = 80
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(307, 260)
        Me.btnUltimo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(88, 34)
        Me.btnUltimo.TabIndex = 79
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(19, 260)
        Me.btnPrimero.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(88, 34)
        Me.btnPrimero.TabIndex = 78
        Me.btnPrimero.Text = "<<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(211, 191)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(88, 62)
        Me.btnModificar.TabIndex = 76
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(115, 191)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(88, 62)
        Me.btnNuevo.TabIndex = 74
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        Usuarios.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Usuarios"
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
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@idUsuario", System.Data.SqlDbType.Int, 0, "idUsuario"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.NVarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@contrasena", System.Data.SqlDbType.NVarChar, 0, "contrasena"), New System.Data.SqlClient.SqlParameter("@puesto", System.Data.SqlDbType.NVarChar, 0, "puesto")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@idUsuario", System.Data.SqlDbType.Int, 0, "idUsuario"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.NVarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@contrasena", System.Data.SqlDbType.NVarChar, 0, "contrasena"), New System.Data.SqlClient.SqlParameter("@puesto", System.Data.SqlDbType.NVarChar, 0, "puesto"), New System.Data.SqlClient.SqlParameter("@Original_idUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_contrasena", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "contrasena", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_contrasena", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "contrasena", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_puesto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "puesto", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_puesto", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "puesto", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_idUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_contrasena", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "contrasena", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_contrasena", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "contrasena", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_puesto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "puesto", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_puesto", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "puesto", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("idUsuario", "idUsuario"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("contrasena", "contrasena"), New System.Data.Common.DataColumnMapping("puesto", "puesto")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 302)
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
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbPuesto As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents txtContrase As TextBox
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents txtConfirmar As TextBox
    Friend WithEvents Label5 As Label
End Class

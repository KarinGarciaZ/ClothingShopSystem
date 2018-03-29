<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedores))
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSet11 = New ClothingShopSystem.DataSet1()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomicilioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedoresTableAdapter = New ClothingShopSystem.DataSet1TableAdapters.ProveedoresTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(145, 41)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.MaxLength = 40
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(379, 22)
        Me.txtNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(24, 41)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(91, 22)
        Me.txtId.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 66)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Teléfono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Domicilio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(288, 11)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Ciudad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 66)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "E-mail"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Enabled = False
        Me.txtDomicilio.Location = New System.Drawing.Point(20, 31)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDomicilio.MaxLength = 40
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(259, 22)
        Me.txtDomicilio.TabIndex = 3
        '
        'txtCiudad
        '
        Me.txtCiudad.Enabled = False
        Me.txtCiudad.Location = New System.Drawing.Point(292, 31)
        Me.txtCiudad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCiudad.MaxLength = 25
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(228, 22)
        Me.txtCiudad.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(20, 86)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.MaxLength = 40
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(259, 22)
        Me.txtEmail.TabIndex = 5
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(292, 86)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.MaxLength = 20
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(228, 22)
        Me.txtTelefono.TabIndex = 6
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(100, 251)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(88, 62)
        Me.btnModificar.TabIndex = 28
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(4, 251)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(88, 62)
        Me.btnNuevo.TabIndex = 26
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Tomato
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(292, 251)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 62)
        Me.btnCancelar.TabIndex = 31
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(412, 214)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(113, 86)
        Me.btnAceptar.TabIndex = 30
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtCiudad)
        Me.GroupBox1.Controls.Add(Me.txtDomicilio)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 73)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(532, 122)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(100, 209)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(88, 34)
        Me.btnAnterior.TabIndex = 36
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(196, 209)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(88, 34)
        Me.btnSiguiente.TabIndex = 35
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(292, 209)
        Me.btnUltimo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(88, 34)
        Me.btnUltimo.TabIndex = 34
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(4, 209)
        Me.btnPrimero.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(88, 34)
        Me.btnPrimero.TabIndex = 33
        Me.btnPrimero.Text = "<<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedorDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.DomicilioDataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProveedoresBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(544, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(591, 286)
        Me.DataGridView1.TabIndex = 37
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Proveedores.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     Proveedores"
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
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@idProveedor", System.Data.SqlDbType.Int, 0, "idProveedor"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.NVarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.NVarChar, 0, "telefono"), New System.Data.SqlClient.SqlParameter("@domicilio", System.Data.SqlDbType.NVarChar, 0, "domicilio"), New System.Data.SqlClient.SqlParameter("@ciudad", System.Data.SqlDbType.NVarChar, 0, "ciudad"), New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.NVarChar, 0, "email")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@idProveedor", System.Data.SqlDbType.Int, 0, "idProveedor"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.NVarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.NVarChar, 0, "telefono"), New System.Data.SqlClient.SqlParameter("@domicilio", System.Data.SqlDbType.NVarChar, 0, "domicilio"), New System.Data.SqlClient.SqlParameter("@ciudad", System.Data.SqlDbType.NVarChar, 0, "ciudad"), New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.NVarChar, 0, "email"), New System.Data.SqlClient.SqlParameter("@Original_idProveedor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idProveedor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_domicilio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "domicilio", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_domicilio", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "domicilio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ciudad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ciudad", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ciudad", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciudad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_idProveedor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idProveedor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_domicilio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "domicilio", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_domicilio", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "domicilio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ciudad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ciudad", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ciudad", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciudad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Proveedores", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("idProveedor", "idProveedor"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("domicilio", "domicilio"), New System.Data.Common.DataColumnMapping("ciudad", "ciudad"), New System.Data.Common.DataColumnMapping("email", "email")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.DataSet11
        '
        'IdProveedorDataGridViewTextBoxColumn
        '
        Me.IdProveedorDataGridViewTextBoxColumn.DataPropertyName = "idProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.HeaderText = "idProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.Name = "IdProveedorDataGridViewTextBoxColumn"
        Me.IdProveedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DomicilioDataGridViewTextBoxColumn
        '
        Me.DomicilioDataGridViewTextBoxColumn.DataPropertyName = "domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.HeaderText = "domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.Name = "DomicilioDataGridViewTextBoxColumn"
        Me.DomicilioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CiudadDataGridViewTextBoxColumn
        '
        Me.CiudadDataGridViewTextBoxColumn.DataPropertyName = "ciudad"
        Me.CiudadDataGridViewTextBoxColumn.HeaderText = "ciudad"
        Me.CiudadDataGridViewTextBoxColumn.Name = "CiudadDataGridViewTextBoxColumn"
        Me.CiudadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 315)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnPrimero)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DomicilioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProveedoresTableAdapter As DataSet1TableAdapters.ProveedoresTableAdapter
End Class

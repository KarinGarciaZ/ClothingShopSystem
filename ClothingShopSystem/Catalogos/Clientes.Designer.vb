<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.txtLimite = New System.Windows.Forms.TextBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New ClothingShopSystem.DataSet1()
        Me.lblLimite = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomicilioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColoniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimiteCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CallesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CallesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(103, 273)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(88, 62)
        Me.btnModificar.TabIndex = 32
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(199, 273)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(88, 62)
        Me.btnBuscar.TabIndex = 31
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(7, 273)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(88, 62)
        Me.btnNuevo.TabIndex = 30
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Tomato
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(295, 270)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(96, 65)
        Me.btnCancelar.TabIndex = 35
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(399, 245)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(123, 90)
        Me.btnAceptar.TabIndex = 34
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(103, 231)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(88, 34)
        Me.btnAnterior.TabIndex = 40
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(199, 231)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(88, 34)
        Me.btnSiguiente.TabIndex = 39
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(295, 231)
        Me.btnUltimo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(88, 34)
        Me.btnUltimo.TabIndex = 38
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(7, 231)
        Me.btnPrimero.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(88, 34)
        Me.btnPrimero.TabIndex = 37
        Me.btnPrimero.Text = "<<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'txtLimite
        '
        Me.txtLimite.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "limiteCredito", True))
        Me.txtLimite.Enabled = False
        Me.txtLimite.Location = New System.Drawing.Point(87, 196)
        Me.txtLimite.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLimite.MaxLength = 8
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Size = New System.Drawing.Size(172, 22)
        Me.txtLimite.TabIndex = 55
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblLimite
        '
        Me.lblLimite.AutoSize = True
        Me.lblLimite.Location = New System.Drawing.Point(83, 176)
        Me.lblLimite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLimite.Name = "lblLimite"
        Me.lblLimite.Size = New System.Drawing.Size(94, 17)
        Me.lblLimite.TabIndex = 54
        Me.lblLimite.Text = "Límite Crédito"
        '
        'txtSaldo
        '
        Me.txtSaldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "saldo", True))
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Location = New System.Drawing.Point(295, 196)
        Me.txtSaldo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(143, 22)
        Me.txtSaldo.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(295, 176)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Saldo"
        '
        'txtTelefono
        '
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "telefono", True))
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(331, 133)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.MaxLength = 20
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(172, 22)
        Me.txtTelefono.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(331, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Teléfono"
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nombre", True))
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(127, 36)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.MaxLength = 40
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(376, 22)
        Me.txtNombre.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Nombre"
        '
        'txtId
        '
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "idCliente", True))
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(5, 36)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(91, 22)
        Me.txtId.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 17)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Id"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DomicilioDataGridViewTextBoxColumn, Me.ColoniaDataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.CPDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn, Me.LimiteCreditoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(529, 5)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(620, 330)
        Me.DataGridView1.TabIndex = 56
        '
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
        Me.IdClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdClienteDataGridViewTextBoxColumn.Width = 50
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 150
        '
        'DomicilioDataGridViewTextBoxColumn
        '
        Me.DomicilioDataGridViewTextBoxColumn.DataPropertyName = "domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.HeaderText = "domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.Name = "DomicilioDataGridViewTextBoxColumn"
        Me.DomicilioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ColoniaDataGridViewTextBoxColumn
        '
        Me.ColoniaDataGridViewTextBoxColumn.DataPropertyName = "colonia"
        Me.ColoniaDataGridViewTextBoxColumn.HeaderText = "colonia"
        Me.ColoniaDataGridViewTextBoxColumn.Name = "ColoniaDataGridViewTextBoxColumn"
        Me.ColoniaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CiudadDataGridViewTextBoxColumn
        '
        Me.CiudadDataGridViewTextBoxColumn.DataPropertyName = "ciudad"
        Me.CiudadDataGridViewTextBoxColumn.HeaderText = "ciudad"
        Me.CiudadDataGridViewTextBoxColumn.Name = "CiudadDataGridViewTextBoxColumn"
        Me.CiudadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CPDataGridViewTextBoxColumn
        '
        Me.CPDataGridViewTextBoxColumn.DataPropertyName = "CP"
        Me.CPDataGridViewTextBoxColumn.HeaderText = "CP"
        Me.CPDataGridViewTextBoxColumn.Name = "CPDataGridViewTextBoxColumn"
        Me.CPDataGridViewTextBoxColumn.ReadOnly = True
        Me.CPDataGridViewTextBoxColumn.Width = 50
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "saldo"
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "saldo"
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        Me.SaldoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SaldoDataGridViewTextBoxColumn.Width = 70
        '
        'LimiteCreditoDataGridViewTextBoxColumn
        '
        Me.LimiteCreditoDataGridViewTextBoxColumn.DataPropertyName = "limiteCredito"
        Me.LimiteCreditoDataGridViewTextBoxColumn.HeaderText = "limiteCredito"
        Me.LimiteCreditoDataGridViewTextBoxColumn.Name = "LimiteCreditoDataGridViewTextBoxColumn"
        Me.LimiteCreditoDataGridViewTextBoxColumn.ReadOnly = True
        Me.LimiteCreditoDataGridViewTextBoxColumn.Width = 70
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        Clientes.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Clientes"
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
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@idCliente", System.Data.SqlDbType.Int, 0, "idCliente"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.NVarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@domicilio", System.Data.SqlDbType.NVarChar, 0, "domicilio"), New System.Data.SqlClient.SqlParameter("@colonia", System.Data.SqlDbType.NVarChar, 0, "colonia"), New System.Data.SqlClient.SqlParameter("@ciudad", System.Data.SqlDbType.NVarChar, 0, "ciudad"), New System.Data.SqlClient.SqlParameter("@CP", System.Data.SqlDbType.NVarChar, 0, "CP"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.NVarChar, 0, "telefono"), New System.Data.SqlClient.SqlParameter("@saldo", System.Data.SqlDbType.Money, 0, "saldo"), New System.Data.SqlClient.SqlParameter("@limiteCredito", System.Data.SqlDbType.Money, 0, "limiteCredito")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@idCliente", System.Data.SqlDbType.Int, 0, "idCliente"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.NVarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@domicilio", System.Data.SqlDbType.NVarChar, 0, "domicilio"), New System.Data.SqlClient.SqlParameter("@colonia", System.Data.SqlDbType.NVarChar, 0, "colonia"), New System.Data.SqlClient.SqlParameter("@ciudad", System.Data.SqlDbType.NVarChar, 0, "ciudad"), New System.Data.SqlClient.SqlParameter("@CP", System.Data.SqlDbType.NVarChar, 0, "CP"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.NVarChar, 0, "telefono"), New System.Data.SqlClient.SqlParameter("@saldo", System.Data.SqlDbType.Money, 0, "saldo"), New System.Data.SqlClient.SqlParameter("@limiteCredito", System.Data.SqlDbType.Money, 0, "limiteCredito"), New System.Data.SqlClient.SqlParameter("@Original_idCliente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idCliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_domicilio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "domicilio", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_domicilio", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "domicilio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_colonia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "colonia", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_colonia", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "colonia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ciudad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ciudad", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ciudad", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciudad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CP", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CP", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CP", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_saldo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "saldo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_saldo", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "saldo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_limiteCredito", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "limiteCredito", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_limiteCredito", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "limiteCredito", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_idCliente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "idCliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_domicilio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "domicilio", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_domicilio", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "domicilio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_colonia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "colonia", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_colonia", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "colonia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ciudad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ciudad", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ciudad", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciudad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_CP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CP", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_CP", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CP", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_saldo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "saldo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_saldo", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "saldo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_limiteCredito", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "limiteCredito", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_limiteCredito", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "limiteCredito", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Clientes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("idCliente", "idCliente"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("domicilio", "domicilio"), New System.Data.Common.DataColumnMapping("colonia", "colonia"), New System.Data.Common.DataColumnMapping("ciudad", "ciudad"), New System.Data.Common.DataColumnMapping("CP", "CP"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("saldo", "saldo"), New System.Data.Common.DataColumnMapping("limiteCredito", "limiteCredito")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'txtDomicilio
        '
        Me.txtDomicilio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "domicilio", True))
        Me.txtDomicilio.Enabled = False
        Me.txtDomicilio.Location = New System.Drawing.Point(5, 85)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDomicilio.MaxLength = 40
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(289, 22)
        Me.txtDomicilio.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 65)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Domicilio"
        '
        'txtColonia
        '
        Me.txtColonia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "colonia", True))
        Me.txtColonia.Enabled = False
        Me.txtColonia.Location = New System.Drawing.Point(304, 85)
        Me.txtColonia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtColonia.MaxLength = 30
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(199, 22)
        Me.txtColonia.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(304, 65)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 17)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Colonia"
        '
        'txtCiudad
        '
        Me.txtCiudad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "ciudad", True))
        Me.txtCiudad.Enabled = False
        Me.txtCiudad.Location = New System.Drawing.Point(8, 137)
        Me.txtCiudad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCiudad.MaxLength = 30
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(207, 22)
        Me.txtCiudad.TabIndex = 62
        Me.txtCiudad.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 113)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 17)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Ciudad"
        '
        'txtCP
        '
        Me.txtCP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "CP", True))
        Me.txtCP.Enabled = False
        Me.txtCP.Location = New System.Drawing.Point(221, 133)
        Me.txtCP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCP.MaxLength = 5
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(100, 22)
        Me.txtCP.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(221, 113)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 17)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "CP"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.txtCP)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCiudad)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtColonia)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDomicilio)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 5)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(512, 167)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CallesBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(8, 133)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(207, 24)
        Me.ComboBox1.TabIndex = 65
        '
        'CallesBindingSource
        '
        Me.CallesBindingSource.DataMember = "Calles"
        Me.CallesBindingSource.DataSource = Me.DataSet11
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Calles.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     Calles"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO [Calles] ([id], [nombre]) VALUES (@id, @nombre);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT id, nombre F" &
    "ROM Calles WHERE (id = @id)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 0, "id"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE [Calles] SET [id] = @id, [nombre] = @nombre WHERE (([id] = @Original_id) A" &
    "ND ([nombre] = @Original_nombre));" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT id, nombre FROM Calles WHERE (id = @i" &
    "d)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 0, "id"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM [Calles] WHERE (([id] = @Original_id) AND ([nombre] = @Original_nombr" &
    "e))"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Calles", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand2
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 343)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtLimite)
        Me.Controls.Add(Me.lblLimite)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnPrimero)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Clientes"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CallesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents txtLimite As TextBox
    Friend WithEvents lblLimite As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCP As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DomicilioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColoniaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LimiteCreditoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CallesBindingSource As BindingSource
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter2 As SqlClient.SqlDataAdapter
End Class

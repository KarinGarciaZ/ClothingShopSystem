<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbCondicion = New System.Windows.Forms.GroupBox()
        Me.rbCredito = New System.Windows.Forms.RadioButton()
        Me.rbEfectivo = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtLimite = New System.Windows.Forms.TextBox()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbTipoPrecio = New System.Windows.Forms.ComboBox()
        Me.txtExistencia = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgAgregar = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblIVA = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblVen = New System.Windows.Forms.Label()
        Me.dtpFechaVen = New System.Windows.Forms.DateTimePicker()
        Me.txtIdVenta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbCondicion.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCondicion
        '
        Me.gbCondicion.Controls.Add(Me.rbCredito)
        Me.gbCondicion.Controls.Add(Me.rbEfectivo)
        Me.gbCondicion.Location = New System.Drawing.Point(12, 2)
        Me.gbCondicion.Name = "gbCondicion"
        Me.gbCondicion.Size = New System.Drawing.Size(93, 90)
        Me.gbCondicion.TabIndex = 23
        Me.gbCondicion.TabStop = False
        Me.gbCondicion.Text = "Condición"
        '
        'rbCredito
        '
        Me.rbCredito.AutoSize = True
        Me.rbCredito.Enabled = False
        Me.rbCredito.Location = New System.Drawing.Point(25, 55)
        Me.rbCredito.Name = "rbCredito"
        Me.rbCredito.Size = New System.Drawing.Size(58, 17)
        Me.rbCredito.TabIndex = 1
        Me.rbCredito.TabStop = True
        Me.rbCredito.Text = "Crédito"
        Me.rbCredito.UseVisualStyleBackColor = True
        '
        'rbEfectivo
        '
        Me.rbEfectivo.AutoSize = True
        Me.rbEfectivo.Enabled = False
        Me.rbEfectivo.Location = New System.Drawing.Point(25, 29)
        Me.rbEfectivo.Name = "rbEfectivo"
        Me.rbEfectivo.Size = New System.Drawing.Size(64, 17)
        Me.rbEfectivo.TabIndex = 0
        Me.rbEfectivo.TabStop = True
        Me.rbEfectivo.Text = "Efectivo"
        Me.rbEfectivo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtLimite)
        Me.GroupBox2.Controls.Add(Me.cbCliente)
        Me.GroupBox2.Controls.Add(Me.txtSaldo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtDomicilio)
        Me.GroupBox2.Controls.Add(Me.txtTelefono)
        Me.GroupBox2.Controls.Add(Me.txtIdCliente)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(112, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(431, 90)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(358, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 13)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Limite Saldo:"
        '
        'txtLimite
        '
        Me.txtLimite.Enabled = False
        Me.txtLimite.Location = New System.Drawing.Point(353, 64)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Size = New System.Drawing.Size(72, 20)
        Me.txtLimite.TabIndex = 41
        '
        'cbCliente
        '
        Me.cbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCliente.DisplayMember = "idGrupo"
        Me.cbCliente.Enabled = False
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(45, 13)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(218, 21)
        Me.cbCliente.TabIndex = 40
        Me.cbCliente.ValueMember = "idGrupo"
        '
        'txtSaldo
        '
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Location = New System.Drawing.Point(266, 64)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(81, 20)
        Me.txtSaldo.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(288, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Saldo:"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Enabled = False
        Me.txtDomicilio.Location = New System.Drawing.Point(94, 64)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(166, 20)
        Me.txtDomicilio.TabIndex = 23
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(6, 64)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(82, 20)
        Me.txtTelefono.TabIndex = 21
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Enabled = False
        Me.txtIdCliente.Location = New System.Drawing.Point(322, 13)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(64, 20)
        Me.txtIdCliente.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Domicilio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.cbProducto)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtIdProducto)
        Me.GroupBox3.Controls.Add(Me.txtCodigoBarras)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(787, 144)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtCantidad)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtPrecio)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.cbTipoPrecio)
        Me.GroupBox4.Controls.Add(Me.txtExistencia)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.btnAgregar)
        Me.GroupBox4.Location = New System.Drawing.Point(4, 78)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(783, 62)
        Me.GroupBox4.TabIndex = 40
        Me.GroupBox4.TabStop = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Location = New System.Drawing.Point(417, 32)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(440, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Cantidad:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(178, 32)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(206, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Precio:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(48, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Tipo Precio:"
        '
        'cbTipoPrecio
        '
        Me.cbTipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoPrecio.Enabled = False
        Me.cbTipoPrecio.FormattingEnabled = True
        Me.cbTipoPrecio.Items.AddRange(New Object() {"Precio1", "Precio2", "Precio3"})
        Me.cbTipoPrecio.Location = New System.Drawing.Point(24, 32)
        Me.cbTipoPrecio.Name = "cbTipoPrecio"
        Me.cbTipoPrecio.Size = New System.Drawing.Size(123, 21)
        Me.cbTipoPrecio.TabIndex = 26
        '
        'txtExistencia
        '
        Me.txtExistencia.Enabled = False
        Me.txtExistencia.Location = New System.Drawing.Point(296, 32)
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.Size = New System.Drawing.Size(104, 20)
        Me.txtExistencia.TabIndex = 36
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(319, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 13)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "Existencia:"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackgroundImage = Global.ClothingShopSystem.My.Resources.Resources.if_meanicons_59_197222
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(544, 13)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(193, 43)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cbProducto
        '
        Me.cbProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProducto.DisplayMember = "idGrupo"
        Me.cbProducto.Enabled = False
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(246, 28)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(234, 21)
        Me.cbProducto.TabIndex = 39
        Me.cbProducto.ValueMember = "idGrupo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(486, 31)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 13)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Código de barras"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(25, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 13)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "ID"
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Enabled = False
        Me.txtIdProducto.Location = New System.Drawing.Point(55, 28)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(90, 20)
        Me.txtIdProducto.TabIndex = 27
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.Enabled = False
        Me.txtCodigoBarras.Location = New System.Drawing.Point(595, 28)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(153, 20)
        Me.txtCodigoBarras.TabIndex = 26
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(188, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(148, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Buscar producto"
        '
        'dgAgregar
        '
        Me.dgAgregar.AllowUserToAddRows = False
        Me.dgAgregar.AllowUserToDeleteRows = False
        Me.dgAgregar.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAgregar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Codigo, Me.Column5, Me.DataGridViewTextBoxColumn4, Me.Column6})
        Me.dgAgregar.Location = New System.Drawing.Point(27, 248)
        Me.dgAgregar.Name = "dgAgregar"
        Me.dgAgregar.ReadOnly = True
        Me.dgAgregar.Size = New System.Drawing.Size(757, 210)
        Me.dgAgregar.TabIndex = 41
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Producto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 180
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código de barras"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Cantidad"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 85
        '
        'Column6
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column6.HeaderText = "Importe"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'btnGrabar
        '
        Me.btnGrabar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Location = New System.Drawing.Point(401, 489)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(146, 54)
        Me.btnGrabar.TabIndex = 43
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(238, 489)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(146, 54)
        Me.btnNuevo.TabIndex = 42
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(712, 540)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(39, 13)
        Me.lblTotal.TabIndex = 49
        Me.lblTotal.Text = "00.00"
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIVA.Location = New System.Drawing.Point(712, 515)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(39, 13)
        Me.lblIVA.TabIndex = 48
        Me.lblIVA.Text = "00.00"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(712, 470)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(39, 13)
        Me.lblSubtotal.TabIndex = 47
        Me.lblSubtotal.Text = "00.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(635, 540)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Total:   $"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(643, 515)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "IVA:   $"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(617, 470)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Subtotal:   $"
        '
        'txtDescuento
        '
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Location = New System.Drawing.Point(699, 489)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(68, 20)
        Me.txtDescuento.TabIndex = 42
        Me.txtDescuento.Text = "00.00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(602, 492)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "Descuento:   $"
        '
        'lblVen
        '
        Me.lblVen.AutoSize = True
        Me.lblVen.Location = New System.Drawing.Point(6, 54)
        Me.lblVen.Name = "lblVen"
        Me.lblVen.Size = New System.Drawing.Size(67, 26)
        Me.lblVen.TabIndex = 56
        Me.lblVen.Text = "Fecha de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vencimiento:"
        Me.lblVen.Visible = False
        '
        'dtpFechaVen
        '
        Me.dtpFechaVen.Location = New System.Drawing.Point(79, 59)
        Me.dtpFechaVen.Name = "dtpFechaVen"
        Me.dtpFechaVen.Size = New System.Drawing.Size(148, 20)
        Me.dtpFechaVen.TabIndex = 55
        Me.dtpFechaVen.Visible = False
        '
        'txtIdVenta
        '
        Me.txtIdVenta.Enabled = False
        Me.txtIdVenta.Location = New System.Drawing.Point(79, 10)
        Me.txtIdVenta.Name = "txtIdVenta"
        Me.txtIdVenta.Size = New System.Drawing.Size(145, 20)
        Me.txtIdVenta.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Fecha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "ID Venta:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(79, 33)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(148, 20)
        Me.dtpFecha.TabIndex = 52
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporte.Location = New System.Drawing.Point(549, 470)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(39, 13)
        Me.lblImporte.TabIndex = 57
        Me.lblImporte.Text = "00.00"
        Me.lblImporte.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.txtIdVenta)
        Me.GroupBox1.Controls.Add(Me.dtpFechaVen)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblVen)
        Me.GroupBox1.Location = New System.Drawing.Point(552, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 89)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(811, 564)
        Me.Controls.Add(Me.lblImporte)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblIVA)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgAgregar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbCondicion)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.gbCondicion.ResumeLayout(False)
        Me.gbCondicion.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbCondicion As GroupBox
    Friend WithEvents rbCredito As RadioButton
    Friend WithEvents rbEfectivo As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtExistencia As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents txtCodigoBarras As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgAgregar As DataGridView
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cbTipoPrecio As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblIVA As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lblVen As Label
    Friend WithEvents dtpFechaVen As DateTimePicker
    Friend WithEvents txtIdVenta As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents txtLimite As TextBox
    Friend WithEvents lblImporte As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class

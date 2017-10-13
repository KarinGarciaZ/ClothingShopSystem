<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaVenta
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
        Me.lblVen = New System.Windows.Forms.Label()
        Me.dtpFechaVen = New System.Windows.Forms.DateTimePicker()
        Me.txtIdVenta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.dgAgregar = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbCliente = New System.Windows.Forms.GroupBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPublico = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblIVA = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblVentas = New System.Windows.Forms.Label()
        Me.cbVentas = New System.Windows.Forms.ComboBox()
        Me.txtBusquedaVenta = New System.Windows.Forms.TextBox()
        Me.cbBusquedaCliente = New System.Windows.Forms.ComboBox()
        Me.dtpBusquedaFecha = New System.Windows.Forms.DateTimePicker()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.rbVenta = New System.Windows.Forms.RadioButton()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.lblAbo = New System.Windows.Forms.Label()
        Me.lblDeu = New System.Windows.Forms.Label()
        Me.lblAbonado = New System.Windows.Forms.Label()
        Me.lblDeuda = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCondicion = New System.Windows.Forms.TextBox()
        CType(Me.dgAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCliente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVen
        '
        Me.lblVen.AutoSize = True
        Me.lblVen.Location = New System.Drawing.Point(492, 115)
        Me.lblVen.Name = "lblVen"
        Me.lblVen.Size = New System.Drawing.Size(115, 13)
        Me.lblVen.TabIndex = 66
        Me.lblVen.Text = "Fecha de vencimiento:"
        Me.lblVen.Visible = False
        '
        'dtpFechaVen
        '
        Me.dtpFechaVen.Enabled = False
        Me.dtpFechaVen.Location = New System.Drawing.Point(449, 137)
        Me.dtpFechaVen.Name = "dtpFechaVen"
        Me.dtpFechaVen.Size = New System.Drawing.Size(194, 20)
        Me.dtpFechaVen.TabIndex = 65
        Me.dtpFechaVen.Visible = False
        '
        'txtIdVenta
        '
        Me.txtIdVenta.Enabled = False
        Me.txtIdVenta.Location = New System.Drawing.Point(679, 84)
        Me.txtIdVenta.Name = "txtIdVenta"
        Me.txtIdVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtIdVenta.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(526, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Fecha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(705, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "ID Venta:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(449, 84)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(194, 20)
        Me.dtpFecha.TabIndex = 62
        '
        'dgAgregar
        '
        Me.dgAgregar.AllowUserToAddRows = False
        Me.dgAgregar.AllowUserToDeleteRows = False
        Me.dgAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAgregar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Codigo, Me.Column5, Me.DataGridViewTextBoxColumn4, Me.Column6})
        Me.dgAgregar.Location = New System.Drawing.Point(27, 169)
        Me.dgAgregar.Name = "dgAgregar"
        Me.dgAgregar.ReadOnly = True
        Me.dgAgregar.Size = New System.Drawing.Size(739, 210)
        Me.dgAgregar.TabIndex = 60
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
        'gbCliente
        '
        Me.gbCliente.Controls.Add(Me.txtCliente)
        Me.gbCliente.Controls.Add(Me.txtSaldo)
        Me.gbCliente.Controls.Add(Me.Label6)
        Me.gbCliente.Controls.Add(Me.txtDomicilio)
        Me.gbCliente.Controls.Add(Me.txtTelefono)
        Me.gbCliente.Controls.Add(Me.txtIdCliente)
        Me.gbCliente.Controls.Add(Me.Label4)
        Me.gbCliente.Controls.Add(Me.Label3)
        Me.gbCliente.Controls.Add(Me.Label2)
        Me.gbCliente.Controls.Add(Me.Label1)
        Me.gbCliente.Location = New System.Drawing.Point(12, 87)
        Me.gbCliente.Name = "gbCliente"
        Me.gbCliente.Size = New System.Drawing.Size(431, 76)
        Me.gbCliente.TabIndex = 58
        Me.gbCliente.TabStop = False
        Me.gbCliente.Visible = False
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(71, 9)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(209, 20)
        Me.txtCliente.TabIndex = 86
        '
        'txtSaldo
        '
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Location = New System.Drawing.Point(344, 48)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(81, 20)
        Me.txtSaldo.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(366, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Saldo:"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Enabled = False
        Me.txtDomicilio.Location = New System.Drawing.Point(129, 48)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(191, 20)
        Me.txtDomicilio.TabIndex = 23
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(23, 48)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(82, 20)
        Me.txtTelefono.TabIndex = 21
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Enabled = False
        Me.txtIdCliente.Location = New System.Drawing.Point(339, 9)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(64, 20)
        Me.txtIdCliente.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(204, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Domicilio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(286, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        '
        'lblPublico
        '
        Me.lblPublico.AutoSize = True
        Me.lblPublico.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublico.Location = New System.Drawing.Point(63, 74)
        Me.lblPublico.Name = "lblPublico"
        Me.lblPublico.Size = New System.Drawing.Size(301, 25)
        Me.lblPublico.TabIndex = 85
        Me.lblPublico.Text = "Venta al público en general"
        Me.lblPublico.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(617, 401)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 76
        Me.Label15.Text = "Descuento:   $"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(727, 445)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(39, 13)
        Me.lblTotal.TabIndex = 75
        Me.lblTotal.Text = "00.00"
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIVA.Location = New System.Drawing.Point(727, 421)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(39, 13)
        Me.lblIVA.TabIndex = 74
        Me.lblIVA.Text = "00.00"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(727, 381)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(39, 13)
        Me.lblSubtotal.TabIndex = 73
        Me.lblSubtotal.Text = "00.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(650, 445)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Total:   $"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(658, 421)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "IVA:   $"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(632, 381)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Subtotal:   $"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblVentas)
        Me.GroupBox1.Controls.Add(Me.cbVentas)
        Me.GroupBox1.Controls.Add(Me.txtBusquedaVenta)
        Me.GroupBox1.Controls.Add(Me.cbBusquedaCliente)
        Me.GroupBox1.Controls.Add(Me.dtpBusquedaFecha)
        Me.GroupBox1.Controls.Add(Me.rbFecha)
        Me.GroupBox1.Controls.Add(Me.rbVenta)
        Me.GroupBox1.Controls.Add(Me.rbCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(788, 64)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta por:"
        '
        'lblVentas
        '
        Me.lblVentas.AutoSize = True
        Me.lblVentas.Location = New System.Drawing.Point(698, 12)
        Me.lblVentas.Name = "lblVentas"
        Me.lblVentas.Size = New System.Drawing.Size(40, 13)
        Me.lblVentas.TabIndex = 85
        Me.lblVentas.Text = "Ventas"
        Me.lblVentas.Visible = False
        '
        'cbVentas
        '
        Me.cbVentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVentas.FormattingEnabled = True
        Me.cbVentas.Location = New System.Drawing.Point(651, 33)
        Me.cbVentas.Name = "cbVentas"
        Me.cbVentas.Size = New System.Drawing.Size(121, 21)
        Me.cbVentas.TabIndex = 84
        Me.cbVentas.Visible = False
        '
        'txtBusquedaVenta
        '
        Me.txtBusquedaVenta.Location = New System.Drawing.Point(76, 32)
        Me.txtBusquedaVenta.Name = "txtBusquedaVenta"
        Me.txtBusquedaVenta.Size = New System.Drawing.Size(83, 20)
        Me.txtBusquedaVenta.TabIndex = 43
        Me.txtBusquedaVenta.Visible = False
        '
        'cbBusquedaCliente
        '
        Me.cbBusquedaCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbBusquedaCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbBusquedaCliente.DisplayMember = "idGrupo"
        Me.cbBusquedaCliente.FormattingEnabled = True
        Me.cbBusquedaCliente.Location = New System.Drawing.Point(177, 32)
        Me.cbBusquedaCliente.Name = "cbBusquedaCliente"
        Me.cbBusquedaCliente.Size = New System.Drawing.Size(236, 21)
        Me.cbBusquedaCliente.TabIndex = 43
        Me.cbBusquedaCliente.ValueMember = "idGrupo"
        Me.cbBusquedaCliente.Visible = False
        '
        'dtpBusquedaFecha
        '
        Me.dtpBusquedaFecha.Location = New System.Drawing.Point(434, 33)
        Me.dtpBusquedaFecha.Name = "dtpBusquedaFecha"
        Me.dtpBusquedaFecha.Size = New System.Drawing.Size(194, 20)
        Me.dtpBusquedaFecha.TabIndex = 83
        Me.dtpBusquedaFecha.Visible = False
        '
        'rbFecha
        '
        Me.rbFecha.AutoSize = True
        Me.rbFecha.Location = New System.Drawing.Point(504, 10)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(55, 17)
        Me.rbFecha.TabIndex = 3
        Me.rbFecha.TabStop = True
        Me.rbFecha.Text = "Fecha"
        Me.rbFecha.UseVisualStyleBackColor = True
        '
        'rbVenta
        '
        Me.rbVenta.AutoSize = True
        Me.rbVenta.Location = New System.Drawing.Point(92, 9)
        Me.rbVenta.Name = "rbVenta"
        Me.rbVenta.Size = New System.Drawing.Size(67, 17)
        Me.rbVenta.TabIndex = 2
        Me.rbVenta.TabStop = True
        Me.rbVenta.Text = "ID Venta"
        Me.rbVenta.UseVisualStyleBackColor = True
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.Location = New System.Drawing.Point(275, 9)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(57, 17)
        Me.rbCliente.TabIndex = 1
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        Me.rbCliente.UseVisualStyleBackColor = True
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuento.Location = New System.Drawing.Point(727, 401)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(39, 13)
        Me.lblDescuento.TabIndex = 78
        Me.lblDescuento.Text = "00.00"
        '
        'lblAbo
        '
        Me.lblAbo.AutoSize = True
        Me.lblAbo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbo.Location = New System.Drawing.Point(380, 401)
        Me.lblAbo.Name = "lblAbo"
        Me.lblAbo.Size = New System.Drawing.Size(80, 13)
        Me.lblAbo.TabIndex = 79
        Me.lblAbo.Text = "Abonado:   $"
        Me.lblAbo.Visible = False
        '
        'lblDeu
        '
        Me.lblDeu.AutoSize = True
        Me.lblDeu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeu.Location = New System.Drawing.Point(394, 421)
        Me.lblDeu.Name = "lblDeu"
        Me.lblDeu.Size = New System.Drawing.Size(67, 13)
        Me.lblDeu.TabIndex = 80
        Me.lblDeu.Text = "Deuda:   $"
        Me.lblDeu.Visible = False
        '
        'lblAbonado
        '
        Me.lblAbonado.AutoSize = True
        Me.lblAbonado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbonado.Location = New System.Drawing.Point(479, 401)
        Me.lblAbonado.Name = "lblAbonado"
        Me.lblAbonado.Size = New System.Drawing.Size(39, 13)
        Me.lblAbonado.TabIndex = 81
        Me.lblAbonado.Text = "00.00"
        Me.lblAbonado.Visible = False
        '
        'lblDeuda
        '
        Me.lblDeuda.AutoSize = True
        Me.lblDeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeuda.Location = New System.Drawing.Point(479, 421)
        Me.lblDeuda.Name = "lblDeuda"
        Me.lblDeuda.Size = New System.Drawing.Size(39, 13)
        Me.lblDeuda.TabIndex = 82
        Me.lblDeuda.Text = "00.00"
        Me.lblDeuda.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(705, 115)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 13)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "Condición:"
        '
        'txtCondicion
        '
        Me.txtCondicion.Enabled = False
        Me.txtCondicion.Location = New System.Drawing.Point(679, 137)
        Me.txtCondicion.Name = "txtCondicion"
        Me.txtCondicion.Size = New System.Drawing.Size(100, 20)
        Me.txtCondicion.TabIndex = 84
        '
        'ConsultaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 467)
        Me.Controls.Add(Me.txtCondicion)
        Me.Controls.Add(Me.lblPublico)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblDeuda)
        Me.Controls.Add(Me.lblAbonado)
        Me.Controls.Add(Me.lblDeu)
        Me.Controls.Add(Me.lblAbo)
        Me.Controls.Add(Me.lblDescuento)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIdVenta)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblIVA)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblVen)
        Me.Controls.Add(Me.dtpFechaVen)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.dgAgregar)
        Me.Controls.Add(Me.gbCliente)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConsultaVenta"
        Me.Text = "ConsultaVenta"
        CType(Me.dgAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCliente.ResumeLayout(False)
        Me.gbCliente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVen As Label
    Friend WithEvents dtpFechaVen As DateTimePicker
    Friend WithEvents txtIdVenta As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents dgAgregar As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents gbCliente As GroupBox
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblIVA As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblVentas As Label
    Friend WithEvents cbVentas As ComboBox
    Friend WithEvents txtBusquedaVenta As TextBox
    Friend WithEvents cbBusquedaCliente As ComboBox
    Friend WithEvents dtpBusquedaFecha As DateTimePicker
    Friend WithEvents rbFecha As RadioButton
    Friend WithEvents rbVenta As RadioButton
    Friend WithEvents rbCliente As RadioButton
    Friend WithEvents lblDescuento As Label
    Friend WithEvents lblAbo As Label
    Friend WithEvents lblDeu As Label
    Friend WithEvents lblAbonado As Label
    Friend WithEvents lblDeuda As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtCondicion As TextBox
    Friend WithEvents lblPublico As Label
    Friend WithEvents txtCliente As TextBox
End Class

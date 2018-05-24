<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Abonos
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
        Me.cbClientes = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbVenta = New System.Windows.Forms.RadioButton()
        Me.rbApartado = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbClientes
        '
        Me.cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClientes.FormattingEnabled = True
        Me.cbClientes.Location = New System.Drawing.Point(183, 41)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(281, 24)
        Me.cbClientes.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbApartado)
        Me.GroupBox1.Controls.Add(Me.rbVenta)
        Me.GroupBox1.Location = New System.Drawing.Point(226, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 110)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de abono"
        '
        'rbVenta
        '
        Me.rbVenta.AutoSize = True
        Me.rbVenta.Location = New System.Drawing.Point(24, 35)
        Me.rbVenta.Name = "rbVenta"
        Me.rbVenta.Size = New System.Drawing.Size(125, 21)
        Me.rbVenta.TabIndex = 0
        Me.rbVenta.TabStop = True
        Me.rbVenta.Text = "Venta a crédito"
        Me.rbVenta.UseVisualStyleBackColor = True
        '
        'rbApartado
        '
        Me.rbApartado.AutoSize = True
        Me.rbApartado.Location = New System.Drawing.Point(24, 75)
        Me.rbApartado.Name = "rbApartado"
        Me.rbApartado.Size = New System.Drawing.Size(87, 21)
        Me.rbApartado.TabIndex = 1
        Me.rbApartado.TabStop = True
        Me.rbApartado.Text = "Apartado"
        Me.rbApartado.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(226, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 56)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Abonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 317)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbClientes)
        Me.Name = "Abonos"
        Me.Text = "Abonos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbClientes As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbApartado As RadioButton
    Friend WithEvents rbVenta As RadioButton
    Friend WithEvents Button1 As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComprasPorProveedor
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
        Me.cbProveedores = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbProveedores
        '
        Me.cbProveedores.FormattingEnabled = True
        Me.cbProveedores.Location = New System.Drawing.Point(219, 63)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(290, 24)
        Me.cbProveedores.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(287, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione proveedor"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(290, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 46)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Generar Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComprasPorProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 244)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbProveedores)
        Me.Name = "ComprasPorProveedor"
        Me.Text = "ComprasPorProveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbProveedores As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class

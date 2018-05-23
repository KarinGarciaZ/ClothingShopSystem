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
        Me.SuspendLayout()
        '
        'cbProveedores
        '
        Me.cbProveedores.FormattingEnabled = True
        Me.cbProveedores.Location = New System.Drawing.Point(194, 55)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(290, 24)
        Me.cbProveedores.TabIndex = 0
        '
        'ComprasPorProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 533)
        Me.Controls.Add(Me.cbProveedores)
        Me.Name = "ComprasPorProveedor"
        Me.Text = "ComprasPorProveedor"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbProveedores As ComboBox
End Class

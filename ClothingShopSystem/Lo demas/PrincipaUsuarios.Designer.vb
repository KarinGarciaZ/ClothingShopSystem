<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrincipaUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatálogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApartadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbonoCreditoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbonoApartadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolucionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatálogosToolStripMenuItem, Me.MovimientosToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(156, 354)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatálogosToolStripMenuItem
        '
        Me.CatálogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem})
        Me.CatálogosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CatálogosToolStripMenuItem.Name = "CatálogosToolStripMenuItem"
        Me.CatálogosToolStripMenuItem.Size = New System.Drawing.Size(143, 34)
        Me.CatálogosToolStripMenuItem.Text = "Catálogos"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(160, 34)
        Me.ProductosToolStripMenuItem.Text = "Clientes"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem, Me.ApartadosToolStripMenuItem, Me.AbonoCreditoToolStripMenuItem, Me.AbonoApartadoToolStripMenuItem, Me.DevolucionesToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(143, 34)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaToolStripMenuItem1})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(249, 34)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ConsultaToolStripMenuItem1
        '
        Me.ConsultaToolStripMenuItem1.Name = "ConsultaToolStripMenuItem1"
        Me.ConsultaToolStripMenuItem1.Size = New System.Drawing.Size(169, 34)
        Me.ConsultaToolStripMenuItem1.Text = "Consulta"
        '
        'ApartadosToolStripMenuItem
        '
        Me.ApartadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaToolStripMenuItem2})
        Me.ApartadosToolStripMenuItem.Name = "ApartadosToolStripMenuItem"
        Me.ApartadosToolStripMenuItem.Size = New System.Drawing.Size(249, 34)
        Me.ApartadosToolStripMenuItem.Text = "Apartados"
        '
        'ConsultaToolStripMenuItem2
        '
        Me.ConsultaToolStripMenuItem2.Name = "ConsultaToolStripMenuItem2"
        Me.ConsultaToolStripMenuItem2.Size = New System.Drawing.Size(169, 34)
        Me.ConsultaToolStripMenuItem2.Text = "Consulta"
        '
        'AbonoCreditoToolStripMenuItem
        '
        Me.AbonoCreditoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaToolStripMenuItem3})
        Me.AbonoCreditoToolStripMenuItem.Name = "AbonoCreditoToolStripMenuItem"
        Me.AbonoCreditoToolStripMenuItem.Size = New System.Drawing.Size(249, 34)
        Me.AbonoCreditoToolStripMenuItem.Text = "Abono Credito"
        '
        'ConsultaToolStripMenuItem3
        '
        Me.ConsultaToolStripMenuItem3.Name = "ConsultaToolStripMenuItem3"
        Me.ConsultaToolStripMenuItem3.Size = New System.Drawing.Size(169, 34)
        Me.ConsultaToolStripMenuItem3.Text = "Consulta"
        '
        'AbonoApartadoToolStripMenuItem
        '
        Me.AbonoApartadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaToolStripMenuItem4})
        Me.AbonoApartadoToolStripMenuItem.Name = "AbonoApartadoToolStripMenuItem"
        Me.AbonoApartadoToolStripMenuItem.Size = New System.Drawing.Size(249, 34)
        Me.AbonoApartadoToolStripMenuItem.Text = "Abono Apartado"
        '
        'ConsultaToolStripMenuItem4
        '
        Me.ConsultaToolStripMenuItem4.Name = "ConsultaToolStripMenuItem4"
        Me.ConsultaToolStripMenuItem4.Size = New System.Drawing.Size(169, 34)
        Me.ConsultaToolStripMenuItem4.Text = "Consulta"
        '
        'DevolucionesToolStripMenuItem
        '
        Me.DevolucionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaToolStripMenuItem5})
        Me.DevolucionesToolStripMenuItem.Name = "DevolucionesToolStripMenuItem"
        Me.DevolucionesToolStripMenuItem.Size = New System.Drawing.Size(249, 34)
        Me.DevolucionesToolStripMenuItem.Text = "Devoluciones"
        '
        'ConsultaToolStripMenuItem5
        '
        Me.ConsultaToolStripMenuItem5.Name = "ConsultaToolStripMenuItem5"
        Me.ConsultaToolStripMenuItem5.Size = New System.Drawing.Size(169, 34)
        Me.ConsultaToolStripMenuItem5.Text = "Consulta"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem1, Me.ProductosToolStripMenuItem1})
        Me.ConsultasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(143, 34)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(184, 34)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'ProductosToolStripMenuItem1
        '
        Me.ProductosToolStripMenuItem1.Name = "ProductosToolStripMenuItem1"
        Me.ProductosToolStripMenuItem1.Size = New System.Drawing.Size(184, 34)
        Me.ProductosToolStripMenuItem1.Text = "Productos"
        '
        'PrincipaUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ClothingShopSystem.My.Resources.Resources.tienda_ropa
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(560, 354)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "PrincipaUsuarios"
        Me.Text = "ClothingShopSystem <<USUARIOS>>"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatálogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ApartadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AbonoCreditoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents AbonoApartadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents DevolucionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem1 As ToolStripMenuItem
End Class

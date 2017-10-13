Public Class PrincipaUsuarios
    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Clientes.ShowDialog()
    End Sub
    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Ventas.ShowDialog()
    End Sub

    Private Sub ConsultaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem1.Click
        ConsultaVenta.ShowDialog()
    End Sub

    Private Sub ApartadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApartadosToolStripMenuItem.Click
        frmApartados.ShowDialog()
    End Sub

    Private Sub ConsultaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem2.Click
        ConsultaApartados.ShowDialog()
    End Sub

    Private Sub AbonoCreditoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbonoCreditoToolStripMenuItem.Click
        AbonoCredito.ShowDialog()
    End Sub

    Private Sub ConsultaToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem3.Click
        ConsultaAbonoCredito.ShowDialog()
    End Sub

    Private Sub AbonoApartadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbonoApartadoToolStripMenuItem.Click
        frmAbonosApartados.ShowDialog()
    End Sub

    Private Sub ConsultaToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem4.Click
        ConsultaAbonosA.ShowDialog()
    End Sub

    Private Sub DevolucionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolucionesToolStripMenuItem.Click
        Devoluciones.ShowDialog()
    End Sub

    Private Sub ConsultaToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem5.Click
        ConsultaDevoluciones.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        ConsultaClientes.ShowDialog()
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
        ConsultaProductos.ShowDialog()
    End Sub
End Class
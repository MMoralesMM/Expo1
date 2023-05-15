Public Class Principal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Acercade.Show()
    End Sub

    Private Sub EntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaToolStripMenuItem.Click
        Entrada.Show()
    End Sub

    Private Sub SalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaToolStripMenuItem.Click
        Salida.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Chequeo.Show()
    End Sub

    Private Sub FuncionariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionariosToolStripMenuItem.Click
        ManteFuncio.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        ManteEmple.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
        ManteProduc.Show()
    End Sub
End Class
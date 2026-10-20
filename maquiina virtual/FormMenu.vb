Public Class FormMenu
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LaMaquinaDeJuegoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaMaquinaDeJuegoToolStripMenuItem.Click
        FormPeluches.Show()
        Hide()
    End Sub

    Private Sub MonedasYCambioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonedasYCambioToolStripMenuItem.Click

    End Sub

    Private Sub TuColecciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TuColecciónToolStripMenuItem.Click
        formColeccion.Show()
        Hide()
    End Sub
End Class
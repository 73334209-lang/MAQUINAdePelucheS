Public Class FormMenu
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LaMaquinaDeJuegoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaMaquinaDeJuegoToolStripMenuItem.Click
        Dim peluches As New FormPeluches()
        peluches.Show()
        Me.Hide()
    End Sub

    Private Sub MonedasYCambioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonedasYCambioToolStripMenuItem.Click
        Dim monedas As New Monedas()
        monedas.Show()
        Me.Hide()
    End Sub

    Private Sub TuColecciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TuColecciónToolStripMenuItem.Click
        Dim coleccion As New FormColeccion()
        coleccion.Show()
        Me.Hide()
    End Sub
End Class
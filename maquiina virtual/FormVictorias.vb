Public Class FormVictorias
    ' Método para recibir y mostrar la imagen del peluche ganado
    Public Sub CargarPremio(imagenPeluche As Image)
        If imagenPeluche IsNot Nothing Then
            ' Clonar e imponer la imagen en el PictureBox
            picPremio.Image = CType(imagenPeluche.Clone(), Image)
            picPremio.SizeMode = PictureBoxSizeMode.Zoom
            picPremio.Visible = True
            picPremio.BringToFront()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub FormVictorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
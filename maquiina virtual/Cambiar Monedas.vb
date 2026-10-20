Public Class Monedas
    Private saldoTotalMonedas As Integer = 0
    Private monedasPendientes As Integer = 0
    Private Const TASA_CAMBIO As Integer = 10
    Private Sub Monedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label7.Text = saldoTotalMonedas.ToString()
    End Sub

    Private Sub Monto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged


    End Sub

    Private Sub btnMonedas_Click(sender As Object, e As EventArgs) Handles btnMonedas.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
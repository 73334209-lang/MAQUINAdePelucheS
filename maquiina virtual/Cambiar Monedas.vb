Public Class Monedas
    ' Variables para resolver los errores de compilación
    Private saldoTotalMonedas As Integer = 0
    Private monedasPendientes As Integer = 0
    Private monedasCalculadas As Integer = 0

    ' Tasa de conversión: 1 Sol = 1 Moneda
    Private Const TASA_CONVERSION As Integer = 1

    Private Sub Monedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializa el marcador de la esquina superior
        label7.Text = saldoTotalMonedas.ToString()
    End Sub

    ' 1. EVENTO PARA EL CUADRO DE TEXTO
    Private Sub Monto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged
        monedasPendientes = 0
    End Sub

    ' 2. BOTÓN "CONVERTIR" (Calcula las monedas según el monto ingresado)
    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim monto As Decimal = 0

        ' Validar que el usuario haya ingresado o seleccionado un monto válido
        If Decimal.TryParse(txtMonto.Text, monto) AndAlso monto > 0 Then
            ' Calcular las monedas correspondientes
            monedasCalculadas = CInt(monto * TASA_CONVERSION)

            ' Actualizar la etiqueta (Label) grande en la interfaz de cambio
            lblSaldo.Text = monedasCalculadas.ToString()
        Else
            ' Mensaje de aviso en caso de dejarlo vacío o ingresar texto no numérico
            MessageBox.Show("Primero debes ingresar un monto válido y hacer clic en 'Convertir'.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' 3. BOTÓN "OBTENER MONEDAS" (Pasa las monedas pendientes al saldo total)
    Private Sub btnMonedas_Click(sender As Object, e As EventArgs) Handles btnMonedas.Click
        If monedasCalculadas > 0 Then
            ' Llamamos a la ventana abierta de FormPeluches para actualizar sus monedas virtuales
            FormPeluches.ActualizarMonedasDesdeCambio(monedasCalculadas)

            ' Cerrar esta ventana para volver a la máquina de peluches
            Me.Close()
        Else
            MessageBox.Show("Primero debes realizar una conversión para obtener monedas.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' 4. BOTÓN "VOLVER" (Regresa al menú principal)
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim menu As New FormMenu()
        menu.Show()
        Me.Hide()
    End Sub

    ' --- EVENTOS PARA LOS BOTONES DE MONEDAS FIJAS ---
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtMonto.Text = "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtMonto.Text = "2"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtMonto.Text = "5"
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        txtMonto.Text = "10"
    End Sub

    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        txtMonto.Text = "20"
    End Sub

    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click
        txtMonto.Text = "50"
    End Sub

    ' --- EVENTOS ADICIONALES VACÍOS ---
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
    End Sub
End Class

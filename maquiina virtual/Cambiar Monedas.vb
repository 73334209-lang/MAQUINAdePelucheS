Public Class Monedas
    ' Variables para el control de saldo
    Private saldoTotalMonedas As Integer = 0
    Private monedasCalculadas As Integer = 0

    ' Tasa de conversión: 1 Sol = 1 Moneda
    Private Const TASA_CONVERSION As Integer = 1

    Private Sub Monedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializa el marcador de la esquina superior si existe label7
        If label7 IsNot Nothing Then
            label7.Text = saldoTotalMonedas.ToString()
        End If
    End Sub

    ' 1. EVENTO PARA EL CUADRO DE TEXTO
    Private Sub Monto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged
        monedasCalculadas = 0
    End Sub

    ' 2. BOTÓN "CONVERTIR"
    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim monto As Decimal = 0

        ' Validar que el usuario haya ingresado un monto numérico mayor a cero
        If Decimal.TryParse(txtMonto.Text, monto) AndAlso monto > 0 Then
            ' Multiplicación corregida entre monto y TASA_CONVERSION
            monedasCalculadas = CInt(monto * TASA_CONVERSION)

            ' Actualizar la etiqueta grande en la interfaz
            lblSaldo.Text = monedasCalculadas.ToString()
        Else
            MessageBox.Show("Primero debes ingresar un monto válido y hacer clic en 'Convertir'.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' 3. BOTÓN "OBTENER MONEDAS"
    Private Sub btnMonedas_Click(sender As Object, e As EventArgs) Handles btnMonedas.Click
        If monedasCalculadas > 0 Then
            ' 1. Buscar la instancia de FormPeluches que ya está abierta en la aplicación
            Dim formJuego As FormPeluches = Application.OpenForms.OfType(Of FormPeluches)().FirstOrDefault()

            If formJuego IsNot Nothing Then
                ' Actualizar las monedas en la ventana abierta del juego
                formJuego.ActualizarMonedasDesdeCambio(monedasCalculadas)

                ' Asegurarse de que el juego sea visible y vuelva al frente
                formJuego.Show()
                formJuego.BringToFront()
                formJuego.WindowState = FormWindowState.Normal
            Else
                ' Si por alguna razón el juego no estaba abierto, crear y mostrar una nueva instancia
                formJuego = New FormPeluches()
                formJuego.ActualizarMonedasDesdeCambio(monedasCalculadas)
                formJuego.Show()
            End If

            ' 2. Mensaje de confirmación
            MessageBox.Show($"¡Se han añadido {monedasCalculadas} monedas a la máquina!",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' 3. Cerrar solo este formulario de cambio de monedas
            Me.Close()
        Else
            MessageBox.Show("Primero debes realizar una conversión para obtener monedas.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' 4. BOTÓN "VOLVER"
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

    ' --- EVENTOS ADICIONALES ---
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
    End Sub

    Private Sub label7_Click(sender As Object, e As EventArgs) Handles label7.Click

    End Sub
End Class
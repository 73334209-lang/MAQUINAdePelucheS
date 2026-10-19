Public Class FormPeluches
    Private monedas As Integer = 5
    Private intentos As Integer = 0

    Private movimientoHorizontal As Integer = 0
    Private bajando As Boolean = False
    Private subiendo As Boolean = False

    Private Sub ActualizarInformacion()

        lblMonedas.Text = "Monedas: " & monedas.ToString()
        lblIntentos.Text = "Intentos: " & intentos.ToString()

    End Sub

    Private Sub MostrarPremio()

        MessageBox.Show(
        "Has obtenido un peluche.",
        "Premio",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    )
        picPremio.Visible = True
        lblMensaje.Text = "¡Premio obtenido!"

    End Sub

    Private Sub RevisarPremio()

        Dim aleatorio As New Random()
        Dim numero As Integer = aleatorio.Next(1, 101)

        If numero <= 35 Then
            lblMensaje.Text = "¡Felicidades! Ganaste un peluche."
            MostrarPremio()
        Else
            lblMensaje.Text = "La garra falló. Intenta nuevamente."
        End If

    End Sub


    Private posicionInicialY As Integer
    Private Sub SubirGarra()

        If bajando OrElse subiendo Then
            Return
        End If

        subiendo = True
        tmrGarra.Start()

    End Sub

    Private Sub BajarGarra()

        If monedas <= 0 Then
            lblMensaje.Text = "No tienes monedas."
            Return
        End If

        If bajando OrElse subiendo Then
            Return
        End If

        monedas -= 1
        intentos += 1

        ActualizarInformacion()

        bajando = True
        subiendo = False

        tmrGarra.Start()

    End Sub


    Private Sub MoverGarra(direccion As Integer)

        Dim nuevaX As Integer = picGarra.Left + direccion

        'Límite izquierdo
        If nuevaX < 10 Then
            nuevaX = 10
        End If

        'Límite derecho
        If nuevaX > pnlJuego.Width - picGarra.Width - 10 Then
            nuevaX = pnlJuego.Width - picGarra.Width - 10
        End If

        picGarra.Left = nuevaX

    End Sub

    Private Sub pnlJuego_Paint(sender As Object, e As PaintEventArgs) Handles pnlJuego.Paint

    End Sub

    Private Sub btnIzquierda_Click(sender As Object, e As EventArgs) Handles btnIzquierda.Click
        MoverGarra(-15)
    End Sub

    Private Sub btnDerecha_Click(sender As Object, e As EventArgs) Handles btnDerecha.Click
        MoverGarra(15)
    End Sub

    Private Sub FormPeluches_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.KeyPreview = True

        posicionInicialY = picGarra.Top
        ActualizarInformacion()
        lblMensaje.Text = "¡Buena suerte!"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub tmrGarra_Tick(sender As Object, e As EventArgs) Handles tmrGarra.Tick
        If bajando Then

            picGarra.Top += 8

            'Posición máxima hacia abajo
            If picGarra.Top >= pnlJuego.Height - picGarra.Height - 30 Then

                bajando = False
                subiendo = True

                RevisarPremio()

            End If

        ElseIf subiendo Then

            picGarra.Top -= 8

            'Regresar a la posición inicial
            If picGarra.Top <= posicionInicialY Then

                picGarra.Top = posicionInicialY
                subiendo = False
                tmrGarra.Stop()

            End If

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnBajarGarra.Click
        BajarGarra()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim respuesta As DialogResult

        respuesta = MessageBox.Show(
        "¿Deseas salir del juego?",
        "Salir",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If respuesta = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        monedas = 5
        intentos = 0

        picGarra.Left = 150
        picGarra.Top = posicionInicialY

        picPremio.Visible = False

        lblMensaje.Text = "¡Buena suerte!"

        ActualizarInformacion()

    End Sub

    Private Sub FormPeluches_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode

            Case Keys.Left
                MoverGarra(-15)

            Case Keys.Right
                MoverGarra(15)

            Case Keys.Down
                BajarGarra()

            Case Keys.Up
                SubirGarra()

        End Select

    End Sub

    Private Sub lblMensaje_Click(sender As Object, e As EventArgs) Handles lblMensaje.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picElefante.Click

    End Sub
End Class
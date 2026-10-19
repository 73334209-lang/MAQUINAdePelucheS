Imports System.Drawing
Imports System.Windows.Forms

Public Class FormPeluches

    '=============================
    ' VARIABLES DEL JUEGO
    '=============================

    Private monedas As Integer = 5
    Private intentos As Integer = 0

    Private posicionInicialX As Integer
    Private posicionInicialY As Integer

    'Límite vertical hasta donde puede bajar la garra
    Private limiteInferiorGarra As Integer

    Private bajando As Boolean = False
    Private subiendo As Boolean = False

    Private movimientoHorizontal As Integer = 15
    Private velocidadVertical As Integer = 8

    Private generador As New Random()


    '=============================
    ' INICIO DEL FORMULARIO
    '=============================

    Private Sub FormPeluches_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load
        picGarra.BringToFront()
        'Permite utilizar las flechas del teclado
        Me.KeyPreview = True

        'Guardar posición inicial de la garra
        posicionInicialX = picGarra.Left
        posicionInicialY = picGarra.Top

        'La garra debe detenerse antes del área de monedas.
        '
        'Esta fórmula utiliza el límite inferior de picPeluches.
        'Asegúrate de que picPeluches cubra únicamente el área
        'donde están los peluches.
        limiteInferiorGarra =
            picPeluches.Top +
            picPeluches.Height -
            picGarra.Height -
            10

        'Evitar que el límite sea negativo
        If limiteInferiorGarra < posicionInicialY Then
            limiteInferiorGarra = posicionInicialY + 100
        End If

        'El Timer no debe comenzar al abrir el juego
        tmrGarra.Stop()

        bajando = False
        subiendo = False

        'Configurar la imagen donde aparece el premio ganado
        picPremio.Visible = False
        picPremio.SizeMode = PictureBoxSizeMode.Zoom

        ActualizarInformacion()

        lblMensaje.Text = "¡Buena suerte!"

    End Sub


    '=============================
    ' LISTA DE PREMIOS
    '=============================

    Private Function ObtenerPremios() As PictureBox()

        Return {
            picElefante,
            picPinguino,
            picPanda,
            picPato,
            picDino,
            picUnicornio,
            picConejo,
            picOso
        }

    End Function


    '=============================
    ' ACTUALIZAR INFORMACIÓN
    '=============================

    Private Sub ActualizarInformacion()

        lblMonedas.Text =
            "Monedas: " & monedas.ToString()

        lblIntentos.Text =
            "Intentos: " & intentos.ToString()

    End Sub


    '=============================
    ' MOVER LA GARRA HORIZONTALMENTE
    '=============================

    Private Sub MoverGarra(direccion As Integer)
        If bajando OrElse subiendo Then
            Return
        End If

        ' 2. Primero se declara y calcula nuevaX
        Dim nuevaX As Integer = picGarra.Left + direccion

        ' 3. Límite izquierdo
        If nuevaX < 10 Then
            nuevaX = 10
        End If

        ' 4. Límite derecho
        Dim limiteDerecho As Integer =
            pnlJuego.ClientSize.Width -
            picGarra.Width -
            10

        If nuevaX > limiteDerecho Then
            nuevaX = limiteDerecho
        End If

        ' 5. Finalmente se asigna la posición
        picGarra.Left = nuevaX
        picGarra.BringToFront()

    End Sub


    '=============================
    ' BOTÓN IZQUIERDA
    '=============================

    Private Sub btnIzquierda_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnIzquierda.Click

        MoverGarra(-movimientoHorizontal)

    End Sub


    '=============================
    ' BOTÓN DERECHA
    '=============================

    Private Sub btnDerecha_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDerecha.Click

        MoverGarra(movimientoHorizontal)

    End Sub


    '=============================
    ' TECLADO
    '=============================

    Private Sub FormPeluches_KeyDown(
        sender As Object,
        e As KeyEventArgs
    ) Handles MyBase.KeyDown

        If bajando OrElse subiendo Then
            Return
        End If

        Select Case e.KeyCode

            Case Keys.Left
                MoverGarra(-movimientoHorizontal)

            Case Keys.Right
                MoverGarra(movimientoHorizontal)

            Case Keys.Down
                BajarGarra()

            Case Keys.Up
                SubirGarra()

        End Select

    End Sub


    '=============================
    ' BOTÓN BAJAR GARRA
    '=============================

    Private Sub btnBajarGarra_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBajarGarra.Click

        BajarGarra()

    End Sub


    '=============================
    ' COMENZAR MOVIMIENTO DE BAJADA
    '=============================

    Private Sub BajarGarra()

        If monedas <= 0 Then
            lblMensaje.Text = "No tienes monedas."
            Return
        End If

        'Evita iniciar otra jugada durante una animación
        If bajando OrElse subiendo Then
            Return
        End If

        monedas -= 1
        intentos += 1

        ActualizarInformacion()

        lblMensaje.Text = "La garra está bajando..."

        bajando = True
        subiendo = False

        'El Timer comienza solamente al presionar Bajar garra
        tmrGarra.Start()

    End Sub


    '=============================
    ' SUBIR GARRA
    '=============================

    Private Sub SubirGarra()

        If Not bajando Then
            Return
        End If

        bajando = False
        subiendo = True

    End Sub


    '=============================
    ' ANIMACIÓN DE LA GARRA
    '=============================

    Private Sub tmrGarra_Tick(
        sender As Object,
        e As EventArgs
    ) Handles tmrGarra.Tick

        If bajando Then

            picGarra.Top += velocidadVertical

            'Detener la garra dentro del área de premios
            If picGarra.Top >= limiteInferiorGarra Then

                picGarra.Top = limiteInferiorGarra

                bajando = False
                subiendo = True

                'Buscar y mostrar el premio
                SeleccionarPremio()

            End If

        ElseIf subiendo Then

            picGarra.Top -= velocidadVertical

            'Regresar a la posición inicial
            If picGarra.Top <= posicionInicialY Then

                picGarra.Top = posicionInicialY

                bajando = False
                subiendo = False

                tmrGarra.Stop()

                lblMensaje.Text =
                    "Puedes realizar otro intento."

            End If

        End If

    End Sub


    '=============================
    ' OBTENER RECTÁNGULO REAL
    '=============================

    Private Function ObtenerRectanguloEnPantalla(
        control As Control
    ) As Rectangle

        Dim posicion As Point =
            control.Parent.PointToScreen(control.Location)

        Return New Rectangle(
            posicion.X,
            posicion.Y,
            control.Width,
            control.Height
        )

    End Function


    '=============================
    ' SELECCIONAR PREMIO
    '=============================

    Private Sub SeleccionarPremio()

        Dim candidatos As New List(Of PictureBox)

        Dim rectanguloGarra As Rectangle =
            ObtenerRectanguloEnPantalla(picGarra)

        For Each premio As PictureBox In ObtenerPremios()

            If premio IsNot Nothing AndAlso
               premio.Visible AndAlso
               premio.Image IsNot Nothing Then

                Dim rectanguloPremio As Rectangle =
                    ObtenerRectanguloEnPantalla(premio)

                If rectanguloGarra.IntersectsWith(
                    rectanguloPremio
                ) Then

                    candidatos.Add(premio)

                End If

            End If

        Next

        If candidatos.Count = 0 Then

            lblMensaje.Text =
                "La garra no alcanzó ningún peluche."

            Return

        End If

        'Si hay más de un peluche debajo,
        'se selecciona uno aleatoriamente.
        Dim indice As Integer =
            generador.Next(0, candidatos.Count)

        Dim premioSeleccionado As PictureBox =
            candidatos(indice)

        MostrarPremio(premioSeleccionado)

    End Sub


    '=============================
    ' MOSTRAR EL PREMIO GANADO
    '=============================

    Private Sub MostrarPremio(
        premioSeleccionado As PictureBox
    )

        If premioSeleccionado Is Nothing Then

            lblMensaje.Text =
                "No se seleccionó ningún premio."

            Return

        End If

        If premioSeleccionado.Image Is Nothing Then

            lblMensaje.Text =
                "El premio no tiene imagen."

            Return

        End If

        'Eliminar la imagen anterior del área de salida
        If picPremio.Image IsNot Nothing Then

            picPremio.Image.Dispose()
            picPremio.Image = Nothing

        End If

        'Copiar la imagen del peluche ganador
        picPremio.Image =
            New Bitmap(premioSeleccionado.Image)

        picPremio.Visible = True

        'Ocultar el peluche dentro de la máquina
        premioSeleccionado.Visible = False

        lblMensaje.Text =
            "¡Ganaste un premio!"

    End Sub


    '=============================
    ' BOTÓN SALIR
    '=============================

    Private Sub btnSalir_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSalir.Click

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


    '=============================
    ' BOTÓN REINICIAR
    '=============================

    Private Sub btnReiniciar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnReiniciar.Click

        monedas = 5
        intentos = 0

        bajando = False
        subiendo = False

        tmrGarra.Stop()

        'Restaurar posición de la garra
        picGarra.Left = posicionInicialX
        picGarra.Top = posicionInicialY

        'Mostrar nuevamente los ocho peluches
        For Each premio As PictureBox In ObtenerPremios()

            premio.Visible = True

        Next

        'Limpiar la zona del premio ganado
        If picPremio.Image IsNot Nothing Then

            picPremio.Image.Dispose()
            picPremio.Image = Nothing

        End If

        picPremio.Visible = False

        lblMensaje.Text =
            "¡Buena suerte!"

        ActualizarInformacion()

    End Sub

End Class

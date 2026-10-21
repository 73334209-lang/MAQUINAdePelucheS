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
    ' MÉTODO CORREGIDO PARA RECIBIR MONEDAS
    '=============================
    Public Sub ActualizarMonedasDesdeCambio(cantidadNuevasMonedas As Integer)
        ' 1. Sumamos las nuevas monedas a la variable interna 'monedas'
        monedas += cantidadNuevasMonedas

        ' 2. Reflejamos el nuevo total actualizado en los controles visuales
        ActualizarInformacion()
    End Sub

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

        'Ajustar la altura de bajada de la garra
        limiteInferiorGarra = picPeluches.Top + (picPeluches.Height \ 2)

        If limiteInferiorGarra < posicionInicialY Then
            limiteInferiorGarra = posicionInicialY + 100
        End If

        'El Timer no debe comenzar al abrir el juego
        tmrGarra.Stop()

        bajando = False
        subiendo = False

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

        lblMonedas.Text = "Monedas: " & monedas.ToString()
        lblIntentos.Text = "Intentos: " & intentos.ToString()

    End Sub


    '=============================
    ' MOVER LA GARRA HORIZONTALMENTE
    '=============================

    Private Sub MoverGarra(direccion As Integer)

        If bajando OrElse subiendo Then
            Return
        End If

        Dim nuevaX As Integer = picGarra.Left + direccion

        'Límite izquierdo
        If nuevaX < 10 Then
            nuevaX = 10
        End If

        'Límite derecho
        Dim limiteDerecho As Integer = pnlJuego.ClientSize.Width - picGarra.Width - 10

        If nuevaX > limiteDerecho Then
            nuevaX = limiteDerecho
        End If

        picGarra.Left = nuevaX
        picGarra.BringToFront()

    End Sub


    '=============================
    ' BOTONES DE CONTROL E INPUTS
    '=============================

    Private Sub btnIzquierda_Click(sender As Object, e As EventArgs) Handles btnIzquierda.Click
        MoverGarra(-movimientoHorizontal)
    End Sub

    Private Sub btnDerecha_Click(sender As Object, e As EventArgs) Handles btnDerecha.Click
        MoverGarra(movimientoHorizontal)
    End Sub

    Private Sub FormPeluches_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

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

    Private Sub btnBajarGarra_Click(sender As Object, e As EventArgs) Handles btnBajarGarra.Click
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

        If bajando OrElse subiendo Then
            Return
        End If

        monedas -= 1
        intentos += 1

        ActualizarInformacion()

        lblMensaje.Text = "La garra está bajando..."

        bajando = True
        subiendo = False

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

    Private Sub tmrGarra_Tick(sender As Object, e As EventArgs) Handles tmrGarra.Tick

        picGarra.BringToFront()

        If bajando Then

            picGarra.Top += velocidadVertical

            If picGarra.Top >= limiteInferiorGarra Then
                picGarra.Top = limiteInferiorGarra
                bajando = False
                subiendo = True

                ' Evaluar si atrapa premio al tocar el punto más bajo
                SeleccionarPremio()
            End If

        ElseIf subiendo Then

            picGarra.Top -= velocidadVertical

            If picGarra.Top <= posicionInicialY Then
                picGarra.Top = posicionInicialY
                bajando = False
                subiendo = False
                tmrGarra.Stop()

                lblMensaje.Text = "Puedes realizar otro intento."
            End If

        End If

    End Sub


    '=============================
    ' SELECCIONAR PREMIO (CON AZAR Y PROBABILIDAD)
    '=============================

    Private Sub SeleccionarPremio()

        Dim candidatos As New List(Of PictureBox)
        Dim centroGarraX As Integer = picGarra.Left + (picGarra.Width \ 2)

        ' 1. Detectar peluches debajo de la garra
        For Each premio As PictureBox In ObtenerPremios()
            If premio IsNot Nothing AndAlso premio.Visible Then
                Dim izquierdaPeluche As Integer = premio.Left
                Dim derechaPeluche As Integer = premio.Left + premio.Width

                If centroGarraX >= izquierdaPeluche AndAlso centroGarraX <= derechaPeluche Then
                    candidatos.Add(premio)
                End If
            End If
        Next

        ' Si no está sobre ningún peluche
        If candidatos.Count = 0 Then
            lblMensaje.Text = "La garra no alcanzó ningún peluche."
            Return
        End If

        ' 2. Agregar probabilidad de fallo (Ejemplo: 40% de éxito)
        Dim probabilidadExito As Integer = 40
        If generador.Next(1, 101) > probabilidadExito Then
            lblMensaje.Text = "¡El peluche se le resbaló a la garra!"
            Return
        End If

        ' 3. Elegir un peluche aleatorio entre los alcanzados
        Dim indice As Integer = generador.Next(0, candidatos.Count)
        Dim premioSeleccionado As PictureBox = candidatos(indice)

        MostrarPremio(premioSeleccionado)

    End Sub


    '=============================
    ' MOSTRAR EL PREMIO GANADO
    '=============================

    Private Sub MostrarPremio(premioSeleccionado As PictureBox)

        If premioSeleccionado Is Nothing OrElse premioSeleccionado.Image Is Nothing Then
            lblMensaje.Text = "No se pudo obtener la imagen del premio."
            Return
        End If

        ' Ocultar el peluche atrapado dentro de la máquina
        premioSeleccionado.Visible = False

        lblMensaje.Text = "¡Atrapaste un premio!"

        ' Crear y mostrar la ventana emergente enviando la imagen
        Dim ventanaGanador As New FormVictorias()
        ventanaGanador.CargarPremio(premioSeleccionado.Image)
        ventanaGanador.ShowDialog()
    End Sub


    '=============================
    ' BOTONES DE SALIR Y REINICIAR
    '=============================

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Dim menu As New FormMenu()
        menu.Show()
        Me.Hide()

    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click

        monedas = 5
        intentos = 0

        bajando = False
        subiendo = False

        tmrGarra.Stop()

        picGarra.Left = posicionInicialX
        picGarra.Top = posicionInicialY

        ' Restaurar visibilidad de todos los peluches
        For Each premio As PictureBox In ObtenerPremios()
            If premio IsNot Nothing Then
                premio.Visible = True
            End If
        Next

        lblMensaje.Text = "¡Buena suerte!"
        ActualizarInformacion()

    End Sub

End Class
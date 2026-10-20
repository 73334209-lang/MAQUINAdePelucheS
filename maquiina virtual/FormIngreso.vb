Public Class FormIngreso
    Private progreso As Integer = 0

    Private Sub FormIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Máquina de Peluches - Pantalla de Carga"
        Me.BackColor = Color.LightBlue
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False

        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle

        Panel2.Location = New Point(0, 0)
        Panel2.Size = New Size(0, Panel1.Height - 4)
        Panel2.BackColor = Color.DeepPink

        Label1.Text = "¡Cargando los peluches más tiernos!"
        Label2.Text = "Por favor, espera."

        Label1.TextAlign = ContentAlignment.MiddleCenter
        Label2.TextAlign = ContentAlignment.MiddleCenter

        Label1.Font = New Font("Arial", 9, FontStyle.Bold)
        Label2.Font = New Font("Arial", 9, FontStyle.Bold)

        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

        Timer1.Interval = 50
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If progreso < 100 Then
            progreso += 2
        End If

        Panel2.BackColor = Color.DeepPink

        Panel2.Width = CInt(Panel1.ClientSize.Width * progreso / 100)

        If progreso >= 100 Then
            Timer1.Stop()
        End If

    End Sub
End Class
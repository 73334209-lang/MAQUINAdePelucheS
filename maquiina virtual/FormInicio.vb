Public Class FormInicio

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        FormRegistro.Show()
        Hide()
    End Sub

    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Ocultar la contraseña al iniciar
        TextBox2.UseSystemPasswordChar = True

        ' Configurar la casilla
        CheckBox1.Text = "Mostrar contraseña"
        CheckBox1.Checked = False

        ' Título de la ventana
        Me.Text = "Máquina de Peluches"

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        ' Mostrar u ocultar la contraseña
        TextBox2.UseSystemPasswordChar = Not CheckBox1.Checked

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text.Trim() = "admin" AndAlso TextBox2.Text = "123" Then

            MessageBox.Show("¡Bienvenido a Máquina de Peluches!",
                            "Acceso correcto",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            ' Aquí puedes abrir tu siguiente formulario

        Else

            MessageBox.Show("Usuario o contraseña incorrectos.",
                            "Acceso denegado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

        End If
        Dim menu As New FormMenu()
        menu.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
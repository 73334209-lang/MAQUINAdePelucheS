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

        ' Verificar que los campos no estén vacíos
        If TextBox1.Text.Trim() = "" Then
            MessageBox.Show("Ingresa tu usuario o correo.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Focus()
            Exit Sub
        End If

        If TextBox2.Text = "" Then
            MessageBox.Show("Ingresa tu contraseña.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox2.Focus()
            Exit Sub
        End If

        ' Todavía no se ha conectado una base de datos
        MessageBox.Show("Los campos están completos. Falta validar el acceso.",
                        "Máquina de Peluches",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

End Class
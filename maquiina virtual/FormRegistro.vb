Public Class FormRegistro
    Private Sub FormRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Registro - Máquina de Peluches"
        Me.StartPosition = FormStartPosition.CenterScreen

        TextBox3.UseSystemPasswordChar = True
        TextBox4.UseSystemPasswordChar = True

        CheckBox1.Text = "Mostrar"
        CheckBox1.Checked = False

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        TextBox3.UseSystemPasswordChar = Not CheckBox1.Checked
        TextBox4.UseSystemPasswordChar = Not CheckBox1.Checked

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text.Trim() = "" OrElse
           TextBox2.Text.Trim() = "" OrElse
           TextBox3.Text = "" OrElse
           TextBox4.Text = "" Then

            MessageBox.Show("Completa todos los campos.",
                            "Máquina de Peluches",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub

        End If

        If Not TextBox2.Text.Contains("@") OrElse
           Not TextBox2.Text.Contains(".") Then

            MessageBox.Show("Ingresa un correo válido.")
            Exit Sub

        End If

        If TextBox3.Text <> TextBox4.Text Then

            MessageBox.Show("Las contraseñas no coinciden.")
            Exit Sub

        End If

        MessageBox.Show("¡Registro validado correctamente!",
                        "Máquina de Peluches",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormInicio.Show()
        Hide()

    End Sub

End Class
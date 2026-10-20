<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistro))
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        CheckBox1 = New CheckBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(-1, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(681, 407)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(288, 156)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(196, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(288, 197)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(196, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(288, 247)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(196, 23)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(288, 292)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(196, 23)
        TextBox4.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.DialogResult = DialogResult.TryAgain
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(164, 340)
        Button1.Name = "Button1"
        Button1.Size = New Size(161, 44)
        Button1.TabIndex = 5
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(359, 340)
        Button2.Name = "Button2"
        Button2.Size = New Size(134, 44)
        Button2.TabIndex = 6
        Button2.TextAlign = ContentAlignment.TopCenter
        Button2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(490, 251)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(67, 19)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Mostrar"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' FormRegistro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(679, 406)
        Controls.Add(CheckBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Name = "FormRegistro"
        Text = "FormRegistro"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class

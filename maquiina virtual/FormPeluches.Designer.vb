<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPeluches
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPeluches))
        pnlJuego = New Panel()
        picElefante = New PictureBox()
        picPremio = New PictureBox()
        picGarra = New PictureBox()
        PictureBox3 = New PictureBox()
        btnDerecha = New Button()
        btnIzquierda = New Button()
        Button3 = New Button()
        Button4 = New Button()
        btnBajarGarra = New Button()
        GroupBox1 = New GroupBox()
        lblIntentos = New Label()
        lblMonedas = New Label()
        GroupBox2 = New GroupBox()
        lblMensaje = New Label()
        btnSalir = New Button()
        PictureBox1 = New PictureBox()
        tmrGarra = New Timer(components)
        btnReiniciar = New Button()
        pnlJuego.SuspendLayout()
        CType(picElefante, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPremio, ComponentModel.ISupportInitialize).BeginInit()
        CType(picGarra, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlJuego
        ' 
        pnlJuego.Controls.Add(picElefante)
        pnlJuego.Controls.Add(picPremio)
        pnlJuego.Controls.Add(picGarra)
        pnlJuego.Controls.Add(PictureBox3)
        pnlJuego.Location = New Point(1, 71)
        pnlJuego.Name = "pnlJuego"
        pnlJuego.Size = New Size(334, 491)
        pnlJuego.TabIndex = 0
        ' 
        ' picElefante
        ' 
        picElefante.Image = My.Resources.Resources.image__3_
        picElefante.Location = New Point(33, 255)
        picElefante.Name = "picElefante"
        picElefante.Size = New Size(66, 86)
        picElefante.SizeMode = PictureBoxSizeMode.StretchImage
        picElefante.TabIndex = 11
        picElefante.TabStop = False
        ' 
        ' picPremio
        ' 
        picPremio.Location = New Point(324, 625)
        picPremio.Name = "picPremio"
        picPremio.Size = New Size(31, 42)
        picPremio.TabIndex = 11
        picPremio.TabStop = False
        picPremio.Visible = False
        ' 
        ' picGarra
        ' 
        picGarra.Image = My.Resources.Resources.image__2_
        picGarra.Location = New Point(134, 33)
        picGarra.Name = "picGarra"
        picGarra.Size = New Size(85, 106)
        picGarra.TabIndex = 10
        picGarra.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Gemini_Generated_Image_ze27duze27duze27
        PictureBox3.Location = New Point(17, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(314, 467)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' btnDerecha
        ' 
        btnDerecha.BackgroundImage = CType(resources.GetObject("btnDerecha.BackgroundImage"), Image)
        btnDerecha.BackgroundImageLayout = ImageLayout.Zoom
        btnDerecha.Location = New Point(474, 136)
        btnDerecha.Name = "btnDerecha"
        btnDerecha.Size = New Size(60, 59)
        btnDerecha.TabIndex = 1
        btnDerecha.UseVisualStyleBackColor = True
        ' 
        ' btnIzquierda
        ' 
        btnIzquierda.BackgroundImage = CType(resources.GetObject("btnIzquierda.BackgroundImage"), Image)
        btnIzquierda.BackgroundImageLayout = ImageLayout.Zoom
        btnIzquierda.Location = New Point(372, 136)
        btnIzquierda.Name = "btnIzquierda"
        btnIzquierda.Size = New Size(60, 59)
        btnIzquierda.TabIndex = 2
        btnIzquierda.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.Location = New Point(423, 71)
        Button3.Name = "Button3"
        Button3.Size = New Size(60, 59)
        Button3.TabIndex = 3
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.LightBlue
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Zoom
        Button4.Location = New Point(423, 201)
        Button4.Name = "Button4"
        Button4.Size = New Size(60, 59)
        Button4.TabIndex = 4
        Button4.UseVisualStyleBackColor = False
        ' 
        ' btnBajarGarra
        ' 
        btnBajarGarra.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnBajarGarra.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBajarGarra.ForeColor = Color.White
        btnBajarGarra.Location = New Point(362, 266)
        btnBajarGarra.Name = "btnBajarGarra"
        btnBajarGarra.Size = New Size(170, 45)
        btnBajarGarra.TabIndex = 5
        btnBajarGarra.Text = "Bajar garra"
        btnBajarGarra.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        GroupBox1.Controls.Add(lblIntentos)
        GroupBox1.Controls.Add(lblMonedas)
        GroupBox1.Location = New Point(341, 326)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(213, 109)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Información del juego"
        ' 
        ' lblIntentos
        ' 
        lblIntentos.BackColor = Color.White
        lblIntentos.Location = New Point(50, 68)
        lblIntentos.Name = "lblIntentos"
        lblIntentos.Size = New Size(109, 23)
        lblIntentos.TabIndex = 3
        lblIntentos.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblMonedas
        ' 
        lblMonedas.BackColor = Color.White
        lblMonedas.Location = New Point(50, 33)
        lblMonedas.Name = "lblMonedas"
        lblMonedas.Size = New Size(109, 21)
        lblMonedas.TabIndex = 2
        lblMonedas.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        GroupBox2.Controls.Add(lblMensaje)
        GroupBox2.Location = New Point(341, 444)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(213, 67)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Mensaje"
        ' 
        ' lblMensaje
        ' 
        lblMensaje.AutoSize = True
        lblMensaje.Location = New Point(62, 32)
        lblMensaje.Name = "lblMensaje"
        lblMensaje.Size = New Size(41, 15)
        lblMensaje.TabIndex = 0
        lblMensaje.Text = "Label3"
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnSalir.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSalir.ForeColor = Color.White
        btnSalir.Location = New Point(362, 517)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(170, 45)
        btnSalir.TabIndex = 8
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.image__1_
        PictureBox1.Location = New Point(1, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(553, 63)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' tmrGarra
        ' 
        ' 
        ' btnReiniciar
        ' 
        btnReiniciar.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnReiniciar.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReiniciar.ForeColor = Color.White
        btnReiniciar.Location = New Point(362, 568)
        btnReiniciar.Name = "btnReiniciar"
        btnReiniciar.Size = New Size(170, 45)
        btnReiniciar.TabIndex = 10
        btnReiniciar.Text = "Reiniciar"
        btnReiniciar.UseVisualStyleBackColor = False
        ' 
        ' FormPeluches
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(558, 750)
        Controls.Add(btnReiniciar)
        Controls.Add(PictureBox1)
        Controls.Add(btnSalir)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnBajarGarra)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(btnIzquierda)
        Controls.Add(btnDerecha)
        Controls.Add(pnlJuego)
        KeyPreview = True
        Name = "FormPeluches"
        Text = "FormPeluches"
        pnlJuego.ResumeLayout(False)
        CType(picElefante, ComponentModel.ISupportInitialize).EndInit()
        CType(picPremio, ComponentModel.ISupportInitialize).EndInit()
        CType(picGarra, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlJuego As Panel
    Friend WithEvents btnDerecha As Button
    Friend WithEvents btnIzquierda As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnBajarGarra As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblIntentos As Label
    Friend WithEvents lblMonedas As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblMensaje As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picGarra As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents tmrGarra As Timer
    Friend WithEvents picPremio As PictureBox
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents picElefante As PictureBox
End Class

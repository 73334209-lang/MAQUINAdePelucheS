<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Monedas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Monedas))
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        btnConvertir = New Button()
        txtMonto = New TextBox()
        Label6 = New Label()
        MontoenSoles = New Label()
        btn50 = New Button()
        btn20 = New Button()
        btn10 = New Button()
        btn5 = New Button()
        btn2 = New Button()
        btn1 = New Button()
        SeleccionarMonto = New Label()
        Panel2 = New Panel()
        btnMonedas = New Button()
        btnVolver = New Button()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel4 = New Panel()
        Label9 = New Label()
        lblSaldo = New Label()
        label7 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(209, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 23)
        Label2.TabIndex = 1
        Label2.Text = "Monedas vituales"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.titulo
        PictureBox1.Location = New Point(-8, -3)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1214, 254)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel1.Controls.Add(btnConvertir)
        Panel1.Controls.Add(txtMonto)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(MontoenSoles)
        Panel1.Controls.Add(btn50)
        Panel1.Controls.Add(btn20)
        Panel1.Controls.Add(btn10)
        Panel1.Controls.Add(btn5)
        Panel1.Controls.Add(btn2)
        Panel1.Controls.Add(btn1)
        Panel1.Controls.Add(SeleccionarMonto)
        Panel1.Location = New Point(1, 259)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(575, 419)
        Panel1.TabIndex = 5
        ' 
        ' btnConvertir
        ' 
        btnConvertir.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConvertir.Location = New Point(280, 349)
        btnConvertir.Margin = New Padding(3, 4, 3, 4)
        btnConvertir.Name = "btnConvertir"
        btnConvertir.Size = New Size(150, 42)
        btnConvertir.TabIndex = 10
        btnConvertir.Text = "Convertir"
        btnConvertir.UseVisualStyleBackColor = True
        ' 
        ' txtMonto
        ' 
        txtMonto.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtMonto.Location = New Point(67, 349)
        txtMonto.Margin = New Padding(3, 4, 3, 4)
        txtMonto.Name = "txtMonto"
        txtMonto.Size = New Size(183, 38)
        txtMonto.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(27, 348)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 37)
        Label6.TabIndex = 8
        Label6.Text = "S/"
        ' 
        ' MontoenSoles
        ' 
        MontoenSoles.AutoSize = True
        MontoenSoles.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MontoenSoles.Location = New Point(27, 299)
        MontoenSoles.Name = "MontoenSoles"
        MontoenSoles.Size = New Size(202, 25)
        MontoenSoles.TabIndex = 7
        MontoenSoles.Text = "Monto Personalizado"
        ' 
        ' btn50
        ' 
        btn50.BackgroundImage = My.Resources.Resources.Moneda
        btn50.BackgroundImageLayout = ImageLayout.Zoom
        btn50.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btn50.Location = New Point(385, 176)
        btn50.Margin = New Padding(3, 4, 3, 4)
        btn50.Name = "btn50"
        btn50.Size = New Size(173, 88)
        btn50.TabIndex = 6
        btn50.Text = "S/50.00"
        btn50.UseVisualStyleBackColor = True
        ' 
        ' btn20
        ' 
        btn20.BackgroundImage = My.Resources.Resources.Moneda
        btn20.BackgroundImageLayout = ImageLayout.Zoom
        btn20.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btn20.Location = New Point(192, 176)
        btn20.Margin = New Padding(3, 4, 3, 4)
        btn20.Name = "btn20"
        btn20.Size = New Size(166, 88)
        btn20.TabIndex = 5
        btn20.Text = "S/20.00"
        btn20.UseVisualStyleBackColor = True
        ' 
        ' btn10
        ' 
        btn10.BackgroundImage = My.Resources.Resources.Moneda
        btn10.BackgroundImageLayout = ImageLayout.Zoom
        btn10.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btn10.Location = New Point(10, 176)
        btn10.Margin = New Padding(3, 4, 3, 4)
        btn10.Name = "btn10"
        btn10.Size = New Size(167, 88)
        btn10.TabIndex = 4
        btn10.Text = "S/10.00"
        btn10.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.BackgroundImage = My.Resources.Resources.Moneda
        btn5.BackgroundImageLayout = ImageLayout.Zoom
        btn5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btn5.Location = New Point(385, 63)
        btn5.Margin = New Padding(3, 4, 3, 4)
        btn5.Name = "btn5"
        btn5.Size = New Size(173, 88)
        btn5.TabIndex = 3
        btn5.Text = "S/5.00"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.BackgroundImage = My.Resources.Resources.Moneda
        btn2.BackgroundImageLayout = ImageLayout.Zoom
        btn2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btn2.Location = New Point(192, 63)
        btn2.Margin = New Padding(3, 4, 3, 4)
        btn2.Name = "btn2"
        btn2.Size = New Size(166, 88)
        btn2.TabIndex = 2
        btn2.Text = "S/2.00"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.BackgroundImage = My.Resources.Resources.Moneda
        btn1.BackgroundImageLayout = ImageLayout.Zoom
        btn1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btn1.Location = New Point(10, 63)
        btn1.Margin = New Padding(3, 4, 3, 4)
        btn1.Name = "btn1"
        btn1.Size = New Size(167, 88)
        btn1.TabIndex = 1
        btn1.Text = "S/1.00"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' SeleccionarMonto
        ' 
        SeleccionarMonto.AutoSize = True
        SeleccionarMonto.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SeleccionarMonto.Location = New Point(10, 15)
        SeleccionarMonto.Name = "SeleccionarMonto"
        SeleccionarMonto.Size = New Size(191, 25)
        SeleccionarMonto.TabIndex = 0
        SeleccionarMonto.Text = "Selecciona el Monto"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel2.Controls.Add(btnMonedas)
        Panel2.Controls.Add(btnVolver)
        Panel2.Location = New Point(1, 686)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(577, 149)
        Panel2.TabIndex = 6
        ' 
        ' btnMonedas
        ' 
        btnMonedas.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        btnMonedas.BackgroundImage = My.Resources.Resources.Moneda
        btnMonedas.BackgroundImageLayout = ImageLayout.Zoom
        btnMonedas.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMonedas.ImageAlign = ContentAlignment.BottomCenter
        btnMonedas.Location = New Point(239, 18)
        btnMonedas.Margin = New Padding(3, 4, 3, 4)
        btnMonedas.Name = "btnMonedas"
        btnMonedas.Size = New Size(320, 81)
        btnMonedas.TabIndex = 1
        btnMonedas.Text = "Obtener Monedas"
        btnMonedas.UseVisualStyleBackColor = False
        ' 
        ' btnVolver
        ' 
        btnVolver.BackgroundImage = CType(resources.GetObject("btnVolver.BackgroundImage"), Image)
        btnVolver.BackgroundImageLayout = ImageLayout.Stretch
        btnVolver.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVolver.ForeColor = SystemColors.ButtonHighlight
        btnVolver.Location = New Point(11, 17)
        btnVolver.Margin = New Padding(3, 4, 3, 4)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(179, 82)
        btnVolver.TabIndex = 0
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ButtonHighlight
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(PictureBox3)
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(lblSaldo)
        Panel3.Controls.Add(label7)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(591, 260)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(586, 575)
        Panel3.TabIndex = 7
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Moneda
        PictureBox2.Location = New Point(104, 47)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(98, 113)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.oso_v2
        PictureBox3.Location = New Point(309, 369)
        PictureBox3.Margin = New Padding(3, 4, 3, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(278, 213)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        Panel4.Controls.Add(Label9)
        Panel4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel4.Location = New Point(94, 176)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(401, 164)
        Panel4.TabIndex = 2
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(86, 84)
        Label9.Name = "Label9"
        Label9.Size = New Size(236, 40)
        Label9.TabIndex = 0
        Label9.Text = "Las Monedas Virtuales se usan en" & vbCrLf & " la Maquina de Peluches"
        ' 
        ' lblSaldo
        ' 
        lblSaldo.AutoSize = True
        lblSaldo.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSaldo.Location = New Point(227, 25)
        lblSaldo.Name = "lblSaldo"
        lblSaldo.Size = New Size(91, 106)
        lblSaldo.TabIndex = 1
        lblSaldo.Text = "0"
        ' 
        ' label7
        ' 
        label7.AutoSize = True
        label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label7.Location = New Point(25, 8)
        label7.Name = "label7"
        label7.Size = New Size(185, 32)
        label7.TabIndex = 0
        label7.Text = "Tu saldo actual"
        ' 
        ' Monedas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1189, 943)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "Monedas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cambiar Monedas"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SeleccionarMonto As Label
    Friend WithEvents btn50 As Button
    Friend WithEvents btn20 As Button
    Friend WithEvents btn10 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnConvertir As Button
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MontoenSoles As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnMonedas As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents label7 As Label
    Friend WithEvents lblSaldo As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class

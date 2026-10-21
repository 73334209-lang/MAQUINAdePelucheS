<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIngreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIngreso))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Timer1 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.GradientInactiveCaption
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.ErrorImage = Nothing
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(697, 391)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel2)
        Panel1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Panel1.Location = New Point(170, 257)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(372, 32)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.ForeColor = Color.Fuchsia
        Panel2.Location = New Point(8, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(359, 24)
        Panel2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientInactiveCaption
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Fuchsia
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(216, 309)
        Label1.Name = "Label1"
        Label1.Size = New Size(284, 21)
        Label1.TabIndex = 3
        Label1.Text = "¡Cargando los peluches más tiernos!"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientInactiveCaption
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Fuchsia
        Label2.ImageAlign = ContentAlignment.TopCenter
        Label2.Location = New Point(273, 330)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 21)
        Label2.TabIndex = 4
        Label2.Text = "Por favor, espera."
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 50
        ' 
        ' FormIngreso
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuBar
        ClientSize = New Size(697, 391)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormIngreso"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormIngreso"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
End Class

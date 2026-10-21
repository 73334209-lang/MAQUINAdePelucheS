<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        MenuStrip1 = New MenuStrip()
        LaMaquinaDeJuegoToolStripMenuItem = New ToolStripMenuItem()
        MonedasYCambioToolStripMenuItem = New ToolStripMenuItem()
        TuColecciónToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {LaMaquinaDeJuegoToolStripMenuItem, MonedasYCambioToolStripMenuItem, TuColecciónToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(638, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' LaMaquinaDeJuegoToolStripMenuItem
        ' 
        LaMaquinaDeJuegoToolStripMenuItem.Name = "LaMaquinaDeJuegoToolStripMenuItem"
        LaMaquinaDeJuegoToolStripMenuItem.Size = New Size(130, 20)
        LaMaquinaDeJuegoToolStripMenuItem.Text = "La maquina de juego"
        ' 
        ' MonedasYCambioToolStripMenuItem
        ' 
        MonedasYCambioToolStripMenuItem.Name = "MonedasYCambioToolStripMenuItem"
        MonedasYCambioToolStripMenuItem.Size = New Size(120, 20)
        MonedasYCambioToolStripMenuItem.Text = "Monedas y cambio"
        ' 
        ' TuColecciónToolStripMenuItem
        ' 
        TuColecciónToolStripMenuItem.Name = "TuColecciónToolStripMenuItem"
        TuColecciónToolStripMenuItem.Size = New Size(86, 20)
        TuColecciónToolStripMenuItem.Text = "Tu colección"
        ' 
        ' FormMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(638, 338)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FormMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormMenu"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LaMaquinaDeJuegoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonedasYCambioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TuColecciónToolStripMenuItem As ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVictorias
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
        Label1 = New Label()
        picPremio = New PictureBox()
        btnAceptar = New Button()
        CType(picPremio, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MediumVioletRed
        Label1.Location = New Point(1, -6)
        Label1.Name = "Label1"
        Label1.Size = New Size(351, 76)
        Label1.TabIndex = 0
        Label1.Text = "¡FELICIDADES," & vbCrLf & "GANASTE ESTE PELUCHE!"
        ' 
        ' picPremio
        ' 
        picPremio.Location = New Point(92, 100)
        picPremio.Margin = New Padding(3, 4, 3, 4)
        picPremio.Name = "picPremio"
        picPremio.Size = New Size(145, 208)
        picPremio.SizeMode = PictureBoxSizeMode.StretchImage
        picPremio.TabIndex = 12
        picPremio.TabStop = False
        picPremio.Visible = False
        ' 
        ' btnAceptar
        ' 
        btnAceptar.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnAceptar.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAceptar.ForeColor = Color.White
        btnAceptar.Location = New Point(66, 326)
        btnAceptar.Margin = New Padding(3, 4, 3, 4)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(194, 60)
        btnAceptar.TabIndex = 13
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = False
        ' 
        ' FormVictorias
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(344, 399)
        Controls.Add(btnAceptar)
        Controls.Add(picPremio)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormVictorias"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormVictorias"
        CType(picPremio, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents picPremio As PictureBox
    Friend WithEvents btnAceptar As Button
End Class

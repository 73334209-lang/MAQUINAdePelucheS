<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(143, 116)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(250, 125)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(953, 881)
        Controls.Add(FlowLayoutPanel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Maquina de Peluches"
        ResumeLayout(False)
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel

End Class

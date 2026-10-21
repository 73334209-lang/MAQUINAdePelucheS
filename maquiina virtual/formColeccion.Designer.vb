<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formColeccion
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
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        lblTotal = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox9 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        btnCerrar = New Button()
        btnVolverjugar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Captura_de_pantalla_2026_10_19_181724
        PictureBox1.Location = New Point(2, 3)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(480, 93)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblTotal)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(2, 104)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(125, 271)
        Panel1.TabIndex = 1
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(24, 207)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(86, 20)
        lblTotal.TabIndex = 2
        lblTotal.Text = "Total: 4/30"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 53)
        Label2.TabIndex = 1
        Label2.Text = "¡Tus Peluches Ganados!"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(24, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 62)
        Label1.TabIndex = 0
        Label1.Text = "🏆"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(130, 108)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(352, 267)
        Panel2.TabIndex = 2
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(PictureBox9, 3, 1)
        TableLayoutPanel1.Controls.Add(PictureBox8, 2, 1)
        TableLayoutPanel1.Controls.Add(PictureBox7, 1, 1)
        TableLayoutPanel1.Controls.Add(PictureBox6, 0, 1)
        TableLayoutPanel1.Controls.Add(PictureBox5, 3, 0)
        TableLayoutPanel1.Controls.Add(PictureBox4, 2, 0)
        TableLayoutPanel1.Controls.Add(PictureBox3, 1, 0)
        TableLayoutPanel1.Controls.Add(PictureBox2, 0, 0)
        TableLayoutPanel1.Location = New Point(130, 104)
        TableLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(352, 271)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Image = My.Resources.Resources.a5793530_ef71_4d5a_9ca9_de45de023028
        PictureBox9.Location = New Point(267, 139)
        PictureBox9.Margin = New Padding(3, 4, 3, 4)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(81, 128)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 7
        PictureBox9.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources._5d52e7c2_07a0_456c_b860_60bbf881d13e
        PictureBox8.Location = New Point(179, 139)
        PictureBox8.Margin = New Padding(3, 4, 3, 4)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(81, 128)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 6
        PictureBox8.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources._55474c66_5775_4151_9174_e8b31cd9a2b0
        PictureBox7.Location = New Point(91, 139)
        PictureBox7.Margin = New Padding(3, 4, 3, 4)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(81, 128)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 5
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.e263a657_1db4_42d1_bb2f_79e69a263e5c
        PictureBox6.Location = New Point(3, 139)
        PictureBox6.Margin = New Padding(3, 4, 3, 4)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(81, 128)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 4
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.image__3_1
        PictureBox5.Location = New Point(267, 4)
        PictureBox5.Margin = New Padding(3, 4, 3, 4)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(81, 127)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 3
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources._1
        PictureBox4.Location = New Point(179, 4)
        PictureBox4.Margin = New Padding(3, 4, 3, 4)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(81, 127)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 2
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources._2
        PictureBox3.Location = New Point(91, 4)
        PictureBox3.Margin = New Padding(3, 4, 3, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(81, 127)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.watermarked_img_15318072709546256769
        PictureBox2.Location = New Point(3, 4)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(81, 127)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Location = New Point(310, 383)
        btnCerrar.Margin = New Padding(3, 4, 3, 4)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(163, 55)
        btnCerrar.TabIndex = 3
        btnCerrar.Text = "CERRAR"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' btnVolverjugar
        ' 
        btnVolverjugar.Location = New Point(134, 383)
        btnVolverjugar.Margin = New Padding(3, 4, 3, 4)
        btnVolverjugar.Name = "btnVolverjugar"
        btnVolverjugar.Size = New Size(163, 55)
        btnVolverjugar.TabIndex = 4
        btnVolverjugar.Text = "VOLVER A JUGAR"
        btnVolverjugar.UseVisualStyleBackColor = True
        ' 
        ' FormColeccion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 453)
        Controls.Add(btnVolverjugar)
        Controls.Add(btnCerrar)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormColeccion"
        Text = "Maquina de Peluches Tu Coleccion"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnVolverjugar As Button
End Class

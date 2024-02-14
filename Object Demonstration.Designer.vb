<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Object_Demonstration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.Font = New System.Windows.Forms.GroupBox()
        Me.Tahoma = New System.Windows.Forms.RadioButton()
        Me.Magneto = New System.Windows.Forms.RadioButton()
        Me.Garamond = New System.Windows.Forms.RadioButton()
        Me.Display_Text = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Font_style = New System.Windows.Forms.GroupBox()
        Me.Bold_Italic = New System.Windows.Forms.CheckBox()
        Me.Bold = New System.Windows.Forms.CheckBox()
        Me.Italic = New System.Windows.Forms.CheckBox()
        Me.Font_Color = New System.Windows.Forms.GroupBox()
        Me.Red = New System.Windows.Forms.RadioButton()
        Me.Blue = New System.Windows.Forms.RadioButton()
        Me.Green = New System.Windows.Forms.RadioButton()
        Me.Load_Picture = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Font.SuspendLayout()
        Me.Display_Text.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Font_style.SuspendLayout()
        Me.Font_Color.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox
        '
        Me.TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.TextBox.Location = New System.Drawing.Point(9, 36)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(185, 27)
        Me.TextBox.TabIndex = 0
        Me.TextBox.Text = "Sample Text"
        '
        'Font
        '
        Me.Font.Controls.Add(Me.Tahoma)
        Me.Font.Controls.Add(Me.Magneto)
        Me.Font.Controls.Add(Me.Garamond)
        Me.Font.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Font.Location = New System.Drawing.Point(320, 12)
        Me.Font.Name = "Font"
        Me.Font.Size = New System.Drawing.Size(452, 100)
        Me.Font.TabIndex = 1
        Me.Font.TabStop = False
        Me.Font.Text = "Font"
        '
        'Tahoma
        '
        Me.Tahoma.AutoSize = True
        Me.Tahoma.Location = New System.Drawing.Point(307, 39)
        Me.Tahoma.Name = "Tahoma"
        Me.Tahoma.Size = New System.Drawing.Size(85, 24)
        Me.Tahoma.TabIndex = 2
        Me.Tahoma.TabStop = True
        Me.Tahoma.Text = "Tahoma"
        Me.Tahoma.UseVisualStyleBackColor = True
        '
        'Magneto
        '
        Me.Magneto.AutoSize = True
        Me.Magneto.Location = New System.Drawing.Point(151, 39)
        Me.Magneto.Name = "Magneto"
        Me.Magneto.Size = New System.Drawing.Size(90, 24)
        Me.Magneto.TabIndex = 1
        Me.Magneto.TabStop = True
        Me.Magneto.Text = "Magneto"
        Me.Magneto.UseVisualStyleBackColor = True
        '
        'Garamond
        '
        Me.Garamond.AutoSize = True
        Me.Garamond.Location = New System.Drawing.Point(6, 39)
        Me.Garamond.Name = "Garamond"
        Me.Garamond.Size = New System.Drawing.Size(103, 24)
        Me.Garamond.TabIndex = 0
        Me.Garamond.TabStop = True
        Me.Garamond.Text = "Garamond"
        Me.Garamond.UseVisualStyleBackColor = True
        '
        'Display_Text
        '
        Me.Display_Text.Controls.Add(Me.TextBox)
        Me.Display_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Display_Text.Location = New System.Drawing.Point(12, 12)
        Me.Display_Text.Name = "Display_Text"
        Me.Display_Text.Size = New System.Drawing.Size(270, 100)
        Me.Display_Text.TabIndex = 2
        Me.Display_Text.TabStop = False
        Me.Display_Text.Text = "Display Text"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 143)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(332, 202)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Font_style
        '
        Me.Font_style.Controls.Add(Me.Bold_Italic)
        Me.Font_style.Controls.Add(Me.Bold)
        Me.Font_style.Controls.Add(Me.Italic)
        Me.Font_style.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Font_style.Location = New System.Drawing.Point(365, 143)
        Me.Font_style.Name = "Font_style"
        Me.Font_style.Size = New System.Drawing.Size(181, 202)
        Me.Font_style.TabIndex = 4
        Me.Font_style.TabStop = False
        Me.Font_style.Text = "Font Style"
        '
        'Bold_Italic
        '
        Me.Bold_Italic.AutoSize = True
        Me.Bold_Italic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bold_Italic.Location = New System.Drawing.Point(9, 145)
        Me.Bold_Italic.Name = "Bold_Italic"
        Me.Bold_Italic.Size = New System.Drawing.Size(108, 24)
        Me.Bold_Italic.TabIndex = 2
        Me.Bold_Italic.Text = "Bold Italic"
        Me.Bold_Italic.UseVisualStyleBackColor = True
        '
        'Bold
        '
        Me.Bold.AutoSize = True
        Me.Bold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bold.Location = New System.Drawing.Point(9, 92)
        Me.Bold.Name = "Bold"
        Me.Bold.Size = New System.Drawing.Size(64, 24)
        Me.Bold.TabIndex = 1
        Me.Bold.Text = "Bold"
        Me.Bold.UseVisualStyleBackColor = True
        '
        'Italic
        '
        Me.Italic.AutoSize = True
        Me.Italic.BackColor = System.Drawing.SystemColors.Control
        Me.Italic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Italic.Location = New System.Drawing.Point(9, 42)
        Me.Italic.Name = "Italic"
        Me.Italic.Size = New System.Drawing.Size(61, 24)
        Me.Italic.TabIndex = 0
        Me.Italic.Text = "Italic"
        Me.Italic.UseVisualStyleBackColor = False
        '
        'Font_Color
        '
        Me.Font_Color.Controls.Add(Me.Red)
        Me.Font_Color.Controls.Add(Me.Blue)
        Me.Font_Color.Controls.Add(Me.Green)
        Me.Font_Color.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Font_Color.Location = New System.Drawing.Point(586, 143)
        Me.Font_Color.Name = "Font_Color"
        Me.Font_Color.Size = New System.Drawing.Size(186, 202)
        Me.Font_Color.TabIndex = 5
        Me.Font_Color.TabStop = False
        Me.Font_Color.Text = "Font Color"
        '
        'Red
        '
        Me.Red.AutoSize = True
        Me.Red.Location = New System.Drawing.Point(7, 145)
        Me.Red.Name = "Red"
        Me.Red.Size = New System.Drawing.Size(57, 24)
        Me.Red.TabIndex = 2
        Me.Red.TabStop = True
        Me.Red.Text = "Red"
        Me.Red.UseVisualStyleBackColor = True
        '
        'Blue
        '
        Me.Blue.AutoSize = True
        Me.Blue.Location = New System.Drawing.Point(7, 92)
        Me.Blue.Name = "Blue"
        Me.Blue.Size = New System.Drawing.Size(59, 24)
        Me.Blue.TabIndex = 1
        Me.Blue.TabStop = True
        Me.Blue.Text = "Blue"
        Me.Blue.UseVisualStyleBackColor = True
        '
        'Green
        '
        Me.Green.AutoSize = True
        Me.Green.Location = New System.Drawing.Point(7, 42)
        Me.Green.Name = "Green"
        Me.Green.Size = New System.Drawing.Size(72, 24)
        Me.Green.TabIndex = 0
        Me.Green.TabStop = True
        Me.Green.Text = "Green"
        Me.Green.UseVisualStyleBackColor = True
        '
        'Load_Picture
        '
        Me.Load_Picture.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Load_Picture.Location = New System.Drawing.Point(53, 378)
        Me.Load_Picture.Name = "Load_Picture"
        Me.Load_Picture.Size = New System.Drawing.Size(199, 60)
        Me.Load_Picture.TabIndex = 6
        Me.Load_Picture.Text = "Load Picture"
        Me.Load_Picture.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Exit_Button.Location = New System.Drawing.Point(593, 378)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(154, 55)
        Me.Exit_Button.TabIndex = 7
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Object_Demonstration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Load_Picture)
        Me.Controls.Add(Me.Font_Color)
        Me.Controls.Add(Me.Font_style)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Display_Text)
        Me.Controls.Add(Me.Font)
        Me.Name = "Object_Demonstration"
        Me.Text = "Object_Demonstration"
        Me.Font.ResumeLayout(False)
        Me.Font.PerformLayout()
        Me.Display_Text.ResumeLayout(False)
        Me.Display_Text.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Font_style.ResumeLayout(False)
        Me.Font_style.PerformLayout()
        Me.Font_Color.ResumeLayout(False)
        Me.Font_Color.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox As TextBox
    Friend WithEvents Font As GroupBox
    Friend WithEvents Display_Text As GroupBox
    Friend WithEvents Tahoma As RadioButton
    Friend WithEvents Magneto As RadioButton
    Friend WithEvents Garamond As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Font_style As GroupBox
    Friend WithEvents Bold_Italic As CheckBox
    Friend WithEvents Bold As CheckBox
    Friend WithEvents Italic As CheckBox
    Friend WithEvents Font_Color As GroupBox
    Friend WithEvents Red As RadioButton
    Friend WithEvents Blue As RadioButton
    Friend WithEvents Green As RadioButton
    Friend WithEvents Load_Picture As Button
    Friend WithEvents Exit_Button As Button
End Class

Public Class Object_Demonstration
    Private Sub LoadPictureButton_Click(sender As Object, e As EventArgs) Handles Load_Picture.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.png;*.gif)|*.bmp;*.jpg;*.png;*.gif|All files (*.*)|*.*"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub FontRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Garamond.CheckedChanged, Magneto.CheckedChanged, Tahoma.CheckedChanged
        Dim selectedFont As String = ""
        If Garamond.Checked Then
            selectedFont = "Garamond"
        ElseIf Magneto.Checked Then
            selectedFont = "Magneto"
        ElseIf Tahoma.Checked Then
            selectedFont = "Tahoma"
        End If
        TextBox.Font = New Font(selectedFont, TextBox.Font.Size, TextBox.Font.Style)
    End Sub

    Private Sub FontStyleCheckBoxButton_CheckedChanged(sender As Object, e As EventArgs) Handles Italic.CheckedChanged, Bold.CheckedChanged, Bold_Italic.CheckedChanged
        Dim fontStyle As FontStyle = FontStyle.Regular
        If Italic.Checked Then
            fontStyle = FontStyle.Italic
        ElseIf Bold.Checked Then
            fontStyle = FontStyle.Bold
        ElseIf Bold_Italic.Checked Then
            fontStyle = FontStyle.Bold Or FontStyle.Italic
        End If
        TextBox.Font = New Font(TextBox.Font.FontFamily, TextBox.Font.Size, fontStyle)
    End Sub

    Private Sub FontColorRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Green.CheckedChanged, Blue.CheckedChanged, Red.CheckedChanged
        Dim fontColor As Color = Color.Black
        If Green.Checked Then
            fontColor = Color.Green
        ElseIf Blue.Checked Then
            fontColor = Color.Blue
        ElseIf Red.Checked Then
            fontColor = Color.Red
        End If
        TextBox.ForeColor = fontColor
    End Sub
End Class
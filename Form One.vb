Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form_one
    Private Sub FormOne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assign tooltips to buttons
        ToolTip1.SetToolTip(Button1, "Load Object Demo")
        ToolTip2.SetToolTip(ExitButton, "Exit")

        ' Maximize form and set initial background color
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Load and display ObjectDemonstrationsForm
        Dim objDemoForm As New Object_Demonstration()
        objDemoForm.Show()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' Terminate the application
        Application.Exit()
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        ' Change background color to RED on form click
        Me.BackColor = Color.Red
    End Sub
End Class

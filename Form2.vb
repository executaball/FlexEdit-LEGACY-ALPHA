Imports MetroFramework.Components

Public Class Form2
    Private msmMain As MetroStyleManager


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click


        Me.StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark

    End Sub
End Class
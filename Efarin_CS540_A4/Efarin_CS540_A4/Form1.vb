Imports System
Imports System.Resources
Imports System.Drawing
Imports System.IO

Public Class Form1
    Dim resx_cur As ResXResourceSet
    Dim resx_usa As ResXResourceSet = New ResXResourceSet("resx_usa.resx")
    Dim resx_austria As ResXResourceSet = New ResXResourceSet("resx_austria.resx")

    Private Sub refreshLocalizableContent()
        Greeting.Text = resx_cur.GetString("greeting")
        ExitButton.Text = resx_cur.GetString("exit_message")
        iconicImage.Image = Image.FromFile(resx_cur.GetString("localpath"))
    End Sub

    Private Sub Label1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Greeting.Click

    End Sub

    Private Sub USAFlag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USAFlag.Click
        resx_cur = resx_usa
        refreshLocalizableContent()
    End Sub

    Private Sub AustriaFlag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AustriaFlag.Click
        resx_cur = resx_austria
        refreshLocalizableContent()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        End
    End Sub
End Class

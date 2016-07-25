Imports System.Globalization
Imports System.Threading

Public Class Form1
    Dim usaInfo As CultureInfo = New CultureInfo("en-US")
    Dim austriaInfo As CultureInfo = New CultureInfo("de-AT")

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Greeting.Click

    End Sub

    Private Sub AustriaFlag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AustriaFlag.Click
        Thread.CurrentThread.CurrentUICulture = austriaInfo
        ReInit()
    End Sub

    Private Sub USAFlag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USAFlag.Click
        Thread.CurrentThread.CurrentUICulture = usaInfo
        ReInit()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        End
    End Sub

    Private Sub ReInit()
        Dim myResources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.ExitButton.Text = myResources.GetString("ExitButton.Text")
        Me.Greeting.Text = myResources.GetString("Greeting.Text")
    End Sub
End Class

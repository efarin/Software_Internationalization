Imports System.Globalization
Imports System.Threading

Public Class Form1
    Dim usaInfo As CultureInfo = New CultureInfo("en-US")
    Dim austriaInfo As CultureInfo = New CultureInfo("de-AT")

    Private Sub ExitButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitButton.Click
        End
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox1.Click
        Thread.CurrentThread.CurrentUICulture = usaInfo
        ReInit()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox2.Click
        Thread.CurrentThread.CurrentUICulture = austriaInfo
        ReInit()
    End Sub

    Private Sub ReInit()
        Dim myResources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.ExitButton.Text = myResources.GetString("ExitButton.Text")
        Me.Label1.Text = myResources.GetString("Label1.Text")
    End Sub
End Class

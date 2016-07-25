Imports System
Imports System.Resources
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO

Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim resx_cur As ResXResourceSet
    Dim resx_canada As ResXResourceSet
    Dim resx_germany As ResXResourceSet
    Dim resx_mexico As ResXResourceSet
    Dim resx_saudi As ResXResourceSet
    Dim resx_usa As ResXResourceSet


    Const WS_EX_LAYOUTRTL = &H400000
    Const WS_EX_NOINHERITLAYOUT = &H100000

    Private _mirrored As Boolean = False
    <Description("Change to the right-to-left layout."),
    DefaultValue(False), Localizable(True),
    Category("Appearance"), Browsable(True)>
    Public Property Mirrored() As Boolean
        Get
            Return _mirrored
        End Get
        Set(ByVal Value As Boolean)
            If _mirrored <> Value Then
                _mirrored = Value
                MyBase.OnRightToLeftChanged(EventArgs.Empty)
            End If
        End Set
    End Property

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim CP As System.Windows.Forms.CreateParams = MyBase.CreateParams
            If Mirrored Then
                CP.ExStyle = CP.ExStyle Or WS_EX_LAYOUTRTL Or WS_EX_NOINHERITLAYOUT
            End If
            Return CP
        End Get
    End Property

    Private Sub refreshLocalizableContent()
        GreetingLabel.Text = resx_cur.GetString("greeting")
        ExitButton.Text = resx_cur.GetString("exit")
        IconicImage.Image = Image.FromFile(resx_cur.GetString("image"))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists("canada.resx") Then
            resx_canada = New ResXResourceSet("canada.resx")
            CanadaFlag.Image = Image.FromFile(resx_canada.GetString("flag_path"))
        Else
            CanadaFlag.Visible = False
        End If

        If My.Computer.FileSystem.FileExists("germany.resx") Then
            resx_germany = New ResXResourceSet("germany.resx")
            GermanFlag.Image = Image.FromFile(resx_germany.GetString("flag_path"))
        Else
            GermanFlag.Visible = False
        End If

        If My.Computer.FileSystem.FileExists("mexico.resx") Then
            resx_mexico = New ResXResourceSet("mexico.resx")
            MexicoFlag.Image = Image.FromFile(resx_mexico.GetString("flag_path"))
        Else
            MexicoFlag.Visible = False
        End If

        If My.Computer.FileSystem.FileExists("saudi.resx") Then
            resx_saudi = New ResXResourceSet("saudi.resx")
            SaudiFlag.Image = Image.FromFile(resx_saudi.GetString("flag_path"))
        Else
            SaudiFlag.Visible = False
        End If

        If My.Computer.FileSystem.FileExists("usa.resx") Then
            resx_usa = New ResXResourceSet("usa.resx")
            USAFlag.Image = Image.FromFile(resx_usa.GetString("flag_path"))
        Else
            USAFlag.Visible = False
        End If
    End Sub

    Private Sub CanadaFlag_Click(sender As Object, e As EventArgs) Handles CanadaFlag.Click
        resx_cur = resx_canada
        Me.Mirrored() = False
        refreshLocalizableContent()
    End Sub

    Private Sub GermanFlag_Click(sender As Object, e As EventArgs) Handles GermanFlag.Click
        resx_cur = resx_germany
        Me.Mirrored() = False
        refreshLocalizableContent()
    End Sub

    Private Sub MexicoFlag_Click(sender As Object, e As EventArgs) Handles MexicoFlag.Click
        resx_cur = resx_mexico
        Me.Mirrored() = False
        refreshLocalizableContent()
    End Sub

    Private Sub SaudiFlag_Click(sender As Object, e As EventArgs) Handles SaudiFlag.Click
        resx_cur = resx_saudi
        Me.Mirrored() = True
        refreshLocalizableContent()
    End Sub

    Private Sub USAFlag_Click(sender As Object, e As EventArgs) Handles USAFlag.Click
        resx_cur = resx_usa
        Me.Mirrored() = False
        refreshLocalizableContent()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End
    End Sub
End Class

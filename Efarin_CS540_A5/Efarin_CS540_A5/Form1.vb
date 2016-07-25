Imports System
Imports System.Resources
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO

Public Class Form1
    Inherits System.Windows.Forms.Form
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

    Dim current_resource_set As ResXResourceSet
    Dim english_resource_set As New ResXResourceSet("english_resources.resx")
    Dim arabic_resource_set As New ResXResourceSet("arabic_resources.resx")

    Dim iconicimage As Image
    Dim usflag As Image
    Dim saudiaflag As Image






    Private Sub MyRefresh()
        Label_Greeting.Text = current_resource_set.GetString("greeting")
        Button_Exit.Text = current_resource_set.GetString("exitmsg")
        iconicimage = Image.FromFile(current_resource_set.GetString("imagepath"))
        Picture_IconicImage.Image = iconicimage
    End Sub

    Private Sub SetEnglish()
        current_resource_set = english_resource_set
        Me.Mirrored() = False
        MyRefresh()
    End Sub

    Private Sub SetArabic()
        current_resource_set = arabic_resource_set
        Me.Mirrored() = True
        MyRefresh()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        current_resource_set = english_resource_set
        MyRefresh()
    End Sub

    Private Sub AmericanFlagClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmericanFlag.Click
        SetEnglish()
    End Sub

    Private Sub SaudiFlagClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaudiFlag.Click
        SetArabic()
    End Sub

    Private Sub Button_ExitClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Exit.Click
        End
    End Sub

End Class



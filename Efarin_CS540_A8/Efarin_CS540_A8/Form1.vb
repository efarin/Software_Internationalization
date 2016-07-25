Imports System
Imports System.IO

Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim bWeHaveAValidInputFile As Boolean = True
    Dim stringInputStringFile As FileStream
    Dim stringReader As StreamReader
    Dim workingString As String = ""
    Const FILE_PATH As String = "rubberButtonInput.txt"

    Private Function readValidInputTextFile(ByVal fileName As String) As Boolean
        'Reads input file in, returns True if file was valid according to spec
        'False if an error happens or if file does not match spec
        Try
            stringInputStringFile = New FileStream(FILE_PATH, FileMode.Open, FileAccess.ReadWrite)
            stringReader = New StreamReader(stringInputStringFile)
            bWeHaveAValidInputFile = True
            Return True
        Catch e As Exception
            'File does not exist, or other error happened. Error is handled 
            'by returning False in the function call
            bWeHaveAValidInputFile = False
            Return False
        End Try
    End Function

    Private Function getNextString(ByRef reader As StreamReader) As String
        Dim readString As String
        If FILE_PATH > workingString Then
            readString = reader.ReadLine()
        Else
            readString = ""
        End If
        Return readString
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If readValidInputTextFile(FILE_PATH) Then
            statusBarLabel.Text = ""
            workingString = getNextString(stringReader)
            processString(workingString)
        Else
            statusBarLabel.Text = "Input text file Not found Or Is invalid"
        End If
    End Sub

    Private Sub processString(ByVal str As String)

        'Resize control:
        Dim g1 As Graphics
        Dim s1 As SizeF
        Dim marginBuffer As Integer
        g1 = Me.resizeFontLabel.CreateGraphics
        s1 = g1.MeasureString(str, resizeControlLabel.Font)
        marginBuffer = g1.MeasureString("  ", resizeControlLabel.Font).Width
        g1.Dispose()
        resizeControlLabel.Width = s1.Width + 20 * marginBuffer
        resizeControlLabel.Text = str

        'Resize font using original method:
        Dim f2 As Font
        Dim g2 As Graphics
        Dim s2 As SizeF
        Dim Faktor, FaktorX, FaktorY As Single
        g2 = Me.resizeFontLabel.CreateGraphics
        s2 = g2.MeasureString("    " + str, resizeFontLabel.Font)
        g2.Dispose()
        FaktorX = resizeFontLabel.Width / s2.Width
        FaktorY = resizeFontLabel.Height / s2.Height
        If FaktorX > FaktorY Then
            Faktor = FaktorY
        Else
            Faktor = FaktorX
        End If
        f2 = resizeFontLabel.Font
        resizeFontLabel.Font = New Font(f2.Name, f2.SizeInPoints * Faktor)
        resizeFontLabel.Text = str

    End Sub


    Private Sub nextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextButton.Click
        If bWeHaveAValidInputFile Then
            workingString = getNextString(stringReader)
            If workingString <> "" Then
                processString(workingString)
            Else
                End
            End If
        End If
    End Sub
End Class

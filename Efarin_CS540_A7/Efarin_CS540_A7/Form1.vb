Imports System.IO
Imports System
Imports System.Globalization
Imports System.Threading

Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim currentCulture As CultureInfo
    Dim localCurrentCultureName As String

    Dim usaCulture As CultureInfo = New CultureInfo("en-US")
    Dim spainCultureInternational As CultureInfo = New CultureInfo("es-ES")
    Dim spainCultureTraditional As CultureInfo = New CultureInfo(&H40A)
    Dim germanyCulture As CultureInfo = New CultureInfo("de-DE")

    Dim sortedStrings(11) As String
    Dim unsortedStrings(11) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        languageChange(usaCulture, "en-US")
        Dim i As Integer
        For i = 0 To 10
            sortedStrings(i) = ""
            unsortedStrings(i) = ""
        Next i
    End Sub

    Private Sub ReadSortButton_Click(sender As Object, e As EventArgs) Handles ReadSortButton.Click
        clearArrays()
        readFile()



        sort(unsortedStrings, sortedStrings)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End
    End Sub

    Private Sub clearArrays()
        Dim i As Integer
        For i = 0 To 10
            sortedStrings(i) = ""
            unsortedStrings(i) = ""
        Next i
        UnsortedTextbox.Clear()
        SortedTextbox.Clear()
    End Sub

    Private Sub languageChange(ByRef newCurrentCulture As CultureInfo, ByVal newLocalCurrentCultureName As String)
        currentCulture = newCurrentCulture
        localCurrentCultureName = newLocalCurrentCultureName
        clearArrays()
    End Sub

    Private Sub sort(ByRef u() As String, ByRef s() As String)

        Dim i As Integer
        Dim j As Integer
        Dim minindex As Integer
        Dim minString As String
        Dim temp As String

        For i = 1 To 10
            s(i) = u(i)
        Next i

        For i = 1 To 10
            minString = s(i)
            minindex = i
            For j = i To 10
                If currentCulture.CompareInfo.Compare(s(j), minString) < 0 Then
                    minindex = j
                    minString = s(j)
                End If
            Next j
            temp = s(i)
            s(i) = minString
            s(minindex) = temp
        Next i

        For k As Integer = 1 To 10
            SortedTextbox.Text += sortedStrings(k) & Environment.NewLine
        Next
    End Sub

    Private Sub readFile()

        Dim myCoolFile As String = PathToInputTextbox.Text '// your file location.
        Dim i As Integer = 0
        For Each line As String In File.ReadLines(myCoolFile)
            unsortedStrings(i) = line
            i = i + 1
            If i > 10 Then
                Exit For
            End If
        Next line

        For j As Integer = 1 To 10
            UnsortedTextbox.Text += unsortedStrings(j) & Environment.NewLine
        Next
        i = 0

        If unsortedStrings(i) = "es-TRADITIONAL" Then
            currentCulture = New CultureInfo(&H40A)
        Else
            currentCulture = New CultureInfo(localCurrentCultureName)
        End If

        Thread.CurrentThread.CurrentUICulture = currentCulture

    End Sub

End Class

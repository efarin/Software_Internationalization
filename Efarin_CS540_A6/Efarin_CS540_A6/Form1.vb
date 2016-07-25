Imports System
Imports System.Globalization
Imports System.Threading

Public Class Form1

    Inherits System.Windows.Forms.Form

    Dim currentCulture As CultureInfo
    Dim usaCulture As CultureInfo = New CultureInfo("en-US")
    Dim indiaCulture As CultureInfo = New CultureInfo("hi-In")
    Dim austriaCulture As CultureInfo = New CultureInfo("de-AT")
    Dim disneylandCulture As CultureInfo = New CultureInfo("")

    Dim dateTime As DateTime = New DateTime(0)
    Dim numberTotal As Integer = New Integer()
    Dim valueTotal As Double = New Integer()

    Dim displayMode As String

    Dim hindi_digits As Char() = {"०"c, "१"c, "२"c, "३"c, "४"c, "५"c, "६"c, "७"c, "८"c, "९"c}
    Dim latin_digits As Char() = {"0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c}
    Dim hindi_digits_enabled As Boolean
    Dim latin_digits_enabled As Boolean
    Dim latin_India_currency_symbol As String
    Dim hindi_India_currency_symbol As String

    Private Sub xlt_digits_to_H(ByRef latin As String)
        Dim i As Integer
        For i = 0 To 9
            latin = latin.Replace(latin_digits(i), hindi_digits(i))
        Next i
    End Sub

    Private Sub defineDisneylandCulture()
        Dim disneylandCurrencyGroupSizes As Integer() = {3, 3}
        Dim disneylandNumberGroupSizes As Integer() = {4, 3}
        disneylandCulture.NumberFormat.CurrencyDecimalDigits = 2
        disneylandCulture.NumberFormat.CurrencyDecimalSeparator = "."
        disneylandCulture.NumberFormat.CurrencyGroupSizes = disneylandCurrencyGroupSizes
        disneylandCulture.NumberFormat.CurrencyGroupSeparator = ","
        disneylandCulture.NumberFormat.CurrencySymbol = " ஜ"
        disneylandCulture.NumberFormat.CurrencyPositivePattern = 1
        disneylandCulture.NumberFormat.NumberDecimalDigits = 2
        disneylandCulture.NumberFormat.NumberDecimalSeparator = "."
        disneylandCulture.NumberFormat.NumberGroupSizes = disneylandNumberGroupSizes
        disneylandCulture.NumberFormat.NumberGroupSeparator = "*"


    End Sub

    Private Sub fishTacoCalculator()
        'datetime1 = 00:00 01-01-2016
        'datetime2 = currentDateTime
        'cost = 4.29
        'initialNumber = 63417
        'rate = 600/min
        Dim d1 As DateTime = DateTime.Parse("1-Jan-2016 00:00:00 AM")
        Dim d2 As DateTime = DateTime.Now()
        Dim difference As TimeSpan = d2 - d1
        Dim minutes As Integer = Math.Abs(difference.TotalMinutes)
        numberTotal = 63417 + (600 * minutes)
        valueTotal = numberTotal * 4.29


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        displayMode = "N"
        currentCulture = usaCulture
        defineDisneylandCulture()
    End Sub

    Private Sub myRefresh()
        Thread.CurrentThread.CurrentUICulture = currentCulture
        fishTacoCalculator()

        NumberLabel.Text = CDbl(numberTotal).ToString("N", currentCulture)
        ValueLabel.Text = CDbl(valueTotal).ToString("C", currentCulture)
        If hindi_digits_enabled Then
            xlt_digits_to_H(NumberLabel.Text)
            xlt_digits_to_H(ValueLabel.Text)
            xlt_digits_to_H(DateTimeLabel.Text)
        End If
    End Sub

    Private Sub NumberLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumberLabel.Click

    End Sub

    Private Sub ValueLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValueLabel.Click

    End Sub

    Private Sub DateTimeLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimeLabel.Click

    End Sub

    Private Sub USAFlag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USAFlag.Click
        currentCulture = usaCulture
        hindi_digits_enabled = False
        myRefresh()
    End Sub

    Private Sub IndiaFlag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndiaFlag.Click
        currentCulture = indiaCulture
        hindi_digits_enabled = True
        myRefresh()
    End Sub

    Private Sub AustriaFlag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AustriaFlag.Click
        currentCulture = austriaCulture
        hindi_digits_enabled = False
        myRefresh()
    End Sub

    Private Sub DisneylandFlag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisneylandFlag.Click
        currentCulture = disneylandCulture
        hindi_digits_enabled = False
        'DateTimeLabel.Text = Format(Now, "YYYY:MM:DD MM:HH")
        myRefresh()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If currentCulture Is disneylandCulture Then
            DateTimeLabel.Text = Format(Now, "yyyy:MM:dd mm:HH")
        Else
            DateTimeLabel.Text = DateTime.Now().ToString("F", currentCulture)
        End If
        myRefresh()
    End Sub
End Class

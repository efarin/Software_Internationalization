<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.resizeFontLabel = New System.Windows.Forms.Label()
        Me.resizeFontLabelLbl = New System.Windows.Forms.Label()
        Me.resizeControlLabel = New System.Windows.Forms.Label()
        Me.resizeControlLabelLbl = New System.Windows.Forms.Label()
        Me.statusBarLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(152, 52)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(64, 24)
        Me.nextButton.TabIndex = 10
        Me.nextButton.Text = "NEXT"
        '
        'resizeFontLabel
        '
        Me.resizeFontLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.resizeFontLabel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.resizeFontLabel.ForeColor = System.Drawing.Color.Red
        Me.resizeFontLabel.Location = New System.Drawing.Point(86, 273)
        Me.resizeFontLabel.Name = "resizeFontLabel"
        Me.resizeFontLabel.Size = New System.Drawing.Size(206, 32)
        Me.resizeFontLabel.TabIndex = 9
        Me.resizeFontLabel.Text = "<Resize Font Size>"
        Me.resizeFontLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'resizeFontLabelLbl
        '
        Me.resizeFontLabelLbl.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.resizeFontLabelLbl.Location = New System.Drawing.Point(86, 222)
        Me.resizeFontLabelLbl.Name = "resizeFontLabelLbl"
        Me.resizeFontLabelLbl.Size = New System.Drawing.Size(206, 32)
        Me.resizeFontLabelLbl.TabIndex = 8
        Me.resizeFontLabelLbl.Text = "resizeFont"
        Me.resizeFontLabelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'resizeControlLabel
        '
        Me.resizeControlLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.resizeControlLabel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.resizeControlLabel.ForeColor = System.Drawing.Color.Red
        Me.resizeControlLabel.Location = New System.Drawing.Point(86, 137)
        Me.resizeControlLabel.Name = "resizeControlLabel"
        Me.resizeControlLabel.Size = New System.Drawing.Size(206, 32)
        Me.resizeControlLabel.TabIndex = 7
        Me.resizeControlLabel.Text = "<Resize Control>"
        Me.resizeControlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'resizeControlLabelLbl
        '
        Me.resizeControlLabelLbl.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.resizeControlLabelLbl.Location = New System.Drawing.Point(86, 96)
        Me.resizeControlLabelLbl.Name = "resizeControlLabelLbl"
        Me.resizeControlLabelLbl.Size = New System.Drawing.Size(206, 32)
        Me.resizeControlLabelLbl.TabIndex = 6
        Me.resizeControlLabelLbl.Text = "resizeControl"
        Me.resizeControlLabelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'statusBarLabel
        '
        Me.statusBarLabel.Location = New System.Drawing.Point(97, 25)
        Me.statusBarLabel.Name = "statusBarLabel"
        Me.statusBarLabel.Size = New System.Drawing.Size(180, 24)
        Me.statusBarLabel.TabIndex = 11
        Me.statusBarLabel.Text = "<Status Bar>"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(375, 383)
        Me.Controls.Add(Me.statusBarLabel)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.resizeFontLabel)
        Me.Controls.Add(Me.resizeFontLabelLbl)
        Me.Controls.Add(Me.resizeControlLabel)
        Me.Controls.Add(Me.resizeControlLabelLbl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents nextButton As Button
    Friend WithEvents resizeFontLabel As Label
    Friend WithEvents resizeFontLabelLbl As Label
    Friend WithEvents resizeControlLabel As Label
    Friend WithEvents resizeControlLabelLbl As Label
    Friend WithEvents statusBarLabel As Label
End Class

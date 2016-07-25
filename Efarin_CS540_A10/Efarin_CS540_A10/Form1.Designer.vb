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
        Me.IconicImage = New System.Windows.Forms.PictureBox()
        Me.CanadaFlag = New System.Windows.Forms.PictureBox()
        Me.GreetingLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GermanFlag = New System.Windows.Forms.PictureBox()
        Me.MexicoFlag = New System.Windows.Forms.PictureBox()
        Me.SaudiFlag = New System.Windows.Forms.PictureBox()
        Me.USAFlag = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.IconicImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CanadaFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GermanFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MexicoFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaudiFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USAFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IconicImage
        '
        Me.IconicImage.Location = New System.Drawing.Point(262, 174)
        Me.IconicImage.Name = "IconicImage"
        Me.IconicImage.Size = New System.Drawing.Size(200, 150)
        Me.IconicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconicImage.TabIndex = 0
        Me.IconicImage.TabStop = False
        '
        'CanadaFlag
        '
        Me.CanadaFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CanadaFlag.Location = New System.Drawing.Point(39, 12)
        Me.CanadaFlag.Name = "CanadaFlag"
        Me.CanadaFlag.Size = New System.Drawing.Size(120, 75)
        Me.CanadaFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CanadaFlag.TabIndex = 1
        Me.CanadaFlag.TabStop = False
        '
        'GreetingLabel
        '
        Me.GreetingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GreetingLabel.Location = New System.Drawing.Point(262, 74)
        Me.GreetingLabel.Name = "GreetingLabel"
        Me.GreetingLabel.Size = New System.Drawing.Size(200, 44)
        Me.GreetingLabel.TabIndex = 6
        Me.GreetingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(330, 330)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'GermanFlag
        '
        Me.GermanFlag.Location = New System.Drawing.Point(39, 93)
        Me.GermanFlag.Name = "GermanFlag"
        Me.GermanFlag.Size = New System.Drawing.Size(120, 75)
        Me.GermanFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GermanFlag.TabIndex = 8
        Me.GermanFlag.TabStop = False
        '
        'MexicoFlag
        '
        Me.MexicoFlag.Location = New System.Drawing.Point(39, 174)
        Me.MexicoFlag.Name = "MexicoFlag"
        Me.MexicoFlag.Size = New System.Drawing.Size(120, 75)
        Me.MexicoFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MexicoFlag.TabIndex = 9
        Me.MexicoFlag.TabStop = False
        '
        'SaudiFlag
        '
        Me.SaudiFlag.Location = New System.Drawing.Point(39, 255)
        Me.SaudiFlag.Name = "SaudiFlag"
        Me.SaudiFlag.Size = New System.Drawing.Size(120, 75)
        Me.SaudiFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SaudiFlag.TabIndex = 10
        Me.SaudiFlag.TabStop = False
        '
        'USAFlag
        '
        Me.USAFlag.Location = New System.Drawing.Point(39, 336)
        Me.USAFlag.Name = "USAFlag"
        Me.USAFlag.Size = New System.Drawing.Size(120, 75)
        Me.USAFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.USAFlag.TabIndex = 11
        Me.USAFlag.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(194, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 426)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.USAFlag)
        Me.Controls.Add(Me.SaudiFlag)
        Me.Controls.Add(Me.MexicoFlag)
        Me.Controls.Add(Me.GermanFlag)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.GreetingLabel)
        Me.Controls.Add(Me.CanadaFlag)
        Me.Controls.Add(Me.IconicImage)
        Me.Name = "Form1"
        Me.Text = "Assignment #10"
        CType(Me.IconicImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CanadaFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GermanFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MexicoFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaudiFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USAFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconicImage As PictureBox
    Friend WithEvents CanadaFlag As PictureBox
    Friend WithEvents GreetingLabel As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents GermanFlag As PictureBox
    Friend WithEvents MexicoFlag As PictureBox
    Friend WithEvents SaudiFlag As PictureBox
    Friend WithEvents USAFlag As PictureBox
    Friend WithEvents Label1 As Label
End Class

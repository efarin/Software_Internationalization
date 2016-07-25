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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.iconicImage = New System.Windows.Forms.PictureBox()
        Me.AustriaFlag = New System.Windows.Forms.PictureBox()
        Me.USAFlag = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Greeting = New System.Windows.Forms.Label()
        CType(Me.iconicImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AustriaFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USAFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'iconicImage
        '
        Me.iconicImage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.iconicImage.Location = New System.Drawing.Point(256, 21)
        Me.iconicImage.Name = "iconicImage"
        Me.iconicImage.Size = New System.Drawing.Size(100, 100)
        Me.iconicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconicImage.TabIndex = 9
        Me.iconicImage.TabStop = False
        '
        'AustriaFlag
        '
        Me.AustriaFlag.Image = CType(resources.GetObject("AustriaFlag.Image"), System.Drawing.Image)
        Me.AustriaFlag.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AustriaFlag.Location = New System.Drawing.Point(237, 151)
        Me.AustriaFlag.Name = "AustriaFlag"
        Me.AustriaFlag.Size = New System.Drawing.Size(100, 50)
        Me.AustriaFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AustriaFlag.TabIndex = 8
        Me.AustriaFlag.TabStop = False
        '
        'USAFlag
        '
        Me.USAFlag.Image = CType(resources.GetObject("USAFlag.Image"), System.Drawing.Image)
        Me.USAFlag.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.USAFlag.Location = New System.Drawing.Point(87, 151)
        Me.USAFlag.Name = "USAFlag"
        Me.USAFlag.Size = New System.Drawing.Size(100, 50)
        Me.USAFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.USAFlag.TabIndex = 7
        Me.USAFlag.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ExitButton.Location = New System.Drawing.Point(175, 219)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Greeting
        '
        Me.Greeting.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Greeting.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Greeting.Location = New System.Drawing.Point(81, 59)
        Me.Greeting.Name = "Greeting"
        Me.Greeting.Size = New System.Drawing.Size(169, 62)
        Me.Greeting.TabIndex = 5
        Me.Greeting.Text = "Good Day!"
        Me.Greeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 262)
        Me.Controls.Add(Me.iconicImage)
        Me.Controls.Add(Me.AustriaFlag)
        Me.Controls.Add(Me.USAFlag)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Greeting)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.iconicImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AustriaFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USAFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents iconicImage As PictureBox
    Friend WithEvents AustriaFlag As PictureBox
    Friend WithEvents USAFlag As PictureBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents Greeting As Label
End Class

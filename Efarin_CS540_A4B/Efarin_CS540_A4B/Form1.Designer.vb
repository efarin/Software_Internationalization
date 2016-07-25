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
        Me.Greeting = New System.Windows.Forms.Label()
        Me.USAFlag = New System.Windows.Forms.PictureBox()
        Me.AustriaFlag = New System.Windows.Forms.PictureBox()
        Me.IconicImage = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.USAFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AustriaFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconicImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Greeting
        '
        Me.Greeting.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Greeting.Location = New System.Drawing.Point(50, 50)
        Me.Greeting.Name = "Greeting"
        Me.Greeting.Size = New System.Drawing.Size(165, 51)
        Me.Greeting.TabIndex = 0
        Me.Greeting.Text = "Good Day!"
        Me.Greeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'USAFlag
        '
        Me.USAFlag.Image = CType(resources.GetObject("USAFlag.Image"), System.Drawing.Image)
        Me.USAFlag.Location = New System.Drawing.Point(50, 153)
        Me.USAFlag.Name = "USAFlag"
        Me.USAFlag.Size = New System.Drawing.Size(100, 50)
        Me.USAFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.USAFlag.TabIndex = 1
        Me.USAFlag.TabStop = False
        '
        'AustriaFlag
        '
        Me.AustriaFlag.Image = CType(resources.GetObject("AustriaFlag.Image"), System.Drawing.Image)
        Me.AustriaFlag.Location = New System.Drawing.Point(173, 153)
        Me.AustriaFlag.Name = "AustriaFlag"
        Me.AustriaFlag.Size = New System.Drawing.Size(100, 50)
        Me.AustriaFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AustriaFlag.TabIndex = 2
        Me.AustriaFlag.TabStop = False
        '
        'IconicImage
        '
        Me.IconicImage.Location = New System.Drawing.Point(231, 30)
        Me.IconicImage.Name = "IconicImage"
        Me.IconicImage.Size = New System.Drawing.Size(100, 100)
        Me.IconicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconicImage.TabIndex = 3
        Me.IconicImage.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(123, 209)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 262)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.IconicImage)
        Me.Controls.Add(Me.AustriaFlag)
        Me.Controls.Add(Me.USAFlag)
        Me.Controls.Add(Me.Greeting)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.USAFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AustriaFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconicImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Greeting As Label
    Friend WithEvents USAFlag As PictureBox
    Friend WithEvents AustriaFlag As PictureBox
    Friend WithEvents IconicImage As PictureBox
    Friend WithEvents ExitButton As Button
End Class

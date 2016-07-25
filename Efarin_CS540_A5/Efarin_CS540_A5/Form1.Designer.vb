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
        Me.Button_Exit = New System.Windows.Forms.Button()
        Me.SaudiFlag = New System.Windows.Forms.PictureBox()
        Me.AmericanFlag = New System.Windows.Forms.PictureBox()
        Me.Label_Greeting = New System.Windows.Forms.Label()
        Me.Picture_IconicImage = New System.Windows.Forms.PictureBox()
        CType(Me.SaudiFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmericanFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_IconicImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Exit
        '
        Me.Button_Exit.Location = New System.Drawing.Point(178, 325)
        Me.Button_Exit.Name = "Button_Exit"
        Me.Button_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button_Exit.Size = New System.Drawing.Size(104, 24)
        Me.Button_Exit.TabIndex = 12
        Me.Button_Exit.Text = "Exit"
        '
        'SaudiFlag
        '
        Me.SaudiFlag.Image = CType(resources.GetObject("SaudiFlag.Image"), System.Drawing.Image)
        Me.SaudiFlag.Location = New System.Drawing.Point(251, 246)
        Me.SaudiFlag.Name = "SaudiFlag"
        Me.SaudiFlag.Size = New System.Drawing.Size(104, 48)
        Me.SaudiFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SaudiFlag.TabIndex = 10
        Me.SaudiFlag.TabStop = False
        '
        'AmericanFlag
        '
        Me.AmericanFlag.Image = CType(resources.GetObject("AmericanFlag.Image"), System.Drawing.Image)
        Me.AmericanFlag.Location = New System.Drawing.Point(91, 246)
        Me.AmericanFlag.Name = "AmericanFlag"
        Me.AmericanFlag.Size = New System.Drawing.Size(104, 48)
        Me.AmericanFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AmericanFlag.TabIndex = 9
        Me.AmericanFlag.TabStop = False
        '
        'Label_Greeting
        '
        Me.Label_Greeting.Font = New System.Drawing.Font("Tahoma", 20.25!)
        Me.Label_Greeting.Location = New System.Drawing.Point(67, 19)
        Me.Label_Greeting.Name = "Label_Greeting"
        Me.Label_Greeting.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_Greeting.Size = New System.Drawing.Size(320, 56)
        Me.Label_Greeting.TabIndex = 14
        Me.Label_Greeting.Text = "Good morning!"
        Me.Label_Greeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Picture_IconicImage
        '
        Me.Picture_IconicImage.Image = CType(resources.GetObject("Picture_IconicImage.Image"), System.Drawing.Image)
        Me.Picture_IconicImage.Location = New System.Drawing.Point(91, 78)
        Me.Picture_IconicImage.Name = "Picture_IconicImage"
        Me.Picture_IconicImage.Size = New System.Drawing.Size(264, 152)
        Me.Picture_IconicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture_IconicImage.TabIndex = 13
        Me.Picture_IconicImage.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(486, 361)
        Me.Controls.Add(Me.Button_Exit)
        Me.Controls.Add(Me.SaudiFlag)
        Me.Controls.Add(Me.AmericanFlag)
        Me.Controls.Add(Me.Label_Greeting)
        Me.Controls.Add(Me.Picture_IconicImage)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SaudiFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmericanFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_IconicImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Exit As Button
    Friend WithEvents SaudiFlag As PictureBox
    Friend WithEvents AmericanFlag As PictureBox
    Friend WithEvents Label_Greeting As Label
    Friend WithEvents Picture_IconicImage As PictureBox

    Private Sub Button_Exit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BosnianFlag_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SaudiFlag_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AmericanFlag_Click(sender As Object, e As EventArgs)

    End Sub
End Class

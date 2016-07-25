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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.USAFlag = New System.Windows.Forms.PictureBox()
        Me.IndiaFlag = New System.Windows.Forms.PictureBox()
        Me.DisneylandFlag = New System.Windows.Forms.PictureBox()
        Me.AustriaFlag = New System.Windows.Forms.PictureBox()
        Me.DateTimeLabel = New System.Windows.Forms.Label()
        Me.DateTimeCaptionLabel = New System.Windows.Forms.Label()
        Me.NumberLabel = New System.Windows.Forms.Label()
        Me.ValueCaptionLabel = New System.Windows.Forms.Label()
        Me.NumberCaptionLabel = New System.Windows.Forms.Label()
        Me.ValueLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.USAFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndiaFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisneylandFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AustriaFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'USAFlag
        '
        Me.USAFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.USAFlag.Image = CType(resources.GetObject("USAFlag.Image"), System.Drawing.Image)
        Me.USAFlag.Location = New System.Drawing.Point(127, 254)
        Me.USAFlag.Name = "USAFlag"
        Me.USAFlag.Size = New System.Drawing.Size(112, 72)
        Me.USAFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.USAFlag.TabIndex = 16
        Me.USAFlag.TabStop = False
        '
        'IndiaFlag
        '
        Me.IndiaFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IndiaFlag.Image = CType(resources.GetObject("IndiaFlag.Image"), System.Drawing.Image)
        Me.IndiaFlag.Location = New System.Drawing.Point(383, 254)
        Me.IndiaFlag.Name = "IndiaFlag"
        Me.IndiaFlag.Size = New System.Drawing.Size(112, 72)
        Me.IndiaFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IndiaFlag.TabIndex = 17
        Me.IndiaFlag.TabStop = False
        '
        'DisneylandFlag
        '
        Me.DisneylandFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DisneylandFlag.Image = CType(resources.GetObject("DisneylandFlag.Image"), System.Drawing.Image)
        Me.DisneylandFlag.Location = New System.Drawing.Point(383, 332)
        Me.DisneylandFlag.Name = "DisneylandFlag"
        Me.DisneylandFlag.Size = New System.Drawing.Size(112, 72)
        Me.DisneylandFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DisneylandFlag.TabIndex = 18
        Me.DisneylandFlag.TabStop = False
        '
        'AustriaFlag
        '
        Me.AustriaFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AustriaFlag.Image = CType(resources.GetObject("AustriaFlag.Image"), System.Drawing.Image)
        Me.AustriaFlag.Location = New System.Drawing.Point(127, 332)
        Me.AustriaFlag.Name = "AustriaFlag"
        Me.AustriaFlag.Size = New System.Drawing.Size(112, 72)
        Me.AustriaFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AustriaFlag.TabIndex = 25
        Me.AustriaFlag.TabStop = False
        '
        'DateTimeLabel
        '
        Me.DateTimeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DateTimeLabel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeLabel.Location = New System.Drawing.Point(127, 160)
        Me.DateTimeLabel.Name = "DateTimeLabel"
        Me.DateTimeLabel.Size = New System.Drawing.Size(368, 48)
        Me.DateTimeLabel.TabIndex = 28
        Me.DateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimeCaptionLabel
        '
        Me.DateTimeCaptionLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeCaptionLabel.Location = New System.Drawing.Point(236, 208)
        Me.DateTimeCaptionLabel.Name = "DateTimeCaptionLabel"
        Me.DateTimeCaptionLabel.Size = New System.Drawing.Size(152, 24)
        Me.DateTimeCaptionLabel.TabIndex = 29
        Me.DateTimeCaptionLabel.Text = "DATE / TIME"
        Me.DateTimeCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumberLabel
        '
        Me.NumberLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NumberLabel.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumberLabel.Location = New System.Drawing.Point(127, 4)
        Me.NumberLabel.Name = "NumberLabel"
        Me.NumberLabel.Size = New System.Drawing.Size(368, 40)
        Me.NumberLabel.TabIndex = 19
        Me.NumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ValueCaptionLabel
        '
        Me.ValueCaptionLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValueCaptionLabel.Location = New System.Drawing.Point(215, 126)
        Me.ValueCaptionLabel.Name = "ValueCaptionLabel"
        Me.ValueCaptionLabel.Size = New System.Drawing.Size(195, 24)
        Me.ValueCaptionLabel.TabIndex = 24
        Me.ValueCaptionLabel.Text = "Money Value of Fish Tacos"
        Me.ValueCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumberCaptionLabel
        '
        Me.NumberCaptionLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberCaptionLabel.Location = New System.Drawing.Point(239, 44)
        Me.NumberCaptionLabel.Name = "NumberCaptionLabel"
        Me.NumberCaptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumberCaptionLabel.Size = New System.Drawing.Size(152, 24)
        Me.NumberCaptionLabel.TabIndex = 23
        Me.NumberCaptionLabel.Text = "Number of Fish Tacos Sold"
        Me.NumberCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ValueLabel
        '
        Me.ValueLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ValueLabel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValueLabel.Location = New System.Drawing.Point(127, 78)
        Me.ValueLabel.Name = "ValueLabel"
        Me.ValueLabel.Size = New System.Drawing.Size(368, 48)
        Me.ValueLabel.TabIndex = 32
        Me.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 505)
        Me.Controls.Add(Me.ValueLabel)
        Me.Controls.Add(Me.DateTimeCaptionLabel)
        Me.Controls.Add(Me.DateTimeLabel)
        Me.Controls.Add(Me.AustriaFlag)
        Me.Controls.Add(Me.ValueCaptionLabel)
        Me.Controls.Add(Me.NumberCaptionLabel)
        Me.Controls.Add(Me.NumberLabel)
        Me.Controls.Add(Me.DisneylandFlag)
        Me.Controls.Add(Me.IndiaFlag)
        Me.Controls.Add(Me.USAFlag)
        Me.Name = "Form1"
        Me.Text = "Assignment 6 EFARIN CS540"
        CType(Me.USAFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndiaFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisneylandFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AustriaFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents USAFlag As PictureBox
    Friend WithEvents IndiaFlag As PictureBox
    Friend WithEvents DisneylandFlag As PictureBox
    Friend WithEvents AustriaFlag As PictureBox
    Friend WithEvents DateTimeLabel As Label
    Friend WithEvents DateTimeCaptionLabel As Label
    Friend WithEvents NumberLabel As Label
    Friend WithEvents ValueCaptionLabel As Label
    Friend WithEvents NumberCaptionLabel As Label
    Friend WithEvents ValueLabel As Label
    Friend WithEvents Timer1 As Timer
End Class

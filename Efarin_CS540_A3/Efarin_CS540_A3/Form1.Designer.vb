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
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.USAFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AustriaFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Greeting
        '
        resources.ApplyResources(Me.Greeting, "Greeting")
        Me.Greeting.Name = "Greeting"
        '
        'USAFlag
        '
        resources.ApplyResources(Me.USAFlag, "USAFlag")
        Me.USAFlag.Name = "USAFlag"
        Me.USAFlag.TabStop = False
        '
        'AustriaFlag
        '
        resources.ApplyResources(Me.AustriaFlag, "AustriaFlag")
        Me.AustriaFlag.Name = "AustriaFlag"
        Me.AustriaFlag.TabStop = False
        '
        'ExitButton
        '
        resources.ApplyResources(Me.ExitButton, "ExitButton")
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.AustriaFlag)
        Me.Controls.Add(Me.USAFlag)
        Me.Controls.Add(Me.Greeting)
        Me.Name = "Form1"
        CType(Me.USAFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AustriaFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Greeting As Label
    Friend WithEvents USAFlag As PictureBox
    Friend WithEvents AustriaFlag As PictureBox
    Friend WithEvents ExitButton As Button
End Class

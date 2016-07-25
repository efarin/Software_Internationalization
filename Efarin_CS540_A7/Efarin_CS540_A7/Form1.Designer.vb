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
        Me.ReadSortButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SortedTextbox = New System.Windows.Forms.TextBox()
        Me.PathToInputTextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UnsortedTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ReadSortButton
        '
        Me.ReadSortButton.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReadSortButton.Location = New System.Drawing.Point(193, 60)
        Me.ReadSortButton.Name = "ReadSortButton"
        Me.ReadSortButton.Size = New System.Drawing.Size(131, 29)
        Me.ReadSortButton.TabIndex = 37
        Me.ReadSortButton.Text = "Read and Sort"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(224, 362)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 42
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SortedTextbox
        '
        Me.SortedTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SortedTextbox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SortedTextbox.Location = New System.Drawing.Point(263, 158)
        Me.SortedTextbox.Multiline = True
        Me.SortedTextbox.Name = "SortedTextbox"
        Me.SortedTextbox.Size = New System.Drawing.Size(197, 198)
        Me.SortedTextbox.TabIndex = 32
        '
        'PathToInputTextbox
        '
        Me.PathToInputTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PathToInputTextbox.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PathToInputTextbox.Location = New System.Drawing.Point(60, 20)
        Me.PathToInputTextbox.Multiline = True
        Me.PathToInputTextbox.Name = "PathToInputTextbox"
        Me.PathToInputTextbox.Size = New System.Drawing.Size(400, 34)
        Me.PathToInputTextbox.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 24)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Language/Locale-Sensitive Sort Order Used"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UnsortedTextbox
        '
        Me.UnsortedTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UnsortedTextbox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnsortedTextbox.Location = New System.Drawing.Point(60, 158)
        Me.UnsortedTextbox.Multiline = True
        Me.UnsortedTextbox.Name = "UnsortedTextbox"
        Me.UnsortedTextbox.Size = New System.Drawing.Size(197, 198)
        Me.UnsortedTextbox.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 24)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Unsorted Text"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(263, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 24)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Sorted Text"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 397)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UnsortedTextbox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ReadSortButton)
        Me.Controls.Add(Me.PathToInputTextbox)
        Me.Controls.Add(Me.SortedTextbox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReadSortButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents SortedTextbox As TextBox
    Friend WithEvents PathToInputTextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UnsortedTextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class

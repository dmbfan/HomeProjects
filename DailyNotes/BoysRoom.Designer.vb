<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BoysRoom
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnBoysRoomRemove = New System.Windows.Forms.Button()
        Me.btnBoysRoomAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(207, 86)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(148, 147)
        Me.ListBox1.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(29, 138)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'btnBoysRoomRemove
        '
        Me.btnBoysRoomRemove.Location = New System.Drawing.Point(29, 181)
        Me.btnBoysRoomRemove.Name = "btnBoysRoomRemove"
        Me.btnBoysRoomRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnBoysRoomRemove.TabIndex = 5
        Me.btnBoysRoomRemove.Text = "Button2"
        Me.btnBoysRoomRemove.UseVisualStyleBackColor = True
        '
        'btnBoysRoomAdd
        '
        Me.btnBoysRoomAdd.Location = New System.Drawing.Point(29, 85)
        Me.btnBoysRoomAdd.Name = "btnBoysRoomAdd"
        Me.btnBoysRoomAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnBoysRoomAdd.TabIndex = 4
        Me.btnBoysRoomAdd.Text = "Add"
        Me.btnBoysRoomAdd.UseVisualStyleBackColor = True
        '
        'BoysRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 318)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnBoysRoomRemove)
        Me.Controls.Add(Me.btnBoysRoomAdd)
        Me.Name = "BoysRoom"
        Me.Text = "BoysRoom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnBoysRoomRemove As System.Windows.Forms.Button
    Friend WithEvents btnBoysRoomAdd As System.Windows.Forms.Button
End Class

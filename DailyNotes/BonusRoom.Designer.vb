<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BonusRoom
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
        Me.btnBonusRoomRemove = New System.Windows.Forms.Button()
        Me.btnBonusRoomAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(206, 87)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(148, 147)
        Me.ListBox1.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(28, 139)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'btnBonusRoomRemove
        '
        Me.btnBonusRoomRemove.Location = New System.Drawing.Point(28, 182)
        Me.btnBonusRoomRemove.Name = "btnBonusRoomRemove"
        Me.btnBonusRoomRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnBonusRoomRemove.TabIndex = 5
        Me.btnBonusRoomRemove.Text = "Remove"
        Me.btnBonusRoomRemove.UseVisualStyleBackColor = True
        '
        'btnBonusRoomAdd
        '
        Me.btnBonusRoomAdd.Location = New System.Drawing.Point(28, 86)
        Me.btnBonusRoomAdd.Name = "btnBonusRoomAdd"
        Me.btnBonusRoomAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnBonusRoomAdd.TabIndex = 4
        Me.btnBonusRoomAdd.Text = "Add"
        Me.btnBonusRoomAdd.UseVisualStyleBackColor = True
        '
        'BonusRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 321)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnBonusRoomRemove)
        Me.Controls.Add(Me.btnBonusRoomAdd)
        Me.Name = "BonusRoom"
        Me.Text = "BonusRoom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnBonusRoomRemove As System.Windows.Forms.Button
    Friend WithEvents btnBonusRoomAdd As System.Windows.Forms.Button
End Class

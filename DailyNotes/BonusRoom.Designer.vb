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
        Me.lstBoxBonusRoom = New System.Windows.Forms.ListBox()
        Me.txtbxBonusRoom = New System.Windows.Forms.TextBox()
        Me.btnBonusRoomRemove = New System.Windows.Forms.Button()
        Me.btnBonusRoomAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstBoxBonusRoom
        '
        Me.lstBoxBonusRoom.FormattingEnabled = True
        Me.lstBoxBonusRoom.Location = New System.Drawing.Point(206, 87)
        Me.lstBoxBonusRoom.Name = "lstBoxBonusRoom"
        Me.lstBoxBonusRoom.Size = New System.Drawing.Size(148, 147)
        Me.lstBoxBonusRoom.TabIndex = 7
        '
        'txtbxBonusRoom
        '
        Me.txtbxBonusRoom.Location = New System.Drawing.Point(28, 139)
        Me.txtbxBonusRoom.Name = "txtbxBonusRoom"
        Me.txtbxBonusRoom.Size = New System.Drawing.Size(100, 20)
        Me.txtbxBonusRoom.TabIndex = 6
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
        Me.Controls.Add(Me.lstBoxBonusRoom)
        Me.Controls.Add(Me.txtbxBonusRoom)
        Me.Controls.Add(Me.btnBonusRoomRemove)
        Me.Controls.Add(Me.btnBonusRoomAdd)
        Me.Name = "BonusRoom"
        Me.Text = "BonusRoom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstBoxBonusRoom As System.Windows.Forms.ListBox
    Friend WithEvents txtbxBonusRoom As System.Windows.Forms.TextBox
    Friend WithEvents btnBonusRoomRemove As System.Windows.Forms.Button
    Friend WithEvents btnBonusRoomAdd As System.Windows.Forms.Button
End Class

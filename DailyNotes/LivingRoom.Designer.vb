<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LivingRoom
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
        Me.lstBxLivingRoom = New System.Windows.Forms.ListBox()
        Me.txtbxLivingRoom = New System.Windows.Forms.TextBox()
        Me.btnLivingRoomRemove = New System.Windows.Forms.Button()
        Me.btnLivingRoomAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstBxLivingRoom
        '
        Me.lstBxLivingRoom.FormattingEnabled = True
        Me.lstBxLivingRoom.Location = New System.Drawing.Point(174, 61)
        Me.lstBxLivingRoom.Name = "lstBxLivingRoom"
        Me.lstBxLivingRoom.Size = New System.Drawing.Size(148, 147)
        Me.lstBxLivingRoom.TabIndex = 7
        '
        'txtbxLivingRoom
        '
        Me.txtbxLivingRoom.Location = New System.Drawing.Point(12, 109)
        Me.txtbxLivingRoom.Name = "txtbxLivingRoom"
        Me.txtbxLivingRoom.Size = New System.Drawing.Size(100, 20)
        Me.txtbxLivingRoom.TabIndex = 6
        '
        'btnLivingRoomRemove
        '
        Me.btnLivingRoomRemove.Location = New System.Drawing.Point(12, 170)
        Me.btnLivingRoomRemove.Name = "btnLivingRoomRemove"
        Me.btnLivingRoomRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnLivingRoomRemove.TabIndex = 5
        Me.btnLivingRoomRemove.Text = "Remove"
        Me.btnLivingRoomRemove.UseVisualStyleBackColor = True
        '
        'btnLivingRoomAdd
        '
        Me.btnLivingRoomAdd.Location = New System.Drawing.Point(12, 61)
        Me.btnLivingRoomAdd.Name = "btnLivingRoomAdd"
        Me.btnLivingRoomAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnLivingRoomAdd.TabIndex = 4
        Me.btnLivingRoomAdd.Text = "Add"
        Me.btnLivingRoomAdd.UseVisualStyleBackColor = True
        '
        'LivingRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 327)
        Me.Controls.Add(Me.lstBxLivingRoom)
        Me.Controls.Add(Me.txtbxLivingRoom)
        Me.Controls.Add(Me.btnLivingRoomRemove)
        Me.Controls.Add(Me.btnLivingRoomAdd)
        Me.Name = "LivingRoom"
        Me.Text = "LivingRoom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstBxLivingRoom As System.Windows.Forms.ListBox
    Friend WithEvents txtbxLivingRoom As System.Windows.Forms.TextBox
    Friend WithEvents btnLivingRoomRemove As System.Windows.Forms.Button
    Friend WithEvents btnLivingRoomAdd As System.Windows.Forms.Button
End Class

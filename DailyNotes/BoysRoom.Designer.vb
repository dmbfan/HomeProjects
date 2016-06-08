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
        Me.lstBoxBoysRoom = New System.Windows.Forms.ListBox()
        Me.txtbxBoysRoom = New System.Windows.Forms.TextBox()
        Me.btnBoysRoomRemove = New System.Windows.Forms.Button()
        Me.btnBoysRoomAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstBoxBoysRoom
        '
        Me.lstBoxBoysRoom.FormattingEnabled = True
        Me.lstBoxBoysRoom.Location = New System.Drawing.Point(207, 86)
        Me.lstBoxBoysRoom.Name = "lstBoxBoysRoom"
        Me.lstBoxBoysRoom.Size = New System.Drawing.Size(148, 147)
        Me.lstBoxBoysRoom.TabIndex = 7
        '
        'txtbxBoysRoom
        '
        Me.txtbxBoysRoom.Location = New System.Drawing.Point(29, 138)
        Me.txtbxBoysRoom.Name = "txtbxBoysRoom"
        Me.txtbxBoysRoom.Size = New System.Drawing.Size(100, 20)
        Me.txtbxBoysRoom.TabIndex = 6
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
        Me.Controls.Add(Me.lstBoxBoysRoom)
        Me.Controls.Add(Me.txtbxBoysRoom)
        Me.Controls.Add(Me.btnBoysRoomRemove)
        Me.Controls.Add(Me.btnBoysRoomAdd)
        Me.Name = "BoysRoom"
        Me.Text = "BoysRoom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstBoxBoysRoom As System.Windows.Forms.ListBox
    Friend WithEvents txtbxBoysRoom As System.Windows.Forms.TextBox
    Friend WithEvents btnBoysRoomRemove As System.Windows.Forms.Button
    Friend WithEvents btnBoysRoomAdd As System.Windows.Forms.Button
End Class

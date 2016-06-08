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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnLivingRoomRemove = New System.Windows.Forms.Button()
        Me.btnLivingRoomAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(190, 90)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(148, 147)
        Me.ListBox1.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 142)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'btnLivingRoomRemove
        '
        Me.btnLivingRoomRemove.Location = New System.Drawing.Point(12, 185)
        Me.btnLivingRoomRemove.Name = "btnLivingRoomRemove"
        Me.btnLivingRoomRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnLivingRoomRemove.TabIndex = 5
        Me.btnLivingRoomRemove.Text = "Remove"
        Me.btnLivingRoomRemove.UseVisualStyleBackColor = True
        '
        'btnLivingRoomAdd
        '
        Me.btnLivingRoomAdd.Location = New System.Drawing.Point(12, 89)
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
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnLivingRoomRemove)
        Me.Controls.Add(Me.btnLivingRoomAdd)
        Me.Name = "LivingRoom"
        Me.Text = "LivingRoom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnLivingRoomRemove As System.Windows.Forms.Button
    Friend WithEvents btnLivingRoomAdd As System.Windows.Forms.Button
End Class

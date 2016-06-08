<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Master
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
        Me.lstBoxMaster = New System.Windows.Forms.ListBox()
        Me.txtbxMaster = New System.Windows.Forms.TextBox()
        Me.btnMasterRemove = New System.Windows.Forms.Button()
        Me.btnMasterAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstBoxMaster
        '
        Me.lstBoxMaster.FormattingEnabled = True
        Me.lstBoxMaster.Location = New System.Drawing.Point(227, 91)
        Me.lstBoxMaster.Name = "lstBoxMaster"
        Me.lstBoxMaster.Size = New System.Drawing.Size(148, 147)
        Me.lstBoxMaster.TabIndex = 7
        '
        'txtbxMaster
        '
        Me.txtbxMaster.Location = New System.Drawing.Point(49, 143)
        Me.txtbxMaster.Name = "txtbxMaster"
        Me.txtbxMaster.Size = New System.Drawing.Size(100, 20)
        Me.txtbxMaster.TabIndex = 6
        '
        'btnMasterRemove
        '
        Me.btnMasterRemove.Location = New System.Drawing.Point(49, 186)
        Me.btnMasterRemove.Name = "btnMasterRemove"
        Me.btnMasterRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnMasterRemove.TabIndex = 5
        Me.btnMasterRemove.Text = "Remove"
        Me.btnMasterRemove.UseVisualStyleBackColor = True
        '
        'btnMasterAdd
        '
        Me.btnMasterAdd.Location = New System.Drawing.Point(49, 90)
        Me.btnMasterAdd.Name = "btnMasterAdd"
        Me.btnMasterAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnMasterAdd.TabIndex = 4
        Me.btnMasterAdd.Text = "Add"
        Me.btnMasterAdd.UseVisualStyleBackColor = True
        '
        'Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 329)
        Me.Controls.Add(Me.lstBoxMaster)
        Me.Controls.Add(Me.txtbxMaster)
        Me.Controls.Add(Me.btnMasterRemove)
        Me.Controls.Add(Me.btnMasterAdd)
        Me.Name = "Master"
        Me.Text = "Master"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstBoxMaster As System.Windows.Forms.ListBox
    Friend WithEvents txtbxMaster As System.Windows.Forms.TextBox
    Friend WithEvents btnMasterRemove As System.Windows.Forms.Button
    Friend WithEvents btnMasterAdd As System.Windows.Forms.Button
End Class

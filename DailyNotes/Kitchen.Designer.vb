<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kitchen
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
        Me.lstBoxKItchen = New System.Windows.Forms.ListBox()
        Me.txtbxKitchen = New System.Windows.Forms.TextBox()
        Me.btnKitchenRemove = New System.Windows.Forms.Button()
        Me.btnKitchenAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstBoxKItchen
        '
        Me.lstBoxKItchen.FormattingEnabled = True
        Me.lstBoxKItchen.Location = New System.Drawing.Point(157, 57)
        Me.lstBoxKItchen.Name = "lstBoxKItchen"
        Me.lstBoxKItchen.Size = New System.Drawing.Size(148, 147)
        Me.lstBoxKItchen.TabIndex = 7
        '
        'txtbxKitchen
        '
        Me.txtbxKitchen.Location = New System.Drawing.Point(12, 114)
        Me.txtbxKitchen.Name = "txtbxKitchen"
        Me.txtbxKitchen.Size = New System.Drawing.Size(100, 20)
        Me.txtbxKitchen.TabIndex = 6
        '
        'btnKitchenRemove
        '
        Me.btnKitchenRemove.Location = New System.Drawing.Point(12, 152)
        Me.btnKitchenRemove.Name = "btnKitchenRemove"
        Me.btnKitchenRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnKitchenRemove.TabIndex = 5
        Me.btnKitchenRemove.Text = "Remove"
        Me.btnKitchenRemove.UseVisualStyleBackColor = True
        '
        'btnKitchenAdd
        '
        Me.btnKitchenAdd.Location = New System.Drawing.Point(12, 57)
        Me.btnKitchenAdd.Name = "btnKitchenAdd"
        Me.btnKitchenAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnKitchenAdd.TabIndex = 4
        Me.btnKitchenAdd.Text = "Add"
        Me.btnKitchenAdd.UseVisualStyleBackColor = True
        '
        'Kitchen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 319)
        Me.Controls.Add(Me.lstBoxKItchen)
        Me.Controls.Add(Me.txtbxKitchen)
        Me.Controls.Add(Me.btnKitchenRemove)
        Me.Controls.Add(Me.btnKitchenAdd)
        Me.Name = "Kitchen"
        Me.Text = "Kitchen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstBoxKItchen As System.Windows.Forms.ListBox
    Friend WithEvents txtbxKitchen As System.Windows.Forms.TextBox
    Friend WithEvents btnKitchenRemove As System.Windows.Forms.Button
    Friend WithEvents btnKitchenAdd As System.Windows.Forms.Button
End Class

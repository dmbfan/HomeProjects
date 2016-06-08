<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Yard
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
        Me.btnYardAdd = New System.Windows.Forms.Button()
        Me.btnYardRemove = New System.Windows.Forms.Button()
        Me.txtbxYard = New System.Windows.Forms.TextBox()
        Me.lstBoxYard = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnYardAdd
        '
        Me.btnYardAdd.Location = New System.Drawing.Point(23, 25)
        Me.btnYardAdd.Name = "btnYardAdd"
        Me.btnYardAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnYardAdd.TabIndex = 0
        Me.btnYardAdd.Text = "Add"
        Me.btnYardAdd.UseVisualStyleBackColor = True
        '
        'btnYardRemove
        '
        Me.btnYardRemove.Location = New System.Drawing.Point(23, 149)
        Me.btnYardRemove.Name = "btnYardRemove"
        Me.btnYardRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnYardRemove.TabIndex = 1
        Me.btnYardRemove.Text = "Remove"
        Me.btnYardRemove.UseVisualStyleBackColor = True
        '
        'txtbxYard
        '
        Me.txtbxYard.Location = New System.Drawing.Point(23, 77)
        Me.txtbxYard.Name = "txtbxYard"
        Me.txtbxYard.Size = New System.Drawing.Size(100, 20)
        Me.txtbxYard.TabIndex = 2
        '
        'lstBoxYard
        '
        Me.lstBoxYard.FormattingEnabled = True
        Me.lstBoxYard.Location = New System.Drawing.Point(201, 25)
        Me.lstBoxYard.Name = "lstBoxYard"
        Me.lstBoxYard.Size = New System.Drawing.Size(148, 147)
        Me.lstBoxYard.TabIndex = 3
        '
        'Yard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 269)
        Me.Controls.Add(Me.lstBoxYard)
        Me.Controls.Add(Me.txtbxYard)
        Me.Controls.Add(Me.btnYardRemove)
        Me.Controls.Add(Me.btnYardAdd)
        Me.Name = "Yard"
        Me.Text = "Yard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnYardAdd As System.Windows.Forms.Button
    Friend WithEvents btnYardRemove As System.Windows.Forms.Button
    Friend WithEvents txtbxYard As System.Windows.Forms.TextBox
    Friend WithEvents lstBoxYard As System.Windows.Forms.ListBox
End Class

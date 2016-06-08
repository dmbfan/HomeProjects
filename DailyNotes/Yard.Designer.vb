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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnYardAdd
        '
        Me.btnYardAdd.Location = New System.Drawing.Point(23, 24)
        Me.btnYardAdd.Name = "btnYardAdd"
        Me.btnYardAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnYardAdd.TabIndex = 0
        Me.btnYardAdd.Text = "Add"
        Me.btnYardAdd.UseVisualStyleBackColor = True
        '
        'btnYardRemove
        '
        Me.btnYardRemove.Location = New System.Drawing.Point(23, 120)
        Me.btnYardRemove.Name = "btnYardRemove"
        Me.btnYardRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnYardRemove.TabIndex = 1
        Me.btnYardRemove.Text = "Remove"
        Me.btnYardRemove.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(23, 77)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(201, 25)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(148, 147)
        Me.ListBox1.TabIndex = 3
        '
        'Yard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 269)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnYardRemove)
        Me.Controls.Add(Me.btnYardAdd)
        Me.Name = "Yard"
        Me.Text = "Yard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnYardAdd As System.Windows.Forms.Button
    Friend WithEvents btnYardRemove As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class

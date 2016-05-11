<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnLivingRoom = New System.Windows.Forms.Button()
        Me.btnYard = New System.Windows.Forms.Button()
        Me.btnMaster = New System.Windows.Forms.Button()
        Me.btnBoys = New System.Windows.Forms.Button()
        Me.btnBonus = New System.Windows.Forms.Button()
        Me.btnKitchen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLivingRoom
        '
        Me.btnLivingRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLivingRoom.Location = New System.Drawing.Point(56, 55)
        Me.btnLivingRoom.Name = "btnLivingRoom"
        Me.btnLivingRoom.Size = New System.Drawing.Size(88, 40)
        Me.btnLivingRoom.TabIndex = 1
        Me.btnLivingRoom.Text = "Living Room"
        Me.btnLivingRoom.UseVisualStyleBackColor = True
        '
        'btnYard
        '
        Me.btnYard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYard.Location = New System.Drawing.Point(56, 117)
        Me.btnYard.Name = "btnYard"
        Me.btnYard.Size = New System.Drawing.Size(88, 37)
        Me.btnYard.TabIndex = 2
        Me.btnYard.Text = "Yard"
        Me.btnYard.UseVisualStyleBackColor = True
        '
        'btnMaster
        '
        Me.btnMaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaster.Location = New System.Drawing.Point(56, 180)
        Me.btnMaster.Name = "btnMaster"
        Me.btnMaster.Size = New System.Drawing.Size(88, 32)
        Me.btnMaster.TabIndex = 3
        Me.btnMaster.Text = "Master Bedroom"
        Me.btnMaster.UseVisualStyleBackColor = True
        '
        'btnBoys
        '
        Me.btnBoys.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBoys.Location = New System.Drawing.Point(250, 117)
        Me.btnBoys.Name = "btnBoys"
        Me.btnBoys.Size = New System.Drawing.Size(99, 37)
        Me.btnBoys.TabIndex = 4
        Me.btnBoys.Text = "Boys Room"
        Me.btnBoys.UseVisualStyleBackColor = True
        '
        'btnBonus
        '
        Me.btnBonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBonus.Location = New System.Drawing.Point(250, 55)
        Me.btnBonus.Name = "btnBonus"
        Me.btnBonus.Size = New System.Drawing.Size(99, 40)
        Me.btnBonus.TabIndex = 5
        Me.btnBonus.Text = "Bonus Room"
        Me.btnBonus.UseVisualStyleBackColor = True
        '
        'btnKitchen
        '
        Me.btnKitchen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKitchen.Location = New System.Drawing.Point(250, 180)
        Me.btnKitchen.Name = "btnKitchen"
        Me.btnKitchen.Size = New System.Drawing.Size(99, 32)
        Me.btnKitchen.TabIndex = 6
        Me.btnKitchen.Text = "KItchen"
        Me.btnKitchen.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 290)
        Me.Controls.Add(Me.btnKitchen)
        Me.Controls.Add(Me.btnBonus)
        Me.Controls.Add(Me.btnBoys)
        Me.Controls.Add(Me.btnMaster)
        Me.Controls.Add(Me.btnYard)
        Me.Controls.Add(Me.btnLivingRoom)
        Me.Name = "Form1"
        Me.Text = "Projects"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLivingRoom As System.Windows.Forms.Button
    Friend WithEvents btnYard As System.Windows.Forms.Button
    Friend WithEvents btnMaster As System.Windows.Forms.Button
    Friend WithEvents btnBoys As System.Windows.Forms.Button
    Friend WithEvents btnBonus As System.Windows.Forms.Button
    Friend WithEvents btnKitchen As System.Windows.Forms.Button

End Class

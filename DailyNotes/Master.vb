Public Class Master

    Private Sub btnMasterAdd_Click(sender As Object, e As EventArgs) Handles btnMasterAdd.Click
        lstBoxMaster.Items.Add(txtbxMaster.Text(vbNewLine))
    End Sub
    Private Sub lstBoxMaster_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxMaster.SelectedIndexChanged

    End Sub

    Private Sub txtbxMaster_TextChanged(sender As Object, e As EventArgs) Handles txtbxMaster.TextChanged

    End Sub

   
    Private Sub btnMasterMain_Click(sender As Object, e As EventArgs) Handles btnMasterMain.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class
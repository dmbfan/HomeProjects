Public Class BoysRoom

    Private Sub btnBoysRoomAdd_Click(sender As Object, e As EventArgs) Handles btnBoysRoomAdd.Click
        lstBoxBoysRoom.Items.Add(txtbxBoysRoom.Text(vbNewLine))
    End Sub

    Private Sub txtbxBoysRoom_TextChanged(sender As Object, e As EventArgs) Handles txtbxBoysRoom.TextChanged

    End Sub

    Private Sub lstBoxBoysRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxBoysRoom.SelectedIndexChanged

    End Sub

    Private Sub btnBoyMain_Click(sender As Object, e As EventArgs) Handles btnBoyMain.Click
        Me.Show()
        Form1.Show()
    End Sub
End Class
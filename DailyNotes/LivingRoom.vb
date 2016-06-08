Public Class LivingRoom

    Private Sub btnLivingRoomAdd_Click(sender As Object, e As EventArgs) Handles btnLivingRoomAdd.Click

        lstBxLivingRoom.Items.Add(txtbxLivingRoom.Text(vbNewLine))

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbxLivingRoom.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBxLivingRoom.SelectedIndexChanged

    End Sub
End Class
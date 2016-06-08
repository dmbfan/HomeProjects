Public Class Kitchen

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnKitchenRemove.Click
        lstBoxKItchen.Items.Add(txtbxKitchen.Text(vbNewLine))

    End Sub

    Private Sub lstBoxKItchen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxKItchen.SelectedIndexChanged

    End Sub

    Private Sub txtbxKitchen_TextChanged(sender As Object, e As EventArgs) Handles txtbxKitchen.TextChanged

    End Sub
End Class
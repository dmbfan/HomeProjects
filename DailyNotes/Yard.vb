Public Class Yard

    Private Sub btnYardAdd_Click(sender As Object, e As EventArgs) Handles btnYardAdd.Click
        lstBoxYard.Items.Add(txtbxYard.Text(vbNewLine))
    End Sub
    Private Sub txtbxYard_TextChanged(sender As Object, e As EventArgs) Handles txtbxYard.TextChanged

    End Sub

    Private Sub lstBoxYard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxYard.SelectedIndexChanged

    End Sub

   
End Class
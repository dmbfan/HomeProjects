﻿Public Class BonusRoom

    Private Sub txtbxBonusRoom_TextChanged(sender As Object, e As EventArgs) Handles txtbxBonusRoom.TextChanged

    End Sub

    Private Sub btnBonusRoomAdd_Click(sender As Object, e As EventArgs) Handles btnBonusRoomAdd.Click
        lstBoxBonusRoom.Items.Add(txtbxBonusRoom.Text(vbNewLine))
    End Sub

    Private Sub lstBoxBonusRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxBonusRoom.SelectedIndexChanged

    End Sub
End Class
Public Class Form1

    Private Sub btnLivingRoom_Click(sender As Object, e As EventArgs) Handles btnLivingRoom.Click
        Me.Hide()
        LivingRoom.Show()
    End Sub

    Private Sub btnBonus_Click(sender As Object, e As EventArgs) Handles btnBonus.Click
        Me.Hide()
        BonusRoom.Show()
    End Sub

    Private Sub btnYard_Click(sender As Object, e As EventArgs) Handles btnYard.Click
        Me.Hide()
        Yard.Show()
    End Sub

    Private Sub btnBoys_Click(sender As Object, e As EventArgs) Handles btnBoys.Click
        Me.Hide()
        BoysRoom.Show()
    End Sub

    Private Sub btnMaster_Click(sender As Object, e As EventArgs) Handles btnMaster.Click
        Me.Hide()
        Master.Show()
    End Sub

    Private Sub btnKitchen_Click(sender As Object, e As EventArgs) Handles btnKitchen.Click
        Me.Hide()
        Kitchen.Show()
    End Sub
End Class

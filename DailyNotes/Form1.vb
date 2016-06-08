Public Class Form1

    Private Sub btnLivingRoom_Click(sender As Object, e As EventArgs) Handles btnLivingRoom.Click
        Me.Close()
        LivingRoom.Show()
    End Sub

    Private Sub btnBonus_Click(sender As Object, e As EventArgs) Handles btnBonus.Click
        Me.Close()
        BonusRoom.Show()
    End Sub

    Private Sub btnYard_Click(sender As Object, e As EventArgs) Handles btnYard.Click
        Me.Close()
        Yard.Show()
    End Sub

    Private Sub btnBoys_Click(sender As Object, e As EventArgs) Handles btnBoys.Click
        Me.Close()
        BoysRoom.Show()
    End Sub

    Private Sub btnMaster_Click(sender As Object, e As EventArgs) Handles btnMaster.Click
        Me.Close()
        Master.Show()
    End Sub

    Private Sub btnKitchen_Click(sender As Object, e As EventArgs) Handles btnKitchen.Click
        Me.Close()
        Kitchen.Show()
    End Sub
End Class

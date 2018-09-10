Public Class frmRegistration
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmRegisterVehicle.Show()
        Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
    frmAdminPortal.Show()
    Me.Close()
  End Sub

  Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    frmCreateUser.Show()
    Me.Close()
  End Sub

  Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        frmCreateReservoir.Show()
        Me.Close()
  End Sub
End Class
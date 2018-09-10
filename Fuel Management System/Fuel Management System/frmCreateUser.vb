Imports System.Data.SQLite
Public Class frmCreateUser
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmRegistration.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegisterUser_Click(sender As Object, e As EventArgs) Handles btnRegisterUser.Click
        Dim db As New DatabaseConnection()

        If txtFullName.Text <> Nothing Or txtECNumber.Text <> Nothing Or txtUsername.Text <> Nothing Or txtPassword.Text <> Nothing Then
            Try
                Dim insertCatQuery As String = "INSERT into accounts(full_name, ec_number, account_type, username, password) VALUES(@full_name, @ec_number, @account_type, @username, @password)"
                db.Command = New SQLiteCommand(insertCatQuery, db.Connection)
                ' TODO encrypt password
                db.Command.Parameters.AddWithValue("@full_name", txtFullName.Text)
                db.Command.Parameters.AddWithValue("@ec_number", txtECNumber.Text)
                db.Command.Parameters.AddWithValue("@account_type", cboUserType.SelectedItem)
                db.Command.Parameters.AddWithValue("@username", txtUsername.Text)
                db.Command.Parameters.AddWithValue("@password", txtPassword.Text)

                db.Connection.Open()
                db.Command.ExecuteNonQuery()
                db.Connection.Close()
                MsgBox("successfully created account")
            Catch ex As Exception
                db.Connection.Close()
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class
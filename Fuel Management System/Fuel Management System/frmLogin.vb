Imports System.Data.SQLite
Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        validateAccount(txtUsername.Text, txtPassword.Text)


    End Sub

    Function validateAccount(username As String, password As String)
        Dim db As New DatabaseConnection

        Try
            Dim LoginQuery As String = "SELECT * FROM accounts WHERE username = @username AND password = @password"
            db.Command = New SQLiteCommand(LoginQuery, db.Connection)
            db.Command.Parameters.AddWithValue("@username", txtUsername.Text)
            db.Command.Parameters.AddWithValue("@password", txtPassword.Text)

            Dim accountType As String
            Dim _ec As String
            db.Connection.Open()
            Dim reader = db.Command.ExecuteReader()
            While reader.Read()
                accountType = reader.GetString(4)
                _ec = reader.GetString(2)
                ' Return True
            End While
            If accountType <> Nothing Then
                If accountType = "administrator" Then
                    Dim frmAdminPortal As New frmAdminPortal(txtUsername.Text)
                    frmAdminPortal.Show()
                    Me.Close()
                ElseIf accountType = "driver" Then

                    Dim frmDriverPortal As New frmDriverPortal(txtUsername.Text, _ec)
                    frmDriverPortal.Show()
                    Me.Close()
                End If

            End If
            'Return False
            db.Connection.Close()
        Catch ex As Exception
            db.Connection.Close()
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

End Class
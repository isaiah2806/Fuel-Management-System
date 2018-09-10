Imports System.Data.SQLite
Public Class frmCreateReservoir

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmRegistration.Show()
        Me.Hide()
    End Sub

    Private Sub btnShowRegistration_Click(sender As Object, e As EventArgs) Handles btnShowRegistration.Click
        Dim db As New DatabaseConnection

        Try
            Dim insertCatQuery As String = "INSERT into reservoirs(name, capacity) VALUES(@name, @capacity)"
            db.Command = New SQLiteCommand(insertCatQuery, db.Connection)

            db.Command.Parameters.AddWithValue("@name", txtName.Text)
            db.Command.Parameters.AddWithValue("@capacity", txtCapacity.Text)

            db.Connection.Open()
            db.Command.ExecuteNonQuery()
            db.Connection.Close()
            MsgBox("successfully created new reservoir")
        Catch ex As Exception
            db.Connection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
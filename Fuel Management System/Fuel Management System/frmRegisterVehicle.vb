Imports System.Data.SQLite
Public Class frmRegisterVehicle

    Private Sub frmRegisterVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnShowLogin_Click(sender As Object, e As EventArgs) Handles btnShowLogin.Click
        frmLogin.Show()

    End Sub

    Private Sub btnShowRegistration_Click(sender As Object, e As EventArgs) Handles btnRegisterVehicle.Click
        Dim db As New DatabaseConnection

        If txtRegNumber.Text <> Nothing Or txtModel.Text <> Nothing Or txtFuelCapacity.Text <> Nothing Or Not IsNumeric(txtFuelCapacity.Text) Then
            Try
                Dim insertCatQuery As String = "INSERT into vehicles(reg_number, model, fuel_capacity) VALUES(@reg_number, @model, @fuel_capacity)"
                db.Command = New SQLiteCommand(insertCatQuery, db.Connection)

                db.Command.Parameters.AddWithValue("@reg_number", txtRegNumber.Text)
                db.Command.Parameters.AddWithValue("@model", txtModel.Text)
                db.Command.Parameters.AddWithValue("@fuel_capacity", txtFuelCapacity.Text)

                db.Connection.Open()
                db.Command.ExecuteNonQuery()
                db.Connection.Close()
                MsgBox("successfully created vehicle")

            Catch ex As Exception

                db.Connection.Close()
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmRegistration.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
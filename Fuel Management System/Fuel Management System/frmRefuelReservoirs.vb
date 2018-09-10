Imports System.Data.SQLite
Public Class frmRefuelReservoirs

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmAdminPortal.Show()
        Me.Close()
    End Sub

    Private Sub frmRefuelReservoirs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim db As New DatabaseConnection
            db.Command.CommandText = "SELECT * FROM reservoirs"
            Dim da As New SQLiteDataAdapter(db.Command)
            Dim dt As New DataTable

            da.Fill(dt)
            dgvFuelReservoirs.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRefuel_Click(sender As Object, e As EventArgs) Handles btnRefuel.Click
        Dim db As New DatabaseConnection()

        Try
            Dim selectedRow = dgvFuelReservoirs.SelectedRows(0)
            Dim id As Integer = selectedRow.Cells(0).Value
            Dim capacity As Integer = selectedRow.Cells(2).Value
            Dim currentLevel As Integer = selectedRow.Cells(3).Value
            Dim newLevel = CInt(Val(txtAmount.Text)) + currentLevel

            If (newLevel > capacity) Then
                MsgBox("There is enough fuel in the reservoir. You have exceeded the tank's capacity by " & (newLevel - capacity) & " litres at the moment")
                Return
            End If

            Dim insertCatQuery As String = "UPDATE reservoirs set current_level = @new_level where id = @id"
            db.Command = New SQLiteCommand(insertCatQuery, db.Connection)

            db.Command.Parameters.AddWithValue("@new_level", newLevel)
            db.Command.Parameters.AddWithValue("@id", id)

            db.Connection.Open()
            db.Command.ExecuteNonQuery()
            db.Connection.Close()

            selectedRow.Cells(3).Value = newLevel.ToString()
            MsgBox("successfully refueled reservoir")
        Catch ex As Exception
            db.Connection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
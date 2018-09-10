Imports System.Data.SQLite
Public Class frmAssignDriver
    Public Sub New(username As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblUsername.Text = username
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim frmAdminPortal As New frmAdminPortal(lblUsername.Text)
        frmAdminPortal.Show()
        Me.Close()
    End Sub

    Private Sub frmAssignDriver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadReservoirs()
        loadDrivers()
        loadVehicles()
    End Sub

    Sub loadReservoirs()
        Try
            Dim db As New DatabaseConnection
            db.Command.CommandText = "SELECT * FROM reservoirs"
            Dim da As New SQLiteDataAdapter(db.Command)
            Dim dt As New DataTable

            da.Fill(dt)
            dgvReservoirs.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub loadDrivers()
        Try
            Dim db As New DatabaseConnection
            db.Command.CommandText = "SELECT * FROM accounts where account_type = 'driver'"
            Dim da As New SQLiteDataAdapter(db.Command)
            Dim dt As New DataTable

            da.Fill(dt)
            dgvDrivers.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loadVehicles()
        Try
            Dim db As New DatabaseConnection
            db.Command.CommandText = "SELECT * FROM vehicles"
            Dim da As New SQLiteDataAdapter(db.Command)
            Dim dt As New DataTable

            da.Fill(dt)
            dgvVehicles.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnShowRegistration_Click(sender As Object, e As EventArgs) Handles btnShowRegistration.Click
        Dim ec As String = dgvDrivers.SelectedRows(0).Cells(2).Value
        Dim reg As String = dgvVehicles.SelectedRows(0).Cells(0).Value
        Dim resName As String = dgvReservoirs.SelectedRows(0).Cells(1).Value
        Dim capacity As Double = dgvVehicles.SelectedRows(0).Cells(2).Value
        Dim amount As Double = Val(txtAmount.Text)

        If amount <= capacity And amount <= capacity Then
            assignDriver(ec, reg, resName, amount)
            MsgBox("Successful !")
        End If


    End Sub

    Public Sub assignDriver(ec As String, reg As String, resName As String, amount As Double)
        Dim assignDriverQuery As String = "INSERT INTO assigned_drivers(driver_ec_number, vehicle_reg_number, date_assigned, fuel_used) VALUES (@ec, @reg, @date, @fuel)"
        Dim updateReservoirQuery As String = "UPDATE reservoirs SET current_level = current_level - @amount WHERE name = @name"

        Dim adate As String = DateTime.Today

        Try


            Dim db = New DatabaseConnection()
            db.Command = New SQLiteCommand(updateReservoirQuery, db.Connection)

            db.Command.Parameters.AddWithValue("@amount", amount)
            db.Command.Parameters.AddWithValue("@name", resName)

            db.Connection.Open()
            db.Command.ExecuteNonQuery()
            db.Connection.Close()


            db.Command = New SQLiteCommand(assignDriverQuery, db.Connection)

            db.Command.Parameters.AddWithValue("@ec", ec)
            db.Command.Parameters.AddWithValue("@reg", reg)
            db.Command.Parameters.AddWithValue("@date", adate)
            db.Command.Parameters.AddWithValue("@fuel", amount)

            db.Connection.Open()

            db.Command.ExecuteNonQuery()
            db.Connection.Close()

        Catch ex As Exception
        End Try



    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub dgvDrivers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDrivers.CellContentClick

    End Sub
End Class
Imports System.Data.SQLite
Public Class frmDriverPortal
    Dim _ec As String
    Public Sub New(username As String, ec As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblusername.Text = username
        _ec = ec
    End Sub
    Private Sub frmDriverPortal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDrivers()
    End Sub
    Public Sub loadDrivers()
        Try
            Dim db As New DatabaseConnection
            Dim driverViewQuery As String = "SELECT * FROM assigned_drivers WHERE driver_ec_number = '" + _ec + "'"

            Dim command = New SQLiteCommand(driverViewQuery, db.Connection)

            Dim da As New SQLiteDataAdapter(command)
            Dim dt As New DataTable

            da.Fill(dt)
            dgvDriver.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
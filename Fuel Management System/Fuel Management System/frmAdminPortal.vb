Public Class frmAdminPortal
    Public Sub New(username As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblUsername.Text = username
    End Sub
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnShowRegistration_Click(sender As Object, e As EventArgs) Handles btnShowRegistration.Click
        frmRegistration.Show()
        Hide()
    End Sub

    Private Sub btnAssignDriver_Click(sender As Object, e As EventArgs) Handles btnAssignDriver.Click
        Dim frmAssignDriver As New frmAssignDriver(lblUsername.Text)
        frmAssignDriver.Show()
        Me.Hide()
    End Sub

    Private Sub btnRefuelReservoirs_Click(sender As Object, e As EventArgs) Handles btnRefuelReservoirs.Click
        frmRefuelReservoirs.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub frmAdminPortal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignDriver
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.dgvDrivers = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvVehicles = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnShowRegistration = New System.Windows.Forms.Button()
        Me.btnShowLogin = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dgvReservoirs = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblUsername = New System.Windows.Forms.Label()
        CType(Me.dgvDrivers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVehicles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvReservoirs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDrivers
        '
        Me.dgvDrivers.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDrivers.Location = New System.Drawing.Point(23, 79)
        Me.dgvDrivers.MultiSelect = False
        Me.dgvDrivers.Name = "dgvDrivers"
        Me.dgvDrivers.ReadOnly = True
        Me.dgvDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDrivers.Size = New System.Drawing.Size(553, 313)
        Me.dgvDrivers.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Driver"
        '
        'dgvVehicles
        '
        Me.dgvVehicles.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVehicles.Location = New System.Drawing.Point(720, 91)
        Me.dgvVehicles.MultiSelect = False
        Me.dgvVehicles.Name = "dgvVehicles"
        Me.dgvVehicles.ReadOnly = True
        Me.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVehicles.Size = New System.Drawing.Size(607, 281)
        Me.dgvVehicles.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1065, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Vehicle"
        '
        'txtAmount
        '
        Me.txtAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAmount.Location = New System.Drawing.Point(1009, 428)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(293, 29)
        Me.txtAmount.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1040, 397)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Amount (l)"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 410)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Select reservoir"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Location = New System.Drawing.Point(-2, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(6, 79)
        Me.Panel1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.Label5.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label5.Location = New System.Drawing.Point(129, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 37)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Assign driver"
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.Image = Global.Fuel_Management_System.My.Resources.Resources.Volume_25px
        Me.PictureBox5.Location = New System.Drawing.Point(1009, 393)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 30
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Image = Global.Fuel_Management_System.My.Resources.Resources.Drum_100px
        Me.PictureBox4.Location = New System.Drawing.Point(23, 408)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 29
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Fuel_Management_System.My.Resources.Resources.Deliver_Food_25px
        Me.PictureBox3.Location = New System.Drawing.Point(1034, 60)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Fuel_Management_System.My.Resources.Resources.Driver_100px
        Me.PictureBox1.Location = New System.Drawing.Point(23, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBack.Image = Global.Fuel_Management_System.My.Resources.Resources.Back_25px
        Me.btnBack.Location = New System.Drawing.Point(11, 14)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(53, 46)
        Me.btnBack.TabIndex = 26
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Fuel_Management_System.My.Resources.Resources.Driver_100px
        Me.PictureBox2.Location = New System.Drawing.Point(73, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'btnShowRegistration
        '
        Me.btnShowRegistration.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowRegistration.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.btnShowRegistration.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnShowRegistration.Image = Global.Fuel_Management_System.My.Resources.Resources.Save_25px
        Me.btnShowRegistration.Location = New System.Drawing.Point(1009, 496)
        Me.btnShowRegistration.Name = "btnShowRegistration"
        Me.btnShowRegistration.Size = New System.Drawing.Size(293, 46)
        Me.btnShowRegistration.TabIndex = 31
        Me.btnShowRegistration.Text = "Assign Driver"
        Me.btnShowRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShowRegistration.UseVisualStyleBackColor = True
        '
        'btnShowLogin
        '
        Me.btnShowLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowLogin.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.btnShowLogin.ForeColor = System.Drawing.Color.Red
        Me.btnShowLogin.Image = Global.Fuel_Management_System.My.Resources.Resources.Delete_25px
        Me.btnShowLogin.Location = New System.Drawing.Point(1147, 582)
        Me.btnShowLogin.Name = "btnShowLogin"
        Me.btnShowLogin.Size = New System.Drawing.Size(155, 46)
        Me.btnShowLogin.TabIndex = 32
        Me.btnShowLogin.Text = "Cancel"
        Me.btnShowLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShowLogin.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel6)
        Me.GroupBox1.Controls.Add(Me.dgvReservoirs)
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.btnShowRegistration)
        Me.GroupBox1.Controls.Add(Me.dgvDrivers)
        Me.GroupBox1.Controls.Add(Me.btnShowLogin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox5)
        Me.GroupBox1.Controls.Add(Me.dgvVehicles)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1345, 655)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel6.Location = New System.Drawing.Point(23, 438)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(2, 201)
        Me.Panel6.TabIndex = 34
        '
        'dgvReservoirs
        '
        Me.dgvReservoirs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvReservoirs.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvReservoirs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReservoirs.Location = New System.Drawing.Point(23, 439)
        Me.dgvReservoirs.MultiSelect = False
        Me.dgvReservoirs.Name = "dgvReservoirs"
        Me.dgvReservoirs.ReadOnly = True
        Me.dgvReservoirs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservoirs.Size = New System.Drawing.Size(906, 200)
        Me.dgvReservoirs.TabIndex = 33
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel5.Location = New System.Drawing.Point(582, 76)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(2, 151)
        Me.Panel5.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(23, 77)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 153)
        Me.Panel3.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 153)
        Me.Panel4.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.Location = New System.Drawing.Point(0, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 463)
        Me.Panel2.TabIndex = 10
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.lblUsername.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblUsername.Location = New System.Drawing.Point(296, 19)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(127, 37)
        Me.lblUsername.TabIndex = 34
        Me.lblUsername.Text = "username"
        Me.lblUsername.Visible = False
        '
        'frmAssignDriver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmAssignDriver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAssignDriver"
        CType(Me.dgvDrivers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVehicles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvReservoirs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDrivers As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvVehicles As DataGridView
  Friend WithEvents Label2 As Label
  Friend WithEvents txtAmount As TextBox
  Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
  Friend WithEvents Panel1 As Panel
  Friend WithEvents Label5 As Label
  Friend WithEvents PictureBox2 As PictureBox
  Friend WithEvents btnBack As Button
  Friend WithEvents PictureBox1 As PictureBox
  Friend WithEvents PictureBox3 As PictureBox
  Friend WithEvents PictureBox4 As PictureBox
  Friend WithEvents PictureBox5 As PictureBox
  Friend WithEvents btnShowRegistration As Button
  Friend WithEvents btnShowLogin As Button
  Friend WithEvents GroupBox1 As GroupBox
  Friend WithEvents Panel5 As Panel
  Friend WithEvents Panel3 As Panel
  Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents dgvReservoirs As System.Windows.Forms.DataGridView
    Friend WithEvents lblUsername As Label
End Class

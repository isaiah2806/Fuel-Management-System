<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateUser
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtFullName = New System.Windows.Forms.TextBox()
    Me.txtECNumber = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cboUserType = New System.Windows.Forms.ComboBox()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.btnShowLogin = New System.Windows.Forms.Button()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.btnRegisterUser = New System.Windows.Forms.Button()
    Me.PictureBox2 = New System.Windows.Forms.PictureBox()
    Me.btnBack = New System.Windows.Forms.Button()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.txtUsername = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtPassword = New System.Windows.Forms.TextBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.GroupBox1.SuspendLayout()
    CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(19, 41)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(81, 21)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Full Name"
    '
    'txtFullName
    '
    Me.txtFullName.Location = New System.Drawing.Point(113, 41)
    Me.txtFullName.Name = "txtFullName"
    Me.txtFullName.Size = New System.Drawing.Size(280, 29)
    Me.txtFullName.TabIndex = 1
    '
    'txtECNumber
    '
    Me.txtECNumber.Location = New System.Drawing.Point(113, 90)
    Me.txtECNumber.Name = "txtECNumber"
    Me.txtECNumber.Size = New System.Drawing.Size(280, 29)
    Me.txtECNumber.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(19, 93)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(90, 21)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "EC Number"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(19, 146)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(76, 21)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "User type"
    '
    'cboUserType
    '
    Me.cboUserType.FormattingEnabled = True
    Me.cboUserType.Items.AddRange(New Object() {"Administrator", "Driver"})
    Me.cboUserType.Location = New System.Drawing.Point(113, 143)
    Me.cboUserType.Name = "cboUserType"
    Me.cboUserType.Size = New System.Drawing.Size(280, 29)
    Me.cboUserType.TabIndex = 5
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.GroupBox2)
    Me.GroupBox1.Controls.Add(Me.btnShowLogin)
    Me.GroupBox1.Controls.Add(Me.Panel2)
    Me.GroupBox1.Controls.Add(Me.cboUserType)
    Me.GroupBox1.Controls.Add(Me.txtFullName)
    Me.GroupBox1.Controls.Add(Me.Label3)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Controls.Add(Me.txtECNumber)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Location = New System.Drawing.Point(20, 88)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(405, 437)
    Me.GroupBox1.TabIndex = 13
    Me.GroupBox1.TabStop = False
    '
    'btnShowLogin
    '
    Me.btnShowLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnShowLogin.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
    Me.btnShowLogin.ForeColor = System.Drawing.Color.Red
    Me.btnShowLogin.Image = Global.Fuel_Management_System.My.Resources.Resources.Delete_25px
    Me.btnShowLogin.Location = New System.Drawing.Point(211, 383)
    Me.btnShowLogin.Name = "btnShowLogin"
    Me.btnShowLogin.Size = New System.Drawing.Size(178, 38)
    Me.btnShowLogin.TabIndex = 18
    Me.btnShowLogin.Text = "Cancel"
    Me.btnShowLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnShowLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    Me.btnShowLogin.UseVisualStyleBackColor = True
    '
    'Panel2
    '
    Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
    Me.Panel2.Location = New System.Drawing.Point(0, 13)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(4, 422)
    Me.Panel2.TabIndex = 16
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
    Me.Panel1.Location = New System.Drawing.Point(-1, -2)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(4, 71)
    Me.Panel1.TabIndex = 15
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
    Me.Label4.ForeColor = System.Drawing.Color.DarkCyan
    Me.Label4.Location = New System.Drawing.Point(126, 9)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(148, 37)
    Me.Label4.TabIndex = 14
    Me.Label4.Text = "Create User"
    '
    'btnRegisterUser
    '
    Me.btnRegisterUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnRegisterUser.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
    Me.btnRegisterUser.ForeColor = System.Drawing.Color.DarkCyan
    Me.btnRegisterUser.Image = Global.Fuel_Management_System.My.Resources.Resources.Save_25px
    Me.btnRegisterUser.Location = New System.Drawing.Point(47, 405)
    Me.btnRegisterUser.Name = "btnRegisterUser"
    Me.btnRegisterUser.Size = New System.Drawing.Size(366, 46)
    Me.btnRegisterUser.TabIndex = 17
    Me.btnRegisterUser.Text = "Register User"
    Me.btnRegisterUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegisterUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    Me.btnRegisterUser.UseVisualStyleBackColor = True
    '
    'PictureBox2
    '
    Me.PictureBox2.Image = Global.Fuel_Management_System.My.Resources.Resources.Add_User_96px
    Me.PictureBox2.Location = New System.Drawing.Point(73, 3)
    Me.PictureBox2.Name = "PictureBox2"
    Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
    Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PictureBox2.TabIndex = 21
    Me.PictureBox2.TabStop = False
    '
    'btnBack
    '
    Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnBack.ForeColor = System.Drawing.SystemColors.Control
    Me.btnBack.Image = Global.Fuel_Management_System.My.Resources.Resources.Back_25px
    Me.btnBack.Location = New System.Drawing.Point(12, 7)
    Me.btnBack.Name = "btnBack"
    Me.btnBack.Size = New System.Drawing.Size(53, 46)
    Me.btnBack.TabIndex = 22
    Me.btnBack.UseVisualStyleBackColor = True
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.txtUsername)
    Me.GroupBox2.Controls.Add(Me.txtPassword)
    Me.GroupBox2.Controls.Add(Me.Label5)
    Me.GroupBox2.Controls.Add(Me.Label6)
    Me.GroupBox2.Location = New System.Drawing.Point(23, 178)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(366, 118)
    Me.GroupBox2.TabIndex = 19
    Me.GroupBox2.TabStop = False
    '
    'txtUsername
    '
    Me.txtUsername.Location = New System.Drawing.Point(102, 28)
    Me.txtUsername.Name = "txtUsername"
    Me.txtUsername.Size = New System.Drawing.Size(258, 29)
    Me.txtUsername.TabIndex = 21
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(8, 28)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(81, 21)
    Me.Label5.TabIndex = 20
    Me.Label5.Text = "Username"
    '
    'txtPassword
    '
    Me.txtPassword.Location = New System.Drawing.Point(102, 77)
    Me.txtPassword.Name = "txtPassword"
    Me.txtPassword.Size = New System.Drawing.Size(258, 29)
    Me.txtPassword.TabIndex = 23
    Me.txtPassword.UseSystemPasswordChar = True
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(8, 80)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(76, 21)
    Me.Label6.TabIndex = 22
    Me.Label6.Text = "Password"
    '
    'frmCreateUser
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(441, 538)
    Me.Controls.Add(Me.btnBack)
    Me.Controls.Add(Me.btnRegisterUser)
    Me.Controls.Add(Me.PictureBox2)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.GroupBox1)
    Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "frmCreateUser"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "frmCreateUser"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents txtFullName As TextBox
  Friend WithEvents txtECNumber As TextBox
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents cboUserType As ComboBox
  Friend WithEvents GroupBox1 As GroupBox
  Friend WithEvents Panel1 As Panel
  Friend WithEvents Label4 As Label
  Friend WithEvents Panel2 As Panel
  Friend WithEvents PictureBox2 As PictureBox
  Friend WithEvents btnShowLogin As Button
  Friend WithEvents btnRegisterUser As Button
  Friend WithEvents btnBack As Button
  Friend WithEvents GroupBox2 As GroupBox
  Friend WithEvents txtUsername As TextBox
  Friend WithEvents txtPassword As TextBox
  Friend WithEvents Label5 As Label
  Friend WithEvents Label6 As Label
End Class

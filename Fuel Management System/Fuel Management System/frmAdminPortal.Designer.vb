<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminPortal
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnRefuelReservoirs = New System.Windows.Forms.Button()
        Me.btnAssignDriver = New System.Windows.Forms.Button()
        Me.btnShowRegistration = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label1.Location = New System.Drawing.Point(74, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 329)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Powered by madevs"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(4, 62)
        Me.Panel1.TabIndex = 4
        '
        'btnLogout
        '
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogout.Image = Global.Fuel_Management_System.My.Resources.Resources.Exit_Sign_48px
        Me.btnLogout.Location = New System.Drawing.Point(615, 7)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(246, 53)
        Me.btnLogout.TabIndex = 20
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Fuel_Management_System.My.Resources.Resources.User_Shield_96px
        Me.PictureBox2.Location = New System.Drawing.Point(19, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'btnRefuelReservoirs
        '
        Me.btnRefuelReservoirs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefuelReservoirs.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.btnRefuelReservoirs.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnRefuelReservoirs.Image = Global.Fuel_Management_System.My.Resources.Resources.Gas_Station_100px
        Me.btnRefuelReservoirs.Location = New System.Drawing.Point(615, 134)
        Me.btnRefuelReservoirs.Name = "btnRefuelReservoirs"
        Me.btnRefuelReservoirs.Size = New System.Drawing.Size(246, 157)
        Me.btnRefuelReservoirs.TabIndex = 5
        Me.btnRefuelReservoirs.Text = "Refuel reservoirs"
        Me.btnRefuelReservoirs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRefuelReservoirs.UseVisualStyleBackColor = True
        '
        'btnAssignDriver
        '
        Me.btnAssignDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssignDriver.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.btnAssignDriver.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnAssignDriver.Image = Global.Fuel_Management_System.My.Resources.Resources.Driver_100px
        Me.btnAssignDriver.Location = New System.Drawing.Point(320, 134)
        Me.btnAssignDriver.Name = "btnAssignDriver"
        Me.btnAssignDriver.Size = New System.Drawing.Size(246, 157)
        Me.btnAssignDriver.TabIndex = 2
        Me.btnAssignDriver.Text = "Assign driver"
        Me.btnAssignDriver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAssignDriver.UseVisualStyleBackColor = True
        '
        'btnShowRegistration
        '
        Me.btnShowRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowRegistration.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.btnShowRegistration.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnShowRegistration.Image = Global.Fuel_Management_System.My.Resources.Resources.Registger_100px
        Me.btnShowRegistration.Location = New System.Drawing.Point(30, 134)
        Me.btnShowRegistration.Name = "btnShowRegistration"
        Me.btnShowRegistration.Size = New System.Drawing.Size(246, 157)
        Me.btnShowRegistration.TabIndex = 1
        Me.btnShowRegistration.Text = "Register"
        Me.btnShowRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnShowRegistration.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.lblUsername.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblUsername.Location = New System.Drawing.Point(193, 14)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(127, 37)
        Me.lblUsername.TabIndex = 21
        Me.lblUsername.Text = "username"
        '
        'frmAdminPortal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 361)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnRefuelReservoirs)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAssignDriver)
        Me.Controls.Add(Me.btnShowRegistration)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmAdminPortal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
  Friend WithEvents btnShowRegistration As Button
  Friend WithEvents btnAssignDriver As Button
  Friend WithEvents Label2 As Label
  Friend WithEvents Panel1 As Panel
  Friend WithEvents btnRefuelReservoirs As Button
  Friend WithEvents PictureBox2 As PictureBox
  Friend WithEvents btnLogout As Button
    Friend WithEvents lblUsername As Label
End Class

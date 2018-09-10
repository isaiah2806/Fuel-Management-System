<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreateReservoir
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnShowRegistration = New System.Windows.Forms.Button()
        Me.btnShowLogin = New System.Windows.Forms.Button()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.Label4.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label4.Location = New System.Drawing.Point(134, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 37)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Create Reservoir"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(24, 75)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(366, 29)
        Me.txtName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Capacity (l)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reservoir Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnShowRegistration)
        Me.GroupBox1.Controls.Add(Me.btnShowLogin)
        Me.GroupBox1.Controls.Add(Me.txtCapacity)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 364)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'btnShowRegistration
        '
        Me.btnShowRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowRegistration.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.btnShowRegistration.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnShowRegistration.Image = Global.Fuel_Management_System.My.Resources.Resources.Save_25px
        Me.btnShowRegistration.Location = New System.Drawing.Point(24, 239)
        Me.btnShowRegistration.Name = "btnShowRegistration"
        Me.btnShowRegistration.Size = New System.Drawing.Size(366, 46)
        Me.btnShowRegistration.TabIndex = 19
        Me.btnShowRegistration.Text = "Register Reservoir"
        Me.btnShowRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShowRegistration.UseVisualStyleBackColor = True
        '
        'btnShowLogin
        '
        Me.btnShowLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowLogin.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.btnShowLogin.ForeColor = System.Drawing.Color.Red
        Me.btnShowLogin.Image = Global.Fuel_Management_System.My.Resources.Resources.Delete_25px
        Me.btnShowLogin.Location = New System.Drawing.Point(212, 305)
        Me.btnShowLogin.Name = "btnShowLogin"
        Me.btnShowLogin.Size = New System.Drawing.Size(178, 38)
        Me.btnShowLogin.TabIndex = 20
        Me.btnShowLogin.Text = "Cancel"
        Me.btnShowLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShowLogin.UseVisualStyleBackColor = True
        '
        'txtCapacity
        '
        Me.txtCapacity.Location = New System.Drawing.Point(24, 177)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(366, 29)
        Me.txtCapacity.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 63)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.Location = New System.Drawing.Point(12, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 349)
        Me.Panel2.TabIndex = 19
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Fuel_Management_System.My.Resources.Resources.Tank_96px
        Me.PictureBox2.Location = New System.Drawing.Point(83, 12)
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
        Me.btnBack.Location = New System.Drawing.Point(12, 14)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(53, 46)
        Me.btnBack.TabIndex = 23
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmCreateReservoir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 473)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCreateReservoir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCreateTank"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnShowRegistration As Button
    Friend WithEvents btnShowLogin As Button
    Friend WithEvents btnBack As Button
End Class

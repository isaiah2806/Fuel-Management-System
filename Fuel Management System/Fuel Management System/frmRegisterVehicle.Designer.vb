<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegisterVehicle
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRegNumber = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtFuelCapacity = New System.Windows.Forms.TextBox()
        Me.btnShowLogin = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRegisterVehicle = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(4, 64)
        Me.Panel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label1.Location = New System.Drawing.Point(125, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Vehicle Registration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Reg Number"
        '
        'txtRegNumber
        '
        Me.txtRegNumber.Location = New System.Drawing.Point(150, 52)
        Me.txtRegNumber.Name = "txtRegNumber"
        Me.txtRegNumber.Size = New System.Drawing.Size(284, 27)
        Me.txtRegNumber.TabIndex = 11
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(150, 172)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(284, 27)
        Me.txtModel.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Model"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.txtFuelCapacity)
        Me.GroupBox1.Controls.Add(Me.btnShowLogin)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnRegisterVehicle)
        Me.GroupBox1.Controls.Add(Me.txtModel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtRegNumber)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 463)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.Location = New System.Drawing.Point(0, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 452)
        Me.Panel2.TabIndex = 10
        '
        'txtFuelCapacity
        '
        Me.txtFuelCapacity.Location = New System.Drawing.Point(150, 287)
        Me.txtFuelCapacity.Name = "txtFuelCapacity"
        Me.txtFuelCapacity.Size = New System.Drawing.Size(284, 27)
        Me.txtFuelCapacity.TabIndex = 21
        '
        'btnShowLogin
        '
        Me.btnShowLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowLogin.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.btnShowLogin.ForeColor = System.Drawing.Color.Red
        Me.btnShowLogin.Image = Global.Fuel_Management_System.My.Resources.Resources.Delete_25px
        Me.btnShowLogin.Location = New System.Drawing.Point(274, 409)
        Me.btnShowLogin.Name = "btnShowLogin"
        Me.btnShowLogin.Size = New System.Drawing.Size(160, 39)
        Me.btnShowLogin.TabIndex = 7
        Me.btnShowLogin.Text = "Cancel"
        Me.btnShowLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShowLogin.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Fuel Capacity"
        '
        'btnRegisterVehicle
        '
        Me.btnRegisterVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterVehicle.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.btnRegisterVehicle.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnRegisterVehicle.Image = Global.Fuel_Management_System.My.Resources.Resources.Save_25px
        Me.btnRegisterVehicle.Location = New System.Drawing.Point(28, 340)
        Me.btnRegisterVehicle.Name = "btnRegisterVehicle"
        Me.btnRegisterVehicle.Size = New System.Drawing.Size(406, 46)
        Me.btnRegisterVehicle.TabIndex = 6
        Me.btnRegisterVehicle.Text = "Register Vehicle"
        Me.btnRegisterVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegisterVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegisterVehicle.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBack.Image = Global.Fuel_Management_System.My.Resources.Resources.Back_25px
        Me.btnBack.Location = New System.Drawing.Point(13, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(53, 46)
        Me.btnBack.TabIndex = 21
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Fuel_Management_System.My.Resources.Resources.Bus_96px
        Me.PictureBox2.Location = New System.Drawing.Point(69, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'frmRegisterVehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 562)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmRegisterVehicle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegisterVehicle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRegisterVehicle As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnShowLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRegNumber As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFuelCapacity As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBack As Button
End Class

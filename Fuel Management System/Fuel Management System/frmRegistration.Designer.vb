<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistration
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
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnBack = New System.Windows.Forms.Button()
    Me.PictureBox2 = New System.Windows.Forms.PictureBox()
    Me.Button3 = New System.Windows.Forms.Button()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.Button1 = New System.Windows.Forms.Button()
    CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
    Me.Panel1.Location = New System.Drawing.Point(0, -1)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(4, 69)
    Me.Panel1.TabIndex = 6
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
    Me.Label1.ForeColor = System.Drawing.Color.DarkCyan
    Me.Label1.Location = New System.Drawing.Point(140, 18)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(108, 37)
    Me.Label1.TabIndex = 5
    Me.Label1.Text = "Register"
    '
    'btnBack
    '
    Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnBack.ForeColor = System.Drawing.SystemColors.Control
    Me.btnBack.Image = Global.Fuel_Management_System.My.Resources.Resources.Back_25px
    Me.btnBack.Location = New System.Drawing.Point(18, 14)
    Me.btnBack.Name = "btnBack"
    Me.btnBack.Size = New System.Drawing.Size(53, 46)
    Me.btnBack.TabIndex = 25
    Me.btnBack.UseVisualStyleBackColor = True
    '
    'PictureBox2
    '
    Me.PictureBox2.Image = Global.Fuel_Management_System.My.Resources.Resources.Registger_100px
    Me.PictureBox2.Location = New System.Drawing.Point(85, 12)
    Me.PictureBox2.Name = "PictureBox2"
    Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
    Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PictureBox2.TabIndex = 19
    Me.PictureBox2.TabStop = False
    '
    'Button3
    '
    Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Button3.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
    Me.Button3.ForeColor = System.Drawing.Color.DarkCyan
    Me.Button3.Image = Global.Fuel_Management_System.My.Resources.Resources.Drum_100px
    Me.Button3.Location = New System.Drawing.Point(623, 161)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(247, 157)
    Me.Button3.TabIndex = 4
    Me.Button3.Text = "Reservoirs"
    Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    Me.Button3.UseVisualStyleBackColor = True
    '
    'Button2
    '
    Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Button2.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
    Me.Button2.ForeColor = System.Drawing.Color.DarkCyan
    Me.Button2.Image = Global.Fuel_Management_System.My.Resources.Resources.People_100px
    Me.Button2.Location = New System.Drawing.Point(334, 161)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(247, 157)
    Me.Button2.TabIndex = 3
    Me.Button2.Text = "Users"
    Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    Me.Button2.UseVisualStyleBackColor = True
    '
    'Button1
    '
    Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Button1.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
    Me.Button1.ForeColor = System.Drawing.Color.DarkCyan
    Me.Button1.Image = Global.Fuel_Management_System.My.Resources.Resources.Vehicles_100px
    Me.Button1.Location = New System.Drawing.Point(34, 161)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(246, 157)
    Me.Button1.TabIndex = 2
    Me.Button1.Text = "Vehicles"
    Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    Me.Button1.UseVisualStyleBackColor = True
    '
    'frmRegistration
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(908, 373)
    Me.Controls.Add(Me.btnBack)
    Me.Controls.Add(Me.PictureBox2)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Button3)
    Me.Controls.Add(Me.Button2)
    Me.Controls.Add(Me.Button1)
    Me.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.Margin = New System.Windows.Forms.Padding(6)
    Me.Name = "frmRegistration"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "frmRegistration"
    CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
  Friend WithEvents PictureBox2 As PictureBox
  Friend WithEvents btnBack As Button
End Class

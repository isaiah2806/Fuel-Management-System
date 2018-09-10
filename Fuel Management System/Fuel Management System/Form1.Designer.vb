<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnShowRegistration = New System.Windows.Forms.Button()
        Me.btnShowLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 40.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label1.Location = New System.Drawing.Point(32, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 72)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome!"
        '
        'btnShowRegistration
        '
        Me.btnShowRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowRegistration.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.btnShowRegistration.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnShowRegistration.Location = New System.Drawing.Point(44, 189)
        Me.btnShowRegistration.Name = "btnShowRegistration"
        Me.btnShowRegistration.Size = New System.Drawing.Size(134, 72)
        Me.btnShowRegistration.TabIndex = 1
        Me.btnShowRegistration.Text = "Register"
        Me.btnShowRegistration.UseVisualStyleBackColor = True
        '
        'btnShowLogin
        '
        Me.btnShowLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowLogin.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.btnShowLogin.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnShowLogin.Location = New System.Drawing.Point(227, 189)
        Me.btnShowLogin.Name = "btnShowLogin"
        Me.btnShowLogin.Size = New System.Drawing.Size(134, 72)
        Me.btnShowLogin.TabIndex = 2
        Me.btnShowLogin.Text = "Login"
        Me.btnShowLogin.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 393)
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
        Me.Panel1.Size = New System.Drawing.Size(6, 100)
        Me.Panel1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 421)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnShowLogin)
        Me.Controls.Add(Me.btnShowRegistration)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnShowRegistration As Button
    Friend WithEvents btnShowLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehicleStatus
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
    Me.DataGridView2 = New System.Windows.Forms.DataGridView()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.btnShowRegistration = New System.Windows.Forms.Button()
    Me.Button1 = New System.Windows.Forms.Button()
    CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'DataGridView2
    '
    Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView2.Location = New System.Drawing.Point(43, 173)
    Me.DataGridView2.Name = "DataGridView2"
    Me.DataGridView2.Size = New System.Drawing.Size(509, 223)
    Me.DataGridView2.TabIndex = 16
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
    Me.Panel1.Location = New System.Drawing.Point(-1, -1)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(6, 100)
    Me.Panel1.TabIndex = 15
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 40.0!)
    Me.Label5.ForeColor = System.Drawing.Color.DarkCyan
    Me.Label5.Location = New System.Drawing.Point(31, 10)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(338, 72)
    Me.Label5.TabIndex = 14
    Me.Label5.Text = "Vehicle Status"
    '
    'btnShowRegistration
    '
    Me.btnShowRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnShowRegistration.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
    Me.btnShowRegistration.ForeColor = System.Drawing.Color.DarkCyan
    Me.btnShowRegistration.Location = New System.Drawing.Point(43, 104)
    Me.btnShowRegistration.Name = "btnShowRegistration"
    Me.btnShowRegistration.Size = New System.Drawing.Size(138, 41)
    Me.btnShowRegistration.TabIndex = 17
    Me.btnShowRegistration.Text = "Print"
    Me.btnShowRegistration.UseVisualStyleBackColor = True
    '
    'Button1
    '
    Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Button1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
    Me.Button1.ForeColor = System.Drawing.Color.DarkCyan
    Me.Button1.Location = New System.Drawing.Point(216, 104)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(138, 41)
    Me.Button1.TabIndex = 18
    Me.Button1.Text = "Export as csv"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'frmVehicleStatus
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(591, 422)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.btnShowRegistration)
    Me.Controls.Add(Me.DataGridView2)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.Label5)
    Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "frmVehicleStatus"
    Me.Text = "frmVehicleStatus"
    CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents DataGridView2 As DataGridView
  Friend WithEvents Panel1 As Panel
  Friend WithEvents Label5 As Label
  Friend WithEvents btnShowRegistration As Button
  Friend WithEvents Button1 As Button
End Class

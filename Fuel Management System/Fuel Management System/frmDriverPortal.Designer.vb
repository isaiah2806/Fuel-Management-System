<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDriverPortal
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
        Me.dgvDriver = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        CType(Me.dgvDriver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDriver
        '
        Me.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDriver.Location = New System.Drawing.Point(44, 127)
        Me.dgvDriver.Name = "dgvDriver"
        Me.dgvDriver.Size = New System.Drawing.Size(559, 366)
        Me.dgvDriver.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(6, 100)
        Me.Panel1.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 40.0!)
        Me.Label5.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label5.Location = New System.Drawing.Point(32, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(360, 72)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Driver Portal - "
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Segoe UI Light", 32.0!)
        Me.lblusername.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblusername.Location = New System.Drawing.Point(364, 20)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(202, 59)
        Me.lblusername.TabIndex = 22
        Me.lblusername.Text = "username"
        '
        'frmDriverPortal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 532)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.dgvDriver)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmDriverPortal"
        Me.Text = "frmDriverPortal"
        CType(Me.dgvDriver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDriver As DataGridView
  Friend WithEvents Panel1 As Panel
  Friend WithEvents Label5 As Label
    Friend WithEvents lblusername As Label
End Class

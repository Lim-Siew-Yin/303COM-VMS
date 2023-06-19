<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usersetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usersetting))
        Me.txtnpass = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtrpass = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtcpass = New System.Windows.Forms.TextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtnpass
        '
        Me.txtnpass.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnpass.Location = New System.Drawing.Point(261, 150)
        Me.txtnpass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnpass.Name = "txtnpass"
        Me.txtnpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnpass.Size = New System.Drawing.Size(411, 29)
        Me.txtnpass.TabIndex = 1
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(64, 153)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(136, 24)
        Me.Label28.TabIndex = 75
        Me.Label28.Text = "New Password"
        '
        'txtrpass
        '
        Me.txtrpass.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrpass.Location = New System.Drawing.Point(261, 190)
        Me.txtrpass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtrpass.Name = "txtrpass"
        Me.txtrpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtrpass.Size = New System.Drawing.Size(411, 29)
        Me.txtrpass.TabIndex = 2
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(64, 193)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(157, 24)
        Me.Label27.TabIndex = 73
        Me.Label27.Text = "Repeat Password"
        '
        'txtcpass
        '
        Me.txtcpass.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcpass.Location = New System.Drawing.Point(261, 111)
        Me.txtcpass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcpass.Name = "txtcpass"
        Me.txtcpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcpass.Size = New System.Drawing.Size(411, 29)
        Me.txtcpass.TabIndex = 0
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(479, 258)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(192, 38)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "Save Change"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(64, 68)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(167, 25)
        Me.Label17.TabIndex = 71
        Me.Label17.Text = "Reset Password"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(64, 113)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(159, 24)
        Me.Label18.TabIndex = 70
        Me.Label18.Text = "Current Password"
        '
        'usersetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(837, 449)
        Me.Controls.Add(Me.txtnpass)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtrpass)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtcpass)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "usersetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnpass As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtrpass As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtcpass As TextBox
    Friend WithEvents btnsave As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
End Class

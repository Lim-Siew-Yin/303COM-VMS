<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homesecurity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homesecurity))
        Me.lblconame = New System.Windows.Forms.Label()
        Me.btnpre = New System.Windows.Forms.Button()
        Me.btnout = New System.Windows.Forms.Button()
        Me.btnin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmergencyCallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btndashboard = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblconame
        '
        Me.lblconame.BackColor = System.Drawing.Color.Transparent
        Me.lblconame.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconame.Location = New System.Drawing.Point(-1, 70)
        Me.lblconame.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblconame.Name = "lblconame"
        Me.lblconame.Size = New System.Drawing.Size(1111, 86)
        Me.lblconame.TabIndex = 15
        Me.lblconame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnpre
        '
        Me.btnpre.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnpre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpre.ForeColor = System.Drawing.Color.White
        Me.btnpre.Location = New System.Drawing.Point(732, 299)
        Me.btnpre.Margin = New System.Windows.Forms.Padding(5)
        Me.btnpre.Name = "btnpre"
        Me.btnpre.Size = New System.Drawing.Size(264, 110)
        Me.btnpre.TabIndex = 2
        Me.btnpre.Text = "PRE-REGISTER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ARRIVAL"
        Me.btnpre.UseVisualStyleBackColor = False
        '
        'btnout
        '
        Me.btnout.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnout.ForeColor = System.Drawing.Color.White
        Me.btnout.Location = New System.Drawing.Point(433, 299)
        Me.btnout.Margin = New System.Windows.Forms.Padding(5)
        Me.btnout.Name = "btnout"
        Me.btnout.Size = New System.Drawing.Size(269, 110)
        Me.btnout.TabIndex = 1
        Me.btnout.Text = "CHECK OUT"
        Me.btnout.UseVisualStyleBackColor = False
        '
        'btnin
        '
        Me.btnin.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnin.ForeColor = System.Drawing.Color.White
        Me.btnin.Location = New System.Drawing.Point(140, 299)
        Me.btnin.Margin = New System.Windows.Forms.Padding(5)
        Me.btnin.Name = "btnin"
        Me.btnin.Size = New System.Drawing.Size(264, 110)
        Me.btnin.TabIndex = 0
        Me.btnin.Text = "CHECK IN"
        Me.btnin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(2, 156)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1108, 69)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "VISITOR MANAGEMENT SYSTEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1111, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.CheckConnectionToolStripMenuItem, Me.ResetPasswordToolStripMenuItem, Me.AboutToolStripMenuItem, Me.EmergencyCallToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'CheckConnectionToolStripMenuItem
        '
        Me.CheckConnectionToolStripMenuItem.Name = "CheckConnectionToolStripMenuItem"
        Me.CheckConnectionToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.CheckConnectionToolStripMenuItem.Text = "Check Connection"
        '
        'ResetPasswordToolStripMenuItem
        '
        Me.ResetPasswordToolStripMenuItem.Name = "ResetPasswordToolStripMenuItem"
        Me.ResetPasswordToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.ResetPasswordToolStripMenuItem.Text = "Reset Password"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'EmergencyCallToolStripMenuItem
        '
        Me.EmergencyCallToolStripMenuItem.Name = "EmergencyCallToolStripMenuItem"
        Me.EmergencyCallToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.EmergencyCallToolStripMenuItem.Text = "Emergency Call"
        '
        'btndashboard
        '
        Me.btndashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndashboard.ForeColor = System.Drawing.Color.White
        Me.btndashboard.Location = New System.Drawing.Point(281, 438)
        Me.btndashboard.Margin = New System.Windows.Forms.Padding(5)
        Me.btndashboard.Name = "btndashboard"
        Me.btndashboard.Size = New System.Drawing.Size(264, 110)
        Me.btndashboard.TabIndex = 16
        Me.btndashboard.Text = "DASHBOARD"
        Me.btndashboard.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(585, 438)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(269, 110)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "VISITOR DETAILS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'homesecurity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = Global.VMS.My.Resources.Resources.default_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1111, 632)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btndashboard)
        Me.Controls.Add(Me.lblconame)
        Me.Controls.Add(Me.btnpre)
        Me.Controls.Add(Me.btnout)
        Me.Controls.Add(Me.btnin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "homesecurity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visitor Management System - Security Guard Home Page"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblconame As Label
    Friend WithEvents btnpre As Button
    Friend WithEvents btnout As Button
    Friend WithEvents btnin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btndashboard As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents EmergencyCallToolStripMenuItem As ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnin = New System.Windows.Forms.Button()
        Me.btnout = New System.Windows.Forms.Button()
        Me.btnpre = New System.Windows.Forms.Button()
        Me.btndashboard = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OtherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmergencyCallListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblconame = New System.Windows.Forms.Label()
        Me.btndetails = New System.Windows.Forms.Button()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 152)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1111, 65)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "VISITOR MANAGEMENT SYSTEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnin
        '
        Me.btnin.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnin.ForeColor = System.Drawing.Color.White
        Me.btnin.Location = New System.Drawing.Point(161, 284)
        Me.btnin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnin.Name = "btnin"
        Me.btnin.Size = New System.Drawing.Size(241, 112)
        Me.btnin.TabIndex = 1
        Me.btnin.Text = "CHECK IN"
        Me.btnin.UseVisualStyleBackColor = False
        '
        'btnout
        '
        Me.btnout.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnout.ForeColor = System.Drawing.Color.White
        Me.btnout.Location = New System.Drawing.Point(433, 284)
        Me.btnout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnout.Name = "btnout"
        Me.btnout.Size = New System.Drawing.Size(241, 112)
        Me.btnout.TabIndex = 2
        Me.btnout.Text = "CHECK OUT"
        Me.btnout.UseVisualStyleBackColor = False
        '
        'btnpre
        '
        Me.btnpre.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnpre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpre.ForeColor = System.Drawing.Color.White
        Me.btnpre.Location = New System.Drawing.Point(705, 284)
        Me.btnpre.Margin = New System.Windows.Forms.Padding(4)
        Me.btnpre.Name = "btnpre"
        Me.btnpre.Size = New System.Drawing.Size(241, 112)
        Me.btnpre.TabIndex = 3
        Me.btnpre.Text = "PRE-REGISTER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ARRIVAL"
        Me.btnpre.UseVisualStyleBackColor = False
        '
        'btndashboard
        '
        Me.btndashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndashboard.ForeColor = System.Drawing.Color.White
        Me.btndashboard.Location = New System.Drawing.Point(433, 426)
        Me.btndashboard.Margin = New System.Windows.Forms.Padding(4)
        Me.btndashboard.Name = "btndashboard"
        Me.btndashboard.Size = New System.Drawing.Size(241, 112)
        Me.btndashboard.TabIndex = 5
        Me.btndashboard.Text = "DASHBOARD"
        Me.btndashboard.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OtherToolStripMenuItem, Me.HelpToolStripMenuItem, Me.LoginToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1111, 28)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OtherToolStripMenuItem
        '
        Me.OtherToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingToolStripMenuItem, Me.EmergencyCallListToolStripMenuItem})
        Me.OtherToolStripMenuItem.Name = "OtherToolStripMenuItem"
        Me.OtherToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.OtherToolStripMenuItem.Text = "File"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'EmergencyCallListToolStripMenuItem
        '
        Me.EmergencyCallListToolStripMenuItem.Name = "EmergencyCallListToolStripMenuItem"
        Me.EmergencyCallListToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.EmergencyCallListToolStripMenuItem.Text = "Emergency Call"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.CheckConnectionToolStripMenuItem, Me.AboutToolStripMenuItem})
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
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'lblconame
        '
        Me.lblconame.BackColor = System.Drawing.Color.Transparent
        Me.lblconame.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconame.Location = New System.Drawing.Point(0, 82)
        Me.lblconame.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblconame.Name = "lblconame"
        Me.lblconame.Size = New System.Drawing.Size(1111, 70)
        Me.lblconame.TabIndex = 7
        Me.lblconame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btndetails
        '
        Me.btndetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btndetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndetails.ForeColor = System.Drawing.Color.White
        Me.btndetails.Location = New System.Drawing.Point(161, 426)
        Me.btndetails.Name = "btndetails"
        Me.btndetails.Size = New System.Drawing.Size(241, 112)
        Me.btndetails.TabIndex = 4
        Me.btndetails.Text = "VISITOR DETAILS"
        Me.btndetails.UseVisualStyleBackColor = False
        '
        'btnreport
        '
        Me.btnreport.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.ForeColor = System.Drawing.Color.White
        Me.btnreport.Location = New System.Drawing.Point(705, 426)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(241, 112)
        Me.btnreport.TabIndex = 6
        Me.btnreport.Text = "REPORT"
        Me.btnreport.UseVisualStyleBackColor = False
        '
        'home
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = Global.VMS.My.Resources.Resources.default_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1111, 631)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.btndetails)
        Me.Controls.Add(Me.lblconame)
        Me.Controls.Add(Me.btndashboard)
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
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visitor Management System - Admin Home Page"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnin As Button
    Friend WithEvents btnout As Button
    Friend WithEvents btnpre As Button
    Friend WithEvents btndashboard As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OtherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblconame As Label
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btndetails As Button
    Friend WithEvents EmergencyCallListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnreport As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class homeuser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homeuser))
        Me.lblconame = New System.Windows.Forms.Label()
        Me.btnin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnsetting = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblconame
        '
        Me.lblconame.BackColor = System.Drawing.Color.Transparent
        Me.lblconame.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconame.Location = New System.Drawing.Point(0, 94)
        Me.lblconame.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblconame.Name = "lblconame"
        Me.lblconame.Size = New System.Drawing.Size(1171, 86)
        Me.lblconame.TabIndex = 15
        Me.lblconame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnin
        '
        Me.btnin.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnin.ForeColor = System.Drawing.Color.White
        Me.btnin.Location = New System.Drawing.Point(277, 352)
        Me.btnin.Margin = New System.Windows.Forms.Padding(5)
        Me.btnin.Name = "btnin"
        Me.btnin.Size = New System.Drawing.Size(264, 110)
        Me.btnin.TabIndex = 0
        Me.btnin.Text = "PRE-REGISTER"
        Me.btnin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 178)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1171, 69)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1171, 28)
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
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.CheckConnectionToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'CheckConnectionToolStripMenuItem
        '
        Me.CheckConnectionToolStripMenuItem.Name = "CheckConnectionToolStripMenuItem"
        Me.CheckConnectionToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CheckConnectionToolStripMenuItem.Text = "Check Connection"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'btnsetting
        '
        Me.btnsetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsetting.ForeColor = System.Drawing.Color.White
        Me.btnsetting.Location = New System.Drawing.Point(596, 352)
        Me.btnsetting.Margin = New System.Windows.Forms.Padding(5)
        Me.btnsetting.Name = "btnsetting"
        Me.btnsetting.Size = New System.Drawing.Size(269, 110)
        Me.btnsetting.TabIndex = 3
        Me.btnsetting.Text = "SETTING"
        Me.btnsetting.UseVisualStyleBackColor = False
        '
        'homeuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = Global.VMS.My.Resources.Resources.default_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1171, 564)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblconame)
        Me.Controls.Add(Me.btnin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsetting)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "homeuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visitor Management System - Tenant Home Page"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblconame As Label
    Friend WithEvents btnin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnsetting As Button
End Class

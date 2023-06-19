<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblviewvisitor = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblvisitor = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblviewactive = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblactive = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblviewout = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblcout = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dateDashboard = New System.Windows.Forms.DateTimePicker()
        Me.radioToday = New System.Windows.Forms.RadioButton()
        Me.radioDate = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(644, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(418, 69)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DASHBOARD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.ForeColor = System.Drawing.Color.White
        Me.btnhome.Location = New System.Drawing.Point(748, 718)
        Me.btnhome.Margin = New System.Windows.Forms.Padding(4)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(244, 44)
        Me.btnhome.TabIndex = 2
        Me.btnhome.Text = "Back To Home"
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblviewvisitor)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblvisitor)
        Me.Panel1.Location = New System.Drawing.Point(193, 347)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 246)
        Me.Panel1.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(5, 202)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(347, 2)
        Me.Label7.TabIndex = 0
        '
        'lblviewvisitor
        '
        Me.lblviewvisitor.AutoSize = True
        Me.lblviewvisitor.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblviewvisitor.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblviewvisitor.Location = New System.Drawing.Point(24, 210)
        Me.lblviewvisitor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblviewvisitor.Name = "lblviewvisitor"
        Me.lblviewvisitor.Size = New System.Drawing.Size(155, 25)
        Me.lblviewvisitor.TabIndex = 1
        Me.lblviewvisitor.Text = "see all visitors  →"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label5.Location = New System.Drawing.Point(29, 95)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 32)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "people visited today"
        '
        'lblvisitor
        '
        Me.lblvisitor.AutoSize = True
        Me.lblvisitor.BackColor = System.Drawing.Color.Transparent
        Me.lblvisitor.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvisitor.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblvisitor.Location = New System.Drawing.Point(20, 7)
        Me.lblvisitor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblvisitor.Name = "lblvisitor"
        Me.lblvisitor.Size = New System.Drawing.Size(77, 89)
        Me.lblvisitor.TabIndex = 0
        Me.lblvisitor.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lblviewactive)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.lblactive)
        Me.Panel2.Location = New System.Drawing.Point(675, 347)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 246)
        Me.Panel2.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(5, 202)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(347, 2)
        Me.Label3.TabIndex = 0
        '
        'lblviewactive
        '
        Me.lblviewactive.AutoSize = True
        Me.lblviewactive.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblviewactive.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblviewactive.Location = New System.Drawing.Point(24, 210)
        Me.lblviewactive.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblviewactive.Name = "lblviewactive"
        Me.lblviewactive.Size = New System.Drawing.Size(155, 25)
        Me.lblviewactive.TabIndex = 1
        Me.lblviewactive.Text = "see all visitors  →"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label9.Location = New System.Drawing.Point(29, 95)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 32)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "active visitor"
        '
        'lblactive
        '
        Me.lblactive.AutoSize = True
        Me.lblactive.BackColor = System.Drawing.Color.Transparent
        Me.lblactive.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblactive.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblactive.Location = New System.Drawing.Point(20, 7)
        Me.lblactive.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblactive.Name = "lblactive"
        Me.lblactive.Size = New System.Drawing.Size(77, 89)
        Me.lblactive.TabIndex = 0
        Me.lblactive.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Tomato
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.lblviewout)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.lblcout)
        Me.Panel3.Location = New System.Drawing.Point(1153, 347)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(360, 246)
        Me.Panel3.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(5, 202)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(347, 2)
        Me.Label4.TabIndex = 0
        '
        'lblviewout
        '
        Me.lblviewout.AutoSize = True
        Me.lblviewout.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblviewout.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblviewout.Location = New System.Drawing.Point(24, 210)
        Me.lblviewout.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblviewout.Name = "lblviewout"
        Me.lblviewout.Size = New System.Drawing.Size(155, 25)
        Me.lblviewout.TabIndex = 1
        Me.lblviewout.Text = "see all visitors  →"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label12.Location = New System.Drawing.Point(29, 95)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(217, 32)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "visitor checked out"
        '
        'lblcout
        '
        Me.lblcout.AutoSize = True
        Me.lblcout.BackColor = System.Drawing.Color.Transparent
        Me.lblcout.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcout.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblcout.Location = New System.Drawing.Point(20, 7)
        Me.lblcout.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcout.Name = "lblcout"
        Me.lblcout.Size = New System.Drawing.Size(77, 89)
        Me.lblcout.TabIndex = 0
        Me.lblcout.Text = "0"
        '
        'dateDashboard
        '
        Me.dateDashboard.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateDashboard.Location = New System.Drawing.Point(584, 252)
        Me.dateDashboard.Name = "dateDashboard"
        Me.dateDashboard.Size = New System.Drawing.Size(376, 38)
        Me.dateDashboard.TabIndex = 12
        '
        'radioToday
        '
        Me.radioToday.AutoSize = True
        Me.radioToday.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioToday.Location = New System.Drawing.Point(194, 252)
        Me.radioToday.Name = "radioToday"
        Me.radioToday.Size = New System.Drawing.Size(99, 36)
        Me.radioToday.TabIndex = 13
        Me.radioToday.TabStop = True
        Me.radioToday.Text = "Today"
        Me.radioToday.UseVisualStyleBackColor = True
        '
        'radioDate
        '
        Me.radioDate.AutoSize = True
        Me.radioDate.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioDate.Location = New System.Drawing.Point(368, 252)
        Me.radioDate.Name = "radioDate"
        Me.radioDate.Size = New System.Drawing.Size(157, 36)
        Me.radioDate.TabIndex = 14
        Me.radioDate.TabStop = True
        Me.radioDate.Text = "Select Date"
        Me.radioDate.UseVisualStyleBackColor = True
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1698, 895)
        Me.Controls.Add(Me.radioDate)
        Me.Controls.Add(Me.radioToday)
        Me.Controls.Add(Me.dateDashboard)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnhome As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblviewvisitor As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblvisitor As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblviewactive As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblactive As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblviewout As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblcout As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dateDashboard As DateTimePicker
    Friend WithEvents radioToday As RadioButton
    Friend WithEvents radioDate As RadioButton
End Class

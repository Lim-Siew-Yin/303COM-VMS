<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class forceout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forceout))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.btncout = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdb2 = New System.Windows.Forms.RadioButton()
        Me.rdb3 = New System.Windows.Forms.RadioButton()
        Me.rdb1 = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 283)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 134)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FORCE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CHECK OUT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt3
        '
        Me.txt3.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3.Location = New System.Drawing.Point(211, 284)
        Me.txt3.Margin = New System.Windows.Forms.Padding(4)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(327, 29)
        Me.txt3.TabIndex = 3
        '
        'btncout
        '
        Me.btncout.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btncout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncout.ForeColor = System.Drawing.Color.White
        Me.btncout.Location = New System.Drawing.Point(409, 365)
        Me.btncout.Margin = New System.Windows.Forms.Padding(4)
        Me.btncout.Name = "btncout"
        Me.btncout.Size = New System.Drawing.Size(192, 38)
        Me.btncout.TabIndex = 5
        Me.btncout.Text = "Force Check Out"
        Me.btncout.UseVisualStyleBackColor = False
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.White
        Me.btnback.Location = New System.Drawing.Point(144, 365)
        Me.btnback.Margin = New System.Windows.Forms.Padding(4)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(192, 38)
        Me.btnback.TabIndex = 4
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblname)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.rdb2)
        Me.Panel1.Controls.Add(Me.rdb3)
        Me.Panel1.Controls.Add(Me.rdb1)
        Me.Panel1.Controls.Add(Me.btnback)
        Me.Panel1.Controls.Add(Me.btncout)
        Me.Panel1.Controls.Add(Me.txt3)
        Me.Panel1.Location = New System.Drawing.Point(633, 123)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 515)
        Me.Panel1.TabIndex = 4
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(183, 114)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(0, 24)
        Me.lblname.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(183, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "because:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(183, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "You're now force check out following visitor:"
        '
        'rdb2
        '
        Me.rdb2.AutoSize = True
        Me.rdb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb2.Location = New System.Drawing.Point(187, 215)
        Me.rdb2.Margin = New System.Windows.Forms.Padding(4)
        Me.rdb2.Name = "rdb2"
        Me.rdb2.Size = New System.Drawing.Size(231, 28)
        Me.rdb2.TabIndex = 1
        Me.rdb2.TabStop = True
        Me.rdb2.Text = "Operating hour has end"
        Me.rdb2.UseVisualStyleBackColor = True
        '
        'rdb3
        '
        Me.rdb3.AutoSize = True
        Me.rdb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb3.Location = New System.Drawing.Point(187, 249)
        Me.rdb3.Margin = New System.Windows.Forms.Padding(4)
        Me.rdb3.Name = "rdb3"
        Me.rdb3.Size = New System.Drawing.Size(78, 28)
        Me.rdb3.TabIndex = 2
        Me.rdb3.TabStop = True
        Me.rdb3.Text = "Other"
        Me.rdb3.UseVisualStyleBackColor = True
        '
        'rdb1
        '
        Me.rdb1.AutoSize = True
        Me.rdb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb1.Location = New System.Drawing.Point(187, 180)
        Me.rdb1.Margin = New System.Windows.Forms.Padding(4)
        Me.rdb1.Name = "rdb1"
        Me.rdb1.Size = New System.Drawing.Size(241, 28)
        Me.rdb1.TabIndex = 0
        Me.rdb1.TabStop = True
        Me.rdb1.Text = "Visitor forget to check out"
        Me.rdb1.UseVisualStyleBackColor = True
        '
        'forceout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1545, 748)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "forceout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Force Check Out"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt3 As TextBox
    Friend WithEvents btncout As Button
    Friend WithEvents btnback As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdb2 As RadioButton
    Friend WithEvents rdb3 As RadioButton
    Friend WithEvents rdb1 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblname As Label
End Class

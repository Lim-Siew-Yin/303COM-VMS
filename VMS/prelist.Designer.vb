<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prelist
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(prelist))
        Me.btnback = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btncheckic = New System.Windows.Forms.Button()
        Me.btncheckp = New System.Windows.Forms.Button()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tblprelist = New System.Windows.Forms.DataGridView()
        Me.txtic = New System.Windows.Forms.MaskedTextBox()
        CType(Me.tblprelist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnback
        '
        Me.btnback.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnback.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.White
        Me.btnback.Location = New System.Drawing.Point(671, 876)
        Me.btnback.Margin = New System.Windows.Forms.Padding(4)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(183, 46)
        Me.btnback.TabIndex = 5
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(410, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(772, 69)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "PRE-REGISTER ARRIVAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(209, 199)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 25)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Search pre-register record"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(216, 242)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 24)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "NRIC"
        '
        'btncheckic
        '
        Me.btncheckic.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btncheckic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncheckic.ForeColor = System.Drawing.Color.White
        Me.btncheckic.Location = New System.Drawing.Point(547, 238)
        Me.btncheckic.Margin = New System.Windows.Forms.Padding(4)
        Me.btncheckic.Name = "btncheckic"
        Me.btncheckic.Size = New System.Drawing.Size(129, 31)
        Me.btncheckic.TabIndex = 2
        Me.btncheckic.Text = "Check NRIC"
        Me.btncheckic.UseVisualStyleBackColor = False
        '
        'btncheckp
        '
        Me.btncheckp.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btncheckp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncheckp.ForeColor = System.Drawing.Color.White
        Me.btncheckp.Location = New System.Drawing.Point(1157, 238)
        Me.btncheckp.Margin = New System.Windows.Forms.Padding(4)
        Me.btncheckp.Name = "btncheckp"
        Me.btncheckp.Size = New System.Drawing.Size(129, 31)
        Me.btncheckp.TabIndex = 4
        Me.btncheckp.Text = "Check Passport"
        Me.btncheckp.UseVisualStyleBackColor = False
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(936, 241)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(215, 29)
        Me.txtpass.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(827, 242)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 24)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Passport"
        '
        'tblprelist
        '
        Me.tblprelist.AllowUserToAddRows = False
        Me.tblprelist.AllowUserToDeleteRows = False
        Me.tblprelist.AllowUserToResizeRows = False
        Me.tblprelist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblprelist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblprelist.BackgroundColor = System.Drawing.SystemColors.Control
        Me.tblprelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblprelist.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.tblprelist.Location = New System.Drawing.Point(0, 324)
        Me.tblprelist.Margin = New System.Windows.Forms.Padding(4)
        Me.tblprelist.Name = "tblprelist"
        Me.tblprelist.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.tblprelist.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tblprelist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.tblprelist.Size = New System.Drawing.Size(1655, 479)
        Me.tblprelist.TabIndex = 17
        '
        'txtic
        '
        Me.txtic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtic.Location = New System.Drawing.Point(327, 239)
        Me.txtic.Margin = New System.Windows.Forms.Padding(4)
        Me.txtic.Mask = "000000-00-0000"
        Me.txtic.Name = "txtic"
        Me.txtic.Size = New System.Drawing.Size(215, 30)
        Me.txtic.TabIndex = 1
        Me.txtic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'prelist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1654, 981)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.txtic)
        Me.Controls.Add(Me.btncheckp)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btncheckic)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tblprelist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "prelist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pre-register Arrival List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tblprelist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnback As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btncheckic As Button
    Friend WithEvents btncheckp As Button
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tblprelist As DataGridView
    Friend WithEvents txtic As MaskedTextBox
End Class

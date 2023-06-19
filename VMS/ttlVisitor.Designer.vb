<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ttlVisitor
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ttlVisitor))
        Me.tblreport = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        CType(Me.tblreport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblreport
        '
        Me.tblreport.AllowUserToAddRows = False
        Me.tblreport.AllowUserToDeleteRows = False
        Me.tblreport.AllowUserToResizeRows = False
        Me.tblreport.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblreport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblreport.BackgroundColor = System.Drawing.SystemColors.Control
        Me.tblreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblreport.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.tblreport.Location = New System.Drawing.Point(0, 191)
        Me.tblreport.Margin = New System.Windows.Forms.Padding(4)
        Me.tblreport.Name = "tblreport"
        Me.tblreport.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.tblreport.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tblreport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.tblreport.Size = New System.Drawing.Size(1711, 506)
        Me.tblreport.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(627, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(494, 69)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "TOTAL VISITOR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnback
        '
        Me.btnback.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnback.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.White
        Me.btnback.Location = New System.Drawing.Point(619, 735)
        Me.btnback.Margin = New System.Windows.Forms.Padding(4)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(183, 46)
        Me.btnback.TabIndex = 0
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'btnhome
        '
        Me.btnhome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnhome.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.ForeColor = System.Drawing.Color.White
        Me.btnhome.Location = New System.Drawing.Point(903, 735)
        Me.btnhome.Margin = New System.Windows.Forms.Padding(4)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(183, 46)
        Me.btnhome.TabIndex = 1
        Me.btnhome.Text = "Back To Home"
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'ttlVisitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1712, 863)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.tblreport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ttlVisitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Total Visitor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tblreport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tblreport As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnback As Button
    Friend WithEvents btnhome As Button
End Class

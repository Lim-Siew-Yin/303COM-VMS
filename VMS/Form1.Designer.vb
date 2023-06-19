<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCode = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.txtCode = New System.Windows.Forms.RichTextBox()
        Me.txtDecode = New System.Windows.Forms.RichTextBox()
        Me.btnDecode = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picQR = New System.Windows.Forms.PictureBox()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.picQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCode
        '
        Me.btnCode.Location = New System.Drawing.Point(60, 382)
        Me.btnCode.Name = "btnCode"
        Me.btnCode.Size = New System.Drawing.Size(160, 38)
        Me.btnCode.TabIndex = 2
        Me.btnCode.Text = "Generate Code"
        Me.btnCode.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(328, 455)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(160, 38)
        Me.btnExport.TabIndex = 3
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(60, 64)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(269, 96)
        Me.txtCode.TabIndex = 4
        Me.txtCode.Text = ""
        '
        'txtDecode
        '
        Me.txtDecode.Location = New System.Drawing.Point(60, 241)
        Me.txtDecode.Name = "txtDecode"
        Me.txtDecode.Size = New System.Drawing.Size(269, 96)
        Me.txtDecode.TabIndex = 5
        Me.txtDecode.Text = ""
        '
        'btnDecode
        '
        Me.btnDecode.Location = New System.Drawing.Point(415, 382)
        Me.btnDecode.Name = "btnDecode"
        Me.btnDecode.Size = New System.Drawing.Size(160, 38)
        Me.btnDecode.TabIndex = 6
        Me.btnDecode.Text = "Decode "
        Me.btnDecode.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Encode Text"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Decode QR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(454, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "QR Code"
        '
        'picQR
        '
        Me.picQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picQR.Location = New System.Drawing.Point(397, 130)
        Me.picQR.Name = "picQR"
        Me.picQR.Size = New System.Drawing.Size(178, 150)
        Me.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picQR.TabIndex = 0
        Me.picQR.TabStop = False
        '
        'btnScan
        '
        Me.btnScan.Location = New System.Drawing.Point(237, 382)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(160, 38)
        Me.btnScan.TabIndex = 10
        Me.btnScan.Text = "Scan QR"
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(136, 455)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(160, 38)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 525)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDecode)
        Me.Controls.Add(Me.txtDecode)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnCode)
        Me.Controls.Add(Me.picQR)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picQR As PictureBox
    Friend WithEvents btnCode As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents txtCode As RichTextBox
    Friend WithEvents txtDecode As RichTextBox
    Friend WithEvents btnDecode As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnScan As Button
    Friend WithEvents btnClear As Button
End Class

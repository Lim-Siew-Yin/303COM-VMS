<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class capturephoto
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
        Me.piccapture = New System.Windows.Forms.PictureBox()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbcamera = New System.Windows.Forms.ComboBox()
        CType(Me.piccapture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'piccapture
        '
        Me.piccapture.BackColor = System.Drawing.SystemColors.Control
        Me.piccapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.piccapture.Location = New System.Drawing.Point(99, 102)
        Me.piccapture.Name = "piccapture"
        Me.piccapture.Size = New System.Drawing.Size(690, 340)
        Me.piccapture.TabIndex = 0
        Me.piccapture.TabStop = False
        '
        'btnCapture
        '
        Me.btnCapture.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCapture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapture.ForeColor = System.Drawing.Color.White
        Me.btnCapture.Location = New System.Drawing.Point(226, 475)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(203, 37)
        Me.btnCapture.TabIndex = 1
        Me.btnCapture.Text = "Capture"
        Me.btnCapture.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(448, 475)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(203, 37)
        Me.btnsave.TabIndex = 2
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(137, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(95, 63)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 24)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Current camera:"
        '
        'cmbcamera
        '
        Me.cmbcamera.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcamera.FormattingEnabled = True
        Me.cmbcamera.Location = New System.Drawing.Point(256, 61)
        Me.cmbcamera.Name = "cmbcamera"
        Me.cmbcamera.Size = New System.Drawing.Size(358, 30)
        Me.cmbcamera.TabIndex = 6
        '
        'capturephoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(893, 578)
        Me.Controls.Add(Me.cmbcamera)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.piccapture)
        Me.Name = "capturephoto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capture Photo"
        CType(Me.piccapture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents piccapture As PictureBox
    Friend WithEvents btnCapture As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnsave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbcamera As ComboBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class visitortype
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(visitortype))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.btnsub = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnnor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(613, 128)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 69)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "VISITOR TYPE"
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.ForeColor = System.Drawing.Color.White
        Me.btnhome.Location = New System.Drawing.Point(732, 664)
        Me.btnhome.Margin = New System.Windows.Forms.Padding(4)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(244, 45)
        Me.btnhome.TabIndex = 3
        Me.btnhome.Text = "Back To Home"
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'btnsub
        '
        Me.btnsub.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnsub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsub.ForeColor = System.Drawing.Color.White
        Me.btnsub.Image = Global.VMS.My.Resources.Resources.preregister
        Me.btnsub.Location = New System.Drawing.Point(1221, 304)
        Me.btnsub.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsub.Name = "btnsub"
        Me.btnsub.Padding = New System.Windows.Forms.Padding(0, 0, 0, 24)
        Me.btnsub.Size = New System.Drawing.Size(267, 248)
        Me.btnsub.TabIndex = 2
        Me.btnsub.Text = "Pre-Register"
        Me.btnsub.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsub.UseVisualStyleBackColor = False
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btndel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.Color.White
        Me.btndel.Image = CType(resources.GetObject("btndel.Image"), System.Drawing.Image)
        Me.btndel.Location = New System.Drawing.Point(720, 304)
        Me.btndel.Margin = New System.Windows.Forms.Padding(4)
        Me.btndel.Name = "btndel"
        Me.btndel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 24)
        Me.btndel.Size = New System.Drawing.Size(267, 248)
        Me.btndel.TabIndex = 1
        Me.btndel.Text = "Vendor / Delivery"
        Me.btndel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnnor
        '
        Me.btnnor.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnnor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnnor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnor.ForeColor = System.Drawing.Color.White
        Me.btnnor.Image = Global.VMS.My.Resources.Resources.user1
        Me.btnnor.Location = New System.Drawing.Point(219, 304)
        Me.btnnor.Margin = New System.Windows.Forms.Padding(4)
        Me.btnnor.Name = "btnnor"
        Me.btnnor.Padding = New System.Windows.Forms.Padding(0, 0, 0, 24)
        Me.btnnor.Size = New System.Drawing.Size(267, 248)
        Me.btnnor.TabIndex = 0
        Me.btnnor.Text = "Walkin Visitor"
        Me.btnnor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnor.UseVisualStyleBackColor = False
        '
        'visitortype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1645, 797)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.btnsub)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnnor)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "visitortype"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visitor Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnnor As Button
    Friend WithEvents btnsub As Button
    Friend WithEvents btnhome As Button
    Friend WithEvents btndel As Button
End Class

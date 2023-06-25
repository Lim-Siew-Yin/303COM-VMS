Public Class home

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblconame.Text = My.Settings.cname

        If logined = True Then
            'display logout if login detected
            LoginToolStripMenuItem.Text = "Logout"
        End If
    End Sub


    'main buttons
    Private Sub btnin_Click(sender As Object, e As EventArgs) Handles btnin.Click
        'check if windows is opened 
        If visitortype.Visible = False Then
            visitortype.Show()
        Else
            visitortype.Close()
        End If
    End Sub

    Private Sub btnout_Click(sender As Object, e As EventArgs) Handles btnout.Click
        If checkout.Visible = False Then
            checkout.Show()
        Else
            checkout.Close()
        End If
    End Sub

    Private Sub btnpre_Click(sender As Object, e As EventArgs) Handles btnpre.Click
        If prelist.Visible = False Then
            prelist.Show()
        Else
            prelist.Close()
        End If
    End Sub

    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        If dashboard.Visible = False Then
            dashboard.Show()
        Else
            dashboard.Close()
        End If
    End Sub

    Private Sub btndetails_Click(sender As Object, e As EventArgs) Handles btndetails.Click

        If visitordetail.Visible = False Then
            visitordetail.Show()
        Else
            visitordetail.Close()
        End If

    End Sub

    Private Sub btnreport_Click_1(sender As Object, e As EventArgs) Handles btnreport.Click
        If report.Visible = False Then
            report.Show()
        Else
            report.Close()
        End If
    End Sub

    'menu strip
    Private Sub LoginToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        If LoginToolStripMenuItem.Text = "Logout" Then
            MsgBox("Logout Successful")
            tenantname = ""
            logined = False
            login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub EmergencyCallListToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EmergencyCallListToolStripMenuItem.Click
        If emergencyCall.Visible = False Then
            emergencyCall.Show()
        Else
            emergencyCall.Close()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Me.Controls.Clear()
        InitializeComponent()
        home_Load(e, e)
    End Sub

    Private Sub CheckConnectionToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CheckConnectionToolStripMenuItem.Click
        If CheckDatabaseExists("vms1") Then

            If opendb() Then
                MsgBox("CONNECTION SUCCESSFUL")

            Else
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If
        Else
            CreateDatabase("vms1")
            MsgBox("Database Created Successfully!")

            If opendb() Then
                MsgBox("CONNECTION SUCCESSFUL")

            Else
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If
        End If

    End Sub

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        If setting.Visible = False Then
            setting.Show()
        Else
            setting.Close()
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        If AboutBox1.Visible = False Then
            AboutBox1.Show()
        Else
            AboutBox1.Close()
        End If
    End Sub

    Private Sub home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        logined = False
        closeForm(e)
    End Sub



End Class

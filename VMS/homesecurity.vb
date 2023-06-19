Imports MySql.Data.MySqlClient
Public Class homesecurity
    Dim reader As MySqlDataReader

    Private Sub homesecurity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblconame.Text = My.Settings.cname

        If logined = True Then
            LoginToolStripMenuItem.Text = "Logout"
        End If

    End Sub


    'main buttons
    Private Sub btnin_Click(sender As Object, e As EventArgs) Handles btnin.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If visitordetail.Visible = False Then
            visitordetail.Show()
        Else
            visitordetail.Close()
        End If

    End Sub

    'menustrips
    Private Sub LoginToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        If LoginToolStripMenuItem.Text = "Logout" Then
            MsgBox("Logout Successful")
            tenantname = ""
            logined = False
            login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Me.Controls.Clear()
        InitializeComponent()
        homesecurity_Load(e, e)
    End Sub

    Private Sub CheckConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckConnectionToolStripMenuItem.Click
        If CheckDatabaseExists("vms") Then

            If opendb() Then
                MsgBox("CONNECTION SUCCESSFUL")

            Else
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If
        Else
            CreateDatabase("vms")
            MsgBox("Database Created Successfully!")

            If opendb() Then
                MsgBox("CONNECTION SUCCESSFUL")

            Else
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If
        End If
    End Sub

    Private Sub ResetPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetPasswordToolStripMenuItem.Click
        If usersetting.Visible = False Then
            usersetting.Show()
        Else
            usersetting.Close()
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        If AboutBox1.Visible = False Then
            AboutBox1.Show()
        Else
            AboutBox1.Close()
        End If

    End Sub

    Private Sub EmergencyCallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmergencyCallToolStripMenuItem.Click
        If emergencyCall.Visible = False Then
            emergencyCall.Show()
        Else
            emergencyCall.Close()
        End If
    End Sub

    Private Sub homesecurity_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        logined = False
        closeForm(e)
    End Sub

End Class
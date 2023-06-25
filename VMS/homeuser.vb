Public Class homeuser

    Private Sub homeuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblconame.Text = My.Settings.cname

        If logined = True Then
            LoginToolStripMenuItem.Text = "Logout"
        End If
    End Sub


    'main buttons
    Private Sub btnin_Click(sender As Object, e As EventArgs) Handles btnin.Click
        If preregister.Visible = False Then
            preregister.Show()
        Else
            preregister.Close()
        End If
    End Sub

    Private Sub btnpre_Click(sender As Object, e As EventArgs)
        If prelist.Visible = False Then
            prelist.Show()
        Else
            prelist.Close()
        End If
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs)
        If report.Visible = False Then
            report.Show()
        Else
            report.Close()
        End If
    End Sub

    Private Sub btnsetting_Click(sender As Object, e As EventArgs) Handles btnsetting.Click
        If usersetting.Visible = False Then
            usersetting.Show()
        Else
            usersetting.Close()
        End If
    End Sub


    'menu strips
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
        homeuser_Load(e, e)
    End Sub

    Private Sub CheckConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckConnectionToolStripMenuItem.Click
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

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        If AboutBox1.Visible = False Then
            AboutBox1.Show()
        Else
            AboutBox1.Close()
        End If

    End Sub

    Private Sub homeuser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        logined = False
        closeForm(e)
    End Sub

End Class
Imports MySql.Data.MySqlClient

Public Class blacklist
    Dim reader As MySqlDataReader

    Private Sub blacklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt3.Enabled = False
        lblname.Text = visitordetail.txtname.Text
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        If reader IsNot Nothing Then
            reader.Close()
        End If

        conn.Close()
        visitordetail.Show()
        Me.Close()
    End Sub
    Private Sub rdb3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb3.CheckedChanged
        If rdb3.Checked = True Then
            txt3.Enabled = True
        Else
            txt3.Enabled = False
        End If
    End Sub


    Private Sub btncout_Click(sender As Object, e As EventArgs) Handles btnblist.Click


        If rdb1.Checked = True Or rdb2.Checked = True Or txt3.Text IsNot "" Then


            If rdb1.Checked = True Then
                blreason = rdb1.Text
            ElseIf rdb2.Checked = True Then
                blreason = rdb2.Text
            ElseIf rdb3.Checked = True Then
                blreason = txt3.Text
            End If



            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MsgBox("Please select a reason.")
        End If

    End Sub


End Class
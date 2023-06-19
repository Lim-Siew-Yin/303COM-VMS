Imports MySql.Data.MySqlClient
Public Class dashboard
    Dim reader As MySqlDataReader
    Public dashboarddatepick As Date
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radioToday.Checked = True
        radioDate.Checked = False
        dateDashboard.Enabled = False


        Try
            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If

            If radioToday.Checked = True Then

                'total visitor
                Dim query1 = "SELECT COUNT(`visitor_id`) AS 'tvisitor'
                  FROM `visitor` 
                  WHERE `checkin` >= CURDATE()
                  AND `checkin` < CURDATE() + INTERVAL 1 DAY "
                Dim command1 As New MySqlCommand(query1, conn)
                lblvisitor.Text = command1.ExecuteScalar().ToString()

                'active visitor
                Dim query2 = "SELECT COUNT(`visitor_id`) AS 'tactive'
                  FROM `visitor` 
                  WHERE `checkin` >= CURDATE()
                  AND `checkin` < CURDATE() + INTERVAL 1 DAY 
                  AND `status` = 0"
                Dim command2 As New MySqlCommand(query2, conn)
                lblactive.Text = command2.ExecuteScalar().ToString()

                'checked out visitor
                Dim query3 = "SELECT COUNT(`visitor_id`) AS 'tcheckout'
                  FROM `visitor` 
                  WHERE `checkin` >= CURDATE()
                  AND `checkin` < CURDATE() + INTERVAL 1 DAY 
                  AND `status` = 1"
                Dim command3 As New MySqlCommand(query3, conn)
                lblcout.Text = command3.ExecuteScalar().ToString()

            End If

            conn.Close()

        Catch ex As MySqlException
            MsgBox("GET COUNT ERROR: " & ex.Message)
        End Try


    End Sub


    Private Sub lblviewvisitor_Click(sender As Object, e As EventArgs) Handles lblviewvisitor.Click
        If ttlVisitor.Visible = False Then
            ttlVisitor.Show()
            Me.Hide()
        Else
            ttlVisitor.Close()
        End If
    End Sub

    Private Sub lblviewactive_Click(sender As Object, e As EventArgs) Handles lblviewactive.Click
        If ttlActive.Visible = False Then
            ttlActive.Show()
            Me.Hide()
        Else
            ttlActive.Close()
        End If
    End Sub

    Private Sub lblviewout_Click(sender As Object, e As EventArgs) Handles lblviewout.Click
        If ttlOut.Visible = False Then
            ttlOut.Show()
            Me.Hide()
        Else
            ttlOut.Close()
        End If
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        If reader IsNot Nothing Then
            reader.Close()
        End If

        conn.Close()
        Me.Close()
    End Sub

    Private Sub radioToday_CheckedChanged(sender As Object, e As EventArgs) Handles radioToday.CheckedChanged
        If radioToday.Checked = True Then
            radioDate.Checked = False
            dateDashboard.Enabled = False

            loadVisitor(Now.Date())

        End If
    End Sub

    Private Sub radioDate_CheckedChanged(sender As Object, e As EventArgs) Handles radioDate.CheckedChanged
        If radioDate.Checked = True Then
            dateDashboard.Enabled = True
            radioToday.Checked = False
        End If
    End Sub

    Private Sub dateDashboard_ValueChanged(sender As Object, e As EventArgs) Handles dateDashboard.ValueChanged

        dashboarddatepick = dateDashboard.Value.Date()

        loadVisitor(dashboarddatepick)

    End Sub


    Function loadVisitor(ByRef datepicked As Date) As String

        Try
            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If

            'MsgBox(datepicked)

            'total visitor
            Dim query1 = "SELECT COUNT(`visitor_id`) AS 'tvisitor'
                      FROM `visitor` 
                      WHERE `checkin` >= @datepicked
                      AND `checkin` < @datepicked + INTERVAL 1 DAY"
            Dim command1 As New MySqlCommand(query1, conn)
            command1.Parameters.Add("@datepicked", MySqlDbType.Date).Value = datepicked
            lblvisitor.Text = command1.ExecuteScalar().ToString()

            'active visitor
            Dim query2 = "SELECT COUNT(`visitor_id`) AS 'tactive'
                      FROM `visitor` 
                      WHERE `checkin` >= @datepicked
                      AND `checkin` < @datepicked + INTERVAL 1 DAY 
                      AND `status` = 0"
            Dim command2 As New MySqlCommand(query2, conn)
            command2.Parameters.Add("@datepicked", MySqlDbType.Date).Value = datepicked
            lblactive.Text = command2.ExecuteScalar().ToString()

            'checked out visitor
            Dim query3 = "SELECT COUNT(`visitor_id`) AS 'tcheckout'
                      FROM `visitor` 
                      WHERE `checkin` >= @datepicked
                      AND `checkin` < @datepicked + INTERVAL 1 DAY 
                      AND `status` = 1"
            Dim command3 As New MySqlCommand(query3, conn)
            command3.Parameters.Add("@datepicked", MySqlDbType.Date).Value = datepicked
            lblcout.Text = command3.ExecuteScalar().ToString()

            conn.Close()

        Catch ex As MySqlException
            MsgBox("GET COUNT ERROR: " & ex.Message)
        End Try
    End Function
End Class
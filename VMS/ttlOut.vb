Imports MySql.Data.MySqlClient
Public Class ttlOut

    Private Sub TtlOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If

            'get date
            Dim datepicker As Date

            If dashboard.radioToday.Checked = True And dashboard.radioDate.Checked = False Then
                datepicker = Now.Date()
            ElseIf dashboard.radioDate.Checked = True And dashboard.radioToday.Checked = False Then
                datepicker = dashboard.dashboarddatepick
            End If

            'check out visitor
            Dim table As New DataTable()
            Dim query = "SELECT `name` AS 'NAME', `ic` AS 'I/C', `passport` AS 'PASSPORT', `contact` AS 'CONTACT', `company` AS 'COMPANY', `vehicleno` AS 'VEHICLE NO', `unit-no` AS 'UNIT', `host-id` AS 'HOST', `checkin` AS 'CHECK IN', `checkout` AS 'CHECK OUT'
              FROM `visitor` 
              WHERE `checkin` >= @datepicked
              AND `checkin` < @datepicked + INTERVAL 1 DAY
              AND `status` = 1
              ORDER BY `name` "

            Dim command As New MySqlCommand(query, conn)
            command.Parameters.Add("@datepicked", MySqlDbType.Date).Value = datepicker
            Dim adapter As New MySqlDataAdapter(command)

            adapter.Fill(table)
            tblreport.DataSource = table

            conn.Close()

        Catch ex As MySqlException
            MsgBox("GET COUNT ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        conn.Close()
        Me.Close()
        dashboard.Close()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        conn.Close()
        dashboard.Show()
        Me.Close()
    End Sub
End Class
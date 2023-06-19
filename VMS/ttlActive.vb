Imports MySql.Data.MySqlClient
Public Class ttlActive

    Private Sub ttlActive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            'active visitor
            Dim table As New DataTable()
            Dim query = "SELECT `name` AS 'NAME', `ic` AS 'I/C', `passport` AS 'PASSPORT', `contact` AS 'CONTACT', `company` AS 'COMPANY', `vehicleno` AS 'VEHICLE NO', `unit-no` AS 'UNIT', `host-id` AS 'HOST', `checkin` AS 'CHECK IN'
              FROM `visitor` 
              WHERE `checkin` >= @datepicked
              AND `checkin` < @datepicked + INTERVAL 1 DAY
              AND `status` = 0
              ORDER BY `name` "

            Dim command As New MySqlCommand(query, conn)
            command.Parameters.Add("@datepicked", MySqlDbType.Date).Value = datepicker
            Dim adapter As New MySqlDataAdapter(command)

            adapter.Fill(table)
            tblreport.DataSource = table

            Dim btn As New DataGridViewButtonColumn()
            tblreport.Columns.Add(btn)
            btn.HeaderText = "Force Check Out"
            btn.Text = "Click Here"
            btn.Name = "btnforce"
            btn.UseColumnTextForButtonValue = True

            conn.Close()

        Catch ex As MySqlException
            MsgBox("GET COUNT ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        conn.Close()
        dashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        conn.Close()
        Me.Close()
        dashboard.Close()
    End Sub

    Private Sub tblreport_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tblreport.CellClick

        If e.ColumnIndex = 8 Then
            forcename = tblreport.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim rowic = tblreport.Rows(e.RowIndex).Cells(1).Value.ToString()
            Dim rowpass = tblreport.Rows(e.RowIndex).Cells(2).Value.ToString()
            Dim rowvehicle = tblreport.Rows(e.RowIndex).Cells(5).Value.ToString()

            If rowic.Trim() IsNot "" And rowpass.Trim() = "" And rowvehicle.Trim() = "" Then
                forceic = rowic
                forcepass = ""
                forcevehicle = ""
            ElseIf rowic.Trim() = "" And rowpass.Trim() IsNot "" And rowvehicle.Trim() = "" Then
                forcepass = rowpass
                forceic = ""
                forcevehicle = ""

            ElseIf rowic.Trim() = "" And rowpass.Trim() = "" And rowvehicle.Trim() IsNot "" Then
                forcevehicle = rowvehicle
                forceic = ""
                forcepass = ""

            End If

            forceout.Show()
            Me.Close()
        End If

    End Sub

End Class
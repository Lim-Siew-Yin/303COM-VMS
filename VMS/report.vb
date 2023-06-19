Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class report
    Dim reader As MySqlDataReader
    Dim unitno As String

    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        unitcmb(cmbunit)
        'cmbunit.SelectedIndex = -1
        cmbunit.Text = ""

        If role = "tenant" Then
            cmbunit.SelectedIndex = 1
            cmbunit.Text = tenantname
            unitno = tenantname
            lblunit.Text = unitno
            cmbunit.Enabled = False
        End If

        'initialise date
        txtdate1.Value = Date.Now
        txtdate1.Format = DateTimePickerFormat.Custom
        'txtdate1.CustomFormat = " "
        txtdate1.Checked = True

        txtdate2.Value = Date.Now
        txtdate2.Format = DateTimePickerFormat.Custom
        'txtdate2.CustomFormat = " "
        txtdate2.Checked = True

        'initialise checkbox list
        listfilter.Items.Add("Visitor Type", False)
        listfilter.Items.Add("Name", True)
        listfilter.Items.Add("I/C", True)
        listfilter.Items.Add("Passport", False)
        listfilter.Items.Add("Contact No.", True)
        listfilter.Items.Add("Email", False)
        listfilter.Items.Add("Unit", True)
        listfilter.Items.Add("Host", True)
        listfilter.Items.Add("Company", False)
        listfilter.Items.Add("Vehicle No.", True)
        listfilter.Items.Add("Badge No.", True)
        listfilter.Items.Add("Visit Purpose", True)
        listfilter.Items.Add("Check In", True)
        listfilter.Items.Add("Check Out", True)
        listfilter.Items.Add("Remark", False)
        listfilter.Items.Add("Force Check Out", False)
        listfilter.Items.Add("Force Check Out Reason", False)
        listfilter.Items.Add("Blacklist Request Date", False)
        listfilter.Items.Add("Blacklist Reason", False)
        listfilter.Items.Add("Blacklist Approval", False)
        listfilter.Items.Add("Blacklist Approved By", False)
        listfilter.Items.Add("Blacklist Approval Date", False)



    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        If reader IsNot Nothing Then
            reader.Close()
        End If

        conn.Close()
        Me.Close()
    End Sub

    'Private Sub txtdate1_Click(sender As Object, e As EventArgs) Handles txtdate1.Click
    '    txtdate1.Checked = True
    '    txtdate2.Checked = True
    'End Sub

    Private Sub txtdate1_ValueChanged(sender As Object, e As EventArgs) Handles txtdate1.ValueChanged
        'formatting datepicker1
        If txtdate1.Format = DateTimePickerFormat.Custom AndAlso txtdate1.CustomFormat = " " Then
            txtdate1.Format = DateTimePickerFormat.Short
        End If
    End Sub

    Private Sub txtdate2_ValueChanged(sender As Object, e As EventArgs) Handles txtdate2.ValueChanged
        'formatting datepicker2
        If txtdate2.Format = DateTimePickerFormat.Custom AndAlso txtdate2.CustomFormat = " " Then
            txtdate2.Format = DateTimePickerFormat.Short
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtdate1.Format = DateTimePickerFormat.Custom
        'txtdate1.CustomFormat = " "
        txtdate1.Value = Date.Now
        'txtdate1.Checked = False

        txtdate2.Format = DateTimePickerFormat.Custom
        'txtdate2.CustomFormat = " "
        txtdate2.Value = Date.Now
        'txtdate2.Checked = False

        txtic.Text = ""
        txtpass.Text = ""
        lblsearch.Text = ""
        cmbtype.SelectedIndex = -1
        tblreport.DataSource = Nothing

        If role IsNot "tenant" Then
            cmbunit.SelectedIndex = -1
            cmbunit.Text = ""
            lblunit.Text = ""
        End If
    End Sub

    Private Sub btnexport_Click(sender As Object, e As EventArgs) Handles btnexport.Click
        dgvtoexcel(tblreport)
    End Sub

    Dim vtype As String
    Dim force As Boolean = False
    Private Sub cmbtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtype.SelectedIndexChanged
        Select Case cmbtype.SelectedIndex
            Case 0
                vtype = "all"
            Case 1
                vtype = "walkin"
            Case 2
                vtype = "delivery"
            Case 3
                force = True
            Case 4
                vtype = "blacklist"
        End Select

    End Sub

    Private Sub cmbunit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbunit.SelectedIndexChanged
        'formatting unit no
        If cmbunit.SelectedIndex > 0 Then
            Dim unitori = cmbunit.Text
            unitno = unitori.Substring(0, unitori.IndexOf("|"))
            lblunit.Text = unitno

        Else
            lblunit.Text = "All"
        End If

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click

        If lblunit.Text = "" Then
            MsgBox("Please select a unit.")
            Exit Sub
        Else
            lblsearch.Text = txtdate1.Value.Date.ToString("dd-MM-yyyy") + " - " + txtdate2.Value.Date.ToString("dd-MM-yyyy")
            'format ic
            Dim fullic As String = txtic.Text
            fullic = fullic.Replace("-", "")    'remove -

            'get last 4 digit
            Dim ic, pass As String
            ic = Microsoft.VisualBasic.Right(fullic, 4)
            pass = Microsoft.VisualBasic.Right(txtpass.Text, 4)

            'encrypt ic (*will still encrypt empty field)
            Dim encryptIC As String = strEncrypt(fullic, ic)
            Dim encryptPassport As String = strEncrypt(txtpass.Text, pass)

            Dim visitorAttribute As String = "`visitor_id` AS 'ID', `visitortype` AS 'VISITOR TYPE', `name` AS 'NAME', `ic` AS 'I/C', `passport` AS 'PASSPORT', `contact` AS 'CONTACT NO.', `email` AS 'EMAIL', `unit` AS 'UNIT', `host` AS 'HOST', `company` AS 'COMPANY', `vehicleno` AS 'VEHICLE NO.', `badge` AS 'BADGE NO.', `purpose` AS 'VISIT PURPOSE', `checkin` AS 'CHECK IN', `checkout` AS 'CHECK OUT', `forcecheckout` AS 'FORCE CHECK OUT', `forcereason` AS 'FORCE CHECK OUT REASON', `remark` AS 'REMARK'"

            Dim blacklistAttribute As String = "`blacklist`.`requestDate` AS 'BLACKLIST REQUEST DATE', `blacklist`.`requestReason` AS 'BLACKLIST REASON', `blacklist`.`approved` AS 'BLACKLIST APPROVAL', `blacklist`.`approvedBy` AS ' BLACKLIST APPROVED BY', `blacklist`.`approvalDate` AS 'BLACKLIST APPROVAL DATE', `visitor`.`visitortype` AS 'VISITOR TYPE', `visitor`.`name` AS 'NAME', `visitor`.`ic` AS 'I/C', `visitor`.`passport` AS 'PASSPORT', `visitor`.`contact` AS 'CONTACT NO.', `visitor`.`email` AS 'EMAIL', `visitor`.`unit` AS 'UNIT', `visitor`.`host` AS 'HOST', `visitor`.`company` AS 'COMPANY', `visitor`.`vehicleno` AS 'VEHICLE NO.', `visitor`.`badge` AS 'BADGE NO.', `visitor`.`purpose` AS 'VISIT PURPOSE', `visitor`.`checkin` AS 'CHECK IN', `visitor`.`checkout` AS 'CHECK OUT', `visitor`.`forcecheckout` AS 'FORCE CHECK OUT', `visitor`.`forcereason` AS 'FORCE CHECK OUT REASON', `visitor`.`remark` AS 'REMARK'"

            Dim query As String
            If txtic.MaskCompleted = False And cmbtype.Text = "" And txtpass.Text = "" Then

                'MsgBox("Fields Empty")
                'Exit Sub
                'search by date
                If cmbunit.SelectedIndex = 0 Then
                    'all unit

                    query = "SELECT " + visitorAttribute + "
                         FROM `visitor` 
                         WHERE `checkin` >= @date1
                         AND `checkin` <= @date2 + INTERVAL 1 DAY
                         ORDER BY `name` "
                Else
                    'specific unit
                    query = "SELECT " + visitorAttribute + "
                         FROM `visitor` 
                         WHERE `checkin` >= @date1
                         AND `checkin` <= @date2 + INTERVAL 1 DAY
                         AND `unit-no` = @unit
                         ORDER BY `name` "
                End If

                lblsearch.Text = txtdate1.Value.Date.ToString("dd-MM-yyyy") + " - " + txtdate2.Value.Date.ToString("dd-MM-yyyy")

            ElseIf txtic.MaskCompleted = True Then
                'search by ic
                If cmbunit.SelectedIndex = 0 Then
                    'all unit
                    query = "SELECT " + visitorAttribute + "
                         FROM `visitor` 
                         WHERE `ic` = @ic
                         AND `checkin` >= @date1
                         AND `checkin` <= @date2 + INTERVAL 1 DAY
                         ORDER BY `checkin` DESC"
                Else
                    'specific unit
                    query = "SELECT " + visitorAttribute + "  
                         FROM `visitor` 
                         WHERE `ic` = @ic
                         AND `checkin` >= @date1
                         AND `checkin` <= @date2 + INTERVAL 1 DAY
                         AND `unit-no` = @unit
                         ORDER BY `checkin` DESC"
                End If

                lblsearch.Text = fullic

            ElseIf Not txtpass.Text = "" Then
                'search by passport
                If cmbunit.SelectedIndex = 0 Then
                    'all unit
                    query = "SELECT " + visitorAttribute + "
                         FROM `visitor` 
                         WHERE `passport` = @passport
                         AND `checkin` >= @date1
                         AND `checkin` <= @date2 + INTERVAL 1 DAY
                         ORDER BY `checkin` DESC"
                Else
                    'if select specific unit
                    query = "SELECT " + visitorAttribute + "
                         FROM `visitor` 
                         WHERE `passport` = @passport
                         AND `checkin` >= @date1
                         AND `checkin` <= @date2 + INTERVAL 1 DAY
                         AND `unit-no` = @unit
                         ORDER BY `checkin` DESC"
                End If

                lblsearch.Text = txtpass.Text

                'ElseIf Not txtdate1.Checked = False And Not txtdate2.Checked = False Then
                '    

            ElseIf Not cmbtype.Text = "" Then
                'search by visitor type
                If force = False Then
                    'if not force checkout

                    If vtype = "all" Then
                        'all type
                        If cmbunit.SelectedIndex = 0 Then
                            'all unit
                            query = "SELECT " + visitorAttribute + "
                                FROM `visitor` 
                                WHERE `forcecheckout` = 0
                                AND `checkin` >= @date1
                                AND `checkin` <= @date2 + INTERVAL 1 DAY
                                ORDER BY `checkin` DESC"
                        Else
                            'specific unit
                            query = "SELECT " + visitorAttribute + "
                                FROM `visitor` 
                                WHERE `forcecheckout` = 0
                                AND `unit-no` = @unit
                                AND `checkin` >= @date1
                                AND `checkin` <= @date2 + INTERVAL 1 DAY
                                ORDER BY `checkin` DESC"
                        End If

                    ElseIf vtype = "delivery" Then
                        'delivery
                        If cmbunit.SelectedIndex = 0 Then
                            'all unit
                            query = "SELECT " + visitorAttribute + "
                                FROM `visitor` 
                                WHERE `visitortype` = @type 
                                AND `forcecheckout` = 0
                                AND `checkin` >= @date1
                                AND `checkin` <= @date2 + INTERVAL 1 DAY
                                ORDER BY `checkin` DESC"
                        Else
                            'specific unit
                            query = "SELECT " + visitorAttribute + "
                                FROM `visitor` 
                                WHERE `visitortype` = @type 
                                AND `forcecheckout` = 0
                                AND `unit-no` = @unit
                                AND `checkin` >= @date1
                                AND `checkin` <= @date2 + INTERVAL 1 DAY
                                ORDER BY `checkin` DESC"
                        End If

                    ElseIf vtype = "blacklist" Then
                        'blacklist
                        If cmbunit.SelectedIndex = 0 Then
                            'all unit
                            query = "SELECT " + blacklistAttribute + "
                                FROM `blacklist` INNER JOIN `visitor` 
                                ON `blacklist`.`visitor-id` = `visitor`.`visitor_id` 
                                AND `requestDate` >= @date1
                                AND `requestDate` <= @date2 + INTERVAL 1 DAY
                                ORDER BY `checkin` DESC"

                        Else
                            'specific unit
                            query = "SELECT " + blacklistAttribute + "
                                FROM `blacklist` INNER JOIN `visitor` 
                                ON `blacklist`.`visitor-id` = `visitor`.`visitor_id`
                                WHERE `visitor`.`unit-no` = @unit
                                AND `requestDate` >= @date1
                                AND `requestDate` <= @date2 + INTERVAL 1 DAY
                                ORDER BY `checkin` DESC"
                        End If

                    Else
                        'other(incl normal visitor)
                        If cmbunit.SelectedIndex = 0 Then
                            'all unit
                            query = "SELECT " + visitorAttribute + "
                                FROM `visitor` 
                                WHERE `visitortype` = @type 
                                AND `forcecheckout` = 0
                                AND `checkin` >= @date1
                                AND `checkin` <= @date2 + INTERVAL 1 DAY
                                ORDER BY `checkin` DESC"
                        Else
                            'specific unit
                            query = "SELECT " + visitorAttribute + "
                                FROM `visitor` 
                                WHERE `visitortype` = @type 
                                AND `forcecheckout` = 0
                                AND `unit-no` = @unit
                                AND `checkin` >= @date1
                                AND `checkin` <= @date2 + INTERVAL 1 DAY
                                ORDER BY `checkin` DESC"
                        End If

                    End If
                Else
                    'force check out
                    If cmbunit.SelectedIndex = 0 Then
                        query = "SELECT " + visitorAttribute + "
                             FROM `visitor` 
                             WHERE `forcecheckout` = 1
                             AND `checkin` >= @date1
                             AND `checkin` <= @date2 + INTERVAL 1 DAY
                             ORDER BY `name` "
                    Else
                        query = "SELECT " + visitorAttribute + "
                             FROM `visitor` 
                             WHERE `forcecheckout` = 1
                             AND `unit-no` = @unit
                             AND `checkin` >= @date1
                             AND `checkin` <= @date2 + INTERVAL 1 DAY
                             ORDER BY `name` "
                    End If

                End If
                lblsearch.Text = cmbtype.SelectedItem

            End If

            Try
                If Not opendb() Then
                    MsgBox("FAILED TO CONNECT TO DATABASE")
                End If

                Dim command As New MySqlCommand(query, conn)
                command.Parameters.Add("@date1", MySqlDbType.Date).Value = txtdate1.Value
                command.Parameters.Add("@date2", MySqlDbType.Date).Value = txtdate2.Value
                command.Parameters.Add("@ic", MySqlDbType.VarChar).Value = encryptIC
                command.Parameters.Add("@passport", MySqlDbType.VarChar).Value = encryptPassport
                command.Parameters.Add("@type", MySqlDbType.VarChar).Value = vtype
                command.Parameters.Add("@force", MySqlDbType.VarChar).Value = force
                command.Parameters.Add("@unit", MySqlDbType.VarChar).Value = lblunit.Text

                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()

                reader = command.ExecuteReader
                If reader.HasRows Then
                    'display on table if has record
                    reader.Close()
                    adapter.Fill(table)
                    tblreport.DataSource = table


                    'filter column display
                    filterTable()

                Else
                    MsgBox("No Datafound")
                    tblreport.DataSource = Nothing
                    reader.Close()
                    Exit Sub
                End If

                'tblreport.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
                reader.Close()
                conn.Close()

            Catch ex As Exception
                MsgBox("RETRIEVE RECORD ERROR: " & ex.Message)
            End Try

        End If
    End Sub

    Function filterTable()

        Try

            'loop list to get checked item value
            'display column that header value = checked item value

            For Each column As DataGridViewColumn In tblreport.Columns
                For Each item In listfilter.CheckedItems

                    If column.HeaderText.ToUpper = item.ToUpper Then

                        tblreport.Columns(column.HeaderText).Visible = True
                        Exit For
                        'break loop after display column
                    Else

                        tblreport.Columns(column.HeaderText).Visible = False

                    End If
                Next
            Next


        Catch ex As Exception
            MsgBox("TABLE FILTERING ERROR: " & ex.Message)
        End Try

    End Function

End Class
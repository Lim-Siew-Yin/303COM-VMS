Imports MySql.Data.MySqlClient
Imports System.IO

Public Class visitordetail

    Dim reader As MySqlDataReader
    Dim encryptIC As String
    Dim visitorid As String
    Dim str4 As String

    Private Sub visitordetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If role = "security" Then
            btnblacklist.Text = "Request Blacklist"

            btnwhitelist.Text = "Request Whitelist"
        End If
    End Sub

    Private Sub btncheck_Click(sender As Object, e As EventArgs) Handles btncheck.Click
        getIC()

        If txtic.MaskCompleted = False Then
            MsgBox("Please fill in your I/C.")
            Exit Sub
        Else
            Try
                If Not opendb() Then
                    MsgBox("FAILED TO CONNECT TO DATABASE")
                End If


                'search visitor record
                Dim query1 = "SELECT * FROM `visitor` WHERE `ic` = @ic"
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@ic", MySqlDbType.VarChar).Value = encryptIC
                reader = command1.ExecuteReader()
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While

                'if there is record
                If count > 0 Then
                    txtname.Text = reader(2)
                    txtcontact.Text = reader(5)
                    txtemail.Text = reader(6)
                    txtcompany.Text = reader(9)
                    txtvehicletype.Text = reader(11)
                    txtvehicle.Text = reader(10)
                    txtVisitorQty.Text = reader(12)
                    txtunit.Text = reader(7)
                    txthost.Text = reader(8)
                    txtpurpose.Text = reader(14)
                    txtbadge.Text = reader(13)
                    txtremark.Text = reader(20)
                    reader.Close()

                    Try
                        'check if visitor is blacklisted
                        str4 = Microsoft.VisualBasic.Right(txtic.Text, 4)
                        'checkblacklist(str4)
                        Dim query3 = "SELECT * FROM `blacklist` WHERE LEFT(`visitor-id`, 4) = @blic"
                        Dim command3 As New MySqlCommand(query3, conn)
                        command3.Parameters.Add("@blic", MySqlDbType.VarChar).Value = str4
                        reader = command3.ExecuteReader()
                        Dim count3 As Integer
                        count3 = 0
                        While reader.Read
                            count3 = count3 + 1
                        End While

                        'if has record
                        If count3 > 0 Then
                            'if not null
                            If reader(4) IsNot DBNull.Value Then
                                'true = blacklist approved
                                If reader(4) = True Then
                                    MsgBox("The visitor has been blacklisted")
                                    lblblacklist.Text = "BLACKLISTED"
                                    If role = "admin" Then
                                        btnblacklist.Visible = False
                                        btnwhitelist.Visible = True
                                    Else
                                        btnblacklist.Enabled = False
                                    End If

                                Else
                                    'false = blacklist rejected
                                    MsgBox("The visitor's blacklist request is rejected")
                                    lblblacklist.Text = "BLACKLIST REJECTED"
                                    If role = "admin" Then
                                        btnblacklist.Visible = True
                                        btnwhitelist.Visible = False
                                    Else
                                        btnblacklist.Enabled = True
                                        btnblacklist.Text = "Request Blacklist"
                                    End If

                                End If

                                reader.Close()

                            Else
                                'null = request blacklist
                                MsgBox("An security has requested to blacklist this visitor with reason: " + reader(3).ToString())
                                lblblacklist.Text = "BLACKLIST REQUESTED"

                                If role = "admin" Then
                                    btnblacklist.Text = "Approve Blacklist"
                                    btnblacklist.Visible = True
                                    btnwhitelist.Visible = False
                                Else
                                    btnblacklist.Enabled = False

                                End If


                                reader.Close()
                            End If

                        Else
                            'if no record
                            reader.Close()
                            lblblacklist.Text = ""
                            btnblacklist.Text = "Blacklist"
                            btnblacklist.Visible = True
                            btnwhitelist.Visible = False
                        End If
                        reader.Close()
                    Catch ex As Exception
                        MsgBox("CHECK BLACKLIST RECORD ERROR: " & ex.Message)
                    End Try

                    'display visit history in table
                    Try
                        Dim table As New DataTable()
                        Dim query2 = "SELECT  `visitor_id`, `checkin` AS 'CHECK IN', `checkout` AS 'CHECK OUT' , `photo` AS 'PHOTO'
                                  FROM `visitor` 
                                  WHERE `ic` = @ic
                                  ORDER BY `checkin`"

                        Dim command2 As New MySqlCommand(query2, conn)
                        command2.Parameters.Add("@ic", MySqlDbType.VarChar).Value = encryptIC
                        Dim adapter As New MySqlDataAdapter(command2)

                        adapter.Fill(table)
                        tblhistory.DataSource = table
                        'hide visitor id
                        tblhistory.Columns(0).Visible = False

                    Catch ex As Exception
                        MsgBox("SEARCH VISIT HISTORY RECORD ERROR: " & ex.Message)
                    End Try


                Else
                    'if no record
                    MsgBox("No Record Found")
                    reader.Close()
                    txtname.Text = ""
                    txtcontact.Text = ""
                    txtemail.Text = ""
                    txtcompany.Text = ""
                    txtvehicletype.Text = ""
                    txtvehicle.Text = ""
                    txtVisitorQty.Text = ""
                    txtunit.Text = ""
                    txthost.Text = ""
                    txtpurpose.Text = ""
                    txtbadge.Text = ""
                    txtremark.Text = ""
                    Exit Sub
                End If

                reader.Close()
                conn.Close()
            Catch ex As MySqlException
                MsgBox("SEARCH IC RECORD ERROR: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub btncheckp_Click(sender As Object, e As EventArgs) Handles btncheckp.Click

        'get last 4 digit
        Dim pass As String = Microsoft.VisualBasic.Right(txtpassport.Text, 4)

        'encrypt passport
        Dim encryptPassport As String = strEncrypt(txtpassport.Text, pass)

        If txtpassport.Text.Trim = "" Then
            MsgBox("Please fill in your passport.")
            Exit Sub
        Else
            Try
                If Not opendb() Then
                    MsgBox("FAILED TO CONNECT TO DATABASE")
                End If


                'search visitor record
                Dim query1 = "SELECT * FROM `visitor` WHERE `passport` = @pass"
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@pass", MySqlDbType.VarChar).Value = encryptPassport
                reader = command1.ExecuteReader()
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While

                'if there is record
                If count > 0 Then
                    txtname.Text = reader(2)
                    txtcontact.Text = reader(5)
                    txtemail.Text = reader(6)
                    txtcompany.Text = reader(9)
                    txtvehicletype.Text = reader(11)
                    txtvehicle.Text = reader(10)
                    txtVisitorQty.Text = reader(12)
                    txtunit.Text = reader(7)
                    txthost.Text = reader(8)
                    txtpurpose.Text = reader(14)
                    txtbadge.Text = reader(13)
                    txtremark.Text = reader(20)
                    reader.Close()

                    Try
                        'check if visitor is blacklisted
                        str4 = Microsoft.VisualBasic.Right(txtpassport.Text, 4)
                        'checkblacklist(str4)
                        Dim query3 = "SELECT * FROM `blacklist` WHERE LEFT(`visitor-id`, 4) = @blic"
                        Dim command3 As New MySqlCommand(query3, conn)
                        command3.Parameters.Add("@blic", MySqlDbType.VarChar).Value = str4
                        reader = command3.ExecuteReader()
                        Dim count3 As Integer
                        count3 = 0
                        While reader.Read
                            count3 = count3 + 1
                        End While

                        'if has record
                        If count3 > 0 Then
                            'if not null
                            If reader(4) IsNot DBNull.Value Then
                                'true = blacklist approved
                                If reader(4) = True Then
                                    MsgBox("The visitor has been blacklisted")
                                    lblblacklist.Text = "BLACKLISTED"
                                    If role = "admin" Then
                                        btnblacklist.Visible = False
                                        btnwhitelist.Visible = True
                                    Else
                                        btnblacklist.Enabled = False
                                    End If

                                Else
                                    'false = blacklist rejected
                                    MsgBox("The visitor's blacklist request is rejected")
                                    lblblacklist.Text = "BLACKLIST REJECTED"
                                    If role = "admin" Then
                                        btnblacklist.Visible = True
                                        btnwhitelist.Visible = False
                                    Else
                                        btnblacklist.Enabled = True
                                        btnblacklist.Text = "Request Blacklist"
                                    End If

                                End If

                                reader.Close()

                            Else
                                'null = request blacklist
                                MsgBox("An security has requested to blacklist this visitor with reason: " + reader(3).ToString())
                                lblblacklist.Text = "BLACKLIST REQUESTED"

                                If role = "admin" Then
                                    btnblacklist.Text = "Approve Blacklist"
                                    btnblacklist.Visible = True
                                    btnwhitelist.Visible = False
                                Else
                                    btnblacklist.Enabled = False

                                End If


                                reader.Close()
                            End If

                        Else
                            'if no record
                            reader.Close()
                            lblblacklist.Text = ""
                            btnblacklist.Text = "Blacklist"
                            btnblacklist.Visible = True
                            btnwhitelist.Visible = False
                        End If
                        reader.Close()
                    Catch ex As Exception
                        MsgBox("CHECK BLACKLIST RECORD ERROR: " & ex.Message)
                    End Try

                    'display visit history in table
                    Try
                        Dim table As New DataTable()
                        Dim query2 = "SELECT  `visitor_id`, `checkin` AS 'CHECK IN', `checkout` AS 'CHECK OUT' , `photo` AS 'PHOTO'
                                  FROM `visitor` 
                                  WHERE `passport` = @pass
                                  ORDER BY `checkin`"

                        Dim command2 As New MySqlCommand(query2, conn)
                        command2.Parameters.Add("@pass", MySqlDbType.VarChar).Value = encryptPassport
                        Dim adapter As New MySqlDataAdapter(command2)

                        adapter.Fill(table)
                        tblhistory.DataSource = table
                        'hide visitor id
                        tblhistory.Columns(0).Visible = False

                    Catch ex As Exception
                        MsgBox("SEARCH VISIT HISTORY RECORD ERROR: " & ex.Message)
                    End Try


                Else
                    'if no record
                    MsgBox("No Record Found")
                    reader.Close()
                    txtname.Text = ""
                    txtcontact.Text = ""
                    txtemail.Text = ""
                    txtcompany.Text = ""
                    txtvehicletype.Text = ""
                    txtvehicle.Text = ""
                    txtVisitorQty.Text = ""
                    txtunit.Text = ""
                    txthost.Text = ""
                    txtpurpose.Text = ""
                    txtbadge.Text = ""
                    txtremark.Text = ""
                    Exit Sub
                End If

                reader.Close()
                conn.Close()
            Catch ex As MySqlException
                MsgBox("SEARCH PASSPORT RECORD ERROR: " & ex.Message)
            End Try
        End If
    End Sub


    Private Sub tblhistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblhistory.CellClick

        getIC()

        'get checkin value
        Dim rowcheckin = tblhistory.Rows(e.RowIndex).Cells(1).Value

        Try
            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If

            Dim query1 = "SELECT * FROM `visitor` WHERE `ic` = @ic  AND `checkin` = @checkin"
            Dim command1 As New MySqlCommand(query1, conn)
            command1.Parameters.Add("@ic", MySqlDbType.VarChar).Value = encryptIC
            command1.Parameters.Add("@checkin", MySqlDbType.DateTime).Value = rowcheckin
            reader = command1.ExecuteReader()
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While

            If count > 0 Then
                visitorid = reader(0)
                txtname.Text = reader(2)
                txtcontact.Text = reader(5)
                txtemail.Text = reader(6)
                txtcompany.Text = reader(9)
                txtvehicletype.Text = reader(11)
                txtvehicle.Text = reader(10)
                txtVisitorQty.Text = reader(12)
                txtunit.Text = reader(7)
                txthost.Text = reader(8)
                txtpurpose.Text = reader(14)
                txtbadge.Text = reader(13)
                txtremark.Text = reader(20)

                'display photo
                If reader(21) IsNot DBNull.Value Then
                    arrImage = reader(21)
                    Dim mstream As New System.IO.MemoryStream(arrImage)
                    imgCaptured.Image = Image.FromStream(mstream)

                Else
                    'clear arrimage
                    Array.Clear(arrImage, 0, arrImage.Length)
                    imgCaptured.Image = Nothing
                End If


                reader.Close()

            End If

            reader.Close()
            conn.Close()
        Catch ex As MySqlException
            MsgBox("SEARCH IC RECORD ERROR: " & ex.Message)
        End Try


    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        conn.Close()
        home.Show()
        Me.Close()
    End Sub

    Private Sub btnblacklist_Click(sender As Object, e As EventArgs) Handles btnblacklist.Click
        'get last 4 digit
        If txtic.MaskCompleted = True Then
            str4 = Microsoft.VisualBasic.Right(txtic.Text, 4)
        ElseIf txtpassport.Text IsNot "" Then
            str4 = Microsoft.VisualBasic.Right(txtpassport.Text, 4)
        End If

        Try

                If Not opendb() Then
                    MsgBox("FAILDED TO CONNECT TO DATABASE")
                End If

            'validate user role via btnblacklist.text
            'if show approve blacklist = has blacklist request, and role is admin
            If btnblacklist.Text = "Approve Blacklist" Then
                'request blacklist
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to approve this blacklist request?", "Approve Blacklist", MessageBoxButtons.YesNoCancel)
                Dim query1 As String

                If result = DialogResult.Cancel Then
                    Exit Sub

                ElseIf result = DialogResult.No Then
                    'reject
                    query1 = "UPDATE `blacklist` 
                        SET `approved` = 0, `approvedBy` = @user, `approvalDate`= NOW() 
                        WHERE LEFT(`visitor-id`, 4) = @blic"
                    MsgBox("Visitor's blacklist request is rejected")


                ElseIf result = DialogResult.Yes Then
                    'approve
                    query1 = "UPDATE `blacklist` 
                        SET `approved` = 1, `approvedBy` = @user, `approvalDate`= NOW() 
                        WHERE LEFT(`visitor-id`, 4) = @blic"
                    MsgBox("Visitor is marked as blasklist successfully")

                End If

                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@blic", MySqlDbType.VarChar).Value = str4
                command1.Parameters.Add("@user", MySqlDbType.Int32).Value = userid
                reader = command1.ExecuteReader()

                reader.Close()
            Else
                'if show blacklist = no blacklist request, and role is admin/security
                reader.Close()
                Try
                    Dim query2 As String
                    If blacklist.ShowDialog() = DialogResult.OK Then

                        If role = "security" Then
                            'security only can request blacklist
                            query2 = "INSERT INTO blacklist (`visitor-id`, `requestDate`, `requestReason`) VALUES (@visitorid, NOW(), @reqreason)"
                            MsgBox("Visitor blasklist requested")
                            btnblacklist.Enabled = False

                        ElseIf role = "admin" Then
                            'admin can direct insert visitor to blacklist
                            query2 = "INSERT INTO blacklist (`visitor-id`, `requestDate`, `requestReason`, `approved`, `approvedBy`, `approvalDate`) VALUES (@visitorid, NOW(), @reqreason, @approve, @approveby, NOW())"
                            MsgBox("Visitor is marked as blasklist successfully")

                        End If
                        Dim command2 As New MySqlCommand(query2, conn)
                        command2.Parameters.Add("@visitorid", MySqlDbType.VarChar).Value = visitorid
                        command2.Parameters.Add("@reqreason", MySqlDbType.VarChar).Value = blreason
                        command2.Parameters.Add("@approve", MySqlDbType.VarChar).Value = "1"
                        command2.Parameters.Add("@approveby", MySqlDbType.VarChar).Value = userid

                        reader = command2.ExecuteReader()

                        reader.Close()


                    End If
                    conn.Close()

                Catch ex As Exception
                    MsgBox("INSERT BLACKLIST ERROR: " & ex.Message)
                End Try

            End If

            reader.Close()
                conn.Close()

            Catch ex As Exception
                MsgBox("BLACKLIST ERROR: " & ex.Message)
            End Try




    End Sub

    'get ic and encrypt ic
    Private Sub getIC()
        Dim fullic As String = txtic.Text
        fullic = fullic.Replace("-", "")

        'get last 4 digit
        Dim ic As String = Microsoft.VisualBasic.Right(fullic, 4)

        'encrypt ic
        encryptIC = strEncrypt(fullic, ic)

    End Sub

    Private Sub btnwhitelist_Click(sender As Object, e As EventArgs) Handles btnwhitelist.Click
        Try

            If Not opendb() Then
                MsgBox("FAILDED TO CONNECT TO DATABASE")
            End If

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove visitor from blacklist?", "Approve Whitelist", MessageBoxButtons.YesNoCancel)

            If result = DialogResult.Cancel Then
                Exit Sub

            ElseIf result = DialogResult.No Then
                'reject
                Exit Sub

            ElseIf result = DialogResult.Yes Then
                'approve


                Dim query1 = "DELETE FROM `blacklist`
                        WHERE LEFT(`visitor-id`, 4) = @blic"
                MsgBox("Visitor is marked as whitelist successfully")
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@blic", MySqlDbType.VarChar).Value = str4
                reader = command1.ExecuteReader()

                reader.Close()
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox("WHITELIST ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click

        txtic.Text = ""
        txtpassport.Text = ""
        txtname.Text = ""
        txtcontact.Text = ""
        txtemail.Text = ""
        txtcompany.Text = ""
        txtvehicletype.Text = ""
        txtvehicle.Text = ""
        txtVisitorQty.Text = ""
        txtunit.Text = ""
        txthost.Text = ""
        txtpurpose.Text = ""
        txtbadge.Text = ""
        txtremark.Text = ""

        imgCaptured.Image = Nothing
        tblhistory.DataSource = Nothing
    End Sub
End Class
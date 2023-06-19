Imports MySql.Data.MySqlClient

Public Class prelist
    Dim reader As MySqlDataReader

    Private Sub prelist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        If reader IsNot Nothing Then
            reader.Close()
        End If

        conn.Close()
        Me.Close()
    End Sub

    Private Sub btncheckic_Click(sender As Object, e As EventArgs) Handles btncheckic.Click

        If txtic.MaskCompleted = False Then
            MsgBox("Fields Empty")
            Exit Sub

        ElseIf txtic.MaskCompleted = True And txtpass.Text.Trim() IsNot "" Then
            MsgBox("Enter either ONE field only")
            txtpass.Text = ""
            Exit Sub
        Else

            Try
                If Not opendb() Then
                    MsgBox("FAILED TO CONNECT TO DATABASE")
                End If

                'format ic
                Dim fullic As String = txtic.Text
                fullic = fullic.Replace("-", "")    'remove -

                'get last 4 digit
                Dim ic As String = Microsoft.VisualBasic.Right(fullic, 4)

                'encrypt ic
                Dim encryptIC As String = strEncrypt(fullic, ic)

                Dim query As String
                If role = "tenant" Then
                    query = "SELECT `prereg_id`, `precheckin` AS 'PRE-REGISTER DATE', `name` AS 'NAME', `company` AS 'COMPANY', `vehicleno` AS 'VEHICLE NO', `unit-no` AS 'UNIT', `host-id` as 'HOST' 
                         FROM `preregister` 
                         WHERE `ic` = @ic
                         AND `unit-no` = @tenant
                         ORDER BY `precheckin`"
                Else
                    query = "SELECT `prereg_id`, `precheckin` AS 'PRE-REGISTER DATE', `name` AS 'NAME', `company` AS 'COMPANY', `vehicleno` AS 'VEHICLE NO', `unit-no` AS 'UNIT', `host-id` as 'HOST' 
                         FROM `preregister` 
                         WHERE `ic` = @ic
                         ORDER BY `precheckin`"
                End If

                Dim command As New MySqlCommand(query, conn)
                command.Parameters.Add("@ic", MySqlDbType.VarChar).Value = encryptIC
                command.Parameters.Add("@tenant", MySqlDbType.VarChar).Value = tenantname


                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                reader = command.ExecuteReader
                If reader.HasRows Then
                    'display on table if has record
                    reader.Close()
                    adapter.Fill(table)
                    tblprelist.DataSource = table

                    'add button for mark arrival
                    tblprelist.Columns(0).Visible = False
                    Dim btn As New DataGridViewButtonColumn()
                    tblprelist.Columns.Add(btn)
                    btn.HeaderText = "VISITOR HAS ARRIVED"
                    btn.Text = "Check In"
                    btn.Name = "btnin"
                    btn.UseColumnTextForButtonValue = True
                    reader.Close()

                    btncheckic.Enabled = False

                Else
                    MsgBox("No Datafound")
                    tblprelist.DataSource = Nothing
                    reader.Close()
                    Exit Sub
                End If

                reader.Close()
                conn.Close()

            Catch ex As Exception
                MsgBox("RETRIEVE RECORD ERROR: " & ex.Message)
            End Try
        End If


    End Sub

    Private Sub btncheckp_Click(sender As Object, e As EventArgs) Handles btncheckp.Click
        If txtpass.Text.Trim = "" Then
            MsgBox("Fields Empty")
            Exit Sub

        ElseIf txtic.MaskCompleted = True And txtpass.Text.Trim() IsNot "" Then
            MsgBox("Enter either ONE field only")
            txtic.Text = ""
            Exit Sub
        Else
            Try
                If Not opendb() Then
                    MsgBox("FAILED TO CONNECT TO DATABASE")
                End If

                'get last 4 digit
                Dim pass As String = Microsoft.VisualBasic.Right(txtpass.Text, 4)

                'encrypt passport
                Dim encryptPassport As String = strEncrypt(txtpass.Text, pass)

                Dim query As String
                If role = "tenant" Then
                    query = "SELECT `prereg_id`, `precheckin` AS 'PRE-REGISTER DATE', `name` AS 'NAME', `company` AS 'COMPANY', `vehicleno` AS 'VEHICLE NO', `unit-no` AS 'UNIT', `host-id` as 'HOST' 
                         FROM `preregister` 
                         WHERE `passport` = @passport
                         AND `unit-no` = @tenant
                         ORDER BY `precheckin`"
                Else
                    query = "SELECT `prereg_id`, `precheckin` AS 'PRE-REGISTER DATE', `name` AS 'NAME', `company` AS 'COMPANY', `vehicleno` AS 'VEHICLE NO', `unit-no` AS 'UNIT', `host-id` as 'HOST'
                         FROM `preregister` 
                         WHERE `passport` = @passport
                         ORDER BY `precheckin`"
                End If

                Dim command As New MySqlCommand(query, conn)
                command.Parameters.Add("@passport", MySqlDbType.VarChar).Value = encryptPassport
                command.Parameters.Add("@tenant", MySqlDbType.VarChar).Value = tenantname


                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                reader = command.ExecuteReader
                If reader.HasRows Then
                    'display on table if has record
                    reader.Close()
                    adapter.Fill(table)
                    tblprelist.DataSource = table

                    'add button for mark arrival
                    tblprelist.Columns(0).Visible = False
                    Dim btn As New DataGridViewButtonColumn()
                    tblprelist.Columns.Add(btn)
                    btn.HeaderText = "VISITOR HAS ARRIVED"
                    btn.Text = "Check In"
                    btn.Name = "btnin"
                    btn.UseColumnTextForButtonValue = True
                    reader.Close()

                    btncheckp.Enabled = False
                Else
                    MsgBox("No Datafound")
                    tblprelist.DataSource = Nothing
                    reader.Close()
                    Exit Sub
                End If

                reader.Close()
                conn.Close()

            Catch ex As Exception
                MsgBox("RETRIEVE RECORD ERROR: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub tblprelist_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tblprelist.CellClick
        If e.ColumnIndex = 7 Then

            Try
                If Not opendb() Then
                    MsgBox("FAILED TO CONNECT TO DATABASE")
                End If

                'set id format
                Dim rowid = tblprelist.Rows(e.RowIndex).Cells(0).Value
                Dim newid, oriid As String
                'get last 4 digit
                oriid = Microsoft.VisualBasic.Left(rowid, 4)
                'get today's timestamp
                Dim datenow = Format(Now, "ddMMyyHHmmss")
                newid = oriid & "-" & datenow

                'format ic
                Dim fullic As String = txtic.Text
                fullic = fullic.Replace("-", "")    'remove -

                'encrypt ic (*will still encrypt empty field)
                Dim encryptIC As String = strEncrypt(fullic, oriid)
                Dim pass As String = Microsoft.VisualBasic.Right(txtpass.Text, 4)
                Dim encryptPassport As String = strEncrypt(txtpass.Text, pass)

                Dim visitorqty As Int32 = InputBox("Please insert number of visitor present", "Visitor Quantity", "")
                Dim badgeno As String = InputBox("Please insert badge no. given to visitor.", "Badge No.", "")

                'check user has checked in or not
                Dim query As String
                'check ic
                If txtic.MaskCompleted = True And txtpass.Text.Trim = "" Then
                    query = "SELECT * FROM `visitor` WHERE `ic` = @ic 
                            AND `checkin` >= CURDATE()
                            AND `checkin` < CURDATE() + INTERVAL 1 DAY "

                    'check passport
                ElseIf txtic.MaskCompleted = False And txtpass.Text.Trim IsNot "" Then
                    query = "SELECT * FROM `visitor` WHERE `passport` = @passport 
                            AND `checkin` >= CURDATE()
                            AND `checkin` < CURDATE() + INTERVAL 1 DAY "

                End If

                Dim command As New MySqlCommand(query, conn)
                command.Parameters.Add("@ic", MySqlDbType.VarChar).Value = encryptIC
                command.Parameters.Add("@passport", MySqlDbType.VarChar).Value = encryptPassport

                reader = command.ExecuteReader()
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While

                If count > 0 Then
                    MsgBox("Visitor already check in")
                    reader.Close()
                    Exit Sub
                Else
                    reader.Close()
                    Try

                        'open form2 to take picture
                        'validate if picture taken and form2 closed
                        If capturephoto.ShowDialog() = DialogResult.OK And arrImage IsNot Nothing And arrImage.Length > 0 Then

                            'insert record
                            'select record form preregister table and insert to visitor table
                            'update empty field in visitor table
                            'delete preregister table record
                            Dim query2 = "INSERT INTO `visitor` (`visitor_id`, `name`, `ic`, `passport`, `email`, `contact`, `vehicleno`, `unit-no`, `host-id`, `purpose`, `remark`) 
                                SELECT `prereg_id`, `name`, `ic`, `passport`, `email`, `contact`, `vehicleno`, `unit-no`, `host-id`, `purpose`, `remark` 
                                FROM `preregister` WHERE `prereg_id` = @rowid;
                                UPDATE `visitor` SET `visitor_id` = @newid, `visitortype` = 'walkin', `visitorqty` = @visitorqty, `badge` = @badge, `checkin` = NOW(), `photo` = @photo WHERE `visitor_id` = @rowid;
                                DELETE FROM `preregister` WHERE `prereg_id` = @rowid;"
                            Dim command2 As New MySqlCommand(query2, conn)
                            command2.Parameters.Add("@rowid", MySqlDbType.VarChar).Value = rowid
                            command2.Parameters.Add("@newid", MySqlDbType.VarChar).Value = newid
                            command2.Parameters.Add("@visitorqty", MySqlDbType.Int32).Value = visitorqty
                            command2.Parameters.Add("@badge", MySqlDbType.VarChar).Value = badgeno
                            command2.Parameters.AddWithValue("@photo", arrImage)

                            reader = command2.ExecuteReader()

                            MsgBox("Check In Successful")
                            reader.Close()

                        End If
                        conn.Close()
                    Catch ex As Exception
                        MsgBox("CHECK IN ERROR: " & ex.Message)
                    End Try
                End If
            Catch ex As MySqlException
                MsgBox("SEARCH VISITOR CHECK IN RECORD ERROR: " & ex.Message)
            End Try

        End If

    End Sub

    Private Sub txtic_TextChanged(sender As Object, e As EventArgs) Handles txtic.TextChanged

        If txtic.MaskCompleted = False Then
            btncheckic.Enabled = True
        End If

    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged
        If txtpass.Text.Trim() = "" Then
            btncheckp.Enabled = True
        End If
    End Sub
End Class
Imports MySql.Data.MySqlClient

Public Class delcheckin
    Dim reader As MySqlDataReader

    Private Sub delcheckin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtvehicle.Select()

        unitcmb(cmbunit)
        compcmb(cmbcompany)

        'If My.Settings.pactivated = False Then
        '    If trialinput(btncin) = False Then
        '        Exit Sub
        '    End If
        'End If
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        If reader IsNot Nothing Then
            reader.Close()
        End If

        conn.Close()
        visitortype.Show()
        Me.Close()
    End Sub

    Private Sub btncin_Click(sender As Object, e As EventArgs) Handles btncin.Click

        'check required field
        If txtvehicle.Text = "" Or cmbcompany.Text = "" Or cmbunit.Text = "" Then
            MsgBox("Please fill in the required field.")
            Exit Sub
        Else

            Try
                If Not opendb() Then
                    MsgBox("FAILED TO CONNECT TO DATABASE")
                End If

                'set id format
                Dim id, ic As String
                ic = Microsoft.VisualBasic.Right(txtvehicle.Text, 4)
                Dim datenow = Format(Now, "ddMMyyHHmmss")
                id = ic & "-" & datenow

                'get unit no
                Dim unitori, unitno As String
                If cmbunit.Text = "" Then
                    Exit Sub
                Else
                    unitori = cmbunit.Text
                    unitno = unitori.Substring(0, unitori.IndexOf("|"))
                End If

                'check if visitor is blacklisted
                Dim blveh = Microsoft.VisualBasic.Right(txtvehicle.Text, 4)
                'MsgBox(blic)
                Dim query2 = "SELECT * FROM `blacklist` WHERE LEFT(`visitor-id`, 4) = @blveh"
                Dim command2 As New MySqlCommand(query2, conn)
                command2.Parameters.Add("@blveh", MySqlDbType.VarChar).Value = blveh
                reader = command2.ExecuteReader()
                Dim count2 As Integer
                count2 = 0
                While reader.Read
                    count2 = count2 + 1
                End While

                If count2 > 0 Then
                    MsgBox("This visitor is blacklisted")
                    btncin.Enabled = False

                    reader.Close()
                Else
                    btncin.Enabled = True

                    reader.Close()

                    'proceed if visitor not blacklist
                    'check user has checked in or not
                    Dim query1 = "SELECT * FROM `visitor` WHERE `vehicleno` = @vehicle
                            AND `checkin` >= CURDATE()
                            AND `checkin` < CURDATE() + INTERVAL 1 DAY "
                    Dim command1 As New MySqlCommand(query1, conn)
                    command1.Parameters.Add("@vehicle", MySqlDbType.VarChar).Value = txtvehicle.Text
                    reader = command1.ExecuteReader()
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
                            'insert record
                            Dim query3 = "INSERT INTO visitor (`visitor_id`, `visitortype`, `name`, `contact`, `unit-no`, `host-id`, `vehicleno`, `company`, `visitorqty`,  `badge`, `purpose`, `checkin`, `remark`) VALUES 
                                        (@id, 'delivery', @company, @contact, @unit, @host, @vehicle, @company, @qty, @badge, @purpose, NOW(), @remark)"
                            Dim command3 As New MySqlCommand(query3, conn)
                            command3.Parameters.Add("@id", MySqlDbType.VarChar).Value = id
                            command3.Parameters.Add("@company", MySqlDbType.VarChar).Value = cmbcompany.Text
                            command3.Parameters.Add("@contact", MySqlDbType.VarChar).Value = "00"
                            command3.Parameters.Add("@unit", MySqlDbType.VarChar).Value = unitno
                            command3.Parameters.Add("@host", MySqlDbType.Int32).Value = 1
                            command3.Parameters.Add("@vehicle", MySqlDbType.VarChar).Value = txtvehicle.Text
                            command3.Parameters.Add("@qty", MySqlDbType.Int32).Value = 1
                            command3.Parameters.Add("@badge", MySqlDbType.VarChar).Value = txtbadge.Text
                            command3.Parameters.Add("@purpose", MySqlDbType.VarChar).Value = "DELIVERY"
                            command3.Parameters.Add("@remark", MySqlDbType.VarChar).Value = txtremark.Text

                            reader = command3.ExecuteReader()

                            sesvehicle = txtvehicle.Text
                            sestime = timeStamp
                            reader.Close()
                            successIn.Show()
                            conn.Close()
                            Me.Close()
                        Catch ex As Exception
                            MsgBox("CHECK IN ERROR: " & ex.Message)
                        End Try
                    End If

                End If

        Catch ex As MySqlException
                MsgBox("SEARCH VISITOR CHECK IN RECORD ERROR: " & ex.Message)
            End Try
        End If
    End Sub
End Class
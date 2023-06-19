Imports MySql.Data.MySqlClient
Public Class forceout
    Dim reader As MySqlDataReader

    Private Sub forceout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt3.Enabled = False
        lblname.Text = forcename

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        If reader IsNot Nothing Then
            reader.Close()
        End If

        conn.Close()
        ttlActive.Show()
        Me.Close()
    End Sub

    Private Sub rdb3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb3.CheckedChanged
        If rdb3.Checked = True Then
            txt3.Enabled = True
        Else
            txt3.Enabled = False
        End If
    End Sub


    Private Sub btncout_Click(sender As Object, e As EventArgs) Handles btncout.Click
        Dim radioValue As String
        If rdb1.Checked = True Then
            radioValue = "Visitor forget to check out"
        ElseIf rdb2.Checked = True Then
            radioValue = "Operating hour has end"
        ElseIf rdb3.Checked = True Then
            radioValue = txt3.Text
        Else
            radioValue = "not selected"
        End If

        'check required field
        If radioValue = "not selected" Then
            MsgBox("Please fill in the required field.")
            Exit Sub
        Else
            Try
                If Not opendb() Then
                    MsgBox("FAILED TO CONNECT TO DATABASE")
                End If

                'check user has checked in or not
                Dim query1 As String
                If forceic IsNot "" And forcepass = "" And forcevehicle = "" Then
                    query1 = "SELECT *FROM `visitor` 
                            WHERE `checkin` >= CURDATE()
                            AND `checkin` < CURDATE() + INTERVAL 1 DAY 
                            AND `ic` = @ic"
                ElseIf forceic = "" And forcepass IsNot "" And forcevehicle = "" Then
                    query1 = "SELECT *FROM `visitor` 
                            WHERE `checkin` >= CURDATE()
                            AND `checkin` < CURDATE() + INTERVAL 1 DAY 
                            AND `passport` = @pass"
                ElseIf forceic = "" And forcepass = "" And forcevehicle IsNot "" Then
                    query1 = "SELECT *FROM `visitor` 
                            WHERE `checkin` >= CURDATE()
                            AND `checkin` < CURDATE() + INTERVAL 1 DAY 
                            AND `vehicleno` = @vehicle"
                End If

                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@ic", MySqlDbType.VarChar).Value = forceic
                command1.Parameters.Add("@pass", MySqlDbType.VarChar).Value = forcepass
                command1.Parameters.Add("@vehicle", MySqlDbType.VarChar).Value = forcevehicle

                reader = command1.ExecuteReader()
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While

                If count = 1 Then
                    reader.Close()
                    Try
                        'update record
                        Dim query2 As String
                        If forceic IsNot "" And forcepass = "" And forcevehicle = "" Then
                            query2 = "UPDATE `visitor` Set `checkout`= NOW(),`status`= 1 , `forcecheckout`= 1, `forcereason`= @reason 
                                        WHERE `checkin` >= CURDATE()
                                        AND `checkin` < CURDATE() + INTERVAL 1 DAY 
                                        AND `ic` = @ic"
                        ElseIf forceic = "" And forcepass IsNot "" And forcevehicle = "" Then
                            query2 = "UPDATE `visitor` Set `checkout`= NOW(),`status`= 1 , `forcecheckout`= 1, `forcereason`= @reason 
                                        WHERE `checkin` >= CURDATE()
                                        AND `checkin` < CURDATE() + INTERVAL 1 DAY 
                                        AND `passport` = @pass"
                        ElseIf forceic = "" And forcepass = "" And forcevehicle IsNot "" Then
                            query2 = "UPDATE `visitor` Set `checkout`= NOW(),`status`= 1 , `forcecheckout`= 1, `forcereason`= @reason 
                                        WHERE `checkin` >= CURDATE()
                                        AND `checkin` < CURDATE() + INTERVAL 1 DAY 
                                        AND `vehicleno` = @vehicle"
                        End If
                        Dim command2 As New MySqlCommand(query2, conn)
                        command2.Parameters.Add("@ic", MySqlDbType.VarChar).Value = forceic
                        command2.Parameters.Add("@pass", MySqlDbType.VarChar).Value = forcepass
                        command2.Parameters.Add("@vehicle", MySqlDbType.VarChar).Value = forcevehicle
                        command2.Parameters.Add("@reason", MySqlDbType.VarChar).Value = radioValue

                        reader = command2.ExecuteReader()

                        MsgBox("Check Out Successful")

                        reader.Close()
                        conn.Close()
                        ttlActive.Show()
                        Me.Close()
                        'successIn.Show()

                    Catch ex As Exception
                        MsgBox("FORCE CHECK OUT ERROR: " & ex.Message)
                    End Try

                ElseIf count > 1 Then
                    MsgBox("More than 1 record detected")
                    reader.Close()
                Else
                    MsgBox("No record found")
                    reader.Close()
                End If
            Catch ex As MySqlException
                MsgBox("SEARCH CHECK IN RECORD ERROR: " & ex.Message)
            End Try
        End If
    End Sub

End Class
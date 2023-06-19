Imports MySql.Data.MySqlClient
Public Class checkout
    Dim reader As MySqlDataReader

    Private Sub checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtic.Select()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        If reader IsNot Nothing Then
            reader.Close()
        End If

        conn.Close()
        Me.Close()
    End Sub

    Private Sub btncout_Click(sender As Object, e As EventArgs) Handles btncout.Click

        'by ic field
        If txtic.MaskCompleted = True And txtpass.Text.Trim = "" And txtvehicle.Text.Trim = "" Then
            Try
                If Not opendb() Then
                    MsgBox("FAILED TO CONNECT TO DATABASE")
                End If

                'format ic
                Dim fullic As String = txtic.Text
                fullic = fullic.Replace("-", "")    'remove -

                'check record
                Dim query1 = "SELECT * FROM `visitor` WHERE `ic` = @ic
                            AND `checkin` >= CURDATE()
                            AND `checkin` < CURDATE() + INTERVAL 1 DAY "
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@ic", MySqlDbType.VarChar).Value = fullic
                reader = command1.ExecuteReader()
                Dim count As Integer = 0

                While reader.Read
                    count = count + 1
                End While

                If count = 1 Then
                    'check visitor has checked out or not
                    If reader(15) = 0 Then
                        reader.Close()
                        Dim query2 = "UPDATE `visitor` 
                        SET `checkout`= NOW(),`status`= 1 
                        WHERE `ic`= @ic 
                        AND `checkin` >= CURDATE()
                        AND `checkin` < CURDATE() + INTERVAL 1 DAY "
                        Dim command2 As New MySqlCommand(query2, conn)
                        command2.Parameters.Add("@ic", MySqlDbType.VarChar).Value = fullic
                        reader = command2.ExecuteReader()

                        sesic = txtic.Text
                        sestime = timeStamp
                        reader.Close()
                        successOut.Show()
                        Me.Close()
                    Else
                        MsgBox("Visitor has checked out")
                        reader.Close()
                        Exit Sub
                    End If
                Else
                    MsgBox("No record found")
                    reader.Close()
                    Exit Sub
                End If

                conn.Close()
            Catch ex As MySqlException
                MsgBox("CHECK OUT ERROR: " & ex.Message)
            End Try

            'by passport
        ElseIf txtic.MaskCompleted = False And txtpass.Text.Trim IsNot "" And txtvehicle.Text.Trim = "" Then
            Try
                If Not opendb() Then
                    MsgBox("FAILED TO CONNECT TO DATABASE")
                End If

                'check record
                Dim query3 = "SELECT * FROM `visitor` WHERE `passport`= @passport
                            AND `checkin` >= CURDATE()
                            AND `checkin` < CURDATE() + INTERVAL 1 DAY "
                Dim command3 As New MySqlCommand(query3, conn)
                command3.Parameters.Add("@passport", MySqlDbType.VarChar).Value = txtpass.Text
                reader = command3.ExecuteReader()
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count = 1 Then
                    'check visitor has checked out or not
                    If reader(15) = 0 Then
                        reader.Close()
                        Dim query4 = "UPDATE `visitor` 
                        SET `checkout`= NOW(),`status`= 1 
                        WHERE `passport`= @passport 
                        AND `checkin` >= CURDATE()
                        AND `checkin` < CURDATE() + INTERVAL 1 DAY "
                        Dim command4 As New MySqlCommand(query4, conn)
                        command4.Parameters.Add("@passport", MySqlDbType.VarChar).Value = txtpass.Text
                        reader = command4.ExecuteReader()

                        sespass = txtpass.Text
                        sestime = timeStamp
                        reader.Close()
                        successOut.Show()
                        Me.Close()

                    Else
                        MsgBox("Visitor has checked out")
                        reader.Close()
                        Exit Sub
                    End If
                Else
                    MsgBox("No record found")
                    reader.Close()
                    Exit Sub
                End If
                conn.Close()
            Catch ex As MySqlException
                MsgBox("CHECK OUT ERROR: " & ex.Message)
            End Try

            'by vehicle no
        ElseIf txtic.MaskCompleted = False And txtpass.Text.Trim = "" And txtvehicle.Text.Trim IsNot "" Then
            Try
                If Not opendb() Then
                    MsgBox("FAILED TO CONNECT TO DATABASE")
                End If

                'check record
                Dim query5 = "SELECT * FROM `visitor` 
                            WHERE `vehicleno`= @vehicle
                            AND `checkin` >= CURDATE()
                            AND `checkin` < CURDATE() + INTERVAL 1 DAY "
                Dim command5 As New MySqlCommand(query5, conn)
                command5.Parameters.Add("@vehicle", MySqlDbType.VarChar).Value = txtvehicle.Text
                reader = command5.ExecuteReader()
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While

                If count = 1 Then
                    'check visitor has checked out or not
                    If reader(15) = 0 Then
                        reader.Close()
                        Dim query6 = "UPDATE `visitor` 
                        SET `checkout`= NOW(),`status`= 1 
                        WHERE `vehicleno`= @vehicle 
                        AND `checkin` >= CURDATE()
                        AND `checkin` < CURDATE() + INTERVAL 1 DAY "
                        Dim command6 As New MySqlCommand(query6, conn)
                        command6.Parameters.Add("@vehicle", MySqlDbType.VarChar).Value = txtvehicle.Text
                        reader = command6.ExecuteReader()

                        sesvehicle = txtvehicle.Text
                        sestime = timeStamp
                        reader.Close()
                        successOut.Show()
                        Me.Close()
                    Else
                        MsgBox("Visitor has checked out")
                        reader.Close()
                        Exit Sub
                    End If
                Else
                    MsgBox("No record found")
                    reader.Close()
                    Exit Sub
                End If
                conn.Close()
            Catch ex As MySqlException
                MsgBox("CHECK OUT ERROR: " & ex.Message)
            End Try

            'if all txtbox are empty
        ElseIf txtic.MaskCompleted = False And txtpass.Text.Trim = "" And txtvehicle.Text.Trim = "" Then
            MsgBox("Please fill in either ONE field.")

        Else
            MsgBox("Please fill in only ONE field.")
        End If

    End Sub
End Class
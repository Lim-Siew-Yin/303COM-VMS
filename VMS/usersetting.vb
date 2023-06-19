Imports MySql.Data.MySqlClient
Public Class usersetting

    Dim reader As MySqlDataReader
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtcpass.Text = "" And txtnpass.Text = "" And txtrpass.Text = "" Then
            MsgBox("Please fill in all field.")
            Exit Sub
        Else

            Try
                If Not opendb() Then
                    MsgBox("FAILED TO CONNECT TO DATABASE")
                End If

                Dim query1 = "SELECT * FROM user WHERE userid = @id AND password = @pass"
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = userid
                command1.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtcpass.Text

                reader = command1.ExecuteReader()

                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While

                If count = 1 Then
                    reader.Close()
                    If txtnpass.Text = txtrpass.Text Then

                        Dim query2 = "UPDATE `user` SET `password` = @pass WHERE `userid` = @id"
                        Dim command2 As New MySqlCommand(query2, conn)
                        command2.Parameters.Add("@id", MySqlDbType.VarChar).Value = userid
                        command2.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtnpass.Text

                        reader = command2.ExecuteReader()
                        MsgBox("Password reset successful")
                    Else
                        MsgBox("Password Not Same")
                        Exit Sub
                    End If

                Else
                    MsgBox("Current password not same")
                End If
                conn.Close()
            Catch ex As MySqlException
                MsgBox("RESET PASSWORD ERROR: " & ex.Message)
            End Try
        End If
    End Sub
End Class
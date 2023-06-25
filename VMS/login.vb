Imports MySql.Data.MySqlClient
Public Class login

    Dim reader As MySqlDataReader
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnlogin
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername.Text = "" And txtpass.Text = "" Then
            MsgBox("Please fill in all field.")
            Exit Sub
        Else

            Try
                'check database connection
                If Not opendb() Then
                    MsgBox("FAILED TO CONNECT TO DATABASE")
                End If

                'search user data from table
                Dim query1 = "SELECT * FROM user WHERE username = @username AND password = @password"
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtusername.Text
                command1.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtpass.Text
                reader = command1.ExecuteReader()
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While

                If count = 1 Then
                    If reader(4) = "admin" Then
                        logined = True
                        role = "admin"
                        userid = reader(0)
                        tenantname = reader(3)
                        home.Show()

                    ElseIf reader(4) = "tenant" Then
                        logined = True
                        role = "tenant"
                        userid = reader(0)
                        tenantname = reader(3)
                        homeuser.Show()

                    ElseIf reader(4) = "security" Then
                        logined = True
                        role = "security"
                        userid = reader(0)
                        tenantname = reader(3)
                        homesecurity.Show()
                    End If

                    'reset input field
                    txtusername.Text = ""
                    txtpass.Text = ""
                    txtusername.Select()

                    Me.Hide()

                ElseIf count > 1 Then
                    MsgBox("User Duplicated")
                Else
                    MsgBox("Invalid username or password")
                End If
                conn.Close()
            Catch ex As MySqlException
                MsgBox("LOGIN ERROR: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If reader IsNot Nothing Then
            reader.Close()
        End If

        logined = False
        conn.Close()
        closeForm(e)
    End Sub
End Class
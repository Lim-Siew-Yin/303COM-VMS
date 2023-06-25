Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Module formexit
    Dim reader As MySqlDataReader

    Public Function closeForm(e As FormClosingEventArgs)
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Exit Program?", "Exit", MessageBoxButtons.YesNo)
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Function


    Public sesic, sespass, sesvehicle, sestime As String    'for display on success in out page
    Public timeStamp As String = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss")    'for display on success in out page
    Public forcename, forceic, forcepass, forcevehicle As String    'for passing value to force check out page
    Public blreason As String       'for passing value from blacklist
    Public logined As Boolean = False   'for login checking
    Public userid, tenantname, role As String   'for access level control
    Public arrImage() As Byte = {}      'saving image


    'check blacklist
    Public Function checkblacklist(ic As String)
        If Not opendb() Then
            MsgBox("FAILED TO CONNECT TO DATABASE")
        End If
        Try
            'check if visitor is blacklisted
            Dim query2 = "SELECT * FROM `blacklist` WHERE LEFT(`visitor-id`, 4) = @blic"
            Dim command2 As New MySqlCommand(query2, conn)
            command2.Parameters.Add("@blic", MySqlDbType.VarChar).Value = ic
            reader = command2.ExecuteReader()
            Dim count2 As Integer
            count2 = 0
            While reader.Read
                count2 = count2 + 1
            End While

            If count2 > 0 Then
                MsgBox("This visitor is blacklisted")
                checkin.btncin.Enabled = False
                delcheckin.btncin.Enabled = False
                preregister.btncin.Enabled = False
                visitordetail.lblblacklist.Text = "BLACKLISTED"
                visitordetail.btnblacklist.Visible = False
                visitordetail.btnwhitelist.Visible = True

            Else
                checkin.btncin.Enabled = True
                delcheckin.btncin.Enabled = True
                preregister.btncin.Enabled = True
                visitordetail.lblblacklist.Text = ""
                visitordetail.btnblacklist.Visible = True
                visitordetail.btnwhitelist.Visible = False

            End If
            reader.Close()

        Catch ex As Exception
            MsgBox("CHECK BLACKLIST ERROR: " & ex.Message)
        End Try


    End Function

    'display unit on combobox list
    Public Function unitcmb(cmb As ComboBox)
        If Not opendb() Then
            MsgBox("FAILED TO CONNECT TO DATABASE")
        End If
        Try
            'view record
            Dim query1 = "SELECT * FROM tenantunit"
            Dim command1 As New MySqlCommand(query1, conn)
            Dim adapter As New MySqlDataAdapter(command1)
            Dim ds As New DataSet()
            adapter.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then

                Dim i As Integer = 0
                Do
                    cmb.Items.Add(ds.Tables(0).Rows(i)(0) & " | " & ds.Tables(0).Rows(i)(1))
                    i += 1
                Loop While (i < ds.Tables(0).Rows.Count)

            End If
            cmb.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("RETRIEVE UNIT ERROR: " & ex.Message)
        End Try
    End Function

    'display delivery companies on combobox list
    Public Function compcmb(cmb As ComboBox)
        If Not opendb() Then
            MsgBox("FAILED TO CONNECT TO DATABASE")
        End If
        Try
            'view record
            Dim query1 = "SELECT compname FROM delcom"
            Dim command1 As New MySqlCommand(query1, conn)
            Dim adapter As New MySqlDataAdapter(command1)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                cmb.DataSource = table
                cmb.DisplayMember = "compname"
                cmb.ValueMember = "compname"

            End If
            cmb.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("RETRIEVE COMPANY ERROR: " & ex.Message)
        End Try
    End Function

    Public Function hostcmb(cmb As ComboBox, unit As String)
        If Not opendb() Then
            MsgBox("FAILED TO CONNECT TO DATABASE")
        End If
        Try

            'view record
            Dim query1 = "SELECT `host_id`, `name` FROM `host` WHERE `unit-no` = @unit"
            Dim command1 As New MySqlCommand(query1, conn)
            command1.Parameters.Add("@unit", MySqlDbType.Byte).Value = unit
            Dim adapter As New MySqlDataAdapter(command1)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                cmb.DataSource = table
                cmb.DisplayMember = "name"
                cmb.ValueMember = "host_id"
            Else
                MsgBox("No Host Found")
                cmb.DataSource = Nothing
                cmb.Items.Clear()
            End If
            cmb.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("RETRIEVE HOST ERROR: " & ex.Message)
        End Try
    End Function

    'email format validation
    Public Function emailFormat(ByVal mail As String)
        Dim eformat = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        Return Regex.IsMatch(mail, eformat)

    End Function

    'unit no format validation
    Public Function checkunitno(s As String) As Boolean
        Return s.IndexOfAny("|".ToCharArray) <> -1
    End Function


    'encrypt string(ic, passport)
    Public Function strEncrypt(plainText As String, enPass As String)
        Try

            Dim wrapper As New Simple3Des(enPass)
            Dim cipherText As String = wrapper.EncryptData(plainText)

            'My.Computer.FileSystem.WriteAllText(
            'My.Computer.FileSystem.SpecialDirectories.MyDocuments &
            ' "\cipherText.txt", cipherText, False)

            Return cipherText

        Catch ex As Exception
            MsgBox("ENCRYPTION ERROR: " & ex.Message)
        End Try
    End Function

    'decrypt string(ic, passport)
    Public Function strDecrypt(encryptedText As String, dePass As String)
        Try

            Dim cipherText As String = encryptedText
            '         My.Computer.FileSystem.ReadAllText(
            'My.Computer.FileSystem.SpecialDirectories.MyDocuments &
            '    "\cipherText.txt")
            Dim password As String = dePass
            Dim wrapper As New Simple3Des(password)

            ' DecryptData throws if the wrong password is used.
            Try
                Dim plainText As String = wrapper.DecryptData(cipherText)
                Return plainText

            Catch ex As System.Security.Cryptography.CryptographicException
                MsgBox("DECRYPTION ERROR: The data could not be decrypted with the password.")
            End Try

        Catch ex As Exception
            MsgBox("DECRYPTION ERROR: " & ex.Message)
        End Try
    End Function

End Module

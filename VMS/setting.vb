Imports MySql.Data.MySqlClient
Imports System.IO
Imports System

Public Class setting
    Dim reader As MySqlDataReader
    Private Sub setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPropertyName.Text = My.Settings.cname
        txtactivationcode.Text = My.Settings.acticode

        compcmb(listDelivery)   'load delivery company list
        unitcmb(listUnit)       'load unit list (unit)
        unitcmb(listHostUnit)   'load unit list (host)
        unitcmb(listUserUnit)   'load unit list (user)

        'Load user table
        Try
            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If

            'user table
            Dim table As New DataTable()
            Dim query = "SELECT `user_id`, `username` AS 'USERNAME', `unit-no` AS 'UNIT', `role` AS 'ACCESS LEVEL' FROM `user` ORDER BY `user_id` "
            Dim adapter As New MySqlDataAdapter(query, conn)

            adapter.Fill(table)
            tblUser.DataSource = table
            tblUser.Columns(0).Visible = False

            conn.Close()

        Catch ex As MySqlException
            MsgBox("GET USER DATA ERROR: " & ex.Message)
        End Try

        'Load host table
        Try
            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If

            'user table
            Dim table As New DataTable()
            Dim query = "SELECT `host_id`, `name` AS 'NAME', `unit-no` AS 'UNIT', `contact` AS 'CONTACT NO.', `email` AS 'EMAIL'
              FROM `host` ORDER BY `host_id` "
            Dim adapter As New MySqlDataAdapter(query, conn)

            adapter.Fill(table)
            tblHost.DataSource = table
            tblHost.Columns(0).Visible = False

            conn.Close()

        Catch ex As MySqlException
            MsgBox("GET HOST DATA ERROR: " & ex.Message)
        End Try

        'Load call table
        Try
            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If

            'user table
            Dim table As New DataTable()
            Dim query = "SELECT `call_id`, `party` AS 'PARTY NAME', `contact` AS 'CONTACT NO.' FROM `emergencycall` ORDER BY `call_id` "
            Dim adapter As New MySqlDataAdapter(query, conn)

            adapter.Fill(table)
            tblEmergency.DataSource = table
            tblEmergency.Columns(0).Visible = False

            conn.Close()

        Catch ex As MySqlException
            MsgBox("GET CALL DATA ERROR: " & ex.Message)
        End Try

    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Me.Controls.Clear()     'removes all the controls on the form
        InitializeComponent()   'load all the controls again
        setting_Load(e, e)      'run load page

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnbackg.Click
        If reader IsNot Nothing Then
            reader.Close()
        End If

        conn.Close()
        Me.Close()
    End Sub


    ''general
    'save property name
    Private Sub btnSaveProperty_Click(sender As Object, e As EventArgs) Handles btnSaveProperty.Click
        If Not txtPropertyName.Text = "" Then
            My.Settings.cname = txtPropertyName.Text.ToUpper()
            My.Settings.Save()
            home.lblconame.Text = My.Settings.cname
            MsgBox("Saved change")
        Else
            MsgBox("Invalid Property Name")
        End If

    End Sub

    'add delivery company
    Private Sub btnAddDelivery_Click_1(sender As Object, e As EventArgs) Handles btnAddDelivery.Click
        If txtDelivery.Text.Trim() IsNot "" Then
            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If
            Try
                'insert record
                Dim query1 = "INSERT INTO delcom (compname) VALUES (@compname)"
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@compname", MySqlDbType.VarChar).Value = txtDelivery.Text

                reader = command1.ExecuteReader()

                MsgBox("Insert Successful")
                reader.Close()
                conn.Close()
            Catch ex As Exception
                MsgBox("INSERT COMPANY ERROR: " & ex.Message)
            End Try

        Else
            MsgBox("Field empty")
            Exit Sub
        End If
        txtDelivery.Text = ""
    End Sub

    'remove delivery company
    Private Sub btnRemoveDelivery_Click_1(sender As Object, e As EventArgs) Handles btnRemoveDelivery.Click
        If listDelivery.Text.Trim IsNot "" Then

            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If
            Try
                'insert record
                Dim query1 = "DELETE FROM delcom WHERE compname = @compname"
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@compname", MySqlDbType.VarChar).Value = listDelivery.Text

                reader = command1.ExecuteReader()

                MsgBox("Remove Successful")
                reader.Close()
                conn.Close()
            Catch ex As Exception
                MsgBox("REMOVE COMPANY ERROR: " & ex.Message)
            End Try
        Else
            MsgBox("Select an item to remove")
            Exit Sub
        End If
    End Sub

    'add emergency call
    Private Sub btnAddEmergency_Click(sender As Object, e As EventArgs) Handles btnAddEmergency.Click
        If txtParty.Text = "" Or txtPartyContact.Text = "" Then
            MsgBox("Field empty")
            Exit Sub
        Else
            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If

            Try
                'insert record
                Dim query1 = "INSERT INTO emergencycall (`party`, `contact`) VALUES (@name, @contact)"
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtParty.Text
                command1.Parameters.Add("@contact", MySqlDbType.VarChar).Value = txtPartyContact.Text

                reader = command1.ExecuteReader()

                MsgBox("Insert Emergency Call Successful")
                reader.Close()
                conn.Close()
            Catch ex As Exception
                MsgBox("INSERT EMERGENCY CALL ERROR: " & ex.Message)
            End Try


        End If

        txtParty.Text = ""
        txtPartyContact.Text = ""

    End Sub

    'edit emergency call
    Private Sub btnEditEmergency_Click(sender As Object, e As EventArgs) Handles btnEditEmergency.Click
        If txtParty.Text = "" Or txtPartyContact.Text = "" Then
            MsgBox("Field empty")
            Exit Sub
        Else
            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If

            Try
                'update record
                Dim query1 = "UPDATE `emergencycall` SET `party` = @party, `contact` = @contact WHERE `call_id` = @id "
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = lblemerid.Text
                command1.Parameters.Add("@party", MySqlDbType.VarChar).Value = txtParty.Text
                command1.Parameters.Add("@contact", MySqlDbType.VarChar).Value = txtPartyContact.Text

                reader = command1.ExecuteReader()

                MsgBox("Edit Emergency Call Successful")
                reader.Close()
                conn.Close()
            Catch ex As Exception
                MsgBox("EDIT EMERGENCY CALL ERROR: " & ex.Message)
            End Try


        End If

        txtParty.Text = ""
        txtPartyContact.Text = ""
    End Sub

    'remove emergency call
    Private Sub btnRemoveEmergency_Click(sender As Object, e As EventArgs) Handles btnRemoveEmergency.Click
        If txtParty.Text = "" Or txtPartyContact.Text = "" Then
            MsgBox("Field empty")
            Exit Sub
        Else
            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If

            Try
                'delete record
                Dim query1 = "DELETE FROM emergencycall WHERE `call_id` = @id "
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = lblemerid.Text

                reader = command1.ExecuteReader()

                MsgBox("Remove Emergency Call Successful")
                reader.Close()
                conn.Close()
            Catch ex As Exception
                MsgBox("REMOVE EMERGENCY CALL ERROR: " & ex.Message)
            End Try


        End If

        txtParty.Text = ""
        txtPartyContact.Text = ""
    End Sub

    'select call from table
    Private Sub tblEmergency_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblEmergency.CellContentClick
        Try
            Dim row As DataGridViewRow
            row = Me.tblEmergency.Rows(e.RowIndex)

            lblemerid.Text = row.Cells("call_id").Value.ToString()
            txtParty.Text = row.Cells("PARTY NAME").Value.ToString()
            txtPartyContact.Text = row.Cells("CONTACT NO.").Value.ToString()


        Catch ex As Exception
            MsgBox("SELECT ROW ERROR: " & ex.Message)

        End Try
    End Sub


    ''unit
    'add unit
    Private Sub btnAddUnit_Click(sender As Object, e As EventArgs) Handles btnAddUnit.Click
        If txtUnitNo.Text = "" Or txtUnitName.Text = "" Then
            MsgBox("Field empty")
            Exit Sub
        Else
            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If
            Try
                'insert record
                Dim query1 = "INSERT INTO tenantunit (unit_no, unitname) VALUES (@unitno, @unitname)"
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@unitno", MySqlDbType.VarChar).Value = txtUnitNo.Text
                command1.Parameters.Add("@unitname", MySqlDbType.VarChar).Value = txtUnitName.Text

                reader = command1.ExecuteReader()

                MsgBox("Insert Successful")
                reader.Close()
                conn.Close()

            Catch ex As Exception
                MsgBox("INSERT UNIT ERROR: " & ex.Message)
            End Try
        End If
        txtUnitNo.Text = ""
        txtUnitName.Text = ""
    End Sub

    'remove unit
    Private Sub btnRemoveUnit_Click(sender As Object, e As EventArgs) Handles btnRemoveUnit.Click
        If Not listUnit.Text.Trim = "" Then

            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If
            Try
                'get unit no
                Dim unitori = listUnit.Text
                Dim unitno = unitori.Substring(0, unitori.IndexOf("|"))

                'delete record
                Dim query1 = "DELETE FROM tenantunit WHERE unit_no = @unitno"
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@unitno", MySqlDbType.VarChar).Value = unitno

                reader = command1.ExecuteReader()

                MsgBox("Remove Successful")
                reader.Close()
                conn.Close()
            Catch ex As Exception
                MsgBox("REMOVE UNIT ERROR: " & ex.Message)
            End Try
        Else
            MsgBox("Select an unit to remove")
            Exit Sub
        End If
    End Sub

    'add host
    Private Sub btnAddHost_Click(sender As Object, e As EventArgs) Handles btnAddHost.Click
        If txtHost.Text = "" Or listHostUnit.Text = "" Or txtContact.Text = "" Then
            MsgBox("Field empty")
            Exit Sub
        Else
            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If

            Try
                Dim unitno As String
                'get unit no
                If checkunitno(listHostUnit.Text) = True Then
                    Dim unitori As String = listHostUnit.Text
                    unitno = unitori.Substring(0, unitori.IndexOf("|"))
                Else
                    unitno = listHostUnit.Text
                End If


                Dim query = "SELECT * FROM `host` WHERE `name` = @name AND `unit-no` = @unit"
                Dim command As New MySqlCommand(query, conn)
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtHost.Text
                command.Parameters.Add("@unit", MySqlDbType.VarChar).Value = unitno

                reader = command.ExecuteReader()
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While

                If count > 0 Then
                    MsgBox("Duplicated user")
                    reader.Close()
                    Exit Sub
                Else
                    reader.Close()
                    Try

                        'insert record
                        Dim query1 = "INSERT INTO host (`name`, `unit-no`, `contact`, `email`) VALUES (@name, @unit, @contact, @email)"
                        Dim command1 As New MySqlCommand(query1, conn)
                        command1.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtHost.Text
                        command1.Parameters.Add("@unit", MySqlDbType.VarChar).Value = unitno
                        command1.Parameters.Add("@contact", MySqlDbType.VarChar).Value = txtContact.Text
                        command1.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text

                        reader = command1.ExecuteReader()

                        MsgBox("Insert Host Successful")
                        reader.Close()
                        conn.Close()
                    Catch ex As Exception
                        MsgBox("INSERT HOST ERROR: " & ex.Message)
                    End Try
                End If

            Catch ex As Exception
                MsgBox("SEARCH HOST DATA ERROR: " & ex.Message)
            End Try
        End If

        txtHost.Text = ""
        listHostUnit.SelectedIndex = -1
        listHostUnit.Text = ""
        txtContact.Text = ""
        txtEmail.Text = ""
    End Sub

    'edit host
    Private Sub btnEditHost_Click(sender As Object, e As EventArgs) Handles btnEditHost.Click
        If txtHost.Text = "" Or listHostUnit.Text = "" Or txtContact.Text = "" Then
            MsgBox("Field empty")
            Exit Sub
        Else
            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If
            Dim unitno As String
            'get unit no
            If checkunitno(listHostUnit.Text) = True Then
                Dim unitori As String = listHostUnit.Text
                unitno = unitori.Substring(0, unitori.IndexOf("|"))
            Else
                unitno = listHostUnit.Text
            End If

            Try
                'update record
                Dim query1 = "UPDATE `host` SET `name` = @name, `unit-no` = @unit, `contact` = @contact, `email` = @email WHERE `host_id` = @id "
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = lblhostid.Text
                command1.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtHost.Text
                command1.Parameters.Add("@unit", MySqlDbType.VarChar).Value = unitno
                command1.Parameters.Add("@contact", MySqlDbType.VarChar).Value = txtContact.Text
                command1.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text

                reader = command1.ExecuteReader()

                MsgBox("Edit Host Successful")
                reader.Close()
                conn.Close()
            Catch ex As Exception
                MsgBox("EDIT HOST ERROR: " & ex.Message)
            End Try
        End If

        txtHost.Text = ""
        listHostUnit.SelectedIndex = -1
        listHostUnit.Text = ""
        txtContact.Text = ""
        txtEmail.Text = ""
    End Sub

    'remove host
    Private Sub btnRemoveHost_Click(sender As Object, e As EventArgs) Handles btnRemoveHost.Click
        If txtHost.Text = "" Or listHostUnit.Text = "" Or txtContact.Text = "" Then
            MsgBox("Field empty")
            Exit Sub
        Else
            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If

            Try
                'delete record
                Dim query1 = "DELETE FROM host WHERE `host_id` = @id "
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = lblhostid.Text

                reader = command1.ExecuteReader()

                MsgBox("Remove Host Successful")

                reader.Close()
                conn.Close()
            Catch ex As Exception
                MsgBox("REMOVE HOST ERROR: " & ex.Message)
            End Try
        End If

        txtHost.Text = ""
        listHostUnit.SelectedIndex = -1
        listHostUnit.Text = ""
        txtContact.Text = ""
        txtEmail.Text = ""
    End Sub

    'select host from table
    Private Sub tblHost_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblHost.CellClick
        Try
            Dim row As DataGridViewRow
            row = Me.tblHost.Rows(e.RowIndex)

            lblhostid.Text = row.Cells("host_id").Value.ToString()
            txtHost.Text = row.Cells("NAME").Value.ToString()
            listHostUnit.Text = row.Cells("UNIT").Value.ToString()
            txtContact.Text = row.Cells("CONTACT NO.").Value.ToString()
            txtEmail.Text = row.Cells("EMAIL").Value.ToString()

        Catch ex As Exception
            MsgBox("SELECT ROW ERROR: " & ex.Message)

        End Try
    End Sub


    ''user
    'change password
    Private Sub btnSavePass_Click(sender As Object, e As EventArgs) Handles btnSavePass.Click
        If txtCurrentPass.Text = "" And txtNewPass.Text = "" And txtRepeatPass.Text = "" Then
            MsgBox("Please fill in all field.")
            Exit Sub
        Else

            Try
                If Not opendb() Then
                    MsgBox("FAILED TO CONNECT TO DATABASE")
                End If

                Dim query1 = "SELECT * FROM user WHERE user_id = @id AND password = @pass"
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = userid
                command1.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtCurrentPass.Text

                reader = command1.ExecuteReader()

                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While

                If count = 1 Then
                    reader.Close()
                    If txtNewPass.Text = txtRepeatPass.Text Then

                        Dim query2 = "UPDATE `user` SET `password` = @pass WHERE `user_id` = @id"
                        Dim command2 As New MySqlCommand(query2, conn)
                        command2.Parameters.Add("@id", MySqlDbType.VarChar).Value = userid
                        command2.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtNewPass.Text

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

    'select user from table
    Private Sub tbluser_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles tblUser.CellClick
        Try
            Dim row As DataGridViewRow
            row = Me.tblUser.Rows(e.RowIndex)

            lblid.Text = row.Cells("user_id").Value.ToString()
            txtUsername.Text = row.Cells("USERNAME").Value.ToString()
            listUserUnit.Text = row.Cells("UNIT").Value.ToString()
            listAccess.Text = row.Cells("ACCESS LEVEL").Value.ToString()
        Catch ex As Exception
            MsgBox("SELECT ROW ERROR: " & ex.Message)

        End Try

    End Sub

    Dim accesslvl As String
    Private Sub cmbaccess_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listAccess.SelectedIndexChanged
        Select Case listAccess.SelectedIndex
            Case 0
                accesslvl = "admin"
            Case 1
                accesslvl = "tenant"
            Case 2
                accesslvl = "security"

        End Select
    End Sub

    'add user
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        If txtUsername.Text = "" Or listUserUnit.Text = "" Or listAccess.Text = "" Then
            MsgBox("Field empty")
            Exit Sub
        Else
            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If

            Try
                Dim unitno As String
                'get unit no
                If checkunitno(listUserUnit.Text) = True Then
                    Dim unitori As String = listUserUnit.Text
                    unitno = unitori.Substring(0, unitori.IndexOf("|"))
                Else
                    unitno = listUserUnit.Text
                End If


                Dim query = "SELECT * FROM `user` WHERE username = @uname"
                Dim command As New MySqlCommand(query, conn)
                command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = txtUsername.Text

                reader = command.ExecuteReader()
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While

                If count > 0 Then
                    MsgBox("Duplicated user")
                    reader.Close()
                    Exit Sub
                Else
                    reader.Close()
                    Try

                        'insert record
                        Dim query1 = "INSERT INTO user (`username`, `password`, `unit-no`, `role`) VALUES (@uname, @uname, @unit, @acclvl)"
                        Dim command1 As New MySqlCommand(query1, conn)
                        command1.Parameters.Add("@uname", MySqlDbType.VarChar).Value = txtUsername.Text
                        command1.Parameters.Add("@unit", MySqlDbType.VarChar).Value = unitno
                        command1.Parameters.Add("@acclvl", MySqlDbType.VarChar).Value = accesslvl

                        reader = command1.ExecuteReader()

                        MsgBox("Insert User Successful")
                        reader.Close()
                        conn.Close()
                    Catch ex As Exception
                        MsgBox("INSERT USER ERROR: " & ex.Message)
                    End Try
                End If

            Catch ex As Exception
                MsgBox("SEARCH USER DATA ERROR: " & ex.Message)
            End Try
        End If

        txtUsername.Text = ""
        listUserUnit.SelectedIndex = -1
        listUserUnit.Text = ""
        listAccess.SelectedIndex = -1
    End Sub

    'edit user
    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
        If txtUsername.Text = "" Or listUserUnit.Text = "" Or listAccess.Text = "" Then
            MsgBox("Field empty")
            Exit Sub
        Else
            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If
            Dim unitno As String
            'get unit no
            If checkunitno(listUserUnit.Text) = True Then
                Dim unitori As String = listUserUnit.Text
                unitno = unitori.Substring(0, unitori.IndexOf("|"))
            Else
                unitno = listUserUnit.Text
            End If

            Try
                'insert record
                Dim query1 = "UPDATE `user` SET `username` = @uname, `unit-no` = @unit, `role` = @acclvl WHERE `user_id` = @id "
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = lblid.Text
                command1.Parameters.Add("@uname", MySqlDbType.VarChar).Value = txtUsername.Text
                command1.Parameters.Add("@unit", MySqlDbType.VarChar).Value = unitno
                command1.Parameters.Add("@acclvl", MySqlDbType.VarChar).Value = accesslvl

                reader = command1.ExecuteReader()

                MsgBox("Edit User Successful")
                reader.Close()
                conn.Close()
            Catch ex As Exception
                MsgBox("EDIT USER ERROR: " & ex.Message)
            End Try
        End If

        txtUsername.Text = ""
        listUserUnit.SelectedIndex = -1
        listUserUnit.Text = ""
        listAccess.SelectedIndex = -1
    End Sub

    'remove user
    Private Sub btnRemoveUser_Click(sender As Object, e As EventArgs) Handles btnRemoveUser.Click
        If txtUsername.Text = "" Or listUserUnit.Text = "" Or listAccess.Text = "" Then
            MsgBox("Field empty")
            Exit Sub
        Else
            If Not opendb() Then
                MsgBox("FAILED TO CONNECT TO DATABASE")
            End If

            Try
                'insert record
                Dim query1 = "DELETE FROM user WHERE `user_id` = @id "
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = lblid.Text

                reader = command1.ExecuteReader()

                MsgBox("Remove User Successful")

                reader.Close()
                conn.Close()
            Catch ex As Exception
                MsgBox("REMOVE USER ERROR: " & ex.Message)
            End Try
        End If

        txtUsername.Text = ""
        listUserUnit.SelectedIndex = -1
        listUserUnit.Text = ""
        listAccess.SelectedIndex = -1
    End Sub


    ''backup and restore
    Public Sub connection()
        Try
            conn = New MySqlConnection("server=localhost; userid=root; password=")
            If conn.State = ConnectionState.Closed Then
                conn.Open()

            End If
        Catch ex As Exception
            MsgBox("Connection Failed")
        End Try
    End Sub

    Private Sub btnbackup_Click(sender As Object, e As EventArgs) Handles btnbackup.Click
        Dim dbfile As String
        Try

            SaveFileDialog1.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*) |*.*"
            SaveFileDialog1.FileName = "Database Backup" + DateTime.Now.ToString("dd-MM-yy") + ".sql"
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                connection()
                dbfile = SaveFileDialog1.FileName
                Dim backupProcess As New Process
                backupProcess.StartInfo.FileName = "cmd.exe"
                backupProcess.StartInfo.UseShellExecute = False
                backupProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin"
                backupProcess.StartInfo.RedirectStandardInput = True
                backupProcess.StartInfo.RedirectStandardOutput = True
                backupProcess.Start()

                Dim backupStream As StreamWriter = backupProcess.StandardInput
                Dim mystreamReader As StreamReader = backupProcess.StandardOutput
                backupStream.WriteLine("mysqldump --user=root --password= -h localhost vms >""" + dbfile + """")

                backupStream.Close()
                backupProcess.WaitForExit()
                backupProcess.Close()
                conn.Close()
                MsgBox("Backup successful")

            End If

        Catch ex As Exception
            MsgBox("Backup failed: " + ex.Message)
        End Try

    End Sub

    Private Sub btnrestore_Click(sender As Object, e As EventArgs) Handles btnrestore.Click
        Dim dbfile As String
        Try

            OpenFileDialog1.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*) |*.*"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                connection()
                dbfile = OpenFileDialog1.FileName
                Dim backupProcess As New Process
                backupProcess.StartInfo.FileName = "cmd.exe"
                backupProcess.StartInfo.UseShellExecute = False
                backupProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin"
                backupProcess.StartInfo.RedirectStandardInput = True
                backupProcess.StartInfo.RedirectStandardOutput = True
                backupProcess.Start()

                Dim backupStream As StreamWriter = backupProcess.StandardInput
                Dim mystreamReader As StreamReader = backupProcess.StandardOutput
                backupStream.WriteLine("mysql --user=root --password= -h localhost vms <""" + dbfile + """")

                backupStream.Close()
                backupProcess.WaitForExit()
                backupProcess.Close()
                conn.Close()
                MsgBox("Restore successful")

            End If

        Catch ex As Exception
            MsgBox("Restore failed: " + ex.Message)
        End Try
    End Sub


    ''activation
    Private Sub btnactivate_Click(sender As Object, e As EventArgs) Handles btnactivate.Click
        encoding()
    End Sub

    Sub encoding()
        Dim h1 As String = txtCurrentPass.Text
        Dim h2 As String = "pR0dv<t Act!v@t3d"

        Dim plaintext As String = h1 & "-" & h2
        Dim pass As String = 1111

        Dim wrapper As New encryptdecrypt(pass)
        Dim ciphertext As String = wrapper.encryptData(plaintext)

        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\ciphertext.txt", ciphertext, False)

        If ciphertext = txtactivationcode.Text Then
            MsgBox("Product Activated Successful")
            My.Settings.pactivated = True
            My.Settings.acticode = txtactivationcode.Text
        Else
            MsgBox("Activation code not valid")
            txtactivationcode.Text = ""
            Exit Sub
        End If

    End Sub








    'Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
    '    Dim dialog As DialogResult
    '    dialog = MessageBox.Show("This action will remove data including company name, activation code and will return to trial mode. Are you sure you want to reset the software?", "Reset To Default", MessageBoxButtons.YesNo)
    '    If dialog = Windows.Forms.DialogResult.No Then
    '        Exit Sub
    '    Else
    '        My.Settings.Reset()
    '    End If
    'End Sub
End Class
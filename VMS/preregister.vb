Imports MySql.Data.MySqlClient
Imports MessagingToolkit.QRCode.Codec
Imports System.Xml      'multiline
Imports System.Xml.Linq
Public Class preregister
    Dim reader As MySqlDataReader


    Private Sub preregister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        unitcmb(cmbunit)                        'populate unit combobox
        txtic.Select()                          'focus on ic

        With txtdate
            .Value = DateTime.Now
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = " "
            .Checked = False
        End With

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

        If role IsNot "tenant" Then
            visitortype.Show()
        End If

        conn.Close()
        Me.Close()
    End Sub

    Private Sub dtcheckin_Click(sender As Object, e As EventArgs) Handles txtdate.Click
        txtdate.Checked = True
    End Sub

    Private Sub dtcheckin_ValueChanged(sender As Object, e As EventArgs) Handles txtdate.ValueChanged
        If txtdate.Format = DateTimePickerFormat.Custom AndAlso txtdate.CustomFormat = " " Then
            txtdate.Format = DateTimePickerFormat.Short
        End If
    End Sub

    Private Sub btncheckic_Click(sender As Object, e As EventArgs) Handles btncheckic.Click
        Dim fullic As String = txtic.Text
        fullic = fullic.Replace("-", "")

        'get last 4 digit
        Dim ic As String = Microsoft.VisualBasic.Right(fullic, 4)

        'encrypt ic
        Dim encryptIC As String = strEncrypt(fullic, ic)

        If txtic.MaskCompleted = False Then
            MsgBox("Please fill in your I/C.")
            Exit Sub
        Else
            Try
                If Not opendb() Then
                    MsgBox("FAILED TO CONNECT TO DATABASE")
                End If

                Dim query1 = "SELECT * FROM `visitor` WHERE `ic` = @ic"
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@ic", MySqlDbType.VarChar).Value = encryptIC
                reader = command1.ExecuteReader()
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While

                If count > 0 Then
                    txtname.Text = reader(2)
                    txtcontact.Text = reader(5)
                    txtemail.Text = reader(6)
                    reader.Close()

                    'check if visitor is blacklisted
                    checkblacklist(ic)

                Else
                    MsgBox("No Record Found")
                    reader.Close()
                    txtname.Text = ""
                    txtcontact.Text = ""
                    txtemail.Text = ""
                    txtcompany.Text = ""
                    cmbVehicleType.Text = ""
                    txtvehicle.Text = ""
                    txtVisitorQty.Text = ""
                    cmbunit.Text = ""
                    cmbhost.Text = ""
                    txtpurpose.Text = ""
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

        'encrypt ic
        Dim encryptPassport As String = strEncrypt(txtpassport.Text, pass)

        If txtpassport.Text.Trim = "" Then
            MsgBox("Please fill in your Passport.")
            Exit Sub
        Else
            Try
                If Not opendb() Then
                    MsgBox("FAILED TO CONNECT TO DATABASE")
                End If

                Dim query1 = "SELECT * FROM `visitor` WHERE `passport` = @passport"
                Dim command1 As New MySqlCommand(query1, conn)
                command1.Parameters.Add("@passport", MySqlDbType.VarChar).Value = txtpassport.Text
                reader = command1.ExecuteReader()
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While

                If count > 0 Then
                    txtname.Text = reader(2)
                    txtcontact.Text = reader(5)
                    txtemail.Text = reader(6)
                    reader.Close()

                    'check if visitor is blacklisted
                    checkblacklist(Microsoft.VisualBasic.Right(txtpassport.Text, 4))

                Else
                    MsgBox("No Record Found")
                    reader.Close()
                    txtname.Text = ""
                    txtcontact.Text = ""
                    txtemail.Text = ""
                    txtcompany.Text = ""
                    cmbVehicleType.Text = ""
                    txtvehicle.Text = ""
                    txtVisitorQty.Text = ""
                    cmbunit.Text = ""
                    cmbhost.Text = ""
                    txtpurpose.Text = ""
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

    Private Sub btncin_Click(sender As Object, e As EventArgs) Handles btncin.Click

        'check required field
        'check ic and passport field
        If txtic.MaskCompleted = False And txtpassport.Text.Trim = "" Then
            MsgBox("Please fill in either NRIC or Passport")
            txtic.Select()
        Else
            'check other required field
            If txtname.Text = "" Or txtcontact.Text = "" Or cmbunit.Text = "" Or cmbhost.Text = "" Or txtpurpose.Text = "" Or txtdate.Checked = False Then
                MsgBox("Please fill in the required field.")
                Exit Sub
            Else
                Try
                    If Not opendb() Then
                        MsgBox("FAILED TO CONNECT TO DATABASE")
                    End If

                    'set id format
                    Dim id, ic, pass As String
                    Dim fullic As String = txtic.Text
                    fullic = fullic.Replace("-", "")    'remove -

                    'get last 4 digit
                    ic = Microsoft.VisualBasic.Right(fullic, 4)
                    pass = Microsoft.VisualBasic.Right(txtpassport.Text, 4)

                    'encrypt ic (*will still encrypt empty field)
                    Dim encryptIC As String = strEncrypt(fullic, ic)
                    Dim encryptPassport As String = strEncrypt(txtpassport.Text, pass)

                    'get today's timestamp
                    Dim datenow = Format(Now, "ddMMyyHHmmss")

                    'set pre-register date time
                    Dim dt As DateTime
                    dt = txtdate.Value.Date ' use only the date portion '
                    Dim tim As DateTime
                    If DateTime.TryParse(txttime.Text, tim) Then
                        dt = dt + tim.TimeOfDay ' use only the time portion '
                    Else
                        MsgBox("Please enter time")
                        Exit Sub
                    End If

                    'validate date
                    Dim result As Int16 = DateTime.Compare(dt, Date.Today)
                    If (result < 0) Then
                        MsgBox("Please select date later than today")
                        Exit Sub
                    End If

                    'check ic
                    If txtic.MaskCompleted = True And txtpassport.Text.Trim = "" Then
                        id = ic & "-" & datenow     'customise id
                        sesic = txtic.Text

                        'check passport
                    ElseIf txtic.MaskCompleted = False And txtpassport.Text.Trim IsNot "" Then
                        id = pass & "-" & datenow   'customise id
                        sespass = txtpassport.Text

                    Else
                        MsgBox("Please enter either NRIC or Passport")
                        Exit Sub
                    End If

                    'validate email
                    If txtemail.Text IsNot "" Then
                        If emailFormat(txtemail.Text) = False Then
                            MsgBox("Email not valid")
                            Exit Sub
                        End If
                    End If

                    'set unit no
                    Dim unitori, unitno As String
                    If cmbunit.Text = "" Then
                        Exit Sub
                    Else
                        unitori = cmbunit.Text
                        unitno = unitori.Substring(0, unitori.IndexOf("|"))
                    End If

                    'insert record
                    Dim query3 = "INSERT INTO preregister (`prereg_id`, `name`, `ic`, `passport`, `contact`, `email`, `company`, `vehicletype`, `vehicleno`, `precheckin`, `visitorqty`, `unit-no`, `host-id`, `purpose`, `remark`) VALUES 
                                      (@id, @name, @ic, @passport, @contact, @email, @company, @vehicletype, @vehicleno, @precheckin, @visitorqty, @unit, @host, @purpose, @remark)"
                    Dim command3 As New MySqlCommand(query3, conn)
                    command3.Parameters.Add("@id", MySqlDbType.VarChar).Value = id
                    command3.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtname.Text
                    command3.Parameters.Add("@ic", MySqlDbType.VarChar).Value = encryptIC
                    command3.Parameters.Add("@passport", MySqlDbType.VarChar).Value = encryptPassport
                    command3.Parameters.Add("@contact", MySqlDbType.VarChar).Value = txtcontact.Text
                    command3.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtemail.Text
                    command3.Parameters.Add("@company", MySqlDbType.VarChar).Value = txtcompany.Text
                    command3.Parameters.Add("@vehicletype", MySqlDbType.VarChar).Value = cmbVehicleType.Text
                    command3.Parameters.Add("@vehicleno", MySqlDbType.VarChar).Value = txtvehicle.Text
                    command3.Parameters.Add("@precheckin", MySqlDbType.DateTime).Value = dt
                    command3.Parameters.Add("@visitorqty", MySqlDbType.Int32).Value = txtVisitorQty.Text
                    command3.Parameters.Add("@unit", MySqlDbType.VarChar).Value = unitno
                    command3.Parameters.Add("@host", MySqlDbType.Int32).Value = cmbhost.SelectedValue
                    command3.Parameters.Add("@purpose", MySqlDbType.VarChar).Value = txtpurpose.Text
                    command3.Parameters.Add("@remark", MySqlDbType.VarChar).Value = txtremark.Text

                    reader = command3.ExecuteReader()

                    sestime = dt
                    Dim successStr As String = encryptIC + "; " + encryptPassport + "; Name: " + txtname.Text + "; Time: " + dt + "; Unit: " + unitno + "; Host:" + cmbhost.Text
                    qrcodeGen(successStr)

                    successPre.lblhost.Text = cmbhost.Text
                    successPre.lblunit.Text = unitno
                    successPre.Show()
                    reader.Close()
                    conn.Close()


                    If role IsNot "tenant" Then
                        visitortype.Show()
                    End If

                    Me.Close()
                Catch ex As Exception
                    MsgBox("PRE-REGISTER ERROR: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub cmbunit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbunit.SelectedIndexChanged
        'retrieve host when select unit
        Dim unitori, unitno As String
        If cmbunit.Text = "" Then
            Exit Sub
        Else
            unitori = cmbunit.Text
            unitno = unitori.Substring(0, unitori.IndexOf("|"))
        End If

        If unitno IsNot "" Then
            hostcmb(cmbhost, unitno)
        End If
    End Sub

    Private Function qrcodeGen(str As String)
        Try
            Dim qrCode As New QRCodeEncoder
            qrCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            qrCode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L
            successPre.picQR.Image = qrCode.Encode(str, System.Text.Encoding.UTF8)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Function


End Class
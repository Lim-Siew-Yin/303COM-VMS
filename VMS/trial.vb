Imports MySql.Data.MySqlClient

Module trial

    Function trialinput(btn As Button)
        If Not opendb() Then
            MsgBox("FAILED TO CONNECT TO DATABASE")
        End If
        Try
            'view record
            Dim query1 = "SELECT COUNT(*) FROM visitor"
            Dim cmd As New MySqlCommand(query1, conn)
            Dim i As Integer = cmd.ExecuteScalar()
            cmd = Nothing

            If i = 5 Then
                MsgBox("Your have exceed the maximum data input for trial. Please activate your product on Setting page.")
                btn.Enabled = False
                Return False
            End If

            conn.Close()

        Catch ex As Exception
            MsgBox("GET ROW COUNT ERROR: " & ex.Message)
        End Try


    End Function


End Module

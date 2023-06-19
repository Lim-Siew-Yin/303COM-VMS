Imports MySql.Data.MySqlClient

Module dbconnection
    Public conn As New MySqlConnection
    Dim result As Boolean
    Dim reader As MySqlDataReader

    Public Function CheckDatabaseExists(ByVal dataBase As String) As Boolean
        Dim conStr As String = "Data Source=localhost; userid=root; password=;"
        Dim cmdText As String = "SELECT schema_name from information_schema.schemata where schema_name = '" & dataBase & "'"
        Dim isExist As Boolean = False
        Using conn As MySqlConnection = New MySqlConnection(conStr)
            conn.Open()
            Using cmd As MySqlCommand = New MySqlCommand(cmdText, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    isExist = reader.HasRows
                End Using
            End Using

            conn.Close()
        End Using

        Return isExist
    End Function

    Public Sub CreateDatabase(ByVal dataBase As String)
        Dim conStr As String = "Data Source=localhost; userid=root; password=;"
        Dim conn As MySqlConnection = New MySqlConnection(conStr)
        Dim str As String = "CREATE DATABASE " & dataBase
        Dim cmd As MySqlCommand = New MySqlCommand(str, conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function opendb() As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=localhost; userid=root; password=; database=vms1; Allow Zero Datetime=true"
                conn.Open()
                result = True
            End If

        Catch ex As Exception
            result = False
            MsgBox(ex.Message)
        End Try

        Return result

    End Function
End Module

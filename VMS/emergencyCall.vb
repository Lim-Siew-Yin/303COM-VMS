Imports MySql.Data.MySqlClient

Public Class emergencyCall
    Private Sub emergencyCall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            tblCall.DataSource = table
            tblCall.Columns(0).Visible = False

            conn.Close()

        Catch ex As MySqlException
            MsgBox("GET CALL DATA ERROR: " & ex.Message)
        End Try
    End Sub
End Class
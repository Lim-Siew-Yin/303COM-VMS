Public Class visitortype

    Private Sub btnnor_Click(sender As Object, e As EventArgs) Handles btnnor.Click
        checkin.Show()
        Me.Close()
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        delcheckin.Show()
        Me.Close()
    End Sub

    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        preregister.Show()
        Me.Close()
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
    End Sub
End Class
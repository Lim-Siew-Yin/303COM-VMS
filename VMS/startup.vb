Public Class startup

    Private Sub startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles exittimer.Tick
        exittimer.Stop()
        Me.Hide()
        login.Show()
    End Sub

End Class
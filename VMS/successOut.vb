Public Class successOut

    Private Sub successOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sesic IsNot "" And sespass = "" And sesvehicle = "" Then
            lblic.Text = sesic

        ElseIf sesic = "" And sespass IsNot "" And sesvehicle = "" Then
            Label2.Text = "PASSPORT:"
            lblic.Text = sespass

        ElseIf sesic = "" And sespass = "" And sesvehicle IsNot "" Then
            Label2.Text = "VEHICLE NO.:"
            lblic.Text = sesvehicle.ToUpper()
        End If

        lbltime.Text = sestime
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        sesic = ""
        sespass = ""
        sesvehicle = ""
        sestime = ""

        Me.Close()
        checkout.Close()
    End Sub
End Class
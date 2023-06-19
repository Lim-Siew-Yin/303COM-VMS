
Public Class successPre
    Private Sub successPre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sesic IsNot "" And sespass = "" And sesvehicle = "" Then
            lblic.Text = sesic

        ElseIf sesic = "" And sespass IsNot "" And sesvehicle = "" Then
            Label3.Text = "PASSPORT:"
            lblic.Text = sespass

        ElseIf sesic = "" And sespass = "" And sesvehicle IsNot "" Then
            Label3.Text = "VEHICLE NO.:"
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
        visitortype.Close()

    End Sub
End Class
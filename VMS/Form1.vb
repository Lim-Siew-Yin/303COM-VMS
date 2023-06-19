
Imports MessagingToolkit.QRCode.Codec

Public Class Form1

    Private Sub btnCode_Click(sender As Object, e As EventArgs) Handles btnCode.Click
        Try
            'Call qrcodeGen()
            'Call barcodeGen()

            Dim plainText As String = InputBox("Enter the plain text:")
            Dim password As String = InputBox("Enter the password:")

            Dim wrapper As New Simple3Des(password)
            Dim cipherText As String = wrapper.EncryptData(plainText)

            txtCode.Text = cipherText
            My.Computer.FileSystem.WriteAllText(
                My.Computer.FileSystem.SpecialDirectories.MyDocuments &
                "\cipherText.txt", cipherText, False)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnDecode_Click(sender As Object, e As EventArgs) Handles btnDecode.Click
        Try
            'Call decodeQR()


            Dim cipherText As String = My.Computer.FileSystem.ReadAllText(
       My.Computer.FileSystem.SpecialDirectories.MyDocuments &
           "\cipherText.txt")
            Dim password As String = InputBox("Enter the password:")
            Dim wrapper As New Simple3Des(password)

            ' DecryptData throws if the wrong password is used.
            Try
                Dim plainText As String = wrapper.DecryptData(cipherText)
                txtDecode.Text = plainText
            Catch ex As System.Security.Cryptography.CryptographicException
                MsgBox("The data could not be decrypted with the password.")
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub qrcodeGen()
        Try
            Dim qrCode As New QRCodeEncoder
            qrCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            qrCode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L
            Me.picQR.Image = qrCode.Encode(Me.txtCode.Text, System.Text.Encoding.UTF8)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub decodeQR()
        Try


            Dim qrDecode As New QRCodeDecoder
            txtDecode.Text = qrDecode.Decode(New Data.QRCodeBitmapImage(picQR.Image))


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            If Me.picQR.Image IsNot Nothing Then
                Me.picQR.Image.Save(IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, Me.txtCode.Text & ".jpg"))
                MessageBox.Show("QR is successfully saved.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        capturephoto.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCode.Text = ""
        txtDecode.Text = ""
        picQR.Image = Nothing
    End Sub


End Class


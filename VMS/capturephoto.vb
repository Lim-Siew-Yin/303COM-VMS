'Imports WebCam_Capture
'Imports MessagingToolkit.QRCode.Codec
Imports System.IO
Public Class capturephoto

    'Webcam
    Public Touchless As New TouchlessLib.TouchlessMgr
    Public Camera1 As TouchlessLib.Camera = Touchless.Cameras.ElementAt(0)  'show error if no camera detected

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Camera1 IsNot Nothing Then
            lblcamera.Text = Touchless.Cameras.ElementAt(0).ToString()
            Touchless.CurrentCamera = Camera1
            Touchless.CurrentCamera.CaptureWidth = 690
            Touchless.CurrentCamera.CaptureHeight = 340
        Else
            lblcamera.Text = "Camera absent"
        End If



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Image = Touchless.CurrentCamera.GetCurrentImage

    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        PictureBox1.Image = Touchless.CurrentCamera.GetCurrentImage

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If Me.PictureBox1.Image IsNot Nothing Then

                'initialise array before assign image into array
                Array.Clear(arrImage, 0, arrImage.Length)

                Dim mstream As New System.IO.MemoryStream()

                'SPECIFIES THE FILE FORMAT OF THE IMAGE
                PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

                'RETURNS THE ARRAY OF UNSIGNED BYTES FROM WHICH THIS STREAM WAS CREATED
                arrImage = mstream.GetBuffer()

                'GET THE SIZE OF THE STREAM IN BYTES
                Dim FileSize As UInt32
                FileSize = mstream.Length
                'CLOSES THE CURRENT STREAM AND RELEASE ANY RESOURCES ASSOCIATED WITH THE CURRENT STREAM
                mstream.Close()




                'Form1.picQR.Image = PictureBox1.Image
                'Me.PictureBox1.Image.Save(IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "IMGGG.jpg"))
                'MessageBox.Show("Image is successfully saved.")
                Touchless.CurrentCamera.Dispose()


                Me.DialogResult = DialogResult.OK
                Me.Dispose()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Touchless.CurrentCamera.Dispose()

    End Sub
End Class

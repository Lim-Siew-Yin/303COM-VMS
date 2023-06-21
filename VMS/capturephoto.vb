'Imports WebCam_Capture
'Imports MessagingToolkit.QRCode.Codec
Imports System.IO
Public Class capturephoto

    'Webcam
    Public Touchless As New TouchlessLib.TouchlessMgr
    'Public Camera() As TouchlessLib.Camera = Touchless.Cameras 'show error if no camera detected
    'Public Camera1 As TouchlessLib.Camera = Touchless.Cameras.ElementAt(0)  'show error if no camera detected

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'check webcam present
            If Touchless.Cameras.Count = 0 Then
                'if no webcam
                MessageBox.Show("This application needs a webcam")
                Me.Close()

            Else
                'if has webcam, display all available webcam
                For Each cam As TouchlessLib.Camera In Touchless.Cameras
                    cmbcamera.Items.Add(cam.ToString())
                Next

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub cmbcamera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcamera.SelectedIndexChanged
        Touchless.CurrentCamera = Touchless.Cameras.ElementAt(cmbcamera.SelectedIndex)
        'lblcamera.Text = Touchless.Cameras.ElementAt(0).ToString()
        Touchless.CurrentCamera.CaptureWidth = 690
        Touchless.CurrentCamera.CaptureHeight = 340
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Try
            'preview webcam on picturebox
            If Touchless.Cameras.Count <> 0 Then
                piccapture.Image = Touchless.CurrentCamera.GetCurrentImage

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        Try
            'run capture only if there's webcam
            If Touchless.Cameras.Count <> 0 Then

                'validate select webcam
                If cmbcamera.Text = "" Then
                    MessageBox.Show("Please select a webcam")
                Else
                    piccapture.Image = Touchless.CurrentCamera.GetCurrentImage
                End If


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try



    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If Me.piccapture.Image IsNot Nothing Then

                'initialise array before assign image into array
                Array.Clear(arrImage, 0, arrImage.Length)

                Dim mstream As New System.IO.MemoryStream()

                'SPECIFIES THE FILE FORMAT OF THE IMAGE
                piccapture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

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

    Private Sub capturephoto_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        Try
            'only dispose webcam if there's any
            If Touchless.Cameras.Count <> 0 Then
                Touchless.CurrentCamera.Dispose()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub


End Class

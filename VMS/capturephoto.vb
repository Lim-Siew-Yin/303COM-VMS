
Imports System.IO
Public Class capturephoto

    'Webcam
    Public Touchless As New TouchlessLib.TouchlessMgr


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

                'specifies the file format of the image
                piccapture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

                'returns the array of unsigned bytes from which this stream was created
                arrImage = mstream.GetBuffer()

                'get the size of the stream in bytes
                Dim FileSize As UInt32
                FileSize = mstream.Length
                'closes the current stream and release any resources associated with the current stream
                mstream.Close()

                'close camera
                Touchless.Dispose()


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
                Touchless.Dispose()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub


End Class

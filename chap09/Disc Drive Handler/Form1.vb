Public Class Form1
    Dim Retries As Short = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            PictureBox1.Image = _
              System.Drawing.Bitmap.FromFile("d:\fileopen.bmp")
        Catch
            Retries += 1
            If Retries <= 2 Then
                MsgBox("Please insert the disc in drive D!")
            Else
                MsgBox("File Load feature disabled")
                Button1.Enabled = False
            End If
        End Try
    End Sub
End Class

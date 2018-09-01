Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        PictureBox1.Image = _
          System.Drawing.Bitmap.FromFile("d:\fileopen.bmp")
        
    End Sub
End Class

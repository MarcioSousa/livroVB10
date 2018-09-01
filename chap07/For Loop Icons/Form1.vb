Public Class Form1

    Dim Counter As Integer = 1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Image = System.Drawing.Image.FromFile _
                ("c:\vb10sbs\chap07\face0" & Counter & ".ico")
        Counter += 1
        If Counter = 5 Then Counter = 1
    End Sub
End Class

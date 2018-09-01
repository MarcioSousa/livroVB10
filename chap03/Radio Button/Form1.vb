Public Class Form1

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        PictureBox1.Image = System.Drawing.Image.FromFile _
          ("c:\vb10sbs\chap03\pcomputr.bmp")
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        PictureBox1.Image = System.Drawing.Image.FromFile _
          ("c:\vb10sbs\chap03\computer.bmp")
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        PictureBox1.Image = System.Drawing.Image.FromFile _
          ("c:\vb10sbs\chap03\laptop1.bmp")
    End Sub
End Class

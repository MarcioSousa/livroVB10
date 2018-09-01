Public Class Form1

    Private Sub TimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeToolStripMenuItem.Click
        Label1.Text = TimeString

    End Sub

    Private Sub DateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateToolStripMenuItem.Click
        Label1.Text = DateString

    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        OpenFileDialog1.Filter = "Bitmaps (*.bmp)|*.bmp"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = System.Drawing.Image.FromFile _
              (OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ColorDialog1.ShowDialog()
        Label1.ForeColor = ColorDialog1.Color

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

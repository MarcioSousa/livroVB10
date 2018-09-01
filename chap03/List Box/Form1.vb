Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        'The list box item selected (0-2) is held in the SelectedIndex property 
        Select Case ListBox1.SelectedIndex
            Case 0
                PictureBox1.Image = System.Drawing.Image.FromFile _
                  ("c:\vb10sbs\chap03\harddisk.bmp")
            Case 1
                PictureBox1.Image = System.Drawing.Image.FromFile _
                  ("c:\vb10sbs\chap03\printer.bmp")
            Case 2
                PictureBox1.Image = System.Drawing.Image.FromFile _
                  ("c:\vb10sbs\chap03\satedish.bmp")
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Add items to a list box like this: 
        ListBox1.Items.Add("Extra hard disk")
        ListBox1.Items.Add("Printer")
        ListBox1.Items.Add("Satellite dish")
    End Sub
End Class

Imports System.Drawing.Printing

Public Class Form1

    'Sub for printing graphic
    Private Sub PrintGraphic(ByVal sender As Object, _
      ByVal ev As PrintPageEventArgs)
        ' Create the graphic using DrawImage
        ev.Graphics.DrawImage(Image.FromFile(TextBox1.Text), _
          ev.Graphics.VisibleClipBounds)
        ' Specify that this is the last page to print
        ev.HasMorePages = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Print using an error handler to catch problems
        Try
            AddHandler PrintDocument1.PrintPage, AddressOf Me.PrintGraphic
            PrintDocument1.Print()   'print graphic
        Catch ex As Exception  'catch printing exception
            MessageBox.Show("Sorry--there is a problem printing", ex.ToString())
        End Try
    End Sub
End Class

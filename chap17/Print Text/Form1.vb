Imports System.Drawing.Printing

Public Class Form1

    'Sub for printing text
    Private Sub PrintText(ByVal sender As Object, _
      ByVal ev As PrintPageEventArgs)
        'Use DrawString to create text in a Graphics object
        ev.Graphics.DrawString(TextBox1.Text, New Font("Arial", _
          11, FontStyle.Regular), Brushes.Black, 120, 120)
        ' Specify that this is the last page to print
        ev.HasMorePages = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Print using an error handler to catch problems
        Try
            ' Declare PrintDoc variable of type PrintDocument
            Dim PrintDoc As New PrintDocument
            AddHandler PrintDoc.PrintPage, AddressOf Me.PrintText
            PrintDoc.Print()   'print text
        Catch ex As Exception  'catch printing exception
            MessageBox.Show("Sorry--there is a problem printing", ex.ToString())
        End Try
    End Sub
End Class

Public Class Form1

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' Change the color of the link by setting LinkVisited to True. 
        LinkLabel1.LinkVisited = True
        ' Use the Process.Start method to open the default browser 
        ' using the Microsoft Press URL: 
        System.Diagnostics.Process.Start _
          ("http://www.microsoft.com/learning/books/")
    End Sub
End Class

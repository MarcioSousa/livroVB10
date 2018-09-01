Public Class Form1

    Private Sub InsertDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertDateToolStripMenuItem.Click
        txtNote.Text = My.Computer.Clock.LocalTime & vbCrLf & txtNote.Text
        txtNote.Select(0, 0)  'remove selection
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            'copy text to disk
            My.Computer.FileSystem.WriteAllText( _
                SaveFileDialog1.FileName, txtNote.Text, False)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class

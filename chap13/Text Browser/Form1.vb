Imports System.IO

Public Class Form1

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim AllText As String = ""
        OpenFileDialog1.Filter = "Text files (*.txt)|*.txt"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then 'display Open dialog box
            Try 'open file and trap any errors using handler
                AllText = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
                lblNote.Text = OpenFileDialog1.FileName 'update label
                txtNote.Text = AllText 'display file
                txtNote.Enabled = True 'allow text cursor
                CloseToolStripMenuItem.Enabled = True  'enable Close command
                OpenToolStripMenuItem.Enabled = False  'disable Open command
            Catch ex As Exception
                MsgBox("An error occurred." & vbCrLf & ex.Message)
            End Try
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        txtNote.Text = ""             'clear text box
        lblNote.Text = "Load a text file with the Open command."
        CloseToolStripMenuItem.Enabled = False  'disable Close command
        OpenToolStripMenuItem.Enabled = True    'enable Open command
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class

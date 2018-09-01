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

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        txtNote.Text = ""             'clear text box
        lblNote.Text = "Load a text file with the Open command."
        CloseToolStripMenuItem.Enabled = False  'disable Close command
        OpenToolStripMenuItem.Enabled = True    'enable Open command
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            'copy text to disk
            My.Computer.FileSystem.WriteAllText( _
                SaveFileDialog1.FileName, txtNote.Text, False)
        End If
    End Sub

    Private Sub InsertDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertDateToolStripMenuItem.Click
        txtNote.Text = My.Computer.Clock.LocalTime & vbCrLf & txtNote.Text
        txtNote.Select(0, 0)  'remove selection
    End Sub

    Private Sub SortTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortTextToolStripMenuItem.Click
        Dim strArray() As String
        Dim sText As String
        Dim i As Short

        sText = txtNote.Text
        'replace different new line characters with one version
        sText = sText.Replace(vbCrLf, vbCr)
        sText = sText.Replace(vbLf, vbCr)
        'remove last carriage return if it exists
        If sText.EndsWith(vbCr) Then
            sText = sText.Substring(0, sText.Length - 1)
        End If

        'split each line in to an array
        strArray = sText.Split(vbCr)

        'sort array
        ShellSort(strArray, strArray.Length)

        'then display sorted array in text box
        sText = ""
        For i = 0 To strArray.Length - 1
            sText = sText & strArray(i) & vbCrLf
        Next i
        txtNote.Text = sText
        txtNote.Select(0, 0)   'remove text selection
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class

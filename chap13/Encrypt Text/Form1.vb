Public Class Form1

    Private Sub mnuSaveAsItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSaveAsItem.Click
        Dim Encrypt As String = ""
        Dim letter As Char
        Dim i, charsInFile As Short

        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                'save text with encryption scheme (ASCII code + 1)
                charsInFile = txtNote.Text.Length
                For i = 0 To charsInFile - 1
                    letter = txtNote.Text.Substring(i, 1)
                    'determine ASCII code and add one to it
                    Encrypt = Encrypt & Chr(Asc(letter) + 1)
                Next
                'write encrypted text to file
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, Encrypt, False)
                txtNote.Text = Encrypt
                txtNote.Select(0, 0)   'remove text selection
                mnuCloseItem.Enabled = True
            Catch ex As Exception
                MsgBox("An error occurred." & vbCrLf & ex.Message)
            End Try
        End If
    End Sub

    Private Sub mnuInsertDateItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInsertDateItem.Click
        txtNote.Text = DateString & vbCrLf & txtNote.Text
        txtNote.Select(0, 0)  'remove selection
    End Sub

    Private Sub mnuExitItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExitItem.Click
        End
    End Sub

    Private Sub mnuOpenItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpenItem.Click
        Dim AllText As String
        Dim i, charsInFile As Short
        Dim letter As Char
        Dim Decrypt As String = ""

        OpenFileDialog1.Filter = "Text files (*.txt)|*.txt"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then 'display Open dialog box
            If My.Computer.FileSystem.FileExists(OpenFileDialog1.FileName) Then
                Try 'open file and trap any errors using handler
                    AllText = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
                    'now, decrypt string by subtracting one from ASCII code
                    charsInFile = AllText.Length 'get length of string
                    For i = 0 To charsInFile - 1 'loop once for each char
                        letter = AllText.Substring(i, 1) 'get character
                        Decrypt = Decrypt & Chr(Asc(letter) - 1) 'subtract 1
                    Next i 'and build new string
                    txtNote.Text = Decrypt 'then display converted string
                    lblNote.Text = OpenFileDialog1.FileName
                    txtNote.Select(0, 0)   'remove text selection
                    txtNote.Enabled = True 'allow text cursor
                    mnuCloseItem.Enabled = True  'enable Close command
                    mnuOpenItem.Enabled = False  'disable Open command
                Catch ex As Exception
                    MsgBox("An error occurred." & vbCrLf & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub mnuCloseItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCloseItem.Click
        txtNote.Text = ""             'clear text box
        lblNote.Text = "Load a text file with the Open command."
        mnuCloseItem.Enabled = False  'disable Close command
        mnuOpenItem.Enabled = True    'enable Open command
    End Sub

End Class

Imports System.IO

Public Class Form1

    Private Sub mnuSaveAsItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSaveAsItem.Click
        Dim letter As Char
        Dim strCode As String
        Dim i, charsInFile, Code As Short
        Dim StreamToWrite As StreamWriter = Nothing

        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                strCode = InputBox("Enter Encryption Code")
                If strCode = "" Then Exit Sub 'if cancel clicked
                'save text with encryption scheme
                Code = CShort(strCode)
                charsInFile = txtNote.Text.Length
                StreamToWrite = My.Computer.FileSystem.OpenTextFileWriter( _
                    SaveFileDialog1.FileName, False)
                For i = 0 To charsInFile - 1
                    letter = txtNote.Text.Substring(i, 1)
                    'convert to number w/ Asc, then use Xor to encrypt
                    StreamToWrite.Write(Asc(letter) Xor Code) 'and save in file
                    'separate numbers with a space
                    StreamToWrite.Write(" ")
                Next
                mnuCloseItem.Enabled = True
            Catch ex As Exception
                MsgBox("An error occurred." & vbCrLf & ex.Message)
            Finally
                If StreamToWrite IsNot Nothing Then
                    StreamToWrite.Close()
                End If
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
        Dim i As Short
        Dim ch As Char
        Dim strCode As String
        Dim Code, Number As Short
        Dim Numbers() As String
        Dim Decrypt As String = ""

        OpenFileDialog1.Filter = "Text files (*.txt)|*.txt"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then 'display Open dialog box
            Try 'open file and trap any errors using handler
                strCode = InputBox("Enter Encryption Code")
                If strCode = "" Then Exit Sub 'if cancel clicked
                Code = CShort(strCode)
                'read encrypted numbers
                AllText = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
                AllText = AllText.Trim
                'split numbers in to an array based on space
                Numbers = AllText.Split(" ")
                'loop through array
                For i = 0 To Numbers.Length - 1
                    Number = CShort(Numbers(i)) 'convert string to number
                    ch = Chr(Number Xor Code) 'convert with Xor
                    Decrypt = Decrypt & ch 'and build string
                Next
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
    End Sub

    Private Sub mnuCloseItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCloseItem.Click
        txtNote.Text = ""             'clear text box
        lblNote.Text = "Load a text file with the Open command."
        mnuCloseItem.Enabled = False  'disable Close command
        mnuOpenItem.Enabled = True    'enable Open command
    End Sub

End Class

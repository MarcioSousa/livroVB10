Imports System.IO  'for FileStream class
Imports System.Drawing.Printing

Public Class Form1
    Private PrintPageSettings As New PageSettings
    Private StringToPrint As String
    Private PrintFont As New Font("Arial", 10)

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Dim FilePath As String
        'Display Open dialog box and select text file
        OpenFileDialog1.Filter = "Text files (*.txt)|*.txt"
        OpenFileDialog1.ShowDialog()
        'If Cancel button not selected, load FilePath variable
        If OpenFileDialog1.FileName <> "" Then
            FilePath = OpenFileDialog1.FileName
            Try
                'Read text file and load into RichTextBox1
                Dim MyFileStream As New FileStream(FilePath, FileMode.Open)
                RichTextBox1.LoadFile(MyFileStream, _
                  RichTextBoxStreamType.PlainText)
                MyFileStream.Close()
                'Initialize string to print
                StringToPrint = RichTextBox1.Text
                'Enable Print button
                btnPrint.Enabled = True
            Catch ex As Exception
                'display error messages if they appear
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            'Specify current page settings
            PrintDocument1.DefaultPageSettings = PrintPageSettings
            'Specify document for print dialog box and show
            StringToPrint = RichTextBox1.Text
            PrintDialog1.Document = PrintDocument1
            Dim result As DialogResult = PrintDialog1.ShowDialog()
            'If click OK, print document to printer
            If result = DialogResult.OK Then
                PrintDocument1.Print()
            End If
        Catch ex As Exception
            'Display error message
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim numChars As Integer
        Dim numLines As Integer
        Dim stringForPage As String
        Dim strFormat As New StringFormat
        'Based on page setup, define drawable rectangle on page
        Dim rectDraw As New RectangleF( _
          e.MarginBounds.Left, e.MarginBounds.Top, _
          e.MarginBounds.Width, e.MarginBounds.Height)
        'Define area to determine how much text can fit on a page
        'Make height one line shorter to ensure text doesn’t clip
        Dim sizeMeasure As New SizeF(e.MarginBounds.Width, _
          e.MarginBounds.Height - PrintFont.GetHeight(e.Graphics))

        'When drawing long strings, break between words
        strFormat.Trimming = StringTrimming.Word
        'Compute how many chars and lines can fit based on sizeMeasure
        e.Graphics.MeasureString(StringToPrint, PrintFont, _
          sizeMeasure, strFormat, numChars, numLines)
        'Compute string that will fit on a page
        stringForPage = StringToPrint.Substring(0, numChars)
        'Print string on current page
        e.Graphics.DrawString(stringForPage, PrintFont, _
          Brushes.Black, rectDraw, strFormat)
        'If there is more text, indicate there are more pages
        If numChars < StringToPrint.Length Then
            'Subtract text from string that has been printed
            StringToPrint = StringToPrint.Substring(numChars)
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            'All text has been printed, so restore string
            StringToPrint = RichTextBox1.Text
        End If
    End Sub
End Class

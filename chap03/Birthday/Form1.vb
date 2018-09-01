Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Your birth date was " & DateTimePicker1.Text)
        MsgBox("Day of the year: " & _
          DateTimePicker1.Value.DayOfYear.ToString())
    End Sub
End Class

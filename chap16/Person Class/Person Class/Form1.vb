Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Employee As New Teacher
        Dim DOB As Date

        Employee.FirstName = TextBox1.Text
        Employee.LastName = TextBox2.Text
        DOB = DateTimePicker1.Value.Date
        Employee.Grade = InputBox("What grade do you teach?")

        MsgBox(Employee.FirstName & " " & Employee.LastName _
          & " teaches grade " & Employee.Grade)
    End Sub
End Class

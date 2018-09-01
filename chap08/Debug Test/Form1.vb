Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Age As Integer
        Age = TextBox1.Text
        If Age >= 13 And Age < 20 Then
            TextBox2.Text = "You're a teenager"
        Else
            TextBox2.Text = "You're not a teenager"
        End If
    End Sub
End Class

Public Class Form1
    'Declare FirstNum and SecondNum variables
    Dim FirstNum, SecondNum As Double

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Assign text box values to variables
        FirstNum = TextBox1.Text
        SecondNum = TextBox2.Text

        'Determine checked button and calculate
        If RadioButton1.Checked = True Then
            TextBox3.Text = FirstNum + SecondNum
        End If
        If RadioButton2.Checked = True Then
            TextBox3.Text = FirstNum - SecondNum
        End If
        If RadioButton3.Checked = True Then
            TextBox3.Text = FirstNum * SecondNum
        End If
        If RadioButton4.Checked = True Then
            TextBox3.Text = FirstNum / SecondNum
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class

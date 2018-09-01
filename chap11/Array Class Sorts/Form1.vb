Public Class Form1
    Dim RandArray(0 To 499) As Long

    'Initialize the Progress bar object and display num of elements
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = UBound(RandArray)
        Label2.Text = UBound(RandArray) + 1
    End Sub

    'Fill the array with random numbers and display in text box
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 0 To UBound(RandArray)
            RandArray(i) = Int(Rnd() * 1000000)
            TextBox1.Text = TextBox1.Text & RandArray(i) & vbCrLf
            ProgressBar1.Value = i  'move progress bar
        Next i
    End Sub

    'Sort the array using the Array.Sort method and display
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer
        TextBox1.Text = ""
        Array.Sort(RandArray)
        For i = 0 To UBound(RandArray)
            TextBox1.Text = TextBox1.Text & RandArray(i) & vbCrLf
            ProgressBar1.Value = i  'move progress bar
        Next i
    End Sub

    'Reverse the order of array elements using Array.Reverse
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i As Integer
        TextBox1.Text = ""
        Array.Reverse(RandArray)
        For i = 0 To UBound(RandArray)
            TextBox1.Text = TextBox1.Text & RandArray(i) & vbCrLf
            ProgressBar1.Value = i  'move progress bar
        Next i
    End Sub    
End Class

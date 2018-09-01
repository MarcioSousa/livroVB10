Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Create a second form named form2
        Dim form2 As New Form

        'Define the Text property and border style of the form
        form2.Text = "My New Form"
        form2.FormBorderStyle = FormBorderStyle.FixedDialog

        'Specify that the position of the form will be set manually
        form2.StartPosition = FormStartPosition.Manual

        'Declare a Rectangle structure to hold the form dimensions
        'Upper left corner of form (200, 100)
        'Width and height of form (300, 250)
        Dim Form2Rect As New Rectangle(200, 100, 300, 250)

        'Set the bounds of the form using the Rectangle object
        form2.DesktopBounds = Form2Rect

        'Display the form as a modal dialog box
        form2.ShowDialog()
    End Sub
End Class

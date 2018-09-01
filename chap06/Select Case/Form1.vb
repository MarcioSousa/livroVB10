Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstCountryBox.Items.Add("England")
        lstCountryBox.Items.Add("Germany")
        lstCountryBox.Items.Add("Mexico")
        lstCountryBox.Items.Add("Italy")
    End Sub

    Private Sub lstCountryBox_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCountryBox.MouseHover
        If lstCountryBox.SelectedIndex < 0 Then
            lblGreeting.Text = "Please click the country name"
        End If
    End Sub

    Private Sub lstCountryBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCountryBox.SelectedIndexChanged
        lblCountry.Text = lstCountryBox.Text
        Select Case lstCountryBox.SelectedIndex
            Case 0
                lblGreeting.Text = "Hello, programmer"
            Case 1
                lblGreeting.Text = "Hallo, programmierer"
            Case 2
                lblGreeting.Text = "Hola, programador"
            Case 3
                lblGreeting.Text = "Ciao, programmatore"
        End Select
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class

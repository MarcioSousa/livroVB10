Public Class Form1

    Private Sub btnSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSales.Click
        Dim SalesPosition As String = ""
        AddName("Sales", SalesPosition)
        txtSales.Text = txtSales.Text & SalesPosition
    End Sub

    Private Sub btnMkt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMkt.Click
        Dim MktPosition As String = ""
        AddName("Marketing", MktPosition)
        txtMkt.Text = txtMkt.Text & MktPosition
    End Sub

    Private Sub btnQuit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class

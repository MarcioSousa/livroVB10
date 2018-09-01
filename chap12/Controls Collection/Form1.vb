Option Infer Off

Public Class Form1
    'Declare a variable of type Control to represent form controls
    Dim ctrl As Control

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each ctrl In Controls
            ctrl.Text = "Click Me!"
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For Each ctrl In Controls
            ctrl.Left = ctrl.Left + 25
        Next
    End Sub

    Private Sub btnMoveObjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveObjects.Click
        For Each ctrl In Controls
            If ctrl.Name <> "btnMoveObjects" Then
                ctrl.Left = ctrl.Left + 25
            End If
        Next
    End Sub
End Class

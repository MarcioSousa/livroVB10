Imports System.Math

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnCalculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim LoanPayment As Double
        'Use Pmt function to determine payment for 36 month loan 
        LoanPayment = Pmt(CDbl(txtInterest.Text) / 12, 36, CDbl(txtAmount.Text))
        txtPayment.Text = Format(Abs(LoanPayment), "$0.00")
    End Sub
End Class

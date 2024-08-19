Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intBankPostedRate As Integer = Integer.Parse(FormatNumber(BankPostedRate.Text, 3))
        Dim intAnnualInterestRate As Integer = Integer.Parse(FormatNumber(AnnualInterestRate.Text, 3))
        Dim prepaymentAmount As Integer
        lblThreeMonthRate.Text = OriginalLoanBalance.Text * AnnualInterestRate.Text / 12 * 3
        lblIRD.Text = PrincipalBalanceOutstanding.Text * (intBankPostedRate - intAnnualInterestRate) / 12 * DateDiff(DateInterval.Month, Now, (ExistingMaturityDate.Value - EarlyRenewalDate.Value))
        prepaymentAmount = (PrincipalBalanceOutstanding.Text * lblThreeMonthRate.Text) / 12 * 3
        lblCharge.Text = prepaymentAmount
    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblOriginalMortgageAmount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTodaysPostedRate = New System.Windows.Forms.Label()
        Me.lblYourCurrentInterestRate = New System.Windows.Forms.Label()
        Me.lblMortgageMaturityDate = New System.Windows.Forms.Label()
        Me.lblAnticioatedPrepaymentDate = New System.Windows.Forms.Label()
        Me.lblMortgageAmountOutstanding = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.OriginalLoanBalance = New System.Windows.Forms.TextBox()
        Me.PrincipalBalanceOutstanding = New System.Windows.Forms.TextBox()
        Me.AnnualInterestRate = New System.Windows.Forms.TextBox()
        Me.BankPostedRate = New System.Windows.Forms.TextBox()
        Me.lblThreeMonthRate = New System.Windows.Forms.Label()
        Me.lblIRD = New System.Windows.Forms.Label()
        Me.lblPrepaymentChargeForCWB = New System.Windows.Forms.Label()
        Me.lblCharge = New System.Windows.Forms.Label()
        Me.EarlyRenewalDate = New System.Windows.Forms.DateTimePicker()
        Me.ExistingMaturityDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblOriginalMortgageAmount
        '
        Me.lblOriginalMortgageAmount.AutoSize = True
        Me.lblOriginalMortgageAmount.Location = New System.Drawing.Point(21, 33)
        Me.lblOriginalMortgageAmount.Name = "lblOriginalMortgageAmount"
        Me.lblOriginalMortgageAmount.Size = New System.Drawing.Size(132, 13)
        Me.lblOriginalMortgageAmount.TabIndex = 0
        Me.lblOriginalMortgageAmount.Text = "Original Mortgage Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Interest Rate Differential:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Three month penalty:"
        '
        'lblTodaysPostedRate
        '
        Me.lblTodaysPostedRate.AutoSize = True
        Me.lblTodaysPostedRate.Location = New System.Drawing.Point(21, 229)
        Me.lblTodaysPostedRate.Name = "lblTodaysPostedRate"
        Me.lblTodaysPostedRate.Size = New System.Drawing.Size(107, 13)
        Me.lblTodaysPostedRate.TabIndex = 3
        Me.lblTodaysPostedRate.Text = "Todays Posted Rate:"
        '
        'lblYourCurrentInterestRate
        '
        Me.lblYourCurrentInterestRate.AutoSize = True
        Me.lblYourCurrentInterestRate.Location = New System.Drawing.Point(21, 189)
        Me.lblYourCurrentInterestRate.Name = "lblYourCurrentInterestRate"
        Me.lblYourCurrentInterestRate.Size = New System.Drawing.Size(133, 13)
        Me.lblYourCurrentInterestRate.TabIndex = 4
        Me.lblYourCurrentInterestRate.Text = "Your Current Interest Rate:"
        '
        'lblMortgageMaturityDate
        '
        Me.lblMortgageMaturityDate.AutoSize = True
        Me.lblMortgageMaturityDate.Location = New System.Drawing.Point(21, 149)
        Me.lblMortgageMaturityDate.Name = "lblMortgageMaturityDate"
        Me.lblMortgageMaturityDate.Size = New System.Drawing.Size(121, 13)
        Me.lblMortgageMaturityDate.TabIndex = 5
        Me.lblMortgageMaturityDate.Text = "Mortgage Maturity Date:"
        '
        'lblAnticioatedPrepaymentDate
        '
        Me.lblAnticioatedPrepaymentDate.AutoSize = True
        Me.lblAnticioatedPrepaymentDate.Location = New System.Drawing.Point(21, 110)
        Me.lblAnticioatedPrepaymentDate.Name = "lblAnticioatedPrepaymentDate"
        Me.lblAnticioatedPrepaymentDate.Size = New System.Drawing.Size(148, 13)
        Me.lblAnticioatedPrepaymentDate.TabIndex = 6
        Me.lblAnticioatedPrepaymentDate.Text = "Anticioated Prepayment Date:"
        '
        'lblMortgageAmountOutstanding
        '
        Me.lblMortgageAmountOutstanding.AutoSize = True
        Me.lblMortgageAmountOutstanding.Location = New System.Drawing.Point(21, 71)
        Me.lblMortgageAmountOutstanding.Name = "lblMortgageAmountOutstanding"
        Me.lblMortgageAmountOutstanding.Size = New System.Drawing.Size(154, 13)
        Me.lblMortgageAmountOutstanding.TabIndex = 7
        Me.lblMortgageAmountOutstanding.Text = "Mortgage Amount Outstanding:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ExistingMaturityDate)
        Me.GroupBox1.Controls.Add(Me.EarlyRenewalDate)
        Me.GroupBox1.Controls.Add(Me.BankPostedRate)
        Me.GroupBox1.Controls.Add(Me.AnnualInterestRate)
        Me.GroupBox1.Controls.Add(Me.PrincipalBalanceOutstanding)
        Me.GroupBox1.Controls.Add(Me.OriginalLoanBalance)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnCalculate)
        Me.GroupBox1.Controls.Add(Me.lblMortgageMaturityDate)
        Me.GroupBox1.Controls.Add(Me.lblMortgageAmountOutstanding)
        Me.GroupBox1.Controls.Add(Me.lblOriginalMortgageAmount)
        Me.GroupBox1.Controls.Add(Me.lblAnticioatedPrepaymentDate)
        Me.GroupBox1.Controls.Add(Me.lblTodaysPostedRate)
        Me.GroupBox1.Controls.Add(Me.lblYourCurrentInterestRate)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(502, 290)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputs"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblIRD)
        Me.GroupBox2.Controls.Add(Me.lblThreeMonthRate)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 296)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(502, 108)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Intermediate Calculations"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblCharge)
        Me.GroupBox3.Controls.Add(Me.lblPrepaymentChargeForCWB)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 407)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(499, 41)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Results"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(6, 261)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(79, 261)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(49, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'OriginalLoanBalance
        '
        Me.OriginalLoanBalance.Location = New System.Drawing.Point(181, 30)
        Me.OriginalLoanBalance.Name = "OriginalLoanBalance"
        Me.OriginalLoanBalance.Size = New System.Drawing.Size(141, 20)
        Me.OriginalLoanBalance.TabIndex = 9
        '
        'PrincipalBalanceOutstanding
        '
        Me.PrincipalBalanceOutstanding.Location = New System.Drawing.Point(181, 68)
        Me.PrincipalBalanceOutstanding.Name = "PrincipalBalanceOutstanding"
        Me.PrincipalBalanceOutstanding.Size = New System.Drawing.Size(141, 20)
        Me.PrincipalBalanceOutstanding.TabIndex = 10
        '
        'AnnualInterestRate
        '
        Me.AnnualInterestRate.Location = New System.Drawing.Point(181, 186)
        Me.AnnualInterestRate.Name = "AnnualInterestRate"
        Me.AnnualInterestRate.Size = New System.Drawing.Size(141, 20)
        Me.AnnualInterestRate.TabIndex = 13
        '
        'BankPostedRate
        '
        Me.BankPostedRate.Location = New System.Drawing.Point(181, 222)
        Me.BankPostedRate.Name = "BankPostedRate"
        Me.BankPostedRate.Size = New System.Drawing.Size(141, 20)
        Me.BankPostedRate.TabIndex = 14
        '
        'lblThreeMonthRate
        '
        Me.lblThreeMonthRate.AutoSize = True
        Me.lblThreeMonthRate.Location = New System.Drawing.Point(154, 43)
        Me.lblThreeMonthRate.Name = "lblThreeMonthRate"
        Me.lblThreeMonthRate.Size = New System.Drawing.Size(0, 13)
        Me.lblThreeMonthRate.TabIndex = 3
        '
        'lblIRD
        '
        Me.lblIRD.AutoSize = True
        Me.lblIRD.Location = New System.Drawing.Point(143, 87)
        Me.lblIRD.Name = "lblIRD"
        Me.lblIRD.Size = New System.Drawing.Size(0, 13)
        Me.lblIRD.TabIndex = 4
        '
        'lblPrepaymentChargeForCWB
        '
        Me.lblPrepaymentChargeForCWB.AutoSize = True
        Me.lblPrepaymentChargeForCWB.Location = New System.Drawing.Point(6, 17)
        Me.lblPrepaymentChargeForCWB.Name = "lblPrepaymentChargeForCWB"
        Me.lblPrepaymentChargeForCWB.Size = New System.Drawing.Size(146, 13)
        Me.lblPrepaymentChargeForCWB.TabIndex = 3
        Me.lblPrepaymentChargeForCWB.Text = "Prepayment Charge for CWB:"
        '
        'lblCharge
        '
        Me.lblCharge.AutoSize = True
        Me.lblCharge.Location = New System.Drawing.Point(158, 17)
        Me.lblCharge.Name = "lblCharge"
        Me.lblCharge.Size = New System.Drawing.Size(0, 13)
        Me.lblCharge.TabIndex = 4
        '
        'EarlyRenewalDate
        '
        Me.EarlyRenewalDate.Location = New System.Drawing.Point(181, 104)
        Me.EarlyRenewalDate.Name = "EarlyRenewalDate"
        Me.EarlyRenewalDate.Size = New System.Drawing.Size(141, 20)
        Me.EarlyRenewalDate.TabIndex = 15
        '
        'ExistingMaturityDate
        '
        Me.ExistingMaturityDate.Location = New System.Drawing.Point(181, 143)
        Me.ExistingMaturityDate.Name = "ExistingMaturityDate"
        Me.ExistingMaturityDate.Size = New System.Drawing.Size(141, 20)
        Me.ExistingMaturityDate.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Mortgage Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblOriginalMortgageAmount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTodaysPostedRate As Label
    Friend WithEvents lblYourCurrentInterestRate As Label
    Friend WithEvents lblMortgageMaturityDate As Label
    Friend WithEvents lblAnticioatedPrepaymentDate As Label
    Friend WithEvents lblMortgageAmountOutstanding As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BankPostedRate As TextBox
    Friend WithEvents AnnualInterestRate As TextBox
    Friend WithEvents PrincipalBalanceOutstanding As TextBox
    Friend WithEvents OriginalLoanBalance As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblIRD As Label
    Friend WithEvents lblThreeMonthRate As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblCharge As Label
    Friend WithEvents lblPrepaymentChargeForCWB As Label
    Friend WithEvents ExistingMaturityDate As DateTimePicker
    Friend WithEvents EarlyRenewalDate As DateTimePicker
End Class

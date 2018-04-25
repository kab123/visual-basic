Public Class Form1
    Const exemptionRate As Double = 4000
    Const bracketCount As Integer = 7
    Dim status As Integer
    Dim totalIncome As Double
    Dim exemptions As Double
    Dim deductions As Double
    Dim taxableIncome As Double
    Dim tax As Double
    Dim withholding As Double
    Dim refundOrTaxDue As Double
    Dim deductionsTable() As Double = {0, 6300, 12600, 6300, 9250, 12600}
    Enum taxTable   ' entries in the tax table
        from
        last
        tax
        percent
    End Enum

    Private Sub radSingle_CheckedChanged(sender As Object, e As EventArgs) Handles radSingle.Click
        status = 1
        computeTax()
    End Sub

    Private Sub radMarriedFilingJointly_CheckedChanged(sender As Object, e As EventArgs) Handles radMarriedFilingJointly.Click
        status = 2
        computeTax()
    End Sub

    Private Sub radMarriedFilingSeparately_CheckedChanged(sender As Object, e As EventArgs) Handles radMarriedFilingSeparately.Click
        status = 3
        computeTax()
    End Sub

    Private Sub radHeadOfHousehold_CheckedChanged(sender As Object, e As EventArgs) Handles radHeadOfHousehold.Click
        status = 4
        computeTax()
    End Sub

    Private Sub radQualifingWidow_CheckedChanged(sender As Object, e As EventArgs) Handles radQualifingWidow.Click
        status = 5
        computeTax()
    End Sub

    Private Sub txtExemptions_TextChanged(sender As Object, e As EventArgs) Handles txtExemptions.TextChanged
        If txtExemptions.Text = "" Then
            exemptions = 0
        Else
            exemptions = CInt(txtExemptions.Text) * exemptionRate
        End If
        computeTax()
    End Sub

    Private Sub txtTotalIncome_TextChanged(sender As Object, e As EventArgs) Handles txtTotalIncome.TextChanged
        If txtTotalIncome.Text = "" Then
            totalIncome = 0
        Else
            totalIncome = CDbl(txtTotalIncome.Text)
        End If
        computeTax()
    End Sub

    Private Sub radStandard_CheckedChanged(sender As Object, e As EventArgs) Handles radStandard.Click
        txtDeductions.Visible = False
        computeTax()
    End Sub

    Private Sub radItemized_CheckedChanged(sender As Object, e As EventArgs) Handles radItemized.CheckedChanged, txtDeductions.Click
        txtDeductions.Visible = True
        txtDeductions.Focus()
        computeTax()
    End Sub

    Private Sub txtDeductions_TextChanged(sender As Object, e As EventArgs) Handles txtDeductions.TextChanged
        computeTax()
    End Sub

    Private Sub txtWithheld_TextChanged(sender As Object, e As EventArgs) Handles txtWithheld.TextChanged
        If txtWithheld.Text = "" Then
            withholding = 0
        Else
            withholding = CDec(txtWithheld.Text)
        End If
        computeTax()
    End Sub

    Private Sub computeTax()
        Dim baseTax As Double
        Dim i As Integer

        ' Determine the deductions
        If txtDeductions.Text = "" Then
            deductions = 0
        Else
            deductions = CDec(txtDeductions.Text)
        End If

        taxableIncome = totalIncome - exemptions - deductions
        If taxableIncome < 0 Then
            taxableIncome = 0
        End If

        ' get the tax table based on the taxpayers status
        Dim table(,) As Double = tableSelection(status)
        ' find the entry in the tax table
        For i = 0 To bracketCount - 1
            If taxableIncome > table(i, taxTable.from) And taxableIncome <= table(i, taxTable.last) Then
                baseTax = table(i, taxTable.tax)
                Dim incomeDelta As Double = (taxableIncome - table(i, taxTable.from))
                Dim percentDelta As Double = table(i, taxTable.percent) / 100.0
                tax = baseTax + (taxableIncome - table(i, taxTable.from)) * table(i, taxTable.percent) / 100.0
                Exit For
            End If
        Next
        refundOrTaxDue = withholding - tax
        displayTaxes()
    End Sub

    Private Function tableSelection(ByVal status) As Double(,)
        Dim maxDouble = Double.MaxValue

        ' from      to          tax         percent
        Dim SingleTaxTable(,) As Double = {
            {0.0, 9225.0, 0.0, 10.0},
            {9225.0, 37450.0, 922.5, 15.0},
            {37450.0, 90750.0, 5156.25, 25.0},
            {90750.0, 189300.0, 18481.25, 28.0},
            {189300.0, 411500.0, 46075.25, 33.0},
            {411500.0, 413200.0, 119401.25, 35.0},
            {413200.0, maxDouble, 119996.25, 39.6}
        }
        Dim MarriedFilingJointlyTaxTable(,) As Double = {
             {0.0, 18450.0, 0.0, 10.0},
             {18450.0, 74900.0, 1845.0, 15.0},
             {74900.0, 151200.0, 10312.5, 25.0},
             {151200.0, 230450.0, 29387.5, 28.0},
             {230450.0, 411500.0, 51577.5, 33.0},
             {411500.0, 464850.0, 111324.0, 35.0},
             {464850.0, maxDouble, 129996.5, 39.6}
         }
        Dim MarriedFilingSeparatelyTaxTable(,) As Double = {
            {0.0, 9225.0, 0.0, 10.0},
            {9225.0, 37450.0, 922.5, 15.0},
            {37450.0, 75600.0, 5156.25, 25.0},
            {75600.0, 115225.0, 14693.75, 28.0},
            {115225.0, 205750.0, 25788.75, 33.0},
            {205750.0, 232425.0, 55662.0, 35.0},
            {232425.0, maxDouble, 64998.25, 39.6}
        }
        Dim HeadOfHouseholdTaxTable(,) As Double = {
            {0.0, 13150.0, 0.0, 10.0},
            {13150.0, 50200.0, 1315.0, 15.0},
            {50200.0, 129600.0, 6872.5, 25.0},
            {129600.0, 209850.0, 26772.5, 28.0},
            {209850.0, 411500.0, 49192.5, 33.0},
            {411500.0, 439000.0, 115737.0, 35.0},
            {439000.0, maxDouble, 125362.0, 39.6}
        }
        Dim QualifyingWidowTaxTable(,) As Double = {
            {0.0, 18450.0, 0.0, 10.0},
            {18450.0, 74900.0, 1845.0, 15.0},
            {74900.0, 151200.0, 10312.5, 25.0},
            {151200.0, 230450.0, 29387.5, 28.0},
            {230450.0, 411500.0, 51577.5, 33.0},
            {411500.0, 464850.0, 111324.0, 35.0},
            {464850.0, maxDouble, 129996.5, 39.6}
        }
        Select Case status
            Case 1
                Return SingleTaxTable
            Case 2
                Return MarriedFilingJointlyTaxTable
            Case 3
                Return MarriedFilingSeparatelyTaxTable
            Case 4
                Return HeadOfHouseholdTaxTable
            Case 5
                Return QualifyingWidowTaxTable
        End Select
        Return SingleTaxTable
    End Function

    Private Sub displayTaxes()
        lblComputedTax.Text =
          String.Format("{0,-15}{1,10}", "Total Income", totalIncome.ToString("C2")) & vbCrLf &
          String.Format("{0,-15}{1,10}", "Exemptions", exemptions.ToString("C2")) & vbCrLf &
          String.Format("{0,-15}{1,10}", "Deductions", deductions.ToString("C2")) & vbCrLf &
          String.Format("{0,-15}{1,10}", "Taxable Income", taxableIncome.ToString("C2")) & vbCrLf &
          vbCrLf &
          String.Format("{0,-15}{1,10}", "Tax", tax.ToString("C2")) & vbCrLf &
          String.Format("{0,-15}{1,10}", "Withholding", withholding.ToString("C2")) & vbCrLf

        If refundOrTaxDue >= 0 Then
            lblComputedTax.Text &=
            String.Format("{0,-15}{1,10}", "Refund", refundOrTaxDue.ToString("C2"))
        Else
            Dim balanceDue As Double = -refundOrTaxDue
            lblComputedTax.Text &=
            String.Format("{0,-15}{1,10}", "Balance Due", balanceDue.ToString("C2"))
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearForm()
    End Sub

    Private Sub clearForm()
        status = 1
        radSingle.Checked = True
        txtExemptions.Text = "1"
        txtTotalIncome.Text = "0"
        radStandard.Checked = True
        txtDeductions.Text = "0"
        txtWithheld.Text = "0"
        computeTax()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearForm()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
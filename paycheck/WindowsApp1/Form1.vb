'enkido betmallo
'2/13/18
Public Class mainttitlelbl

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click

        Dim hours As Decimal
        Dim rate As Decimal
        Dim regHours As Decimal
        Dim overHours As Decimal
        Dim regPay As Decimal
        Dim overPay As Decimal
        Dim paycheck As Decimal

        hours = CDec(hoursbox.Text)
        rate = CDec(ratebox.Text)

        If hours <= 40 Then
            regHours = hours
            overHours = 0
        Else
            hours = 40
            overHours = hours - 40
        End If
        regPay = regHours * rate
        overPay = overHours * rate * 1.5
        paycheck = regPay + overPay

        resultlbl.Text = "your pay is" & FormatCurrency(paycheck)



    End Sub
End Class

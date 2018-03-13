Public Class Form1

    Const minimumWage As Decimal = 10.5D    ' $10.50 per hour
    Const maximumPayRate As Decimal = 100D  ' maximum pay per hour at this company is $100 / hour

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim hoursThisDay As Decimal
        Dim regularHoursThisDay As Decimal
        Dim overtimeHoursThisDay As Decimal

        Dim totalHours As Decimal = 0
        Dim totalRegularHours As Decimal = 0
        Dim totalOvertimeHours As Decimal = 0

        Dim payRate As Decimal
        Dim regularPay As Decimal
        Dim overtimePay As Decimal
        Dim totalPay As Decimal

        Try
            ' Get the payrate and name from the TextBoxes on the form - validate
            payRate = CDec(txtPayrate.Text)

            ' Compute the total hours, overtime hours and regular hours by looking at 
            ' each TextBox in the group of TextBoxes
            Dim ctrl As Control ' Control is the base class, ctrl is an object of type Control
            For Each ctrl In grpHoursEachDay.Controls ' step through each object in the GroupBox
                If (ctrl.GetType() Is GetType(TextBox)) Then ' is this object a TextBox
                    Dim txt As TextBox = CType(ctrl, TextBox) ' -yes, txt will be one of the TextBoxes
                    hoursThisDay = 0            ' initialize for each day
                    regularHoursThisDay = 0
                    overtimeHoursThisDay = 0

                    If txt.Text <> String.Empty Then
                        hoursThisDay = CDec(txt.Text)   ' get the day's hours from the textbox
                        If hoursThisDay <= 8 Then
                            regularHoursThisDay = hoursThisDay
                            overtimeHoursThisDay = 0
                        Else
                            regularHoursThisDay = 8
                            overtimeHoursThisDay = hoursThisDay - 8
                        End If
                    End If

                    ' Accumulate the totals
                    totalHours += hoursThisDay
                    totalRegularHours += regularHoursThisDay
                    totalOvertimeHours += overtimeHoursThisDay
                End If
            Next

            ' Compute the paycheck
            regularPay = totalRegularHours * payRate
            overtimePay = totalOvertimeHours * payRate * 1.5
            totalPay = regularPay + overtimePay

            ' Display the summary information for hours and amount paid
            lblRegular.Text = totalRegularHours.ToString
            lblOverTime.Text = totalOvertimeHours.ToString
            lblTotalHours.Text = totalHours.ToString
            lblAmountPaid.Text = totalPay.ToString("C2")  ' display as currency            

            ' Display the employee name, date and pay on the paycheck form
            lblPayCheckName.Text = txtName.Text ' Put the name on the paycheck
            lblPayCheckAmount.Text = totalPay.ToString("C2")
            lblPayCheckDate.Text = DateString

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Call the clear subroutine
        clearPaycheckForm()
    End Sub

    Private Sub clearPaycheckForm() ' called by formLoad and the clear button
        txtName.Text = String.Empty
        txtMonday.Text = String.Empty
        txtTuesday.Text = String.Empty
        txtWednesday.Text = String.Empty
        txtThursday.Text = String.Empty
        txtFriday.Text = String.Empty
        txtSaturday.Text = String.Empty
        txtSunday.Text = String.Empty
        txtPayrate.Text = String.Empty
        lblRegular.Text = String.Empty
        lblAmountPaid.Text = String.Empty
        lblOverTime.Text = String.Empty
        lblPayCheckAmount.Text = String.Empty
        lblPayCheckDate.Text = String.Empty
        lblPayCheckName.Text = String.Empty
        lblTotalHours.Text = String.Empty
    End Sub

End Class

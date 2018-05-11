Public Class Form1
    'since I am unemployed these are sample income taxes
    Const FedTaxRate As Decimal = 0.15
    Const StateTaxRate As Decimal = 0.05
    Const SDItaxRate As Decimal = 0.01
    Const FICAtaxRate As Decimal = 0.062

    'global variables
    Dim employee As String
    Dim hours As Decimal
    Dim rate As Decimal
    Dim regHours As Decimal
    Dim otHours As Decimal
    Dim regPay As Decimal
    Dim otPay As Decimal
    Dim grossPay As Decimal
    Dim fedTax As Decimal
    Dim stateTax As Decimal
    Dim SDI As Decimal
    Dim FICA As Decimal
    Dim deductions As Decimal
    Dim netPAy As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearForm()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        ComputePAy()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub

    Private Sub ClearForm()
        txtName.Text = String.Empty
        txtHours.Text = String.Empty
        txtRate.Text = String.Empty
        lstPayCheck.Items.Clear()
    End Sub

    Private Sub ComputePAy()
        Try
            employee = txtName.Text
            hours = CDec(txtHours.Text)
            rate = CDec(txtRate.Text)
            If hours < 0 Or hours > 168 Then
                Throw New Exception("Illegal entry. Try again")
            End If
            If hours <= 40 Then
                regHours = hours
                otHours = 0
            Else
                regHours = 40
                otHours = hours - 40
            End If
        Catch
            MessageBox.Show("Illegal entry. Try again")
        End Try
    End Sub
End Class

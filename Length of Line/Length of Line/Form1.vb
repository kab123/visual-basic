

Imports System.Math

Public Class Form1
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim x1 As Double
        Dim y1 As Double
        Dim x2 As Double
        Dim y2 As Double
        Dim c As Double
        Try
            Dim endpoints() As String = Split(txtEndPoints.Text, ",", 4)
            x1 = CDbl(endpoints(0))
            y1 = CDbl(endpoints(1))
            x2 = CDbl(endpoints(2))
            y2 = CDbl(endpoints(3))

            c = ComputeLineLength(x1, y1, x2, y2)
            lblResult.Text = "C = " & c.ToString("N2")
        Catch ex As Exception
            MsgBox("Illegal input")
        End Try
    End Sub
    Private Function ComputeLineLength(ByVal x1 As Double, ByVal y1 As Double,
                                       ByVal x2 As Double, ByVal y2 As Double)
        Dim a As Double
        Dim b As Double
        Dim hypotenous As Double
        a = x1 - x2
        b = y1 - y2
        hypotenous = Sqrt(a ^ 2 + b ^ 2)
        Return hypotenous
    End Function

    Private Sub txtEndPoints_Enter(sender As Object, e As EventArgs) Handles txtEndPoints.Enter
        txtEndPoints.Text = String.Empty
    End Sub
End Class

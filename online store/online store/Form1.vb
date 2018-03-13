Public Class Form1
    Const MUSIC_PRICE As Decimal = 0.99D
    Const MUSIC_COMISSION_PERCENT As Decimal = 0.2D
    Const VIDEO_PRICE As Decimal = 4.95D
    Const VIDEO_COMISSION_PERCENT = 0.25D
    Private Sub btncompute_Click(sender As Object, e As EventArgs) Handles btncompute.Click
        Dim musicSold As Integer
        Dim musicGrossSales As Decimal
        Dim musicComission As Decimal

        Dim videoSold As Integer
        Dim videoGrossSales As Decimal
        Dim videoComission As Decimal

        Dim itemsSold As Integer
        Dim grossSales As Decimal
        Dim comission As Decimal
        Dim netToSellers As Decimal

        musicSold = CInt(musicTxt.Text)
        videoSold = CInt(VideoTxt.Text)

        musicGrossSales = musicSold * MUSIC_PRICE
        musicComission = musicGrossSales * MUSIC_COMISSION_PERCENT

        videoGrossSales = videoSold * VIDEO_PRICE
        videoComission = videoGrossSales * VIDEO_COMISSION_PERCENT

        itemsSold = musicSold + videoSold
        grossSales = musicGrossSales + videoGrossSales
        comission = musicComission + videoComission
        netToSellers = grossSales - comission

        lblitemssold.Text = "Items sold: " & itemsSold.ToString
        lblgrosssales.Text = "Gross Sales: " & grossSales.ToString("C2")
        lblcommison.Text = "Commission: " & comission.ToString("C2")
        lblnettosellers.Text = "Net To Sellers: " & netToSellers.ToString("C2")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        musicTxt.Text = String.Empty
        VideoTxt.Text = String.Empty
        lblitemssold.Text = "Items sold: "
        lblgrosssales.Text = "Gross Sales: "
        lblcommison.Text = "Commission: "
        lblnettosellers.Text = "Net To Sellers: "
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

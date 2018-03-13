Public Class WorkShopForm
    Dim totalFees As Double = 0
    Dim workShopList(,) As String = {
        {"Handling Stress", "3", "595"},
        {"Time Management", "3", "695"},
        {"Supervision Skills", "3", "995"},
        {"Hostage Negotiation", "5", "1295"},
        {"How to Interview & get the job,", "1", "395"}
    }
    Const WorkShopName As Integer = 0
    Const WorkShopDays As Integer = 1
    Const WorkShopPrice As Integer = 2

    Dim LocationList(,) As String = {
        {"Austin", 95},
        {"Chicago", 125},
        {"Dallas", 110},
        {"Orlando", 100},
        {"Phoenix", 92},
        {"Raleigh", 90}
    }

    Const LocationName As Integer = 0
    Const LocationDailyFee As Integer = 1

    Private Sub WorkShopForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer

        For i = 0 To workShopList.GetLength(WorkShopName) - 1
            lsWorkShop.Items.Add(workShopList(i, WorkShopName))
        Next

        For i = 0 To LocationList.GetLength(LocationName) - 1
            lsLocation.Items.Add(LocationList(i, LocationName))
        Next

        totalFees = 0
    End Sub

    Private Sub btnAddWorkshop_Click(sender As Object, e As EventArgs) Handles btnAddWorkshop.Click
        If lsWorkShop.SelectedIndex = -1 Or lsLocation.SelectedIndex = -1 Then
            MsgBox("Must pick both a Workshop AND Location")
        Else
            Dim workshopSelection As Integer = lsWorkShop.SelectedIndex
            Dim name As String = workShopList(workshopSelection, WorkShopName)
            Dim days As Integer = CInt(workShopList(workshopSelection, WorkShopDays))
            Dim regestration As Double = CDbl(workShopList(workshopSelection, WorkShopPrice))

            Dim locationSelection = lsLocation.SelectedIndex
            Dim location As String = LocationList(locationSelection, LocationDailyFee)
            Dim lodgingFee As Double = CDbl(LocationList(locationSelection, LocationDailyFee))

            Dim lodgingTotal As Double = days * lodgingFee
            Dim worksShopCost As Double = regestration + lodgingFee
            totalFees = totalFees + worksShopCost
            lblTotal.Text = ""
            Dim thisWorkshopIndex = lsCosts.Items.Count
            lsCosts.Items.Add(name)
            lsCosts.Items.Add("Registration: " & FormatCurrency(regestration))
            lsCosts.Items.Add("Location: " & location)
            lsCosts.Items.Add(days & " Days at " & FormatCurrency(lodgingFee))
            lsCosts.Items.Add("Lodging Fees:" & FormatCurrency(lodgingTotal))
            lsCosts.Items.Add("This Workshop: " & FormatCurrency(worksShopCost))
            lsCosts.Items.Add("")
            lsCosts.SelectedIndex = thisWorkshopIndex

            lsWorkShop.SelectedIndex = -1
            lsLocation.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        lblTotal.Text = FormatCurrency(totalFees)
    End Sub

    Private Sub btnRest_Click(sender As Object, e As EventArgs) Handles btnRest.Click
        totalFees = 0
        lblTotal.Text = String.Empty
        lsCosts.Items.Clear()
        lsWorkShop.SelectedIndex = -1
        lsLocation.SelectedIndex = -1
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class

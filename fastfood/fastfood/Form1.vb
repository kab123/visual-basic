Public Class frmFastFood
    Const TAX_RATE As Decimal = 0.0875D
    Const PRICE_CHEESEBURGER As Decimal = 2.75D
    Const PRICE_PHILLY As Decimal = 3.25D
    Const PRICE_CHICKEN As Decimal = 2.49D
    Const PRICE_CHEESE As Decimal = 0.1D
    Const PRICE_BACON As Decimal = 0.2D
    Const PRICE_DRINKS As Decimal = 1.25D
    Const PRICE_FRIES As Decimal = 1.29D
    Const PRICE_RINGS As Decimal = 2.3D

    Dim subtotal As Decimal
    Dim tax As Decimal
    Dim total As Decimal

    Private Sub frmFastFood_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitializeVariables()
        ClearTheCustomerSelections()
        ClearTheRecipt()
    End Sub
    Private Sub InitializeVariables()
        subtotal = 0
        tax = 0
        total = 0
    End Sub
    Private Sub ClearTheCustomerSelections()
        rbNone.Checked = True
        cboxCheese.Checked = False
        cboxBacon.Checked = False
        rbDrinksNone.Checked = True
        cboxFries.Checked = False
        cboxRings.Checked = False
    End Sub
    Private Sub ClearTheRecipt()
        lsOrderRecipt.Items.Clear()
        lsTotal.Items.Clear()
    End Sub
    Private Sub ComputeCurrentSelection()
        If rbBurger.Checked Then
            subtotal += PRICE_CHEESEBURGER
            Dim burgerItem As String = PRICE_CHEESEBURGER.ToString("C") & " CheeseBurger"
            lsOrderRecipt.Items.Add(burgerItem)
        End If
        If rbSteakSandwich.Checked Then
            subtotal += PRICE_PHILLY
            Dim PhillyItem As String = PRICE_PHILLY.ToString("C") & " CheeseSteak"
            lsOrderRecipt.Items.Add(PhillyItem)
        End If
        If rbChickenSandwich.Checked Then
            subtotal += PRICE_CHICKEN
            Dim ChickenSandwichItem As String = PRICE_CHICKEN.ToString("C") & " Chicken Sandwich"
            lsOrderRecipt.Items.Add(ChickenSandwichItem)
        End If
        If cboxCheese.Checked Then
            subtotal += PRICE_CHEESE
            Dim cheeseItem As String = PRICE_CHEESE.ToString("C") & " Cheese"
            lsOrderRecipt.Items.Add(cheeseItem)
        End If
        If cboxBacon.Checked Then
            subtotal += PRICE_BACON
            Dim baconItem As String = PRICE_BACON.ToString("C") & " Bacon"
            lsOrderRecipt.Items.Add(baconItem)
        End If
        If rbCoke.Checked Or rbOrangeSoda.Checked Or rbBeer.Checked Then
            subtotal += PRICE_DRINKS
            Dim drinkItem As String = PRICE_DRINKS.ToString("C") & " Drink"
            lsOrderRecipt.Items.Add(drinkItem)
        End If
        If cboxFries.Checked Then
            subtotal += PRICE_FRIES
            Dim fryItem As String = PRICE_FRIES.ToString("C") & " Fry"
            lsOrderRecipt.Items.Add(fryItem)
        End If
        If cboxRings.Checked Then
            subtotal += PRICE_RINGS
            Dim ringsItem As String = PRICE_FRIES.ToString("C") & " Onion Rings"
            lsOrderRecipt.Items.Add(ringsItem)
        End If
    End Sub

    Private Sub updateTotal()
        lsTotal.Items.Clear()
        lsTotal.Items.Add("Sub Total: " & subtotal.ToString("C"))
        tax = subtotal * TAX_RATE
        lsTotal.Items.Add("Tax: " & tax.ToString("C"))
        total = subtotal + tax
        lsTotal.Items.Add("Total: " & total.ToString("C"))
        lsOrderRecipt.Items.Add("-------------------------")
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ComputeCurrentSelection()
        updateTotal()
        ClearTheCustomerSelections()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        InitializeVariables()
        ClearTheCustomerSelections()
        ClearTheRecipt()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

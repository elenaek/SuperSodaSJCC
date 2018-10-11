Public Module StudentCode
    Public totalDeposit As Integer
    Public change As Integer
    Public colaAmt As Integer
    Public limeAmt As Integer
    Public rootAmt As Integer
    Public waterAmt As Integer
    ' Names and prices of sodas. NOTE: the prices are stated in cents  125 = $1.25
    Public SodaName() As String = {"", "Cola", "Lemon Lime", "Root Beer", "Water"}
    Public SodaPrice() As Integer = {0, 125, 115, 115, 85}

    ' Current amount deposited - expressed in cents  (100 = $1.00)
    Public intDeposit As Integer = 0

    Public Sub CoinDeposited(ByVal CoinValue As Integer)
        ' Put code here to process each coin that is deposited.
        ' Update the current amount being deposited and call
        ' the DisplayDepositAmount() routine to display the amount
        ' deposited.

        totalDeposit += CoinValue
        DisplayDepositAmount(totalDeposit)

    End Sub

    Public Sub BillDeposited(ByVal BillValue As Integer)
        ' Put code here to process each dollar bill that is deposited
        totalDeposit += BillValue
        DisplayDepositAmount(totalDeposit)
    End Sub

    Public Sub ButtonPressed(ByVal ButtonNumber As Integer)
        ' Put code here to process a soda selection button being clicked
        Select Case ButtonNumber

            Case 1
                If totalDeposit = 125 Then
                    DropSoda(1)
                    colaAmt += 1
                ElseIf totalDeposit > 125 Then
                    DropSoda(1)
                    change += totalDeposit - 125
                    colaAmt += 1
                Else
                    MsgBox("Not enough currency deposited!")
                End If


            Case 2
                If totalDeposit = 115 Then
                    DropSoda(2)
                    limeAmt += 1
                ElseIf totalDeposit > 115 Then
                    DropSoda(2)
                    change += totalDeposit - 115
                    limeAmt += 1
                Else
                    MsgBox("Not enough currency deposited!")
                End If


            Case 3
                If totalDeposit = 115 Then
                    DropSoda(3)
                    rootAmt += 1
                ElseIf totalDeposit > 115 Then
                    DropSoda(3)
                    change += totalDeposit - 115
                    rootAmt += 1
                Else
                    MsgBox("Not enough currency deposited!")
                End If


            Case 4
                If totalDeposit = 85 Then
                    DropSoda(4)
                    waterAmt += 1
                ElseIf totalDeposit > 85 Then
                    DropSoda(4)
                    change += totalDeposit - 85
                    waterAmt += 1
                Else
                    MsgBox("Not enough currency deposited!")
                End If
        End Select

        totalDeposit = 0
        DisplayDepositAmount(0)

        While change > 0
            Select Case change > 0
                Case change Mod 25 = 0
                    DropQuarter()
                    change -= 25

                Case change Mod 10 = 0
                    DropDime()
                    change -= 10

                Case change Mod 5 = 0
                    DropNickle()
                    change -= 5
            End Select

        End While

    End Sub

    Public Sub mnuPrint()
        ' Put code here to print a report of items sold and total revenue
        frmSoda.prntReport.Print()
    End Sub

    Public Sub mnuExit()
        frmSoda.Close()
    End Sub

    Public Sub mnuSalesReport()
        ' Put code here to display the items sold and total revenue
        Dim revenueShow As String = FormatCurrency(calculateSalesRevenue() / 100, 2)
        MsgBox("Amount of Cola sold: " & colaAmt & vbCrLf & "Amount of Lemon Lime sold: " & limeAmt & vbCrLf & "Amount of Root Beer sold: " & rootAmt & vbCrLf &
               "Amount of Water sold: " & waterAmt & vbCrLf & vbCrLf & "Sales Revenue: " & revenueShow)

    End Sub

    Public Sub mnuInstructions()
        ' Put code here to display a form that gives instructions
        ' to the user on how to use the soda machine

        MsgBox("Step 1: Insert Bills or Coins until you have deposited enough for the drink that you desire." &
               vbCrLf & "Step 2: Press on the button of your chosen drink. " & vbCrLf & "Step 3: Take drink and change. " & vbCrLf & "Step 4: Enjoy. ")
    End Sub

    Public Sub mnuAbout()
        ' Put code here to display an "About Box" that gives the name
        ' of the project, the instructor's name, your name, and the 
        ' date the project was completed
        Dim aboutbox As New abtSoda
        aboutbox.Show()



    End Sub

    Public Function calculateSalesRevenue()
        Dim revenue As Integer
        revenue += colaAmt * 125
        revenue += limeAmt * 115
        revenue += rootAmt * 115
        revenue += waterAmt * 85

        Return revenue
    End Function
End Module

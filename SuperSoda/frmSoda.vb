Public Class frmSoda

    Private Sub frmSuperSoda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Create sodas and place in each dispenser column
        CreateSodas(Me, 1, grpCol1) ' The sodas and prices are 
        CreateSodas(Me, 2, grpCol2) '   defined in the StudentCode module
        CreateSodas(Me, 3, grpCol3)
        CreateSodas(Me, 4, grpCol4)
        CreateCoins(Me, Nickles, 5, 360, "Nickle.bmp")
        CreateCoins(Me, Dimes, 10, 400, "Dime.bmp")
        CreateCoins(Me, Quarters, 25, 440, "Quarter.bmp")
        CreateBills(Me, Dollars, 100, 480, "Dollar.bmp")

        ' Put the soda names and prices on each button
        btnCol1.Text = SodaName(1) & ControlChars.CrLf & FormatCurrency(SodaPrice(1) / 100, 2)
        btnCol2.Text = SodaName(2) & ControlChars.CrLf & FormatCurrency(SodaPrice(2) / 100, 2)
        btnCol3.Text = SodaName(3) & ControlChars.CrLf & FormatCurrency(SodaPrice(3) / 100, 2)
        btnCol4.Text = SodaName(4) & ControlChars.CrLf & FormatCurrency(SodaPrice(4) / 100, 2)
    End Sub

    Private Sub CreateSodas(ByVal frmSuperSoda As Control, _
                            ByVal ColumnNumber As Integer, _
                            ByVal grpSodaList As GroupBox)
        Dim i As Integer
        For i = 1 To MaxSodasInDispenser
            ' Put a soda in the column
            SodaColumn(ColumnNumber, i) = New clsSodaCan(grpSodaList, ColumnNumber, i)
            ' Count the number of sodas in the column
            SodasInColumn(ColumnNumber) = i
        Next i
    End Sub

    Private Sub CreateCoins(ByVal frmSuperSoda As Control, _
                            ByRef CoinArray() As clsCoin, _
                            ByRef CoinValue As Integer, _
                            ByRef CoinXloc As Integer, _
                            ByRef CoinImage As String)
        Dim i As Integer
        Dim CoinYloc As Integer
        For i = 1 To MaxCoinsOfType
            CoinYloc = 366 - i * 12 ' Stack coins one on top of another
            CoinArray(i) = New clsCoin(Me, CoinValue, CoinXloc, CoinYloc, CoinImage)
        Next
    End Sub

    Private Sub CreateBills(ByVal frmSuperSoda As Control, _
                         ByRef BillArray() As clsBill, _
                         ByRef BillValue As Integer, _
                         ByRef BillXloc As Integer, _
                         ByRef BillImage As String)
        Dim i As Integer
        Dim BillYloc As Integer
        For i = 1 To MaxCoinsOfType
            BillYloc = 366 - i * 12 ' stack bills one on top of another
            BillArray(i) = New clsBill(Me, BillValue, BillXloc, BillYloc, BillImage)
        Next
    End Sub

    ' Process the button clicks for the four selections

    Private Sub btnCol1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCol1.Click
        CoinsInChangeSlot = 0   ' Display coins from the left edge of change slot
        ButtonPressed(1)        ' Call the student's routine
    End Sub

    Private Sub btnCol2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCol2.Click
        CoinsInChangeSlot = 0   ' Display coins from the left edge of change slot
        ButtonPressed(2)        ' Call the student's routine
    End Sub

    Private Sub btnCol3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCol3.Click
        CoinsInChangeSlot = 0   ' Display coins from the left edge of change slot
        ButtonPressed(3)        ' Call the student's routine
    End Sub

    Private Sub btnCol4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCol4.Click
        CoinsInChangeSlot = 0   ' Display coins from the left edge of change slot
        ButtonPressed(4)        ' Call the student's routine
    End Sub

    Private Sub tmrDropSoda_Tick(ByRef SodaTimer As Timer, _
                             ByRef ColumnNumber As Integer, _
                             ByRef SodaButton As Button)
        Dim SodaPosition As Point
        Dim i As Integer

        ' Drop each soda in the dispenser down one position
        For i = 1 To SodasInColumn(ColumnNumber)
            SodaPosition = SodaColumn(ColumnNumber, i).Postiton
            SodaPosition.Y += 4
            SodaColumn(ColumnNumber, i).Postiton = SodaPosition

            ' When the bottom soda has completly fallen,
            '    there is one less soda to drop
            '    put a soda in the dispenser
            '    stop dropping sodas by disabling the timer
            If i = SodasInColumn(ColumnNumber) And SodaPosition.Y > grpCol1.Height Then
                SodasInColumn(ColumnNumber) -= 1
                ' Create a soda and put it in the dispenser box
                Dim SodaCan As PictureBox = New System.Windows.Forms.PictureBox
                grpProduct.Controls.Add(SodaCan)
                SodaCan.Location = New Point(Rnd() * 40, Rnd() * 25)
                SodaCan.ImageLocation = ImagePath & SodaName(ColumnNumber) & ".bmp"
                SodaCan.Height = 32
                SodaCan.Width = 22
                SodaCan.Tag = -1
                SodaCan.BringToFront()
                AddHandler SodaCan.Click, AddressOf SodaCan_Click
                SodaTimer.Enabled = False
                SodasInDispenser += 1
                lblSodasInDispenser.Text = _
                   "Click soda to remove          " & _
                   SodasInDispenser.ToString()
                lblSodasInDispenser.Visible = True
            End If

            ' If all the sodas are gone,
            '     disable that soda's button
            '     set the button's color darker
            If SodasInColumn(ColumnNumber) = 0 Then
                SodaButton.Enabled = False
                SodaButton.BackColor = Color.Silver
                SodaButton.Text = SodaName(ColumnNumber) & ControlChars.CrLf & "Sold Out"
            End If
        Next i
    End Sub

    Private Sub tmrCol1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCol1.Tick
        tmrDropSoda_Tick(tmrCol1, 1, btnCol1)
    End Sub

    Private Sub tmrCol2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCol2.Tick
        tmrDropSoda_Tick(tmrCol2, 2, btnCol2)
    End Sub

    Private Sub tmrCol3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCol3.Tick
        tmrDropSoda_Tick(tmrCol3, 3, btnCol3)
    End Sub

    Private Sub tmrCol4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCol4.Tick
        tmrDropSoda_Tick(tmrCol4, 4, btnCol4)
    End Sub

    ' The SodaCan_Click event is activated by a mouse click on a soda in the dispenser:
    Public Sub SodaCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.visible = False  ' Soda no longer visible
        SodasInDispenser -= 1   ' One less soda
        lblSodasInDispenser.Text = _
           "Click soda to remove          " & _
           SodasInDispenser.ToString()  ' Update the message
        If SodasInDispenser < 1 Then
            lblSodasInDispenser.Visible = False
        End If
    End Sub

    Private Sub tmrCoinDeposit_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCoinDeposit.Tick
        CoinInDepositSlot.visible = False
        tmrCoinDeposit.Enabled = False
    End Sub

    Private Sub tmrBillDeposit_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBillDeposit.Tick
        BillInDepositSlot.Visible = False
        tmrBillDeposit.Enabled = False
    End Sub

    ' Open a new browser window if the SJCC logo picture is clicked
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        System.Diagnostics.Process.Start("http://www.sjcc.edu/")
    End Sub

    Private Sub PrintMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintMenu.Click
        mnuPrint()
    End Sub

    Private Sub ExitMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitMenu.Click
        mnuExit()
    End Sub

    Private Sub SalesReportMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReportMenu.Click
        mnuSalesReport()
    End Sub

    Private Sub InstructionsMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstructionsMenu.Click
        mnuInstructions()
    End Sub

    Private Sub AboutMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutMenu.Click
        mnuAbout()
    End Sub

    Private Sub lblDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDeposit.Click

    End Sub


    Private Sub prntReport_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim revenueShow As Integer = calculateSalesRevenue()
        Dim drawFont As New Font("Courier", 18)
        Dim drawBrush As New SolidBrush(Color.Black)
        Dim drawFormat As New StringFormat
        e.Graphics.DrawString("Amount of Cola sold: " & colaAmt & vbCrLf & "Amount of Lemon Lime sold: " & limeAmt & vbCrLf & "Amount of Root Beer sold: " & rootAmt & vbCrLf &
               "Amount of Water sold: " & waterAmt & vbCrLf & vbCrLf & "Sales Revenue: " & revenueShow, drawFont, drawBrush, 100, 100, drawFormat)
    End Sub
End Class

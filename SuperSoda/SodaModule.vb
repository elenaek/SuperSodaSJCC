Module modSoda
    Public Const ImagePath As String = ""
    Public Const MaxCoinsOfType = 10
    Public Const MaxSodasInDispenser As Integer = 6
    Public Const ColumnCount As Integer = 4
    Public Const Border_Width As Integer = 12
    Public Const Title_Menu_Height As Integer = 40
    Public SodaColumn(ColumnCount, MaxSodasInDispenser) As clsSodaCan

    ' Set default Soda Type and Price
    Public SodasInColumn(ColumnCount) As Integer
    Public SodasInDispenser As Integer = 0
    Public CoinsInChangeSlot As Integer = 0
    Public Const SodaDispenserYdelta As Integer = 43

    Public Nickles(MaxCoinsOfType) As clsCoin
    Public Dimes(MaxCoinsOfType) As clsCoin
    Public Quarters(MaxCoinsOfType) As clsCoin
    Public Dollars(MaxCoinsOfType) As clsBill
    Public CoinInDepositSlot As PictureBox
    Public BillInDepositSlot As PictureBox

    Public Enum SodaStateEnum
        SodaInColumn
        SodaInDispenser
    End Enum

    Public Sub DisplayDepositAmount(ByRef DepositAmount As Integer)
        frmSoda.lblDeposit.Text = FormatCurrency(DepositAmount / 100, 2)
    End Sub

    Public Sub DropNickle()
        DropCoin(5)
    End Sub

    Public Sub DropDime()
        DropCoin(10)
    End Sub

    Public Sub DropQuarter()
        DropCoin(25)
    End Sub

    Private Sub DropCoin(ByVal Value As Integer)
        Dim CoinImage As String = ""
        Dim Coin As clsCoin
        Dim Xloc As Integer
        Dim Yloc As Integer

        Select Case Value
            Case 5
                CoinImage = "Nickle.bmp"
            Case 10
                CoinImage = "Dime.bmp"
            Case 25
                CoinImage = "Quarter.bmp"
        End Select

        Xloc = frmSoda.lblChange.Location.X + Border_Width + (CoinsInChangeSlot Mod 7) * 12 + 10
        Yloc = frmSoda.lblChange.Location.Y + Title_Menu_Height + (CoinsInChangeSlot Mod 7) * 3 + 2
        CoinsInChangeSlot += 1
        Coin = New clsCoin(frmSoda, Value, Xloc, Yloc, CoinImage)
    End Sub

    Public Sub DropSoda(ByRef ButtonNumber As Integer)
        Select Case ButtonNumber
            Case 1
                frmSoda.tmrCol1.Enabled = True
            Case 2
                frmSoda.tmrCol2.Enabled = True
            Case 3
                frmSoda.tmrCol3.Enabled = True
            Case 4
                frmSoda.tmrCol4.Enabled = True
        End Select
    End Sub

End Module

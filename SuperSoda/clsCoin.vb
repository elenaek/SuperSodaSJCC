Public Class clsCoin
    Private picCoin As PictureBox
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private CoinMove As Boolean = False

    ' Code for creating a new coin
    Public Sub New(ByRef frmSoda As Control, _
                    ByRef CoinValue As Integer, _
                    ByRef Xposition As Integer, _
                    ByRef Yposition As Integer, _
                    ByRef CoinImage As String)
        picCoin = New System.Windows.Forms.PictureBox
        picCoin.ImageLocation = ImagePath & CoinImage
        picCoin.Height = 27
        picCoin.Width = 27
        picCoin.Tag = CoinValue
        picCoin.Location = New Point(Xposition, Yposition)
        frmSoda.Controls.Add(picCoin)
        picCoin.BringToFront()
        AddHandler picCoin.MouseDown, AddressOf Coin_MouseDown
        AddHandler picCoin.MouseMove, AddressOf Coin_MouseMove
        AddHandler picCoin.MouseUp, AddressOf Coin_MouseUp
    End Sub

    ' When the mouse button is first pressed, record the mouse location
    Public Sub Coin_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        MouseDownX = e.X
        MouseDownY = e.Y
        CoinMove = True
        sender.bringtofront()
    End Sub

    ' Make the coin follow the mouse location
    Public Sub Coin_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim CoinPosition As Point = sender.Location
        If CoinMove Then
            CoinPosition.X += e.X - MouseDownX
            CoinPosition.Y += e.Y - MouseDownY
            sender.Location = CoinPosition
        End If
    End Sub

    ' When the mouse is released, see if the coin is in the coin slot
    Public Sub Coin_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim CoinPosition As Point = sender.Location
        Dim CoinDepositLocation As Point = frmSoda.lblCoins.Location
        ' Adjust Deposit location to include border, titlebar and menubar
        CoinDepositLocation.X += Border_Width
        CoinDepositLocation.Y += Title_Menu_Height

        Dim CoinValue As Integer = sender.tag
        If CoinPosition.X >= CoinDepositLocation.X And _
           CoinPosition.X <= CoinDepositLocation.X + frmSoda.lblCoins.Width - 20 And _
           CoinPosition.Y >= CoinDepositLocation.Y And _
           CoinPosition.Y <= CoinDepositLocation.Y + frmSoda.lblCoins.Height - 20 Then

            CoinDeposited(CoinValue)

            ' Give 200 ms. before the coin disappears
            CoinInDepositSlot = sender
            frmSoda.tmrCoinDeposit.Enabled = True
        End If
        CoinMove = False
    End Sub

End Class

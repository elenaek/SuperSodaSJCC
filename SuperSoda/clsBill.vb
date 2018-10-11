Public Class clsBill
    Private picBill As PictureBox
    Private intValue As Integer

    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private BillMove As Boolean = False

    ' Code for creating a bill and putting it on the screen
    Public Sub New(ByRef frmSoda As Control, _
                    ByRef BillValue As Integer, _
                    ByRef Xposition As Integer, _
                    ByRef Yposition As Integer, _
                    ByRef BillImage As String)
        intValue = BillValue
        picBill = New System.Windows.Forms.PictureBox
        picBill.ImageLocation = ImagePath & BillImage
        picBill.Height = 60
        picBill.Width = 32
        picBill.Tag = BillValue
        picBill.Location = New Point(Xposition, Yposition)
        frmSoda.Controls.Add(picBill)
        picBill.BringToFront()
        AddHandler picBill.MouseDown, AddressOf Bill_MouseDown
        AddHandler picBill.MouseMove, AddressOf Bill_MouseMove
        AddHandler picBill.MouseUp, AddressOf Bill_MouseUp
    End Sub

    ' Record the bill's position when the mouse button is first down
    Public Sub Bill_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        MouseDownX = e.X
        MouseDownY = e.Y
        BillMove = True
        sender.bringtofront()
    End Sub

    ' Make the bill's location follow the mouse's location
    Public Sub Bill_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim BillPosition As Point = sender.Location
        If BillMove Then
            BillPosition.X += e.X - MouseDownX
            BillPosition.Y += e.Y - MouseDownY
            sender.Location = BillPosition
        End If
    End Sub

    ' When the mouse is released, see if the bill is in the bill slot
    Public Sub Bill_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim BillPosition As Point = sender.Location
        Dim BillDepositLocation As Point = frmSoda.lblBills.Location
        ' Adjust Deposit location to include border, titlebar and menubar
        BillDepositLocation.X += Border_Width
        BillDepositLocation.Y += Title_Menu_Height

        Dim BillValue As Integer = sender.tag
        If BillPosition.X >= BillDepositLocation.X And _
           BillPosition.X <= BillDepositLocation.X + frmSoda.lblCoins.Width - 20 And _
           BillPosition.Y >= BillDepositLocation.Y And _
           BillPosition.Y <= BillDepositLocation.Y + frmSoda.lblCoins.Height - 20 Then

            BillDeposited(BillValue)

            ' Give 200 ms. before the bill disappears
            BillInDepositSlot = sender
            frmSoda.tmrBillDeposit.Enabled = True
        End If
        BillMove = False
    End Sub
End Class

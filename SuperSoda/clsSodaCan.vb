Public Class clsSodaCan
    Private SodaCan As PictureBox
    Private SodaCanState As SodaStateEnum = SodaStateEnum.SodaInDispenser

    ' Code to create a soda can or water bottle
    Public Sub New(ByRef grpSodaDispenser As GroupBox, ByVal ColumnNumber As Integer, ByRef CanNumber As Integer)
        SodaCan = New System.Windows.Forms.PictureBox
        grpSodaDispenser.Controls.Add(SodaCan)
        SodaCan.Location = New Point(8, 8 + (CanNumber - 1) * SodaDispenserYdelta)
        SodaCan.ImageLocation = ImagePath & SodaName(ColumnNumber) & ".bmp"
        SodaCan.Height = 32
        SodaCan.Width = 22
        SodaCan.Tag = CanNumber
    End Sub

    ' Return or set the location of a soda can or water bottle
    Public Property Postiton() As Point
        Get
            Return SodaCan.Location
        End Get
        Set(ByVal value As Point)
            SodaCan.Location = value
        End Set
    End Property

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSoda))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblSodasInDispenser = New System.Windows.Forms.Label()
        Me.grpProduct = New System.Windows.Forms.GroupBox()
        Me.grpCol4 = New System.Windows.Forms.GroupBox()
        Me.grpCol3 = New System.Windows.Forms.GroupBox()
        Me.grpCol2 = New System.Windows.Forms.GroupBox()
        Me.grpCol1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblBills = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCoins = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.btnCol4 = New System.Windows.Forms.Button()
        Me.btnCol3 = New System.Windows.Forms.Button()
        Me.btnCol2 = New System.Windows.Forms.Button()
        Me.btnCol1 = New System.Windows.Forms.Button()
        Me.tmrCol1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCol2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCol3 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCol4 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrCoinDeposit = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBillDeposit = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.prntReport = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox1.Controls.Add(Me.lblChange)
        Me.GroupBox1.Controls.Add(Me.lblSodasInDispenser)
        Me.GroupBox1.Controls.Add(Me.grpProduct)
        Me.GroupBox1.Controls.Add(Me.grpCol4)
        Me.GroupBox1.Controls.Add(Me.grpCol3)
        Me.GroupBox1.Controls.Add(Me.grpCol2)
        Me.GroupBox1.Controls.Add(Me.grpCol1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblBills)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblCoins)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblDeposit)
        Me.GroupBox1.Controls.Add(Me.btnCol4)
        Me.GroupBox1.Controls.Add(Me.btnCol3)
        Me.GroupBox1.Controls.Add(Me.btnCol2)
        Me.GroupBox1.Controls.Add(Me.btnCol1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 40)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(327, 367)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblChange
        '
        Me.lblChange.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChange.Location = New System.Drawing.Point(218, 312)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(96, 40)
        Me.lblChange.TabIndex = 35
        '
        'lblSodasInDispenser
        '
        Me.lblSodasInDispenser.Location = New System.Drawing.Point(9, 301)
        Me.lblSodasInDispenser.Name = "lblSodasInDispenser"
        Me.lblSodasInDispenser.Size = New System.Drawing.Size(60, 42)
        Me.lblSodasInDispenser.TabIndex = 34
        Me.lblSodasInDispenser.Text = "Click soda to remove          1"
        Me.lblSodasInDispenser.Visible = False
        '
        'grpProduct
        '
        Me.grpProduct.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.grpProduct.Location = New System.Drawing.Point(75, 298)
        Me.grpProduct.Name = "grpProduct"
        Me.grpProduct.Size = New System.Drawing.Size(62, 55)
        Me.grpProduct.TabIndex = 32
        Me.grpProduct.TabStop = False
        '
        'grpCol4
        '
        Me.grpCol4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.grpCol4.Location = New System.Drawing.Point(157, 19)
        Me.grpCol4.Name = "grpCol4"
        Me.grpCol4.Size = New System.Drawing.Size(41, 262)
        Me.grpCol4.TabIndex = 31
        Me.grpCol4.TabStop = False
        '
        'grpCol3
        '
        Me.grpCol3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.grpCol3.Location = New System.Drawing.Point(110, 19)
        Me.grpCol3.Name = "grpCol3"
        Me.grpCol3.Size = New System.Drawing.Size(41, 262)
        Me.grpCol3.TabIndex = 30
        Me.grpCol3.TabStop = False
        '
        'grpCol2
        '
        Me.grpCol2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.grpCol2.Location = New System.Drawing.Point(63, 19)
        Me.grpCol2.Name = "grpCol2"
        Me.grpCol2.Size = New System.Drawing.Size(41, 262)
        Me.grpCol2.TabIndex = 29
        Me.grpCol2.TabStop = False
        '
        'grpCol1
        '
        Me.grpCol1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.grpCol1.Location = New System.Drawing.Point(16, 19)
        Me.grpCol1.Name = "grpCol1"
        Me.grpCol1.Size = New System.Drawing.Size(41, 262)
        Me.grpCol1.TabIndex = 28
        Me.grpCol1.TabStop = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(165, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 18)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Change"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBills
        '
        Me.lblBills.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblBills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBills.Image = CType(resources.GetObject("lblBills.Image"), System.Drawing.Image)
        Me.lblBills.Location = New System.Drawing.Point(260, 274)
        Me.lblBills.Name = "lblBills"
        Me.lblBills.Size = New System.Drawing.Size(50, 20)
        Me.lblBills.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(215, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 18)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Bills"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCoins
        '
        Me.lblCoins.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblCoins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCoins.Location = New System.Drawing.Point(260, 232)
        Me.lblCoins.Name = "lblCoins"
        Me.lblCoins.Size = New System.Drawing.Size(50, 40)
        Me.lblCoins.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(216, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Coins"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDeposit
        '
        Me.lblDeposit.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblDeposit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeposit.ForeColor = System.Drawing.Color.Red
        Me.lblDeposit.Location = New System.Drawing.Point(229, 195)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(81, 24)
        Me.lblDeposit.TabIndex = 20
        Me.lblDeposit.Text = "$0.00"
        Me.lblDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCol4
        '
        Me.btnCol4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCol4.Location = New System.Drawing.Point(229, 146)
        Me.btnCol4.Name = "btnCol4"
        Me.btnCol4.Size = New System.Drawing.Size(81, 35)
        Me.btnCol4.TabIndex = 19
        Me.btnCol4.Text = "&Water"
        Me.btnCol4.UseVisualStyleBackColor = False
        '
        'btnCol3
        '
        Me.btnCol3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCol3.Location = New System.Drawing.Point(229, 105)
        Me.btnCol3.Name = "btnCol3"
        Me.btnCol3.Size = New System.Drawing.Size(81, 35)
        Me.btnCol3.TabIndex = 18
        Me.btnCol3.Text = "&Root Beer"
        Me.btnCol3.UseVisualStyleBackColor = False
        '
        'btnCol2
        '
        Me.btnCol2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCol2.Location = New System.Drawing.Point(229, 64)
        Me.btnCol2.Name = "btnCol2"
        Me.btnCol2.Size = New System.Drawing.Size(81, 35)
        Me.btnCol2.TabIndex = 17
        Me.btnCol2.Text = "&Lemon Lime"
        Me.btnCol2.UseVisualStyleBackColor = False
        '
        'btnCol1
        '
        Me.btnCol1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCol1.Location = New System.Drawing.Point(229, 23)
        Me.btnCol1.Name = "btnCol1"
        Me.btnCol1.Size = New System.Drawing.Size(81, 35)
        Me.btnCol1.TabIndex = 16
        Me.btnCol1.Text = "&Cola"
        Me.btnCol1.UseVisualStyleBackColor = False
        '
        'tmrCol1
        '
        Me.tmrCol1.Interval = 30
        '
        'tmrCol2
        '
        Me.tmrCol2.Interval = 30
        '
        'tmrCol3
        '
        Me.tmrCol3.Interval = 30
        '
        'tmrCol4
        '
        Me.tmrCol4.Interval = 30
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ViewMenu, Me.HelpMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(540, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintMenu, Me.ExitMenu})
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "&File"
        '
        'PrintMenu
        '
        Me.PrintMenu.Name = "PrintMenu"
        Me.PrintMenu.Size = New System.Drawing.Size(137, 22)
        Me.PrintMenu.Text = "Print Report"
        '
        'ExitMenu
        '
        Me.ExitMenu.Name = "ExitMenu"
        Me.ExitMenu.Size = New System.Drawing.Size(137, 22)
        Me.ExitMenu.Text = "E&xit"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesReportMenu})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(44, 20)
        Me.ViewMenu.Text = "&View"
        '
        'SalesReportMenu
        '
        Me.SalesReportMenu.Name = "SalesReportMenu"
        Me.SalesReportMenu.Size = New System.Drawing.Size(138, 22)
        Me.SalesReportMenu.Text = "Sales Report"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructionsMenu, Me.AboutMenu})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'InstructionsMenu
        '
        Me.InstructionsMenu.Name = "InstructionsMenu"
        Me.InstructionsMenu.Size = New System.Drawing.Size(136, 22)
        Me.InstructionsMenu.Text = "Instructions"
        '
        'AboutMenu
        '
        Me.AboutMenu.Name = "AboutMenu"
        Me.AboutMenu.Size = New System.Drawing.Size(136, 22)
        Me.AboutMenu.Text = "&About"
        '
        'tmrCoinDeposit
        '
        Me.tmrCoinDeposit.Interval = 200
        '
        'tmrBillDeposit
        '
        Me.tmrBillDeposit.Interval = 200
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(377, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 110)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmSoda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 416)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSoda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Soda Machine"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpCol4 As System.Windows.Forms.GroupBox
    Friend WithEvents grpCol3 As System.Windows.Forms.GroupBox
    Friend WithEvents grpCol2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblBills As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCoins As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDeposit As System.Windows.Forms.Label
    Friend WithEvents btnCol4 As System.Windows.Forms.Button
    Friend WithEvents btnCol3 As System.Windows.Forms.Button
    Friend WithEvents btnCol2 As System.Windows.Forms.Button
    Friend WithEvents btnCol1 As System.Windows.Forms.Button
    Friend WithEvents grpProduct As System.Windows.Forms.GroupBox
    Friend WithEvents grpCol1 As System.Windows.Forms.GroupBox
    Friend WithEvents tmrCol1 As System.Windows.Forms.Timer
    Friend WithEvents tmrCol2 As System.Windows.Forms.Timer
    Friend WithEvents tmrCol3 As System.Windows.Forms.Timer
    Friend WithEvents tmrCol4 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesReportMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblSodasInDispenser As System.Windows.Forms.Label
    Friend WithEvents tmrCoinDeposit As System.Windows.Forms.Timer
    Friend WithEvents tmrBillDeposit As System.Windows.Forms.Timer
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PrintMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructionsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents prntReport As System.Drawing.Printing.PrintDocument

End Class

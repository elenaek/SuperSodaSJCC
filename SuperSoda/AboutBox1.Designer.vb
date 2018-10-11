<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abtSoda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lblProgName As System.Windows.Forms.Label
    Friend WithEvents lblInstructor As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents tbDescription As System.Windows.Forms.TextBox
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents lblStudentName As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abtSoda))
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.lblProgName = New System.Windows.Forms.Label()
        Me.lblInstructor = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.tbDescription = New System.Windows.Forms.TextBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.0!))
        Me.TableLayoutPanel.Controls.Add(Me.lblProgName, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.lblInstructor, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.lblStudentName, 1, 2)
        Me.TableLayoutPanel.Controls.Add(Me.lblDate, 1, 3)
        Me.TableLayoutPanel.Controls.Add(Me.tbDescription, 1, 4)
        Me.TableLayoutPanel.Controls.Add(Me.OKButton, 1, 5)
        Me.TableLayoutPanel.Controls.Add(Me.LogoPictureBox, 0, 2)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(9, 9)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 6
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(608, 514)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(3, 97)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.TableLayoutPanel.SetRowSpan(Me.LogoPictureBox, 6)
        Me.LogoPictureBox.Size = New System.Drawing.Size(194, 188)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'lblProgName
        '
        Me.lblProgName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProgName.Location = New System.Drawing.Point(206, 0)
        Me.lblProgName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblProgName.MaximumSize = New System.Drawing.Size(0, 17)
        Me.lblProgName.Name = "lblProgName"
        Me.lblProgName.Size = New System.Drawing.Size(399, 17)
        Me.lblProgName.TabIndex = 0
        Me.lblProgName.Text = "Program Name: Soda Machine Project"
        Me.lblProgName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInstructor
        '
        Me.lblInstructor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblInstructor.Location = New System.Drawing.Point(206, 47)
        Me.lblInstructor.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblInstructor.MaximumSize = New System.Drawing.Size(0, 17)
        Me.lblInstructor.Name = "lblInstructor"
        Me.lblInstructor.Size = New System.Drawing.Size(399, 17)
        Me.lblInstructor.TabIndex = 0
        Me.lblInstructor.Text = "Instructor's Name: Dan McElroy"
        Me.lblInstructor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStudentName
        '
        Me.lblStudentName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStudentName.Location = New System.Drawing.Point(206, 94)
        Me.lblStudentName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblStudentName.MaximumSize = New System.Drawing.Size(0, 17)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(399, 17)
        Me.lblStudentName.TabIndex = 0
        Me.lblStudentName.Text = "Student Name: Keane Le"
        Me.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDate
        '
        Me.lblDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDate.Location = New System.Drawing.Point(206, 141)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblDate.MaximumSize = New System.Drawing.Size(0, 17)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(399, 17)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Date: 5/4/2013"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbDescription
        '
        Me.tbDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbDescription.Location = New System.Drawing.Point(206, 191)
        Me.tbDescription.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.tbDescription.Multiline = True
        Me.tbDescription.Name = "tbDescription"
        Me.tbDescription.ReadOnly = True
        Me.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbDescription.Size = New System.Drawing.Size(399, 231)
        Me.tbDescription.TabIndex = 0
        Me.tbDescription.TabStop = False
        Me.tbDescription.Text = resources.GetString("tbDescription.Text")
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Location = New System.Drawing.Point(530, 446)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "&OK"
        '
        'abtSoda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.OKButton
        Me.ClientSize = New System.Drawing.Size(626, 532)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "abtSoda"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

End Class

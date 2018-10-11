Public NotInheritable Class abtSoda

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.lblProgName.Text = My.Application.Info.ProductName
        Me.lblInstructor.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.lblStudentName.Text = My.Application.Info.Copyright
        Me.lblDate.Text = My.Application.Info.CompanyName
        Me.tbDescription.Text = My.Application.Info.Description
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub TextBoxDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDescription.TextChanged

    End Sub
End Class

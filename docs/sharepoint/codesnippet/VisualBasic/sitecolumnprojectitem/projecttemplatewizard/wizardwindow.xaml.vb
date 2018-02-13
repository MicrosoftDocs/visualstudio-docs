'<Snippet4>
Public Class WizardWindow
    Private firstPage As Page1
    Private secondPage As Page2
    Private Const firstPageLabel As String = "Specify the site and security level for debugging"
    Private Const secondPageLabel As String = "Configure the site column"

    Friend Sub New(ByVal presentationModel As SiteColumnWizardModel)
        InitializeComponent()
        Me.PresentationModel = presentationModel
        firstPage = New Page1(Me)
        secondPage = New Page2(Me)
        secondPage.Visibility = Visibility.Hidden
    End Sub

    Friend Property PresentationModel As SiteColumnWizardModel

    Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
        headingLabel.Content = firstPageLabel
        pageGrid.Children.Add(firstPage)
        pageGrid.Children.Add(secondPage)
    End Sub

    Private Sub nextButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)

        ' Initialize the second wizard page if this is the first time 
        ' it has been shown with the current site URL.
        If Not PresentationModel.IsSecondPagePopulated Then

            If Not ValidateUrl() Then
                Return
            End If

            ' Refresh the UI in the second page.
            secondPage.ClearControls()
            secondPage.PopulateSiteColumnOptions()

            ' Do not do this work again until the user changes the site URL.
            PresentationModel.IsSecondPagePopulated = True
        End If

        ' Display the second wizard page and update related controls.
        firstPage.Visibility = Visibility.Hidden
        secondPage.Visibility = Visibility.Visible
        previousButton.IsEnabled = True
        nextButton.IsEnabled = False
        nextButton.IsDefault = False
        finishButton.IsDefault = True
        headingLabel.Content = secondPageLabel
    End Sub

    ' Display the first wizard page again and update related controls.
    Private Sub previousButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        secondPage.Visibility = Visibility.Hidden
        firstPage.Visibility = Visibility.Visible
        previousButton.IsEnabled = False
        finishButton.IsDefault = False
        nextButton.IsEnabled = True
        nextButton.IsDefault = True
        headingLabel.Content = firstPageLabel
    End Sub

    Private Sub finishButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If ValidateUrl() Then
            DialogResult = True
            Close()
        End If
    End Sub

    Private Function ValidateUrl() As Boolean
        Dim errorMessage As String = String.Empty
        If Not PresentationModel.ValidateCurrentUrl(errorMessage) Then
            MessageBox.Show(String.Format("Cannot connect to the SharePoint site: {0}. {1}",
                PresentationModel.CurrentSiteUrl, errorMessage),
                "SharePoint Connection Error")
            Return False
        End If
        Return True
    End Function
End Class
'</Snippet4>

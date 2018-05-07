'<Snippet2>
Public Class Page1
    Private mainWindow As WizardWindow

    Friend Sub New(ByVal mainWindow As WizardWindow)
        Me.mainWindow = mainWindow
        InitializeComponent()
    End Sub

    Private Sub UserControl_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If (mainWindow.PresentationModel.IsSandboxed) Then
            sandboxedSolutionRadioButton.IsChecked = True
        Else
            sandboxedSolutionRadioButton.IsEnabled = False
            farmSolutionRadioButton.IsChecked = True
        End If
        siteUrlTextBox.Text = mainWindow.PresentationModel.CurrentSiteUrl
    End Sub

    ' Validate that the URL exists on the development computer.
    Private Sub validateButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim errorMessage As String = String.Empty
        validateButton.IsEnabled = False

        If Not mainWindow.PresentationModel.ValidateCurrentUrl(errorMessage) Then
            MessageBox.Show(String.Format("Cannot connect to the SharePoint site: {0}. {1}",
                mainWindow.PresentationModel.CurrentSiteUrl, errorMessage),
                "SharePoint Connection Error")
        Else
            MessageBox.Show("Successfully connected to SharePoint site " +
                mainWindow.PresentationModel.CurrentSiteUrl, "Connection Successful")
        End If
        validateButton.IsEnabled = True
    End Sub

    ' Prevent users from finishing the wizard if the URL is not formatted correctly.
    Private Sub siteUrlTextBox_TextChanged(ByVal sender As Object, ByVal e As TextChangedEventArgs)
        Dim url As String = EnsureTrailingSlash(siteUrlTextBox.Text)

        ' Perform some basic error-checking on the URL here.
        If url.Length > 0 AndAlso Uri.IsWellFormedUriString(Uri.EscapeUriString(url), UriKind.Absolute) Then

            mainWindow.finishButton.IsEnabled = True
            mainWindow.nextButton.IsEnabled = True
            validateButton.IsEnabled = True
            mainWindow.PresentationModel.CurrentSiteUrl = url
            mainWindow.PresentationModel.IsSecondPagePopulated = False
        Else
            mainWindow.finishButton.IsEnabled = False
            mainWindow.nextButton.IsEnabled = False
            validateButton.IsEnabled = False
        End If
    End Sub

    Private Sub sandboxedSolutionRadioButton_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        mainWindow.PresentationModel.IsSandboxed = CBool(sandboxedSolutionRadioButton.IsChecked)
    End Sub

    Private Sub farmSolutionRadioButton_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        mainWindow.PresentationModel.IsSandboxed = CBool(sandboxedSolutionRadioButton.IsChecked)
    End Sub

    Private Function EnsureTrailingSlash(ByVal url As String)
        If Not String.IsNullOrEmpty(url) AndAlso url(url.Length - 1) <> "/" Then
            url += "/"
        End If
        Return url
    End Function
End Class
'</Snippet2>

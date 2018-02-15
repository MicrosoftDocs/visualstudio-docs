//<Snippet2>
using System;
using System.Windows;
using System.Windows.Controls;

namespace ProjectTemplateWizard
{
    public partial class Page1 : UserControl
    {
        private WizardWindow mainWindow;

        internal Page1(WizardWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (mainWindow.PresentationModel.IsSandboxed)
            {
                sandboxedSolutionRadioButton.IsChecked = true;
            }
            else
            {
                sandboxedSolutionRadioButton.IsEnabled = false;
                farmSolutionRadioButton.IsChecked = true;
            }

            siteUrlTextBox.Text = mainWindow.PresentationModel.CurrentSiteUrl;
        }

        // Validate that the URL exists on the development computer.
        private void validateButton_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage;
            validateButton.IsEnabled = false;

            if (!mainWindow.PresentationModel.ValidateCurrentUrl(out errorMessage))
            {
                MessageBox.Show(String.Format("Cannot connect to the SharePoint site: {0}. {1}",
                    mainWindow.PresentationModel.CurrentSiteUrl, errorMessage),
                    "SharePoint Connection Error");
            }
            else
            {
                MessageBox.Show("Successfully connected to SharePoint site " +
                    mainWindow.PresentationModel.CurrentSiteUrl, "Connection Successful");
            }

            validateButton.IsEnabled = true;
        }

        // Prevent users from finishing the wizard if the URL is not formatted correctly.
        private void siteUrlTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string url = EnsureTrailingSlash(siteUrlTextBox.Text);

            // Perform some basic error-checking on the URL here.
            if ((url.Length > 0) && (Uri.IsWellFormedUriString(Uri.EscapeUriString(url), UriKind.Absolute)))
            {
                mainWindow.finishButton.IsEnabled = true;
                mainWindow.nextButton.IsEnabled = true;
                validateButton.IsEnabled = true;
                mainWindow.PresentationModel.CurrentSiteUrl = url;
                mainWindow.PresentationModel.IsSecondPagePopulated = false;
            }
            else
            {
                mainWindow.finishButton.IsEnabled = false;
                mainWindow.nextButton.IsEnabled = false;
                validateButton.IsEnabled = false;
            }
        }

        private void sandboxedSolutionRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            mainWindow.PresentationModel.IsSandboxed = (bool)sandboxedSolutionRadioButton.IsChecked;
        }

        private void farmSolutionRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            mainWindow.PresentationModel.IsSandboxed = (bool)sandboxedSolutionRadioButton.IsChecked;
        }

        private string EnsureTrailingSlash(string url)
        {
            if (!String.IsNullOrEmpty(url)
                && url[url.Length - 1] != '/')
            {
                url += '/';
            }
            return url;
        }
    }
}
//</Snippet2>


//<Snippet4>
using System;
using System.Windows;
using Microsoft.VisualStudio.PlatformUI;

namespace ProjectTemplateWizard
{
    public partial class WizardWindow : DialogWindow
    {
        private Page1 firstPage;
        private Page2 secondPage;
        private const string firstPageLabel = "Specify the site and security level for debugging";
        private const string secondPageLabel = "Configure the site column";

        internal WizardWindow(SiteColumnWizardModel presentationModel)
        {
            InitializeComponent();
            this.PresentationModel = presentationModel;
            firstPage = new Page1(this);
            secondPage = new Page2(this);
            secondPage.Visibility = Visibility.Hidden;
        }

        internal SiteColumnWizardModel PresentationModel { get; set; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            headingLabel.Content = firstPageLabel;
            pageGrid.Children.Add(firstPage);
            pageGrid.Children.Add(secondPage);
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            // Initialize the second wizard page if this is the first time 
            // it has been shown with the current site URL.
            if (!PresentationModel.IsSecondPagePopulated)
            {
                if (!ValidateUrl())
                {
                    return;
                }

                // Refresh the UI in the second page.
                secondPage.ClearControls();
                secondPage.PopulateSiteColumnOptions();

                // Do not do this work again until the user changes the site URL.
                PresentationModel.IsSecondPagePopulated = true;
            }

            // Display the second wizard page and update related controls.
            firstPage.Visibility = Visibility.Hidden;
            secondPage.Visibility = Visibility.Visible;
            previousButton.IsEnabled = true;
            nextButton.IsEnabled = false;
            finishButton.IsDefault = true;
            headingLabel.Content = secondPageLabel;
        }

        // Display the first wizard page again and update related controls.
        private void previousButton_Click(object sender, RoutedEventArgs e)
        {
            secondPage.Visibility = Visibility.Hidden;
            firstPage.Visibility = Visibility.Visible;
            previousButton.IsEnabled = false;
            finishButton.IsDefault = false;
            nextButton.IsEnabled = true;
            nextButton.IsDefault = true;
            headingLabel.Content = firstPageLabel;
        }

        private void finishButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateUrl())
            {
                DialogResult = true;
                Close();
            }
        }

        private bool ValidateUrl()
        {
            string errorMessage;
            if (!PresentationModel.ValidateCurrentUrl(out errorMessage))
            {
                MessageBox.Show(String.Format("Cannot connect to the SharePoint site: {0}. {1}",
                    PresentationModel.CurrentSiteUrl, errorMessage),
                    "SharePoint Connection Error");
                return false;
            }
            return true;
        }
    }
}
//</Snippet4>
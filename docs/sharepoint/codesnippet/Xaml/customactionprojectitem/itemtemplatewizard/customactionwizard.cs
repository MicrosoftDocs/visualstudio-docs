//<Snippet8>
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;

namespace ItemTemplateWizard
{
    public class CustomActionWizard : IWizard
    {
        private WizardWindow wizardPage;

        public CustomActionWizard()
        {
        }

        #region IWizard Methods

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, 
            WizardRunKind runKind, object[] customParams)
        {
            wizardPage = new WizardWindow();
            Nullable<bool> dialogCompleted = wizardPage.ShowModal();
            
            if (dialogCompleted == true)
            {
                PopulateReplacementDictionary(replacementsDictionary);
            }
            else
            {
                throw new WizardCancelledException();
            }
        }

        // Always return true; this IWizard implementation throws a WizardCancelledException
        // that is handled by Visual Studio if the user cancels the wizard.
        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }

        // The following IWizard methods are not implemented in this example.
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }

        #endregion

        private void PopulateReplacementDictionary(Dictionary<string, string> replacementsDictionary)
        {
            // Fill in the replacement values from the UI selections on the wizard page. These values are automatically inserted
            // into the Elements.xml file for the custom action.
            string locationValue = (bool)wizardPage.standardMenuRadioButton.IsChecked ?
                CustomActionLocations.StandardMenu : CustomActionLocations.ListEdit;
            replacementsDictionary.Add("$LocationValue$", locationValue);
            replacementsDictionary.Add("$GroupIdValue$", (string)wizardPage.idComboBox.SelectedItem);
            replacementsDictionary.Add("$IdValue$", Guid.NewGuid().ToString());

            string titleText = DefaultTextBoxStrings.TitleText;
            if (!String.IsNullOrEmpty(wizardPage.titleTextBox.Text))
            {
                titleText = wizardPage.titleTextBox.Text;
            }

            string descriptionText = DefaultTextBoxStrings.DescriptionText;
            if (!String.IsNullOrEmpty(wizardPage.descriptionTextBox.Text))
            {
                descriptionText = wizardPage.descriptionTextBox.Text;
            }

            string urlText = DefaultTextBoxStrings.UrlText;
            if (!String.IsNullOrEmpty(wizardPage.urlTextBox.Text))
            {
                urlText = wizardPage.urlTextBox.Text;
            }

            replacementsDictionary.Add("$TitleValue$", titleText);
            replacementsDictionary.Add("$DescriptionValue$", descriptionText);
            replacementsDictionary.Add("$UrlValue$", urlText);
        }
    }
}
//</Snippet8>

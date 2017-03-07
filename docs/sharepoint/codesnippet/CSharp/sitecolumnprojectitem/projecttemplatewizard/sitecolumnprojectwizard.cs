//<Snippet7>
using EnvDTE;
using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;

namespace ProjectTemplateWizard
{
    public class SiteColumnProjectWizard : IWizard
    {
        private WizardWindow wizardUI;
        private DTE dteObject;
        private SiteColumnWizardModel presentationModel;
        private ProjectSigningManager signingManager;

        public SiteColumnProjectWizard()
        {
            signingManager = new ProjectSigningManager();
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, 
            WizardRunKind runKind, object[] customParams)
        {
            dteObject = automationObject as DTE;
            presentationModel = new SiteColumnWizardModel(dteObject, false);

            if (!presentationModel.ProjectService.IsSharePointInstalled)
            {
                string errorString = "A SharePoint server is not installed on this computer. A SharePoint server " +
                    "must be installed to work with SharePoint projects.";
                System.Windows.MessageBox.Show(errorString, "SharePoint Not Installed", System.Windows.MessageBoxButton.OK,
                    System.Windows.MessageBoxImage.Error);
                throw new WizardCancelledException(errorString);
            }

            wizardUI = new WizardWindow(presentationModel);
            Nullable<bool> dialogCompleted = wizardUI.ShowModal();
            
            if (dialogCompleted == true)
            {
                replacementsDictionary.Add("$selectedfieldtype$", presentationModel.FieldType);
                replacementsDictionary.Add("$selectedgrouptype$", presentationModel.FieldGroup);
                replacementsDictionary.Add("$fieldname$", presentationModel.FieldName);
                signingManager.GenerateKeyFile();
            }
            else
            {
                throw new WizardCancelledException();
            }
        }

        // Populate the SiteUrl and IsSandboxedSolution properties in the new project, and add a new 
        // key.snk file to the project.
        public void ProjectFinishedGenerating(Project project)
        {
            ISharePointProject sharePointProject = presentationModel.ProjectService.Convert<Project, ISharePointProject>(project);
            sharePointProject.SiteUrl = new Uri(presentationModel.CurrentSiteUrl, UriKind.Absolute);
            sharePointProject.IsSandboxedSolution = presentationModel.IsSandboxed;
            signingManager.AddKeyFile(project);
        }

        // Always return true; this IWizard implementation throws a WizardCancelledException
        // that is handled by Visual Studio if the user cancels the wizard.
        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }

        // The following IWizard methods are not used in this example.
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }
    }
}
//</Snippet7>

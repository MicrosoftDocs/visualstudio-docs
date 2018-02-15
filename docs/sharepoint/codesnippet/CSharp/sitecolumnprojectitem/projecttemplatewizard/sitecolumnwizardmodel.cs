//<Snippet6>
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using EnvDTE;
using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using IOleServiceProvider = Microsoft.VisualStudio.OLE.Interop.IServiceProvider;

namespace ProjectTemplateWizard
{
    internal class SiteColumnWizardModel
    {
        private DTE dteObject;
        private ISharePointProjectService projectServiceValue;
        private List<string> validatedUrls = new List<string>();

        internal SiteColumnWizardModel(DTE dteObject, bool requiresFarmPriveleges)
        {
            this.dteObject = dteObject;

            // Initialize default values for wizard choices.
            IsSandboxed = !requiresFarmPriveleges;
            IsSecondPagePopulated = false;
            FieldType = "Text";
            FieldGroup = "Custom Columns";
            FieldName = "My Custom Column";
            CurrentSiteUrl = GetLocalHostUrl();
        }

        #region Helper methods used by the wizard UI

        // Specifies whether the current site URL is valid. Uses the ValidateSite SharePoint command to do this.
        internal bool ValidateCurrentUrl(out string errorMessage)
        {
            bool isValid = false;
            errorMessage = String.Empty;

            if (validatedUrls.Contains(CurrentSiteUrl))
            {
                isValid = true;
            }
            else
            {
                Uri uriToValidate = new Uri(CurrentSiteUrl, UriKind.Absolute);
                IVsThreadedWaitDialog2 vsThreadedWaitDialog = null;

                try
                {
                    vsThreadedWaitDialog = ShowProgressDialog("Connect to SharePoint",
                        "Connecting to SharePoint site " + CurrentSiteUrl);
                    isValid = this.ProjectService.SharePointConnection.ExecuteCommand<Uri, bool>(
                        Contoso.SharePoint.Commands.CommandIds.ValidateSite, uriToValidate);
                }
                catch (Exception ex)
                {
                    errorMessage = "An error occurred while validating the site. " + ex.Message;
                }
                finally
                {
                    if (isValid)
                    {
                        validatedUrls.Add(CurrentSiteUrl);
                    }

                    if (vsThreadedWaitDialog != null)
                    {
                        CloseProgressDialog(vsThreadedWaitDialog);
                    }
                }
            }

            return isValid;
        }

        // Gets the available field types from the SharePoint site. Uses the GetFieldTypes SharePoint command to do this.
        internal ArrayList GetFieldTypes()
        {
            // If we have not yet validated this site, do it now.
            string errorMessage;
            if (!ValidateCurrentUrl(out errorMessage))
            {
                MessageBox.Show(String.Format("Cannot connect to the SharePoint site: {0}. {1}",
                    CurrentSiteUrl, errorMessage), "SharePoint Connection Error");
                return null;
            }

            // Site is valid, so go ahead and get the available field types.
            Uri siteUri = new Uri(CurrentSiteUrl, UriKind.Absolute);
            IVsThreadedWaitDialog2 vsThreadedWaitDialog = ShowProgressDialog(
                "Connect to SharePoint", "Connecting to SharePoint site " + CurrentSiteUrl);
            string[] fieldTypesArray = this.ProjectService.SharePointConnection.ExecuteCommand<Uri, string[]>(
                    Contoso.SharePoint.Commands.CommandIds.GetFieldTypes, siteUri);

            if (vsThreadedWaitDialog != null)
            {
                CloseProgressDialog(vsThreadedWaitDialog);
            }

            return new ArrayList(fieldTypesArray);
        }

        // Returns the default column group names in SharePoint.
        internal List<string> GetFieldGroups()
        {
            List<string> groups = new List<string>();
            groups.Add("Base Columns");
            groups.Add("Core Contact and Calendar Columns");
            groups.Add("Core Document Columns");
            groups.Add("Core Task and Issue Columns");
            groups.Add("Extended Columns");
            return groups;
        }

        #endregion

        #region Properties shared by the wizard implementation and the wizard UI

        internal ISharePointProjectService ProjectService
        {
            get
            {
                if (projectServiceValue == null)
                {
                    projectServiceValue = GetProjectService();
                }
                return projectServiceValue;
            }
        }

        internal bool IsSecondPagePopulated { get; set; }
        internal bool IsSandboxed { get; set; }
        internal string FieldType { get; set; }
        internal string FieldGroup { get; set; }
        internal string FieldName { get; set; }
        internal string CurrentSiteUrl { get; set; }

        #endregion

        #region Private methods

        private string GetLocalHostUrl()
        {
            const string HttpScheme = "http";
            UriBuilder builder = new UriBuilder(HttpScheme, Environment.MachineName.ToLowerInvariant());
            return builder.ToString();
        }

        private ISharePointProjectService GetProjectService()
        {
            ServiceProvider serviceProvider = new ServiceProvider(dteObject as IOleServiceProvider);
            return serviceProvider.GetService(typeof(ISharePointProjectService)) as ISharePointProjectService;
        }

        private IVsThreadedWaitDialog2 ShowProgressDialog(string caption, string message)
        {
            IOleServiceProvider oleServiceProvider = dteObject as IOleServiceProvider;
            IVsThreadedWaitDialogFactory dialogFactory = new ServiceProvider(oleServiceProvider).GetService(
                typeof(SVsThreadedWaitDialogFactory)) as IVsThreadedWaitDialogFactory;

            if (dialogFactory == null)
            {
                throw new InvalidOperationException("The IVsThreadedWaitDialogFactory object could not be retrieved.");
            }

            IVsThreadedWaitDialog2 vsThreadedWaitDialog = null;
            ErrorHandler.ThrowOnFailure(dialogFactory.CreateInstance(out vsThreadedWaitDialog));
            ErrorHandler.ThrowOnFailure(vsThreadedWaitDialog.StartWaitDialog(caption, message,
                 null, null, String.Empty, 0, false, true));
            return vsThreadedWaitDialog;
        }

        private void CloseProgressDialog(IVsThreadedWaitDialog2 vsThreadedWaitDialog)
        {
            if (vsThreadedWaitDialog == null)
            {
                throw new ArgumentNullException("vsThreadedWaitDialog");
            }

            int canceled;
            ErrorHandler.ThrowOnFailure(vsThreadedWaitDialog.EndWaitDialog(out canceled));
        }

        #endregion
    }
}
//</Snippet6>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace Trin_OL_HTMLFolder
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            CreateHtmlFolder();
        }
        //<Snippet1>
        private void CreateHtmlFolder()
        {
            Outlook.MAPIFolder newView = null;
            string viewName = "HtmlView";
            Outlook.MAPIFolder inBox = (Outlook.MAPIFolder)
                this.Application.ActiveExplorer().Session.GetDefaultFolder(Outlook
                .OlDefaultFolders.olFolderInbox);
            Outlook.Folders searchFolders = (Outlook.Folders)inBox.Folders;
            bool foundView = false;
            foreach (Outlook.MAPIFolder searchFolder in searchFolders)
            {
                if (searchFolder.Name == viewName)
                {
                    newView = inBox.Folders[viewName];
                    foundView = true;
                }
            }
            if (!foundView)
            {
                newView = (Outlook.MAPIFolder)inBox.Folders.
                    Add("HtmlView", Outlook.OlDefaultFolders.olFolderInbox);
                newView.WebViewURL = "http://www.microsoft.com";
                newView.WebViewOn = true;
            }
            Application.ActiveExplorer().SelectFolder(newView);
            Application.ActiveExplorer().CurrentFolder.Display();
        }
        //</Snippet1>




        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}

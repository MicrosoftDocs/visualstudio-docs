using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;

namespace Trin_OL_SaveAttachments
{
    public partial class ThisAddIn
    {
        //<Snippet1>
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.Application.NewMail += new Microsoft.Office.Interop.Outlook
                .ApplicationEvents_11_NewMailEventHandler(ThisApplication_NewMail);
        }

        private void ThisApplication_NewMail()
        {
            Outlook.MAPIFolder inBox = this.Application.ActiveExplorer()
                .Session.GetDefaultFolder(Outlook
                .OlDefaultFolders.olFolderInbox);
            Outlook.Items inBoxItems = inBox.Items;
            Outlook.MailItem newEmail = null;
            inBoxItems = inBoxItems.Restrict("[Unread] = true");
            try
            {
                foreach (object collectionItem in inBoxItems)
                {
                    newEmail = collectionItem as Outlook.MailItem;
                    if (newEmail != null)
                    {
                        if (newEmail.Attachments.Count > 0)
                        {
                            for (int i = 1; i <= newEmail
                               .Attachments.Count; i++)
                            {
                                newEmail.Attachments[i].SaveAsFile
                                    (@"C:\TestFileSave\" +
                                    newEmail.Attachments[i].FileName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string errorInfo = (string)ex.Message
                    .Substring(0, 11);
                if (errorInfo == "Cannot save")
                {
                    MessageBox.Show(@"Create Folder C:\TestFileSave");
                }
            }
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

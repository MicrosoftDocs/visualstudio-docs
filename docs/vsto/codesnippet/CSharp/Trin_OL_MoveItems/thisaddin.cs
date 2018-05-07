using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;

namespace Trin_OL_MoveItems
{
    public partial class ThisAddIn
    {
        //<Snippet1>
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.Application.NewMail += new Microsoft.Office.Interop.Outlook.
                ApplicationEvents_11_NewMailEventHandler
                (ThisAddIn_NewMail);

        }

        private void ThisAddIn_NewMail()
        {
            Outlook.MAPIFolder inBox = (Outlook.MAPIFolder)this.Application.
                ActiveExplorer().Session.GetDefaultFolder
                (Outlook.OlDefaultFolders.olFolderInbox);
            Outlook.Items items = (Outlook.Items)inBox.Items;
            Outlook.MailItem moveMail = null;
            items.Restrict("[UnRead] = true");
            Outlook.MAPIFolder destFolder = inBox.Folders["Test"];
            foreach (object eMail in items)
            {
                try
                {
                    moveMail = eMail as Outlook.MailItem;
                    if (moveMail != null)
                    {
                        string titleSubject = (string)moveMail.Subject;
                        if (titleSubject.IndexOf("Test") > 0)
                        {
                            moveMail.Move(destFolder);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

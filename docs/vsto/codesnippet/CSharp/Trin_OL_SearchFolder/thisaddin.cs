using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;

namespace Trin_OL_SearchFolder
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            SearchInBox();
        }
        //<Snippet1>
        private void SearchInBox()
        {
            Outlook.Folder inbox = this.Application.ActiveExplorer().Session.
                GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox);
            Outlook.Items items = inbox.Items;
            Outlook.MailItem mailItem = null;
            object folderItem;
            string subjectName = string.Empty;
            string filter = "[Subject] > 's' And [Subject] <'u'";
            folderItem = items.Find(filter);
            while (folderItem != null)
            {
                mailItem = folderItem as Outlook.MailItem;
                if (mailItem != null)
                {
                    subjectName += "\n" + mailItem.Subject;
                }
                folderItem = items.FindNext();
            }
            subjectName = " The following e-mail messages were found: " +
                subjectName;
            MessageBox.Show(subjectName);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;

namespace Trin_OL_CustFolderItem
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        //<Snippet1>
        private void CreateCustomFolder()
        {
            Outlook.Folder inBox = (Outlook.Folder)
                Application.ActiveExplorer().Session.GetDefaultFolder
                (Outlook.OlDefaultFolders.olFolderInbox);
            string userName = (string)this.Application.ActiveExplorer()
                .Session.CurrentUser.Name;
            Outlook.Folder customFolder = null;
            try
            {
                customFolder = (Outlook.Folder)inBox.Folders.Add(userName,
                    Outlook.OlDefaultFolders.olFolderInbox);
                MessageBox.Show("You have created a new folder named " +
                    userName + ".");
                inBox.Folders[userName].Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred: " + ex.Message);
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

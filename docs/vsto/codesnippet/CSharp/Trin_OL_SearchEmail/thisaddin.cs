using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;

namespace Trin_OL_SearchEmail
{
    public partial class ThisAddIn
    {
        //<Snippet1>
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            SearchforEmail("example.com");
        }

        private void SearchforEmail(string partialAddress)
        {
            string contactMessage = string.Empty;
            Outlook.MAPIFolder contacts = (Outlook.MAPIFolder)
                this.Application.ActiveExplorer().Session.GetDefaultFolder
                 (Outlook.OlDefaultFolders.olFolderContacts);
            foreach (Outlook.ContactItem foundContact in contacts.Items)
            {
                if (foundContact.Email1Address != null)
                {
                    if (foundContact.Email1Address.Contains(partialAddress))
                    {
                        contactMessage = contactMessage + "New contact"
                        + foundContact.FirstName + " " + foundContact.LastName
                        + " Email Address is " + foundContact.Email1Address +
                        ". \n";
                    }
                }
            }
            if (!(contactMessage.Length > 0))
            {
                contactMessage = "No Contacts were found.";
            }
            MessageBox.Show(contactMessage);
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

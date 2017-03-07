using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;

namespace Trin_Outlook_RL_SearchForContact
{
    public partial class ThisAddIn
    {
        // <snippet1>
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            FindContactEmailByName("John", "Evans");
        }

        private void FindContactEmailByName(string firstName, string lastName)
        {
            Outlook.NameSpace outlookNameSpace = this.Application.GetNamespace("MAPI");
            Outlook.MAPIFolder contactsFolder =
                outlookNameSpace.GetDefaultFolder(
                Microsoft.Office.Interop.Outlook.
                OlDefaultFolders.olFolderContacts);

            Outlook.Items contactItems = contactsFolder.Items;

            try
            {
                Outlook.ContactItem contact =
                    (Outlook.ContactItem)contactItems.
                    Find(String.Format("[FirstName]='{0}' and "
                    + "[LastName]='{1}'", firstName, lastName));
                if (contact != null)
                {
                    contact.Display(true);
                }
                else
                {
                    MessageBox.Show("The contact information was not found.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // </snippet1>


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

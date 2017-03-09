using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;

namespace trin_ol_addcontact
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        //<Snippet1>
        private void AddContact()
        {
            Outlook.ContactItem newContact = (Outlook.ContactItem)
                this.Application.CreateItem(Outlook.OlItemType.olContactItem);
            try
            {
                newContact.FirstName = "Jo";
                newContact.LastName = "Berry";
                newContact.Email1Address = "somebody@example.com";
                newContact.CustomerID = "123456";
                newContact.PrimaryTelephoneNumber = "(425)555-0111";
                newContact.MailingAddressStreet = "123 Main St.";
                newContact.MailingAddressCity = "Redmond";
                newContact.MailingAddressState = "WA";
                newContact.Save();
                newContact.Display(true);
            }
            catch
            {
                MessageBox.Show("The new contact was not saved.");
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

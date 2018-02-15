using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace Trin_OL_ProgramEMail
{
    public partial class ThisAddIn
    {
        //<Snippet1>
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            SendEmailtoContacts();
        }

        private void SendEmailtoContacts()
        {
            string subjectEmail = "Meeting has been rescheduled.";
            string bodyEmail = "Meeting is one hour later.";
            Outlook.MAPIFolder sentContacts = (Outlook.MAPIFolder)
                this.Application.ActiveExplorer().Session.GetDefaultFolder
                (Outlook.OlDefaultFolders.olFolderContacts);
            foreach (Outlook.ContactItem contact in sentContacts.Items)
            {
                if (contact.Email1Address.Contains("example.com"))
                {
                    this.CreateEmailItem(subjectEmail, contact
                        .Email1Address, bodyEmail);
                }
            }
        }

        private void CreateEmailItem(string subjectEmail,
               string toEmail, string bodyEmail)
        {
            Outlook.MailItem eMail = (Outlook.MailItem)
                this.Application.CreateItem(Outlook.OlItemType.olMailItem);
            eMail.Subject = subjectEmail;
            eMail.To = toEmail;
            eMail.Body = bodyEmail;
            eMail.Importance = Outlook.OlImportance.olImportanceLow;
            ((Outlook._MailItem)eMail).Send();
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

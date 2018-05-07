using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace Trin_Outlook_RL_DeleteContacts
{
    public partial class ThisAddIn
    {
        // <Snippet1>
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            DeleteContact("Pinto", "Armando");
        }

        private void DeleteContact(string lastName, string firstName)
        {
            Outlook.ContactItem contact =
                this.Application.GetNamespace("MAPI").
            GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts).
            Items.
            Find(
            string.Format("[LastName]='{0}' AND [FirstName]='{1}'",
            lastName, firstName))
            as Outlook.ContactItem;

            if (contact != null)
            {
                contact.Delete();
            }
        }
        // </Snippet1>

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

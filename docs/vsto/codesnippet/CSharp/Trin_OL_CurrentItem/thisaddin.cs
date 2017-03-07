using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;

namespace Trin_OL_CurrentItem
{
    public partial class ThisAddIn
    {
        //<Snippet1>
        Outlook.Explorer currentExplorer = null;

        private void ThisAddIn_Startup
            (object sender, System.EventArgs e)
        {
            currentExplorer = this.Application.ActiveExplorer();
            currentExplorer.SelectionChange += new Outlook
                .ExplorerEvents_10_SelectionChangeEventHandler
                (CurrentExplorer_Event);
        }

        private void CurrentExplorer_Event()
        {
            Outlook.MAPIFolder selectedFolder =
                this.Application.ActiveExplorer().CurrentFolder;
            String expMessage = "Your current folder is "
                + selectedFolder.Name + ".\n";
            String itemMessage = "Item is unknown.";
            try
            {
                if (this.Application.ActiveExplorer().Selection.Count > 0)
                {
                    Object selObject = this.Application.ActiveExplorer().Selection[1];
                    if (selObject is Outlook.MailItem)
                    {
                        Outlook.MailItem mailItem =
                            (selObject as Outlook.MailItem);
                        itemMessage = "The item is an e-mail message." +
                            " The subject is " + mailItem.Subject + ".";
                        mailItem.Display(false);
                    }
                    else if (selObject is Outlook.ContactItem)
                    {
                        Outlook.ContactItem contactItem =
                            (selObject as Outlook.ContactItem);
                        itemMessage = "The item is a contact." +
                            " The full name is " + contactItem.Subject + ".";
                        contactItem.Display(false);
                    }
                    else if (selObject is Outlook.AppointmentItem)
                    {
                        Outlook.AppointmentItem apptItem =
                            (selObject as Outlook.AppointmentItem);
                        itemMessage = "The item is an appointment." +
                            " The subject is " + apptItem.Subject + ".";
                    }
                    else if (selObject is Outlook.TaskItem)
                    {
                        Outlook.TaskItem taskItem =
                            (selObject as Outlook.TaskItem);
                        itemMessage = "The item is a task. The body is "
                            + taskItem.Body + ".";
                    }
                    else if (selObject is Outlook.MeetingItem)
                    {
                        Outlook.MeetingItem meetingItem =
                            (selObject as Outlook.MeetingItem);
                        itemMessage = "The item is a meeting item. " +
                             "The subject is " + meetingItem.Subject + ".";
                    }
                }
                expMessage = expMessage + itemMessage;
            }
            catch (Exception ex)
            {
                expMessage = ex.Message;
            }
            MessageBox.Show(expMessage);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace Trin_Outlook_RL_DeleteAppointment
{
    public partial class ThisAddIn
    {
        // <Snippet1>
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Outlook.MAPIFolder calendar =
                Application.Session.GetDefaultFolder(
                 Outlook.OlDefaultFolders.olFolderCalendar);

            Outlook.Items calendarItems = calendar.Items;

            Outlook.AppointmentItem item =
                calendarItems["Test Appointment"] as Outlook.AppointmentItem;

            Outlook.RecurrencePattern pattern =
                item.GetRecurrencePattern();
            Outlook.AppointmentItem itemDelete = pattern.
                GetOccurrence(new DateTime(2006, 6, 28, 8, 0, 0));

            if (itemDelete != null)
            {
                itemDelete.Delete();
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

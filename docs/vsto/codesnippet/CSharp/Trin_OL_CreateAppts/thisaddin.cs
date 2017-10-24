using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;

namespace Trin_OL_CreateAppts
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }
        //<Snippet1>
        private void AddAppointment()
        {
            try
            {
                Outlook.AppointmentItem newAppointment =
                    (Outlook.AppointmentItem)
                this.Application.CreateItem(Outlook.OlItemType.olAppointmentItem);
                newAppointment.Start = DateTime.Now.AddHours(2);
                newAppointment.End = DateTime.Now.AddHours(3);
                newAppointment.Location = "ConferenceRoom #2345";
                newAppointment.Body =
                    "We will discuss progress on the group project.";
                newAppointment.AllDayEvent = false;
                newAppointment.Subject = "Group Project";
                newAppointment.Recipients.Add("Roger Harui");
                Outlook.Recipients sentTo = newAppointment.Recipients;
                Outlook.Recipient sentInvite = null;
                sentInvite = sentTo.Add("Holly Holt");
                sentInvite.Type = (int)Outlook.OlMeetingRecipientType
                    .olRequired;
                sentInvite = sentTo.Add("David Junca ");
                sentInvite.Type = (int)Outlook.OlMeetingRecipientType
                    .olOptional;
                sentTo.ResolveAll();
                newAppointment.Save();
                newAppointment.Display(true);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace Trin_Outlook_RL_MeetingRequest
{
    public partial class ThisAddIn
    {
        // <snippet1>
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Outlook.AppointmentItem agendaMeeting = (Outlook.AppointmentItem)
                this.Application.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.
                olAppointmentItem);

            if (agendaMeeting != null)
            {
                agendaMeeting.MeetingStatus =
                    Microsoft.Office.Interop.Outlook.OlMeetingStatus.olMeeting;
                agendaMeeting.Location = "Conference Room";
                agendaMeeting.Subject = "Discussing the Agenda";
                agendaMeeting.Body = "Let's discuss the agenda.";
                agendaMeeting.Start = new DateTime(2005, 5, 5, 5, 0, 0);
                agendaMeeting.Duration = 60;
                Outlook.Recipient recipient =
                    agendaMeeting.Recipients.Add("Nate Sun");
                recipient.Type =
                    (int)Outlook.OlMeetingRecipientType.olRequired;
                ((Outlook._AppointmentItem)agendaMeeting).Send();
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

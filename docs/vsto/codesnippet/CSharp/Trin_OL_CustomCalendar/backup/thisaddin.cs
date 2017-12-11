using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace Trin_OL_CustomCalendar
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        //<Snippet1>
        private void CreateCustomCalendar()
        {
            const string newCalendarName = "PersonalCalendar";
            Outlook.MAPIFolder primaryCalendar = (Outlook.MAPIFolder)
                this.Application.ActiveExplorer().Session.GetDefaultFolder
                 (Outlook.OlDefaultFolders.olFolderCalendar);
            bool needFolder = true;
            foreach (Outlook.MAPIFolder personalCalendar
                in primaryCalendar.Folders)
            {
                if (personalCalendar.Name == newCalendarName)
                {
                    needFolder = false;
                    break;
                }
            }
            if (needFolder)
            {
                Outlook.MAPIFolder personalCalendar = primaryCalendar
                    .Folders.Add(newCalendarName,
                        Outlook.OlDefaultFolders.olFolderCalendar);
                Outlook.AppointmentItem newEvent =
                    personalCalendar.Items.Add
                    (Outlook.OlItemType.olAppointmentItem)
                    as Outlook.AppointmentItem;
                newEvent.Start = DateTime.Now.AddHours(1);
                newEvent.End = DateTime.Now.AddHours(1.25);
                newEvent.Subject = "New plan";
                newEvent.Body = " Meet to discuss new plan.";
                newEvent.Save();
            }
            Application.ActiveExplorer().SelectFolder(primaryCalendar
                .Folders[newCalendarName]);
            Application.ActiveExplorer().CurrentFolder.Display();
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

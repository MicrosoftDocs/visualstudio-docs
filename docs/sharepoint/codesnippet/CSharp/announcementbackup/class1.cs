// <Snippet1>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;

namespace AnnouncementBackup
{
    // This custom activity will back up all of the announcements in 
    // the Announcements list on the SharePoint site.
    public class Class1 : System.Workflow.ComponentModel.Activity
        {
        public Class1()
        { }
        
        // Triggers when the activity is executed.
        protected override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext)
        {
            try
            {
                // Get a reference to the SharePoint site.
                SPSite site = new SPSite("http://" + System.Environment.MachineName);
                SPWeb web = site.OpenWeb("/");

                // Reference the original Announcements list.
                SPList aList = web.GetList("/Lists/Announcements");

                // If the Announcements Backup list already exists, delete it.
                try
                {
                    SPList bList = web.GetList("/Lists/Announcements Backup");
                    bList.Delete();
                }
                catch
                { }

                // Create a new backup Announcements list and reference it.
                Guid newAnnID = web.Lists.Add("Announcements Backup", "A backup Announcements list.", SPListTemplateType.Announcements);
                SPList bakList = web.Lists[newAnnID];

                // Copy announcements from original to backup Announcements list.
                foreach (SPListItem item in aList.Items)
                {
                    SPListItem newAnnItem = bakList.Items.Add();
                    foreach (SPField field in aList.Fields)
                    {
                        if (!field.ReadOnlyField)
                            newAnnItem[field.Id] = item[field.Id];
                    }
                    newAnnItem.Update();
                }

                // Put the Backup Announcements list on the QuickLaunch bar.
                bakList.OnQuickLaunch = true;
                bakList.Update();

            }

            catch (Exception errx)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + errx.ToString());
            }
            
            return base.Execute(executionContext);
        }


	}
}
// </Snippet1>
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
// <Snippet1>
using System;
// </Snippet1>

namespace FeatureEvtTest2.Features.Feature1
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("d56949f4-4761-4bef-a5f7-b0a87ca9f201")]
    public class Feature1EventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        //public override void FeatureActivated(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised before a feature is deactivated.

        // <Snippet2>
        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            try
            {
                // Get reference to SharePoint site.
                SPSite site = new SPSite("http://localhost");
                SPWeb web = site.OpenWeb("/");
                // Get reference to Announcements list.
                SPList announcementsList = web.Lists["Announcements"];

                // Add new announcement to Announcements list.
                SPListItem oListItem = announcementsList.Items.Add();
                oListItem["Title"] = "Deactivated Feature: " + properties.Definition.DisplayName;
                oListItem["Body"] = properties.Definition.DisplayName + " was deactivated on: " + DateTime.Now.ToString();
                oListItem.Update();

            }

            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
            
        }
        // </Snippet2>

        // Uncomment the method below to handle the event raised after a feature has been installed.

        //public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        //{
        //}

        
        // Uncomment the method below to handle the event raised before a feature is uninstalled.

        //public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        //{
        //}

        // Uncomment the method below to handle the event raised when a feature is upgrading.

        //public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        //{
        //}
    }
}

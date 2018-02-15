using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;

namespace CustomField1.TestEventReceiver1
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class TestEventReceiver1 : SPItemEventReceiver
    {
       /// <summary>
       /// An item was added.
       /// </summary>
       // <Snippet1>
       public override void ItemAdded(SPItemEventProperties properties)
       {
           properties.ListItem["Patient Name"] = "Scott Brown";
           properties.ListItem.Update();
           base.ItemAdded(properties);
       }
        // </Snippet1>

    }
}

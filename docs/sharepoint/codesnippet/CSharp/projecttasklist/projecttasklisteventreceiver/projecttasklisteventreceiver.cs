using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;

namespace ProjectTaskList.ProjectTaskListEventReceiver
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class ProjectTaskListEventReceiver : SPItemEventReceiver
    {
       /// <summary>
       /// An item was added.
       /// </summary>
 
        //<snippet1>
        public override void ItemAdded(SPItemEventProperties properties)
       {
           base.ItemAdded(properties);
           SPWeb web = properties.OpenWeb();
           properties.ListItem["Due Date"] = "July 1, 2009";
           properties.ListItem["Description"] = "This is a critical task.";
           properties.ListItem.Update(); 
       }  
        //</snippet1>

    }
}

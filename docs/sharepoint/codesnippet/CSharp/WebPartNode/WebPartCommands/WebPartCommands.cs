//<Snippet6>
using System.Collections.Generic;
using Microsoft.SharePoint;
using Microsoft.VisualStudio.SharePoint.Commands;

namespace ServerExplorer.SharePointConnections.WebPartNode
{
    internal class WebPartsCommands
    {
        // Gets data for each Web Part on the SharePoint site, and returns an array of 
        // serializable objects that contain the data.
        [SharePointCommand(WebPartCommandIds.GetWebParts)]
        private static WebPartNodeInfo[] GetWebParts(ISharePointCommandContext context)
        {
            var nodeInfos = new List<WebPartNodeInfo>();
            SPListItemCollection webParts = context.Site.GetCatalog(
                SPListTemplateType.WebPartCatalog).Items;

            foreach (SPListItem webPart in webParts)
            {
                WebPartNodeInfo nodeInfo = new WebPartNodeInfo
                {
                    Id = webPart.ID,
                    SiteId = webPart.ParentList.ParentWeb.ID,
                    Name = webPart.Title,
                    UniqueId = webPart.UniqueId,
                    ImageUrl = webPart.ParentList.ImageUrl
                };
                nodeInfos.Add(nodeInfo);
            }

            return nodeInfos.ToArray();
        }

        // Gets additional property data for a specific Web Part.
        [SharePointCommand(WebPartCommandIds.GetWebPartProperties)]
        private static Dictionary<string, string> GetWebPartProperties(ISharePointCommandContext context, 
            WebPartNodeInfo nodeInfo)
        {
            SPList webParts = context.Site.GetCatalog(SPListTemplateType.WebPartCatalog);
            SPListItem webPart = webParts.Items[nodeInfo.UniqueId];

            return SharePointCommandServices.GetProperties(webPart);
        }
    }
}
//</Snippet6>



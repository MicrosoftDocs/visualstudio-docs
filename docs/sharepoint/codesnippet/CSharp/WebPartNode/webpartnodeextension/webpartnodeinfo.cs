//<Snippet3>
using System;

namespace ServerExplorer.SharePointConnections.WebPartNode
{
    // Contains basic data about a single Web Part on the SharePoint site. This class is 
    // serializable so that instances of it can be sent between the WebPartNode and 
    // WebPartCommands assemblies.
    [Serializable]
    public class WebPartNodeInfo
    {
        public Guid SiteId { get; set; }
        public int Id { get; set; }
        public Guid UniqueId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}
//</Snippet3>
'<Snippet6>
Imports System.Collections.Generic
Imports Microsoft.SharePoint
Imports Microsoft.VisualStudio.SharePoint.Commands

Namespace ServerExplorer.SharePointConnections.WebPartNode

    Friend Class WebPartsCommands

        ' Gets data for each Web Part on the SharePoint site, and returns an array of 
        ' serializable objects that contain the data.
        <SharePointCommand(WebPartCommandIds.GetWebParts)> _
        Private Shared Function GetWebParts(ByVal context As ISharePointCommandContext) As WebPartNodeInfo()

            Dim nodeInfos = New List(Of WebPartNodeInfo)()
            Dim webParts As SPListItemCollection = context.Site.GetCatalog( _
                SPListTemplateType.WebPartCatalog).Items

            For Each webPart As SPListItem In webParts
                Dim nodeInfo As WebPartNodeInfo = New WebPartNodeInfo()
                With nodeInfo
                    .Id = webPart.ID
                    .SiteId = webPart.ParentList.ParentWeb.ID
                    .Name = webPart.Title
                    .UniqueId = webPart.UniqueId
                    .ImageUrl = webPart.ParentList.ImageUrl
                End With
                nodeInfos.Add(nodeInfo)
            Next
            Return nodeInfos.ToArray()
        End Function

        ' Gets additional property data for a specific Web Part.
        <SharePointCommand(WebPartCommandIds.GetWebPartProperties)> _
        Private Shared Function GetWebPartProperties(ByVal context As ISharePointCommandContext, _
            ByVal webPartNodeInfo As WebPartNodeInfo) As Dictionary(Of String, String)

            Dim webParts As SPList = context.Site.GetCatalog(SPListTemplateType.WebPartCatalog)
            Dim webPart As SPListItem = webParts.Items(webPartNodeInfo.UniqueId)
            Return SharePointCommandServices.GetProperties(webPart)
        End Function
    End Class
End Namespace
'</Snippet6>

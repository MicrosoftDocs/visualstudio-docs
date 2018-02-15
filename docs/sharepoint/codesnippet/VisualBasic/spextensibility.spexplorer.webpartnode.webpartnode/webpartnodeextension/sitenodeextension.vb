'<Snippet1>
Imports System.Collections.Generic
Imports System.ComponentModel.Composition
Imports Microsoft.SharePoint.Client
Imports Microsoft.VisualStudio.SharePoint
Imports Microsoft.VisualStudio.SharePoint.Explorer

Namespace ServerExplorer.SharePointConnections.WebPartNode

    ' Export attribute: Enables Visual Studio to discover and load this extension.
    ' ExplorerNodeType attribute: Indicates that this class extends SharePoint site nodes in Server Explorer.
    ' SiteNodeExtension class: Represents an extension of SharePoint site nodes in Server Explorer.
    <Export(GetType(IExplorerNodeTypeExtension))> _
    <ExplorerNodeType(ExplorerNodeTypes.SiteNode)> _
    Friend Class SiteNodeExtension
        Implements IExplorerNodeTypeExtension

        Private siteUrl As System.Uri = Nothing

        Private Sub Initialize(ByVal nodeType As IExplorerNodeType) _
            Implements IExplorerNodeTypeExtension.Initialize

            ' The NodeChildrenRequested event is raised when the user expands the
            ' SharePoint site node in Server Explorer.
            AddHandler nodeType.NodeChildrenRequested, AddressOf NodeChildrenRequested
        End Sub

        ' Creates the new Web Part Gallery node with the specified icon.
        Private Sub NodeChildrenRequested(ByVal Sender As Object, ByVal e As ExplorerNodeEventArgs)

            ' Get the site URL so that it can be used later to access the site
            ' by using the SharePoint client object model.
            siteUrl = e.Node.Context.SiteUrl

            ' The CreateWebPartNodes argument is a delegate that Visual Studio calls 
            ' to create the child nodes under the Web Part Gallery node.
            e.Node.ChildNodes.AddFolder("Web Part Gallery", My.Resources.WebPartsNode.ToBitmap(), _
                AddressOf CreateWebPartNodes)
        End Sub

        ' Creates individual Web Part nodes under the new Web Part Gallery node.
        Private Sub CreateWebPartNodes(ByVal parentNode As IExplorerNode)

            ' Use the SharePoint client object model to get items from the Web Part gallery.
            Dim Context As ClientContext = New ClientContext(siteUrl.AbsoluteUri)
            Dim WebPartsGallery As List = Context.Web.GetCatalog(CType(ListTemplateType.WebPartCatalog, Integer))
            Dim WebParts As ListItemCollection = WebPartsGallery.GetItems(New CamlQuery())

            ' Request the FieldValuesAsText property values with the Web Part items.
            Context.Load(WebParts, Function(listItems) listItems.Include(Function(i) i.FieldValuesAsText))
            Context.ExecuteQuery()

            If WebParts IsNot Nothing Then
                For Each WebPart As ListItem In WebParts

                    ' Create a new annotation object to store the current Web Part item with the new node.
                    Dim Annotations = New Dictionary(Of Object, Object)()
                    Annotations.Add(GetType(ListItem), WebPart)

                    ' Create the new node for the current Web Part item.
                    parentNode.ChildNodes.Add(WebPartNodeTypeProvider.WebPartNodeTypeId, _
                        WebPart.FieldValuesAsText.FieldValues("Title"), Annotations)
                Next
            End If
        End Sub
    End Class
End Namespace
'</Snippet1>

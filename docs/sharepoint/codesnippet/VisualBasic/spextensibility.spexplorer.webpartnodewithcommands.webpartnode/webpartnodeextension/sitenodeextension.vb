'<Snippet1>
Imports System.Collections.Generic
Imports System.ComponentModel.Composition
Imports Microsoft.VisualStudio.SharePoint.Explorer

Namespace ServerExplorer.SharePointConnections.WebPartNode

    ' Export attribute: Enables Visual Studio to discover and load this extension.
    ' ExplorerNodeType attribute:  Indicates that this class extends SharePoint site nodes in Server Explorer.
    ' WebPartNodeTypeProvider class: Represents an extension of SharePoint site nodes in Server Explorer.
    <Export(GetType(IExplorerNodeTypeExtension))> _
    <ExplorerNodeType(ExplorerNodeTypes.SiteNode)> _
    Friend Class SiteNodeExtension
        Implements IExplorerNodeTypeExtension

        Private Sub Initialize(ByVal nodeType As IExplorerNodeType) _
            Implements IExplorerNodeTypeExtension.Initialize

            ' The NodeChildrenRequested event is raised when the user expands the
            ' SharePoint site node in Server Explorer.
            AddHandler nodeType.NodeChildrenRequested, AddressOf NodeChildrenRequested
        End Sub

        ' Creates the new Web Part Gallery node with the specified icon.
        Private Sub NodeChildrenRequested(ByVal Sender As Object, ByVal e As ExplorerNodeEventArgs)

            ' The CreateWebPartNodes argument is a delegate that Visual Studio calls 
            ' to create the child nodes under the Web Part Gallery node.
            e.Node.ChildNodes.AddFolder("Web Part Gallery", My.Resources.WebPartsNode.ToBitmap(), _
                AddressOf CreateWebPartNodes)
        End Sub

        ' Creates all of the individual Web Part nodes under the new Web Part Gallery node.
        Private Sub CreateWebPartNodes(ByVal parentNode As IExplorerNode)

            ' Call the custom SharePoint command to get items from the Web Part gallery.
            Dim webParts = parentNode.Context.SharePointConnection.ExecuteCommand(Of WebPartNodeInfo())( _
                WebPartCommandIds.GetWebParts)
            If webParts IsNot Nothing Then
                For Each webPart As WebPartNodeInfo In webParts

                    ' Create a new annotation object to store the current Web Part item with the new node.
                    Dim annotations = New Dictionary(Of Object, Object)()
                    annotations.Add(GetType(WebPartNodeInfo), webPart)

                    ' Create the new node for the current Web Part item.
                    parentNode.ChildNodes.Add(WebPartNodeTypeProvider.WebPartNodeTypeId, _
                        webPart.Name, annotations)
                Next
            End If
        End Sub

    End Class
End Namespace
'</Snippet1>
'<Snippet2>
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.ComponentModel.Composition
Imports Microsoft.VisualStudio.SharePoint
Imports Microsoft.VisualStudio.SharePoint.Explorer

Namespace ServerExplorer.SharePointConnections.WebPartNode

    ' Export attribute: Enables Visual Studio to discover and load this extension.
    ' ExplorerNodeType attribute: Specifies the ID for this new node type.
    ' WebPartNodeTypeProvider class: Defines a new node type that represents a Web Part on a SharePoint site.
    <Export(GetType(IExplorerNodeTypeProvider))> _
    <ExplorerNodeType(WebPartNodeTypeProvider.WebPartNodeTypeId)> _
    Friend Class WebPartNodeTypeProvider
        Implements IExplorerNodeTypeProvider

        Friend Const WebPartNodeTypeId As String = "Contoso.WebPart"

        Private Sub InitializeType(ByVal typeDefinition As IExplorerNodeTypeDefinition) _
            Implements IExplorerNodeTypeProvider.InitializeType

            typeDefinition.DefaultIcon = My.Resources.WebPart.ToBitmap()
            typeDefinition.IsAlwaysLeaf = True
            AddHandler typeDefinition.NodePropertiesRequested, AddressOf NodePropertiesRequested
        End Sub

        ' Retrieves properties that are displayed in the Properties window when
        ' a Web Part node is selected.
        Private Sub NodePropertiesRequested(ByVal Sernder As Object, _
            ByVal e As ExplorerNodePropertiesRequestedEventArgs)

            Dim nodeInfo = e.Node.Annotations.GetValue(Of WebPartNodeInfo)()

            ' Call the custom SharePoint command to get the Web Part properties.
            Dim properties As Dictionary(Of String, String) = _
                e.Node.Context.SharePointConnection.ExecuteCommand( _
                Of WebPartNodeInfo, Dictionary(Of String, String))(
                WebPartCommandIds.GetWebPartProperties, nodeInfo)
            Dim propertySource As Object = e.Node.Context.CreatePropertySourceObject(properties)
            e.PropertySources.Add(propertySource)
        End Sub

    End Class
End Namespace
'</Snippet2>

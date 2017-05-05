'<Snippet2>
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.ComponentModel.Composition
Imports Microsoft.SharePoint.Client
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
            AddHandler typeDefinition.NodeMenuItemsRequested, AddressOf NodeMenuItemsRequested
        End Sub

        ' Retrieves properties that are displayed in the Properties window when
        ' a Web Part node is selected.
        Private Sub NodePropertiesRequested(ByVal Sender As Object, _
            ByVal e As ExplorerNodePropertiesRequestedEventArgs)

            Dim webPart = e.Node.Annotations.GetValue(Of ListItem)()
            Dim propertySource = e.Node.Context.CreatePropertySourceObject( _
                webPart.FieldValuesAsText.FieldValues)
            e.PropertySources.Add(propertySource)
        End Sub

        Private Sub NodeMenuItemsRequested(ByVal Sender As Object, _
            ByVal e As ExplorerNodeMenuItemsRequestedEventArgs)
            Dim WebPartNodeMenuItem As IMenuItem = e.MenuItems.Add("Display Message")
            AddHandler WebPartNodeMenuItem.Click, AddressOf MenuItemClick
        End Sub

        Private Sub MenuItemClick(ByVal Sender As Object, ByVal e As MenuItemEventArgs)
            Dim ParentNode As IExplorerNode = TryCast(e.Owner, IExplorerNode)
            If ParentNode IsNot Nothing Then
                Dim webPart = ParentNode.Annotations.GetValue(Of ListItem)()
                MessageBox.Show("You clicked the context menu for the following Web part: " & _
                    webPart.FieldValuesAsText.FieldValues("Title") + ".", "Web Part Menu Command")
            End If
        End Sub
    End Class
End Namespace
'</Snippet2>

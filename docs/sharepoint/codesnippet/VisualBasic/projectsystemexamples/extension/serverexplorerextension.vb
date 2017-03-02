'<Snippet9>
Imports System.ComponentModel
Imports System.ComponentModel.Composition
Imports System.Windows.Forms
Imports Microsoft.VisualStudio.SharePoint
Imports Microsoft.VisualStudio.SharePoint.Explorer
Imports Microsoft.VisualStudio.SharePoint.Explorer.Extensions

Namespace Contoso.ServerExplorerExtension
    <Export(GetType(IExplorerNodeTypeExtension))> _
    <ExplorerNodeType(ExplorerNodeTypes.SiteNode)> _
    Friend Class SiteNodeExtensionWithContextMenu
        Implements IExplorerNodeTypeExtension

        Private Sub Initialize(ByVal nodeType As IExplorerNodeType) _
            Implements IExplorerNodeTypeExtension.Initialize
            AddHandler nodeType.NodeMenuItemsRequested, AddressOf NodeMenuItemsRequested
        End Sub

        Private Sub NodeMenuItemsRequested(ByVal Sender As Object, ByVal e As ExplorerNodeMenuItemsRequestedEventArgs)
            Dim menuItem = e.MenuItems.Add("Display Message")
            AddHandler menuItem.Click, AddressOf MenuItemClick
        End Sub

        Private Sub MenuItemClick(ByVal Sender As Object, ByVal e As MenuItemEventArgs)
            Dim node As IExplorerNode = CType(e.Owner, IExplorerNode)
            MessageBox.Show(String.Format("Clicked the menu item for the '{0}' node.", node.Text))
        End Sub
    End Class

    <Export(GetType(IExplorerNodeTypeExtension))> _
    <ExplorerNodeType(ExtensionNodeTypes.FieldNode)> _
    Friend Class FieldNodeExtensionWithProperty
        Implements IExplorerNodeTypeExtension

        Private Sub Initialize(ByVal nodeType As IExplorerNodeType) _
            Implements IExplorerNodeTypeExtension.Initialize
            AddHandler nodeType.NodePropertiesRequested, AddressOf NodePropertiesRequested
        End Sub

        Private Sub NodePropertiesRequested(ByVal Sender As Object, ByVal e As ExplorerNodePropertiesRequestedEventArgs)
            Dim propertyObject As ExampleProperty = Nothing

            ' Only add the property to "Body" fields.
            If e.Node.Text = "Body" Then
                ' If the properties object already exists for this node, get it from the node's annotations.
                If False = e.Node.Annotations.TryGetValue(propertyObject) Then
                    ' Otherwise, create a new properties object and add it to the annotations.
                    propertyObject = New ExampleProperty(e.Node)
                    e.Node.Annotations.Add(propertyObject)
                End If
                e.PropertySources.Add(propertyObject)
            End If
        End Sub
    End Class

    Friend Class ExampleProperty

        Private node As IExplorerNode
        Private Const propertyId As String = "Contoso.CustomActionTestProperty"
        Private Const propertyDefaultValue As String = "This is a test value."

        Friend Sub New(ByVal node As IExplorerNode)
            Me.node = node
        End Sub

        ' Gets or sets a simple string property. 
        <DisplayName("ContosoExampleProperty")> _
        <DescriptionAttribute("This is an example property for field nodes.")> _
        <DefaultValue(propertyDefaultValue)> _
        Public Property TestProperty As String
            Get
                Dim propertyValue As String = Nothing

                ' Get the current property value if it already exists; otherwise, return a default value.
                If False = node.Annotations.TryGetValue(propertyId, propertyValue) Then
                    propertyValue = propertyDefaultValue
                End If
                Return propertyValue
            End Get
            Set(ByVal value As String)
                If value <> propertyDefaultValue Then
                    ' Store the property value in the Annotations property of the node. 
                    ' Data in the Annotations property does not persist when Visual Studio exits.
                    node.Annotations(propertyId) = value
                Else
                    ' Do not save the default value.
                    node.Annotations.Values.Remove(propertyId)
                End If
            End Set
        End Property
    End Class
End Namespace
'</Snippet9>


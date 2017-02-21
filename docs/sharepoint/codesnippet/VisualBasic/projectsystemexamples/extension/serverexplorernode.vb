'<Snippet5>
Imports System.ComponentModel.Composition
Imports Microsoft.VisualStudio.SharePoint
Imports Microsoft.VisualStudio.SharePoint.Explorer

Namespace Contoso.ServerExplorerExtension

    '<Snippet6>
    <Export(GetType(IExplorerNodeTypeProvider))> _
    <ExplorerNodeType(ExampleNodeTypeProvider.NodeTypeId)> _
    Friend Class ExampleNodeTypeProvider
        Implements IExplorerNodeTypeProvider
        Friend Const NodeTypeId As String = "Contoso.ServerExplorerNodeExample"

        Private Sub InitializeType(ByVal typeDefinition As IExplorerNodeTypeDefinition) _
            Implements IExplorerNodeTypeProvider.InitializeType
            typeDefinition.DefaultIcon = _
                My.Resources.CustomChildNodeIcon.ToBitmap()
            typeDefinition.IsAlwaysLeaf = True
        End Sub
    End Class
    '</Snippet6>

    '<Snippet7>
    <Export(GetType(IExplorerNodeTypeExtension))> _
    <ExplorerNodeType(ExplorerNodeTypes.SiteNode)> _
    Friend Class SiteNodeExtension
        Implements IExplorerNodeTypeExtension

        Private Sub Initialize(ByVal nodeType As IExplorerNodeType) _
            Implements IExplorerNodeTypeExtension.Initialize
            AddHandler nodeType.NodeChildrenRequested, AddressOf NodeChildrenRequested
        End Sub

        '<Snippet8>
        Private Sub NodeChildrenRequested(ByVal Sender As Object, ByVal e As ExplorerNodeEventArgs)
            e.Node.ChildNodes.Add(ExampleNodeTypeProvider.NodeTypeId, _
                "Custom Node", Nothing)
        End Sub
        '</Snippet8>
    End Class
    '</Snippet7>
End Namespace
'</Snippet5>

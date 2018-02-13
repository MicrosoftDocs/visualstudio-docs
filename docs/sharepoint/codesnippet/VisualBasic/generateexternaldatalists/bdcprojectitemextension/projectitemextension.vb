'<Snippet1>
Imports Microsoft.VisualStudio.SharePoint
Imports System.ComponentModel.Composition

Namespace Contoso.SharePointProjectItemExtensions.GenerateExternalDataLists

    ' Export attribute: Enables Visual Studio to discover and load this extension.
    ' SharePointProjectItemType attribute: Specifies the ID of the project item to extend.
    ' GenerateExternalDataListsExtension class: Defines the extension for the BDC project item.
    '     The other part of the partial class contains the logic for generating the external data lists. 
    <Export(GetType(ISharePointProjectItemTypeExtension))> _
    <SharePointProjectItemType("Microsoft.VisualStudio.SharePoint.BusinessDataConnectivity")> _
    Partial Friend Class GenerateExternalDataListsExtension
        Implements ISharePointProjectItemTypeExtension

        ' Creates the new shortcut menu item that the user clicks to generate the external data lists.
        Private Sub Initialize(ByVal SharePointProjectItemType As ISharePointProjectItemType) _
            Implements ISharePointProjectItemTypeExtension.Initialize
            AddHandler SharePointProjectItemType.ProjectItemMenuItemsRequested,
                AddressOf SharePointProjectItemMenuItemsRequested
        End Sub

        Private Sub SharePointProjectItemMenuItemsRequested(ByVal Sender As Object, _
            ByVal e As SharePointProjectItemMenuItemsRequestedEventArgs)
            Dim generateListMenuItem As IMenuItem = e.ViewMenuItems.Add("Generate External Data List")
            AddHandler generateListMenuItem.Click, AddressOf GenerateExternalDataLists_Execute
        End Sub
    End Class
End Namespace
'</Snippet1>


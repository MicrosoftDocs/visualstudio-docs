'<Snippet1>
Imports System
Imports System.Diagnostics
Imports System.ComponentModel
Imports System.ComponentModel.Composition
Imports Microsoft.VisualStudio.SharePoint

Namespace Contoso.SharePointProjectItems.SiteColumn

    ' Export attribute: Enables Visual Studio to discover and load this extension.
    ' SharePointProjectItemType attribute: Specifies the ID for the new project item type. This string must match the value of the 
    '     Type attribute of the ProjectItem element in the .spdata file for the project item.
    ' SiteColumnProjectItemTypeProvider class: Defines a new type of project item.
    <Export(GetType(ISharePointProjectItemTypeProvider))> _
    <SharePointProjectItemType("Contoso.SiteColumn")> _
    Partial Friend Class SiteColumnProjectItemTypeProvider
        Implements ISharePointProjectItemTypeProvider

        Private WithEvents projectItemTypeDefinition As ISharePointProjectItemTypeDefinition

        ' Configures the behavior of the project item type.
        Private Sub InitializeType(ByVal projectItemTypeDefinition As ISharePointProjectItemTypeDefinition) _
            Implements ISharePointProjectItemTypeProvider.InitializeType

            projectItemTypeDefinition.SupportedDeploymentScopes = _
                SupportedDeploymentScopes.Site Or SupportedDeploymentScopes.Web
            projectItemTypeDefinition.SupportedTrustLevels = SupportedTrustLevels.All
            Me.projectItemTypeDefinition = projectItemTypeDefinition
        End Sub

        ' Creates a custom property for this project item.
        Private Sub ProjectItemPropertiesRequested(ByVal Sender As Object,
            ByVal e As SharePointProjectItemPropertiesRequestedEventArgs) _
            Handles projectItemTypeDefinition.ProjectItemPropertiesRequested

            Dim properties As SiteColumnProperties = Nothing

            ' If the properties object already exists, get it from the project item's annotations.
            If False = e.ProjectItem.Annotations.TryGetValue(properties) Then
                ' Otherwise, create a new properties object and add it to the annotations.
                properties = New SiteColumnProperties(e.ProjectItem)
                e.ProjectItem.Annotations.Add(properties)
            End If
            e.PropertySources.Add(properties)
        End Sub
    End Class

    Friend Class SiteColumnProperties
        Private projectItem As ISharePointProjectItem
        Private Const TestPropertyId As String = "Contoso.SiteColumnProperty"
        Private Const PropertyDefaultValue As String = "Default custom property value."

        Friend Sub New(ByVal projectItem As ISharePointProjectItem)
            Me.projectItem = projectItem
        End Sub

        'The property gets or sets a simple string value. 
        <DisplayName("Example Property")> _
        <DescriptionAttribute("This is an example property for site column project items.")> _
        <DefaultValue(PropertyDefaultValue)> _
        Public Property ExampleProperty As String
            Get
                Dim propertyValue As String = Nothing

                ' Get the current property value if it already exists; otherwise, return a default value.
                If False = projectItem.ExtensionData.TryGetValue(TestPropertyId, propertyValue) Then
                    propertyValue = PropertyDefaultValue
                End If
                Return propertyValue
            End Get
            Set(ByVal value As String)
                If value <> PropertyDefaultValue Then
                    ' Store the property value in the ExtensionData property of the project item.
                    ' Data in the ExtensionData property persists when the project is closed.
                    projectItem.ExtensionData(TestPropertyId) = value
                Else
                    ' Do not save the default value.
                    projectItem.ExtensionData.Remove(TestPropertyId)
                End If
            End Set
        End Property
    End Class
End Namespace
'</Snippet1>
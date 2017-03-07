'<Snippet8>
Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Composition
Imports Microsoft.VisualStudio.SharePoint

Namespace Contoso.Examples.ProjectItemExtensionWithProperty

    <Export(GetType(ISharePointProjectItemTypeExtension))> _
    <SharePointProjectItemType("Microsoft.VisualStudio.SharePoint.EventHandler")> _
    Friend Class ExampleProjectItemExtensionWithProperty
        Implements ISharePointProjectItemTypeExtension

        '<Snippet9>
        Private Sub Initialize(ByVal projectItemType As ISharePointProjectItemType) _
            Implements ISharePointProjectItemTypeExtension.Initialize
            AddHandler projectItemType.ProjectItemPropertiesRequested, AddressOf ProjectItemPropertiesRequested
        End Sub
        '</Snippet9>

        '<Snippet10>
        Private Sub ProjectItemPropertiesRequested(ByVal Sender As Object,
            ByVal e As SharePointProjectItemPropertiesRequestedEventArgs)
            Dim propertyObject As CustomProperties = Nothing

            ' If the properties object already exists, get it from the project item's annotations.
            If False = e.ProjectItem.Annotations.TryGetValue(propertyObject) Then
                ' Otherwise, create a new properties object and add it to the annotations.
                propertyObject = New CustomProperties(e.ProjectItem)
                e.ProjectItem.Annotations.Add(propertyObject)
            End If
            e.PropertySources.Add(propertyObject)
        End Sub
        '</Snippet10>
    End Class

    Friend Class CustomProperties
        Private projectItem As ISharePointProjectItem

        Friend Sub New(ByVal projectItem As ISharePointProjectItem)
            Me.projectItem = projectItem
        End Sub

        Private Const TestPropertyId As String = "Contoso.ExampleProperty"
        Private Const PropertyDefaultValue As String = "This is an example property."

        <DisplayName("Example Property")> _
        <DescriptionAttribute("This is an example property for project items.")> _
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
'</Snippet8>


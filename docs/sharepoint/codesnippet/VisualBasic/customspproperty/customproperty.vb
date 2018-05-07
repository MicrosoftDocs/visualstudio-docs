' <Snippet1>
Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Composition
Imports Microsoft.VisualStudio
Imports Microsoft.VisualStudio.SharePoint
Imports Microsoft.VisualStudio.Shell.Interop

Namespace CustomSharePointProperty

    <Export(GetType(ISharePointProjectExtension))> _
    Partial Friend Class ProjectExtensionWithProperty
        Implements ISharePointProjectExtension

        Public Sub Initialize(ByVal projectService As ISharePointProjectService) _
            Implements ISharePointProjectExtension.Initialize
            AddHandler projectService.ProjectPropertiesRequested, _
                AddressOf ProjectPropertiesRequested
        End Sub

        Private Sub ProjectPropertiesRequested(ByVal sender As Object, _
            ByVal e As SharePointProjectPropertiesRequestedEventArgs)

            Dim propertiesObject As CustomProjectProperties = Nothing

            ' If the properties object already exists, get it from the project's annotations.
            If False = e.Project.Annotations.TryGetValue(propertiesObject) Then
                ' Otherwise, create a new properties object and add it to the annotations.
                propertiesObject = New CustomProjectProperties(e.Project)
                e.Project.Annotations.Add(propertiesObject)
            End If

            e.PropertySources.Add(propertiesObject)
        End Sub
    End Class

    Public Class CustomProjectProperties
        '<Snippet3>
        Private sharePointProject As ISharePointProject
        Private projectStorage As IVsBuildPropertyStorage
        Private Const ProjectFilePropertyId As String = "ContosoCustomProjectFileProperty"
        Private Const ProjectFilePropertyDefaultValue As String = "Default"

        Public Sub New(ByVal myProject As ISharePointProject)
            sharePointProject = myProject
            projectStorage = sharePointProject.ProjectService.Convert(Of ISharePointProject, IVsBuildPropertyStorage)(sharePointProject)
        End Sub

        <DisplayName("Custom Project File Property")> _
        <DescriptionAttribute("This property is saved to the .csproj/.vbproj file.")> _
        <DefaultValue(ProjectFilePropertyDefaultValue)> _
        Public Property CustomProjectFileProperty As String
            Get
                Dim propertyValue As String = String.Empty
                Dim hr As Integer = projectStorage.GetPropertyValue(ProjectFilePropertyId, String.Empty, _
                    CUInt(_PersistStorageType.PST_PROJECT_FILE), propertyValue)

                ' Try to get the current value from the project file; if it does not yet exist, return a default value.
                If Not ErrorHandler.Succeeded(hr) Or String.IsNullOrEmpty(propertyValue) Then
                    propertyValue = ProjectFilePropertyDefaultValue
                End If
                Return propertyValue
            End Get
            Set(ByVal value As String)
                ' Do not save the default value.
                If value <> ProjectFilePropertyDefaultValue Then
                    projectStorage.SetPropertyValue(ProjectFilePropertyId, String.Empty, _
                        CUInt(_PersistStorageType.PST_PROJECT_FILE), value)
                End If
            End Set
        End Property
        '</Snippet3>

        '<Snippet2>
        Private Const UserFilePropertyId As String = "ContosoCustomUserFileProperty"
        Private Const UserFilePropertyDefaultValue As String = "Default"

        <DisplayName("Custom Project User File Property")> _
        <DescriptionAttribute("This property is saved to the .user file.")> _
        <DefaultValue(UserFilePropertyDefaultValue)> _
        Public Property CustomUserFileProperty As String
            Get
                Dim propertyValue As String = String.Empty
                ' Try to get the current value from the .user file; if it does not yet exist, return a default value.
                If Not sharePointProject.ProjectUserFileData.TryGetValue(UserFilePropertyId, propertyValue) Then
                    propertyValue = UserFilePropertyDefaultValue
                End If
                Return propertyValue
            End Get
            Set(ByVal value As String)
                ' Do not save the default value.
                If value <> UserFilePropertyDefaultValue Then
                    sharePointProject.ProjectUserFileData(UserFilePropertyId) = value
                End If
            End Set
        End Property
        '</Snippet2>
    End Class
End Namespace
' </Snippet1>

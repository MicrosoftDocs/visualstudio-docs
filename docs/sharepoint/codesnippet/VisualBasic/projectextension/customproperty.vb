'<Snippet1>
Imports System
Imports System.Linq
Imports System.ComponentModel
Imports System.ComponentModel.Composition
Imports System.Windows.Forms
Imports Microsoft.VisualStudio.SharePoint
Imports EnvDTE

Namespace Contoso.SharePointProjectExtensions.MapImagesFolder

    ' Export attribute: Enables Visual Studio to discover and load this extension.
    ' MapImagesFolderProjectExtension class: Adds a new Map Images Folder property to any SharePoint project.
    <Export(GetType(ISharePointProjectExtension))> _
    Public Class MapImagesFolderProjectExtension
        Implements ISharePointProjectExtension

        Public Sub Initialize(ByVal projectService As ISharePointProjectService) Implements ISharePointProjectExtension.Initialize
            AddHandler projectService.ProjectPropertiesRequested, AddressOf Me.projectService_ProjectPropertiesRequested
        End Sub

        Private Sub projectService_ProjectPropertiesRequested(ByVal sender As Object, ByVal e As SharePointProjectPropertiesRequestedEventArgs)
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
        Private sharePointProject As ISharePointProject = Nothing
        Private Const MapImagesFolderPropertyDefaultValue As Boolean = False
        Private Const MapImagesFolderPropertyId = "ContosoMapImagesFolderProperty"

        Public Sub New(ByVal myProject As ISharePointProject)
            sharePointProject = myProject
        End Sub

        ' Represents the new boolean property MapImagesFolder.
        ' True = Map an Images folder to the project if one does not already exist; otherwise, do nothing.
        ' False = Remove the Images folder from the project, if one exists; otherwise, do nothing.
        <DisplayName("Map Images Folder")> _
        <DescriptionAttribute("Specifies whether an Images folder is mapped to the SharePoint project.")> _
        <DefaultValue(MapImagesFolderPropertyDefaultValue)> _
        Public Property MapImagesFolder As Boolean
            Get
                Dim propertyStringValue As String = String.Empty

                ' Try to get the current value from the .user file; if it does not yet exist, return a default value.
                If Not sharePointProject.ProjectUserFileData.TryGetValue(MapImagesFolderPropertyId, propertyStringValue) Then
                    Return MapImagesFolderPropertyDefaultValue
                Else
                    Return CBool(propertyStringValue)
                End If
            End Get

            Set(ByVal value As Boolean)
                If value Then
                    If Not ImagesMappedFolderInProjectExists(sharePointProject) Then
                        ' An Images folder is not mapped to the project, so map one.
                        Dim mappedFolder As IMappedFolder = sharePointProject.MappedFolders.Add(MappedFolderType.Images)
                        sharePointProject.ProjectService.Logger.WriteLine( _
                            mappedFolder.Name & " mapped folder added to the project.", LogCategory.Status)
                    End If
                ElseIf (ImagesMappedFolderInProjectExists(sharePointProject) AndAlso UserSaysDeleteFile()) Then
                    ' An Images folder is mapped to the project and the user wants to remove it.
                    DeleteFolder()
                End If

                sharePointProject.ProjectUserFileData(MapImagesFolderPropertyId) = value.ToString()
            End Set
        End Property

        Private Function ImagesMappedFolderInProjectExists(ByVal sharePointProject As ISharePointProject) As Boolean
            Dim returnValue As Boolean = False
            For Each folder As IMappedFolder In sharePointProject.MappedFolders
                ' Check to see if an Images folder is already mapped.
                If (folder.FolderType = MappedFolderType.Images) Then
                    returnValue = True
                End If
            Next
            Return returnValue
        End Function

        Private Function UserSaysDeleteFile() As Boolean
            ' Ask the user whether they want to delete the Images folder.
            Dim returnValue As Boolean = False
            If (MessageBox.Show("Do you want to delete the Images folder from the project?", _
                "Delete the Images folder?", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                returnValue = True
            End If
            Return returnValue
        End Function

        Private Sub DeleteFolder()
            ' The Visual Studio DTE object model is required to delete the mapped folder.
            Dim dteProject As EnvDTE.Project = _
                sharePointProject.ProjectService.Convert(Of ISharePointProject, EnvDTE.Project)(sharePointProject)
            Dim targetFolderName As String = _
                sharePointProject.MappedFolders.First(Function(mf) mf.FolderType = MappedFolderType.Images).Name
            Dim mappedFolderItem As EnvDTE.ProjectItem = dteProject.ProjectItems.Item(targetFolderName)
            mappedFolderItem.Delete()

            sharePointProject.ProjectService.Logger.WriteLine("Mapped Folder " & _
                targetFolderName & " deleted", LogCategory.Status)
        End Sub
    End Class
End Namespace
' </Snippet1>
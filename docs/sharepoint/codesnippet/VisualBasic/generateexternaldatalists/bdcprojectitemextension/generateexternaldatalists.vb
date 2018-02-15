'<Snippet2>
Imports Microsoft.VisualStudio.SharePoint
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Xml.Linq

Namespace Contoso.SharePointProjectItemExtensions.GenerateExternalDataLists

    ' Creates the external data lists for the BDC item. The other part of the partial class 
    ' defines the BDC project item extension.
    Partial Friend Class GenerateExternalDataListsExtension

        Private Const ModelFileNameString As String = "ModelFileName"
        Private Const EXTENSION_BDCM As String = ".bdcm"
        Private Const NamespaceString As String = "http://schemas.microsoft.com/windows/2007/BusinessDataCatalog"
        Private Shared ReadOnly BdcNamespace As XNamespace = XNamespace.Get(NamespaceString)

        ' Generates an external data list for each Entity in the BDC model. This event handler is called
        ' when the developer clicks the shortcut menu item that the extension adds to the BDC project item.
        Private Sub GenerateExternalDataLists_Execute(ByVal Sender As Object, ByVal e As MenuItemEventArgs)

            Dim projectItem As ISharePointProjectItem = CType(e.Owner, ISharePointProjectItem)
            Dim bdcmFile As ISharePointProjectItemFile = GetModelFile(projectItem)

            Dim doc As XDocument = XDocument.Load(bdcmFile.FullPath)
            Dim skippedEntities As List(Of XElement) = New List(Of XElement)()

            ' Try to generate an external data list for each entity defined in the BDC model file.
            For Each entity As XElement In doc.Root.Elements(BdcNamespace + "LobSystems").Elements( _
                BdcNamespace + "LobSystem").Elements(BdcNamespace + "Entities").Elements(BdcNamespace + "Entity")

                If False = GenerateExternalDataList(projectItem, entity) Then
                    skippedEntities.Add(entity)
                End If
            Next

            ' Report skipped entities.
            If skippedEntities.Count <> 0 Then
                Dim entityNameList As StringBuilder = Nothing
                skippedEntities.ForEach(Function(entity As XElement)
                                            If (entityNameList Is Nothing) Then
                                                entityNameList = New StringBuilder()
                                            Else
                                                entityNameList.AppendLine(",")
                                            End If
                                            entityNameList.Append(entity.Attribute("Name").Value)
                                        End Function)

                Dim message As String = String.Format("The following Entities were skipped because " &
                    "either a LobSystemInstance, SpecificFinder, or Finder was not found for them. \r\n{0}", _
                    entityNameList)
                projectItem.Project.ProjectService.Logger.WriteLine(message, LogCategory.Warning)
            End If
        End Sub

        ' Gets the ISharePointProjectItemFile object for the BDC model file.
        Private Function GetModelFile(ByVal projectItem As ISharePointProjectItem) As ISharePointProjectItemFile

            Dim modelFileName As String = Nothing
            If projectItem.FeatureProperties.TryGetValue(ModelFileNameString, modelFileName) Then
                modelFileName = Path.GetFileName(modelFileName)
                Return (From file In projectItem.Files _
                        Where String.Compare(file.Name, modelFileName, StringComparison.OrdinalIgnoreCase) = 0 _
                        Select file).FirstOrDefault()
            Else
                ' If we can't find the ModelFileName through the FeatureProperties, 
                ' get the first file that has a '.bdcm' extension
                Return (From file In projectItem.Files _
                        Where file.Name.EndsWith(EXTENSION_BDCM, StringComparison.OrdinalIgnoreCase) _
                        Select file).FirstOrDefault()
            End If
        End Function

        ' Boilerplate XML for the new list instance that is based on the BDC model.
        Private Const externalDataListContent As String = _
            "<?xml version=""1.0"" encoding=""utf-8""?>" & vbCrLf & _
            "        <Elements xmlns=""http://schemas.microsoft.com/sharepoint/"">" & vbCrLf & _
            "          <ListInstance Title=""$EntityName$DataList""" & vbCrLf & _
            "                        OnQuickLaunch=""TRUE""" & vbCrLf & _
            "                        TemplateType=""104""" & vbCrLf & _
            "                        FeatureId=""$SharePoint.Feature.Id$""" & vbCrLf & _
            "                        Url=""Lists/$EntityName$DataList""" & vbCrLf & _
            "                        Description=""Default List for $EntityName$."">" & vbCrLf & _
            "            <DataSource>" & vbCrLf & _
            "              <Property Name=""LobSystemInstance"" Value=""$LobSystemInstance$"" />" & vbCrLf & _
            "              <Property Name=""EntityNamespace"" Value=""$EntityNamespace$"" />" & vbCrLf & _
            "              <Property Name=""Entity"" Value=""$EntityName$"" />" & vbCrLf & _
            "              <Property Name=""SpecificFinder"" Value=""$SpecificFinder$"" />" & vbCrLf & _
            "              <Property Name=""Finder"" Value=""$Finder$"" />" & vbCrLf & _
            "            </DataSource>" & vbCrLf & _
            "          </ListInstance>" & vbCrLf & _
            "        </Elements>"

        ' Tries to generate an external data list for the specified BDC model project item and entity.
        Private Function GenerateExternalDataList(ByVal projectItem As ISharePointProjectItem, ByVal entity As XElement) As Boolean

            Dim lobSystemInstanceName As String = GetLobSystemInstanceName(entity)
            Dim specificFinderName As String = GetSpecificFinderName(entity)
            Dim finderName As String = GetFinderName(entity)
            Dim entityName As String = entity.Attribute("Name").Value

            If String.IsNullOrEmpty(lobSystemInstanceName) Or String.IsNullOrEmpty(specificFinderName) Or _
                String.IsNullOrEmpty(finderName) Then
                Return False
            End If

            Dim newExternalDataListName As String = entityName & "DataList"
            Dim existingProjectItem As ISharePointProjectItem = (From existingItem As ISharePointProjectItem In projectItem.Project.ProjectItems
                                                Where existingItem.Name = newExternalDataListName
                                                Select existingItem).FirstOrDefault()

            ' Add a new list instance and populate it with data from the BDC model.
            If existingProjectItem Is Nothing Then
                Dim newExternalDataList As ISharePointProjectItem = projectItem.Project.ProjectItems.Add(newExternalDataListName, _
                    "Microsoft.VisualStudio.SharePoint.ListInstance")

                Dim newExternalDataListString As String = externalDataListContent
                newExternalDataListString = newExternalDataListString.Replace("$EntityName$", entityName)
                newExternalDataListString = newExternalDataListString.Replace("$LobSystemInstance$", lobSystemInstanceName)
                newExternalDataListString = newExternalDataListString.Replace("$EntityNamespace$", entity.Attribute("Namespace").Value)
                newExternalDataListString = newExternalDataListString.Replace("$SpecificFinder$", specificFinderName)
                newExternalDataListString = newExternalDataListString.Replace("$Finder$", finderName)

                Dim elementsXmlPath As String = Path.Combine(newExternalDataList.FullPath, "Elements.xml")
                File.WriteAllText(elementsXmlPath, newExternalDataListString)
                Dim elementsFile As ISharePointProjectItemFile = newExternalDataList.Files.AddFromFile(elementsXmlPath)
                elementsFile.DeploymentType = DeploymentType.ElementManifest
            End If

            Return True
        End Function

        Private Function GetLobSystemInstanceName(ByVal entity As XElement) As String

            Dim lobSystemInstances As XElement = entity.Parent.Parent.Element(BdcNamespace + "LobSystemInstances")
            If lobSystemInstances IsNot Nothing Then
                Dim lobSystemInstance As XElement = lobSystemInstances.Elements(BdcNamespace + "LobSystemInstance").FirstOrDefault()
                If lobSystemInstance IsNot Nothing Then
                    Return lobSystemInstance.Attribute("Name").Value
                End If
            End If
            Return Nothing
        End Function

        Private Function GetSpecificFinderName(ByVal entity As XElement) As String
            Return GetMethodInstance(entity, "SpecificFinder")
        End Function

        Private Function GetFinderName(ByVal entity As XElement) As String
            Return GetMethodInstance(entity, "Finder")
        End Function

        Private Function GetMethodInstance(ByVal entity As XElement, ByVal methodInstanceType As String) As String
            Dim methods As XElement = entity.Element(BdcNamespace + "Methods")
            If methods IsNot Nothing Then
                For Each method As XElement In methods.Elements(BdcNamespace + "Method")
                    Dim methodInstances As XElement = method.Element(BdcNamespace + "MethodInstances")
                    If methodInstances IsNot Nothing Then
                        For Each methodInstance As XElement In methodInstances.Elements(BdcNamespace + "MethodInstance")
                            If methodInstance.Attribute("Type").Value = methodInstanceType Then
                                Return methodInstance.Attribute("Name").Value
                            End If
                        Next
                    End If
                Next
            End If
            Return Nothing
        End Function

    End Class
End Namespace
'</Snippet2>

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

' Need to mention this in snippet intros.
Imports Microsoft.VisualStudio.Tools.Applications
Imports Microsoft.VisualStudio.Tools.Applications.Runtime

Partial Public Class Form1
    Inherits Form

    ' All of these snippets assume Book1.xlsx exists on the desktop!!!
    Public Sub New()
        InitializeComponent()

        Dim desktopPath As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        'CreateServerDocumentFromPath((desktopPath + "\ExcelWorkbook1.xlsx"))
        'CreateServerDocumentFromByteArray((desktopPath + "\ExcelWorkbook1.xlsx"))
        'CreateServerDocumentFromStream((desktopPath + "\ExcelWorkbook1.xlsx"))
        'CreateServerDocumentReadOnly((desktopPath + "\ExcelWorkbook1.xlsx"))
        'DisplayDataCacheContents((desktopPath + "\ExcelWorkbook1.xlsx"))
        'AddCustomizationUsingDocumentPath(desktopPath + "\ExcelWorkbook1.xlsx", desktopPath + "\Publish Test\ExcelWorkbook1.vsto")
        'AddCustomizationUsingAssemblyPath(desktopPath + "\ExcelWorkbook1.xlsx", desktopPath + "\Publish Test\ExcelWorkbook1_1_0_0_0\ExcelWorkbook1.dll.deploy", New Guid("5f51999b-7fd5-44c9-9360-0e28aa08e164"), desktopPath + "\Publish Test\ExcelWorkbook1.vsto")
        'RemoveAssembly((desktopPath + "\ExcelWorkbook1.xlsx"))
        'ModifyCachedString(desktopPath + "\ExcelWorkbook1.xlsx")
        'ReadCachedStringValue(desktopPath + "\ExcelWorkbook1.xlsx")
    End Sub

    '<Snippet1>
    Private Sub CreateServerDocumentFromPath(ByVal documentPath As String)
        Dim runtimeVersion As Integer = 0
        Dim serverDocument1 As ServerDocument = Nothing

        Try
            runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath)
            If runtimeVersion = 3 Then
                serverDocument1 = New ServerDocument(documentPath)
                MessageBox.Show("The URL of the deployment manifest is: " & vbLf & _
                    serverDocument1.DeploymentManifestUrl.ToString())
            End If

        Catch ex As System.IO.FileNotFoundException
            System.Windows.Forms.MessageBox.Show("The specified document does not exist.")
        Catch ex As UnknownCustomizationFileException
            System.Windows.Forms.MessageBox.Show("The specified document has a file " & _
                "extension that is not supported by Visual Studio Tools for Office.")
        Finally
            If Not (serverDocument1 Is Nothing) Then
                serverDocument1.Close()
            End If
        End Try
    End Sub
    '</Snippet1>

    ' Note: This works, but should come up with something a 
    ' little more useful. 
    '<Snippet2>
    Private Sub CreateServerDocumentFromByteArray(ByVal documentPath As String)
        Dim runtimeVersion As Integer = 0
        Dim serverDocument1 As ServerDocument = Nothing
        Dim stream As System.IO.FileStream = Nothing

        Try
            runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath)
            If runtimeVersion = 3 Then
                ' Read the file into a byte array.
                stream = New System.IO.FileStream(documentPath, System.IO.FileMode.Open, _
                    System.IO.FileAccess.Read)
                Dim buffer(Fix(stream.Length)) As Byte
                stream.Read(buffer, 0, Fix(buffer.Length))

                ' Display the number of bytes in the document.
                serverDocument1 = New ServerDocument(buffer, "*.xlsx")
                MessageBox.Show("The Document property contains " & _
                    serverDocument1.Document.Length.ToString() & " bytes.")
            End If

        Catch ex As System.IO.FileNotFoundException
            System.Windows.Forms.MessageBox.Show("The specified document does not exist.")
        Catch ex As UnknownCustomizationFileException
            System.Windows.Forms.MessageBox.Show("The specified document has a file " & _
                "extension that is not supported by Visual Studio Tools for Office.")
        Finally
            If Not (serverDocument1 Is Nothing) Then
                serverDocument1.Close()
            End If
            If Not (stream Is Nothing) Then
                stream.Close()
            End If
        End Try
    End Sub
    '</Snippet2>

    '<Snippet3>
    Private Sub CreateServerDocumentFromStream(ByVal documentPath As String)
        Dim runtimeVersion As Integer = 0
        Dim serverDocument1 As ServerDocument = Nothing
        Dim stream As System.IO.FileStream = Nothing

        Try
            runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath)
            If runtimeVersion = 3 Then
                stream = New System.IO.FileStream(documentPath, System.IO.FileMode.Open)
                serverDocument1 = New ServerDocument(stream, "*.xlsx")
                MessageBox.Show("The URL of the deployment manifest is: " & vbLf & _
                    serverDocument1.DeploymentManifestUrl.ToString())
            End If

        Catch ex As System.IO.FileNotFoundException
            System.Windows.Forms.MessageBox.Show("The specified document does not exist.")
        Catch ex As UnknownCustomizationFileException
            System.Windows.Forms.MessageBox.Show("The specified document has a file " & _
                "extension that is not supported by Visual Studio Tools for Office.")
        Finally
            If Not (serverDocument1 Is Nothing) Then
                serverDocument1.Close()
            End If
            If Not (stream Is Nothing) Then
                stream.Close()
            End If
        End Try
    End Sub
    '</Snippet3>

    '<Snippet4>
    Private Sub CreateServerDocumentReadOnly(ByVal documentPath As String)
        Dim runtimeVersion As Integer = 0
        Dim serverDocument1 As ServerDocument = Nothing

        Try
            runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath)
            If runtimeVersion = 3 Then
                serverDocument1 = New ServerDocument(documentPath, System.IO.FileAccess.Read)
                MessageBox.Show("The URL of the deployment manifest is: " & vbLf & _
                    serverDocument1.DeploymentManifestUrl.ToString())
            End If

        Catch ex As System.IO.FileNotFoundException
            System.Windows.Forms.MessageBox.Show("The specified document does not exist.")
        Catch ex As DocumentNotCustomizedException
            System.Windows.Forms.MessageBox.Show("The specified document does not " & _
                "have a customization.")
        Catch ex As UnknownCustomizationFileException
            System.Windows.Forms.MessageBox.Show("The specified document has a file " & _
                "extension that is not supported by Visual Studio Tools for Office.")
        Finally
            If Not (serverDocument1 Is Nothing) Then
                serverDocument1.Close()
            End If
        End Try
    End Sub
    '</Snippet4>

    '<Snippet5>
    Private Sub DisplayDataCacheContents(ByVal documentPath As String)
        Dim runtimeVersion As Integer = 0
        Dim serverDocument1 As ServerDocument = Nothing

        Try
            runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath)
            If runtimeVersion <> 3 Then
                MessageBox.Show("This document does not have a Visual Studio Tools for Office " & _
                    "customization, or it has a customization that was created with a version of " & _
                    "the runtime that is incompatible with this version of the ServerDocument class.")
                Return
            End If

            If ServerDocument.IsCacheEnabled(documentPath) Then
                serverDocument1 = New ServerDocument(documentPath)
                Dim stringBuilder1 As New System.Text.StringBuilder()

                ' Display all of the cached data items 
                ' in the document.
                Dim hostItem1 As CachedDataHostItem
                For Each hostItem1 In serverDocument1.CachedData.HostItems
                    stringBuilder1.Append(vbLf & "Namespace and class: ")
                    stringBuilder1.Append(hostItem1.Id & vbLf)
                    Dim dataItem1 As CachedDataItem
                    For Each dataItem1 In hostItem1.CachedData
                        stringBuilder1.Append("     Data item: ")
                        stringBuilder1.Append(dataItem1.Id & vbLf)
                    Next dataItem1
                Next hostItem1
                MessageBox.Show(stringBuilder1.ToString())
            Else
                MessageBox.Show("The specified document does not have cached data.")
            End If

        Catch ex As System.IO.FileNotFoundException
            System.Windows.Forms.MessageBox.Show("The specified document does not exist.")
        Catch ex As UnknownCustomizationFileException
            System.Windows.Forms.MessageBox.Show("The specified document has a file " & _
                "extension that is not supported by Visual Studio Tools for Office.")
        Finally
            If Not (serverDocument1 Is Nothing) Then
                serverDocument1.Close()
            End If
        End Try
    End Sub
    '</Snippet5>

    '<Snippet6>
    Private Sub AddCustomizationUsingDocumentPath(ByVal documentPath As String, _
        ByVal deployManifestPath As String)
        Dim runtimeVersion As Integer = 0

        Try
            ' Make sure that this document does not yet have any Visual Studio Tools 
            ' for Office customizations.
            runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath)
            If runtimeVersion = 0 Then
                Dim deploymentManifestUri As New Uri(deployManifestPath)
                ServerDocument.AddCustomization(documentPath, deploymentManifestUri)
                MessageBox.Show("The document was successfully customized.")
            Else
                System.Windows.Forms.MessageBox.Show("The document is already customized.")
            End If

        Catch ex As System.IO.FileNotFoundException
            System.Windows.Forms.MessageBox.Show("The specified document does not exist.")
        Catch ex As UnknownCustomizationFileException
            System.Windows.Forms.MessageBox.Show("The specified document has a file " & _
                "extension that is not supported by Visual Studio Tools for Office.")
        Catch ex As DocumentNotCustomizedException
            System.Windows.Forms.MessageBox.Show("The document could not be customized." & _
            vbLf & ex.Message)
        End Try
    End Sub
    '</Snippet6>

    '<Snippet7>
    Private Sub AddCustomizationUsingAssemblyPath(ByVal documentPath As String, _
        ByVal assemblyName As String, ByVal solutionID As Guid, ByVal deployManifestPath As String)
        Dim runtimeVersion As Integer = 0

        Try
            ' Make sure that this document does not yet have any Visual Studio Tools 
            ' for Office customizations.
            runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath)
            If runtimeVersion = 0 Then
                Dim deploymentManifestUri As New Uri(deployManifestPath)
                ServerDocument.AddCustomization(documentPath, assemblyName, solutionID, deploymentManifestUri)
                MessageBox.Show("The document was successfully customized.")
            Else
                System.Windows.Forms.MessageBox.Show("The document is already customized.")
            End If

        Catch ex As System.IO.FileNotFoundException
            System.Windows.Forms.MessageBox.Show("The specified document does not exist.")
        Catch ex As UnknownCustomizationFileException
            System.Windows.Forms.MessageBox.Show("The specified document has a file " & _
                "extension that is not supported by Visual Studio Tools for Office.")
        Catch ex As DocumentNotCustomizedException
            System.Windows.Forms.MessageBox.Show("The document could not be customized." & _
            vbLf & ex.Message)
        End Try
    End Sub
    '</Snippet7>

    '<Snippet8>
    Private Shared Sub RemoveAssembly(ByVal documentPath As String)
        Dim runtimeVersion As Integer = 0

        Try
            ' Make sure that this customization was created using the correct runtime.
            runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath)
            If runtimeVersion <> 3 Then
                MessageBox.Show("This document does not have a Visual Studio Tools for Office " & _
                    "customization, or it has a customization that was created with a version of " & _
                    "the runtime that is incompatible with this version of the ServerDocument class.")
                Return
            End If

            ServerDocument.RemoveCustomization(documentPath)
            MessageBox.Show("The customization has been removed.")

        Catch ex As System.IO.FileNotFoundException
            System.Windows.Forms.MessageBox.Show("The specified document does not exist.")
        Catch ex As System.IO.IOException
            System.Windows.Forms.MessageBox.Show("The specified document is read-only.")
        Catch ex As UnknownCustomizationFileException
            System.Windows.Forms.MessageBox.Show("The specified document has a file " & _
                "extension that is not supported by Visual Studio Tools for Office.")
        Catch ex As InvalidOperationException
            System.Windows.Forms.MessageBox.Show("The customization could not be removed." & _
                vbLf & ex.Message)
        End Try
    End Sub
    '</Snippet8>

    '<Snippet9>
    Private Sub ModifyCachedString(ByVal documentPath As String)
        Dim runtimeVersion As Integer = 0
        Dim serverDocument1 As ServerDocument = Nothing

        Try
            runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath)
            If runtimeVersion <> 3 Then
                MessageBox.Show("This document does not have a Visual Studio Tools for Office " & _
                    "customization, or it has a customization that was created with a version of " & _
                    "the runtime that is incompatible with this version of the ServerDocument class.")
                Return
            End If

            If ServerDocument.IsCacheEnabled(documentPath) Then
                '<Snippet11>
                '<Snippet12>
                serverDocument1 = New ServerDocument(documentPath)
                Dim hostItem1 As CachedDataHostItem = _
                    serverDocument1.CachedData.HostItems("ExcelWorkbook1.Sheet1")
                Dim dataItem1 As CachedDataItem = hostItem1.CachedData("CachedString")
                '</Snippet12>

                If dataItem1 IsNot Nothing AndAlso _
                    Type.GetType(dataItem1.DataType).Equals(GetType(String)) Then

                    dataItem1.SerializeDataInstance("This is the new cached string value.")
                    serverDocument1.Save()
                End If
                '</Snippet11>
            Else
                MessageBox.Show("The specified document does not have cached data.")
            End If

        Catch ex As System.IO.FileNotFoundException
            System.Windows.Forms.MessageBox.Show("The specified document does not exist.")
        Catch ex As UnknownCustomizationFileException
            System.Windows.Forms.MessageBox.Show("The specified document has a file " & _
                "extension that is not supported by Visual Studio Tools for Office.")
        Finally
            If Not (serverDocument1 Is Nothing) Then
                serverDocument1.Close()
            End If
        End Try
    End Sub
    '</Snippet9>

    '<Snippet10>
    Private Sub ReadCachedStringValue(ByVal documentPath As String)
        Dim runtimeVersion As Integer = 0
        Dim serverDocument1 As ServerDocument = Nothing

        Try
            runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath)
            If runtimeVersion <> 3 Then
                MessageBox.Show("This document does not have a Visual Studio Tools for Office " & _
                    "customization, or it has a customization that was created with a version of " & _
                    "the runtime that is incompatible with this version of the ServerDocument class.")
                Return
            End If

            If ServerDocument.IsCacheEnabled(documentPath) Then
                serverDocument1 = New ServerDocument(documentPath)
                Dim hostItem1 As CachedDataHostItem = _
                    serverDocument1.CachedData.HostItems("ExcelWorkbook1.Sheet1")
                Dim dataItem1 As CachedDataItem = hostItem1.CachedData("CachedString")

                If dataItem1 IsNot Nothing AndAlso _
                    Type.GetType(dataItem1.DataType).Equals(GetType(String)) Then

                    Using stringReader As New System.IO.StringReader(dataItem1.Xml)
                        Dim serializer As New System.Xml.Serialization.XmlSerializer(GetType(String))
                        Dim cachedString As String = serializer.Deserialize(stringReader)
                        MessageBox.Show("The value of CachedString is: " + cachedString)
                    End Using
                End If
            Else
                MessageBox.Show("The specified document does not have cached data.")
            End If

        Catch ex As System.IO.FileNotFoundException
            System.Windows.Forms.MessageBox.Show("The specified document does not exist.")
        Catch ex As UnknownCustomizationFileException
            System.Windows.Forms.MessageBox.Show("The specified document has a file " & _
                "extension that is not supported by Visual Studio Tools for Office.")
        Finally
            If Not (serverDocument1 Is Nothing) Then
                serverDocument1.Close()
            End If
        End Try
    End Sub
    '</Snippet10>

End Class
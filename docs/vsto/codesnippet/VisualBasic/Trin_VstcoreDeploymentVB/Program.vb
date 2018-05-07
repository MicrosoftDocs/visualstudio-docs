Imports System.IO
Imports System.IO.Packaging
Imports System.Xml

'<Snippet4>
'<Snippet1>
Imports Microsoft.VisualStudio.Tools.Applications
'</Snippet1>
Imports Microsoft.VisualStudio.Tools.Applications.Runtime
'</Snippet4>
Imports System

Class Program

    Shared Sub Main()
        'RemoveVSTOCustomization()
        'AddVSTOCustomization()
    End Sub

    Private Shared Sub RemoveVSTOCustomization()
        '<Snippet2>
        Dim documentPath As String = System.Environment.GetFolderPath( _
            Environment.SpecialFolder.Desktop) & "\WordDocument1.docx"
        Dim runtimeVersion As Integer = 0

        Try
            runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath)
            If runtimeVersion = 3 Then
                ServerDocument.RemoveCustomization(documentPath)
                System.Windows.Forms.MessageBox.Show("The customization has been removed.")
            End If
        Catch ex As FileNotFoundException
            System.Windows.Forms.MessageBox.Show("The specified document does not exist.")
        Catch ex As IOException
            System.Windows.Forms.MessageBox.Show("The specified document is read-only.")
        Catch ex As InvalidOperationException
            System.Windows.Forms.MessageBox.Show("The customization could not be removed." & _
                vbLf & ex.Message)
        End Try
        '</Snippet2>
    End Sub

    Private Shared Sub AddVSTOCustomization()
        '<Snippet3>
        Dim documentPath As String = System.Environment.GetFolderPath( _
             Environment.SpecialFolder.Desktop) + "\WordDocument1.docx"
        Dim runtimeVersion As Integer = 0

        Try
            runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath)

            ' Make sure that this document does not yet have any Visual Studio Tools 
            ' for Office customizations.
            If runtimeVersion = 0 Then
                Dim deployManifestPath As String = System.Environment.GetFolderPath( _
                    Environment.SpecialFolder.Desktop) & "\Publish\WordDocument1.vsto"
                Dim deploymentManifestUri As New Uri(deployManifestPath)
                ServerDocument.AddCustomization(documentPath, deploymentManifestUri)
                System.Windows.Forms.MessageBox.Show("The document was successfully customized.")
            Else
                System.Windows.Forms.MessageBox.Show("The document is already customized.")
            End If
        Catch ex As FileNotFoundException
            System.Windows.Forms.MessageBox.Show("The specified document does not exist.")
        Catch ex As DocumentNotCustomizedException
            System.Windows.Forms.MessageBox.Show("The document could not be customized." & _
                vbLf & ex.Message)
        End Try
        '</Snippet3>
    End Sub
End Class
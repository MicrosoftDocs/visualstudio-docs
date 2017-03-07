' <snippet7>
' <snippet1>
Imports Microsoft.VisualStudio.Tools.Applications.Deployment
Imports Microsoft.VisualStudio.Tools.Applications
' </snippet1>

' <snippet2>
Public Class FileCopyPDA
    Implements IAddInPostDeploymentAction
' </snippet2>

' <snippet3>
    Sub Execute(ByVal args As AddInPostDeploymentActionArgs) Implements IAddInPostDeploymentAction.Execute
        Dim dataDirectory As String = "Data\ExcelWorkbook.xlsx"
        Dim file As String = "ExcelWorkbook.xlsx"
        Dim sourcePath As String = args.AddInPath
        Dim deploymentManifestUri As Uri = args.ManifestLocation
        Dim destPath As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
        Dim sourceFile As String = System.IO.Path.Combine(sourcePath, dataDirectory)
        Dim destFile As String = System.IO.Path.Combine(destPath, file)

        Select Case args.InstallationStatus
            Case AddInInstallationStatus.InitialInstall, AddInInstallationStatus.Update
                System.IO.File.Copy(sourceFile, destFile)
                ServerDocument.RemoveCustomization(destFile)
                ServerDocument.AddCustomization(destFile, deploymentManifestUri)
                Exit Select
            Case AddInInstallationStatus.Uninstall
                If System.IO.File.Exists(destFile) Then
                    System.IO.File.Delete(destFile)
                End If
                Exit Select
        End Select
    End Sub
    ' </snippet3>
    ' </snippet7>

End Class

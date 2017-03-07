'<snippet4>
Imports Microsoft.VisualStudio.Tools.Applications.Deployment
'</snippet4>

'<snippet5>
Public Class RegistryPDA
    Implements IAddInPostDeploymentAction
'</snippet5>

'<snippet6>
    Sub Execute(ByVal args As AddInPostDeploymentActionArgs) Implements IAddInPostDeploymentAction.Execute
        Select Case args.InstallationStatus
            Case AddInInstallationStatus.InitialInstall
                Dim key As Microsoft.Win32.RegistryKey
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\Microsoft\VSTO Runtime Setup\v4")
                key.SetValue("RegKeyString", "Post-Deployment Action Test")
                key.Close()
                Exit Select
            Case AddInInstallationStatus.Uninstall
                Microsoft.Win32.Registry.LocalMachine.DeleteSubKey("SOFTWARE\Microsoft\VSTO Runtime Setup\v4\RegKeyString")
                Exit Select
        End Select
    End Sub
    '</snippet6>

End Class

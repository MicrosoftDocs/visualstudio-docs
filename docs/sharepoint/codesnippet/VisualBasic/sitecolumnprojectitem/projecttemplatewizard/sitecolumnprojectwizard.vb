'<Snippet7>
Imports EnvDTE
Imports Microsoft.VisualStudio.SharePoint
Imports Microsoft.VisualStudio.TemplateWizard
Imports System
Imports System.Collections.Generic

Public Class SiteColumnProjectWizard
    Implements IWizard

    Private wizardUI As WizardWindow
    Private dteObject As DTE
    Private presentationModel As SiteColumnWizardModel
    Private signingManager As ProjectSigningManager

    Public Sub New()
        signingManager = New ProjectSigningManager()
    End Sub

    Public Sub RunStarted(ByVal automationObject As Object, ByVal replacementsDictionary As Dictionary(Of String, String), _
        ByVal runKind As WizardRunKind, ByVal customParams() As Object) Implements IWizard.RunStarted

        dteObject = CType(automationObject, DTE)
        presentationModel = New SiteColumnWizardModel(dteObject, False)

        If Not presentationModel.ProjectService.IsSharePointInstalled Then
            Dim errorString As String = "A SharePoint server is not installed on this computer. A SharePoint server " &
                "must be installed to work with SharePoint projects."
            System.Windows.MessageBox.Show(errorString, "SharePoint Not Installed", System.Windows.MessageBoxButton.OK,
                System.Windows.MessageBoxImage.Error)
            Throw New WizardCancelledException(errorString)
        End If

        wizardUI = New WizardWindow(presentationModel)
        Dim dialogCompleted? As Boolean = wizardUI.ShowModal()

        If (dialogCompleted = True) Then
            replacementsDictionary.Add("$selectedfieldtype$", presentationModel.FieldType)
            replacementsDictionary.Add("$selectedgrouptype$", presentationModel.FieldGroup)
            replacementsDictionary.Add("$fieldname$", presentationModel.FieldName)
            signingManager.GenerateKeyFile()
        Else
            Throw New WizardCancelledException()
        End If
    End Sub

    ' Populate the SiteUrl and IsSandboxedSolution properties in the new project, and add a new 
    ' key.snk file to the project.
    Public Sub ProjectFinishedGenerating(ByVal project As Project) _
        Implements IWizard.ProjectFinishedGenerating
        Dim sharePointProject As ISharePointProject = presentationModel.ProjectService.Convert(Of Project, ISharePointProject)(project)
        sharePointProject.SiteUrl = New Uri(presentationModel.CurrentSiteUrl, UriKind.Absolute)
        sharePointProject.IsSandboxedSolution = presentationModel.IsSandboxed
        signingManager.AddKeyFile(project)
    End Sub

    ' Always return true; this IWizard implementation throws a WizardCancelledException
    ' that is handled by Visual Studio if the user cancels the wizard.
    Public Function ShouldAddProjectItem(ByVal filePath As String) As Boolean _
        Implements IWizard.ShouldAddProjectItem
        Return True
    End Function

    ' The following IWizard methods are not used in this example.
    Public Sub BeforeOpeningFile(ByVal projectItem As ProjectItem) _
        Implements IWizard.BeforeOpeningFile
    End Sub

    Public Sub ProjectItemFinishedGenerating(ByVal projectItem As ProjectItem) _
        Implements IWizard.ProjectItemFinishedGenerating
    End Sub

    Public Sub RunFinished() Implements IWizard.RunFinished
    End Sub
End Class
'</Snippet7>

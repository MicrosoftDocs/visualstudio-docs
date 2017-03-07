'<Snippet8>
Imports EnvDTE
Imports Microsoft.VisualStudio.TemplateWizard
Imports System
Imports System.Collections.Generic

Public Class CustomActionWizard
    Implements IWizard

    Private wizardPage As WizardWindow

#Region "IWizard Methods"

    Public Sub RunStarted(ByVal automationObject As Object, ByVal replacementsDictionary As Dictionary(Of String, String), _
        ByVal runKind As WizardRunKind, ByVal customParams() As Object) Implements IWizard.RunStarted
        wizardPage = New WizardWindow()
        Dim dialogCompleted? As Boolean = wizardPage.ShowModal()

        If (dialogCompleted = True) Then
            PopulateReplacementDictionary(replacementsDictionary)
        Else
            Throw New WizardCancelledException()
        End If
    End Sub

    ' Always return true; this IWizard implementation throws a WizardCancelledException
    ' that is handled by Visual Studio if the user cancels the wizard.
    Public Function ShouldAddProjectItem(ByVal filePath As String) As Boolean _
        Implements IWizard.ShouldAddProjectItem
        Return True
    End Function

    ' The following IWizard methods are not implemented in this example.
    Public Sub BeforeOpeningFile(ByVal projectItem As ProjectItem) _
        Implements IWizard.BeforeOpeningFile
    End Sub

    Public Sub ProjectFinishedGenerating(ByVal project As Project) _
        Implements IWizard.ProjectFinishedGenerating
    End Sub

    Public Sub ProjectItemFinishedGenerating(ByVal projectItem As ProjectItem) _
        Implements IWizard.ProjectItemFinishedGenerating
    End Sub

    Public Sub RunFinished() Implements IWizard.RunFinished
    End Sub

#End Region

    Private Sub PopulateReplacementDictionary(ByVal replacementsDictionary As Dictionary(Of String, String))

        ' Fill in the replacement values from the UI selections on the wizard page. These values are automatically inserted
        ' into the Elements.xml file for the custom action.
        Dim locationValue As String = If(wizardPage.standardMenuRadioButton.IsChecked,
                CustomActionLocations.StandardMenu, CustomActionLocations.ListEdit)
        replacementsDictionary.Add("$LocationValue$", locationValue)
        replacementsDictionary.Add("$GroupIdValue$", CType(wizardPage.idComboBox.SelectedItem, String))
        replacementsDictionary.Add("$IdValue$", Guid.NewGuid().ToString())

        Dim titleText As String = DefaultTextBoxStrings.TitleText
        If False = String.IsNullOrEmpty(wizardPage.titleTextBox.Text) Then
            titleText = wizardPage.titleTextBox.Text
        End If

        Dim descriptionText As String = DefaultTextBoxStrings.DescriptionText
        If False = String.IsNullOrEmpty(wizardPage.descriptionTextBox.Text) Then
            descriptionText = wizardPage.descriptionTextBox.Text
        End If

        Dim urlText As String = DefaultTextBoxStrings.UrlText
        If False = String.IsNullOrEmpty(wizardPage.urlTextBox.Text) Then
            urlText = wizardPage.urlTextBox.Text
        End If

        replacementsDictionary.Add("$TitleValue$", titleText)
        replacementsDictionary.Add("$DescriptionValue$", descriptionText)
        replacementsDictionary.Add("$UrlValue$", urlText)
    End Sub
End Class
'</Snippet8>


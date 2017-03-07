'<Snippet6>
Imports EnvDTE
Imports Microsoft.VisualStudio.SharePoint
Imports Microsoft.VisualStudio
Imports Microsoft.VisualStudio.Shell
Imports Microsoft.VisualStudio.Shell.Interop
Imports IOleServiceProvider = Microsoft.VisualStudio.OLE.Interop.IServiceProvider

Public Class SiteColumnWizardModel
    Private dteObject As DTE
    Private projectServiceValue As ISharePointProjectService
    Private validatedUrls As New List(Of String)

    Friend Sub New(ByVal dteObject As DTE, ByVal requiresFarmPriveleges As Boolean)
        Me.dteObject = dteObject

        ' Initialize default values for wizard choices.
        IsSandboxed = Not requiresFarmPriveleges
        IsSecondPagePopulated = False
        FieldType = "Text"
        FieldGroup = "Custom Columns"
        FieldName = "My Custom Column"
        CurrentSiteUrl = GetLocalHostUrl()
    End Sub

#Region "Helper methods used by the wizard UI"

    ' Specifies whether the current site URL is valid. Uses the ValidateSite SharePoint command to do this.
    Friend Function ValidateCurrentUrl(ByVal errorMessage As String) As Boolean
        Dim isValid As Boolean = False
        errorMessage = String.Empty

        If validatedUrls.Contains(CurrentSiteUrl) Then
            isValid = True
        Else
            Dim uriToValidate As Uri = New Uri(CurrentSiteUrl, UriKind.Absolute)
            Dim vsThreadedWaitDialog As IVsThreadedWaitDialog2 = Nothing

            Try
                vsThreadedWaitDialog = ShowProgressDialog("Connect to SharePoint",
                    "Connecting to SharePoint site " + CurrentSiteUrl)
                isValid = Me.ProjectService.SharePointConnection.ExecuteCommand(Of Uri, Boolean)(
                    Contoso.SharePoint.Commands.CommandIds.ValidateSite, uriToValidate)
            Catch ex As Exception
                errorMessage = "An error occurred while validating the site. " + ex.Message
            Finally
                If isValid Then
                    validatedUrls.Add(CurrentSiteUrl)
                End If
                If vsThreadedWaitDialog IsNot Nothing Then
                    CloseProgressDialog(vsThreadedWaitDialog)
                End If
            End Try
        End If
        Return isValid
    End Function

    ' Gets the available field types from the SharePoint site. Uses the GetFieldTypes SharePoint command to do this.
    Friend Function GetFieldTypes() As ArrayList
        ' If we have not yet validated this site, do it now.
        Dim errorMessage As String = String.Empty
        If Not ValidateCurrentUrl(errorMessage) Then
            MessageBox.Show(String.Format("Cannot connect to the SharePoint site: {0}. {1}",
                CurrentSiteUrl, errorMessage), "SharePoint Connection Error")
            Return Nothing
        End If

        ' Site is valid, so go ahead and get the available field types.
        Dim siteUri As Uri = New Uri(CurrentSiteUrl, UriKind.Absolute)
        Dim vsThreadedWaitDialog As IVsThreadedWaitDialog2 = ShowProgressDialog(
            "Connect to SharePoint", "Connecting to SharePoint site " + CurrentSiteUrl)
        Dim fieldTypesArray As String() = Me.ProjectService.SharePointConnection.ExecuteCommand(Of Uri, String())(
            Contoso.SharePoint.Commands.CommandIds.GetFieldTypes, siteUri)

        If vsThreadedWaitDialog IsNot Nothing Then
            CloseProgressDialog(vsThreadedWaitDialog)
        End If

        Return New ArrayList(fieldTypesArray)
    End Function

    ' Returns the default column group names in SharePoint.
    Friend Function GetFieldGroups() As List(Of String)
        Dim groups As List(Of String) = New List(Of String)()
        groups.Add("Base Columns")
        groups.Add("Core Contact and Calendar Columns")
        groups.Add("Core Document Columns")
        groups.Add("Core Task and Issue Columns")
        groups.Add("Extended Columns")
        Return groups
    End Function
#End Region

#Region "Properties shared by the wizard implementation and the wizard UI"

    Friend ReadOnly Property ProjectService As ISharePointProjectService
        Get
            If projectServiceValue Is Nothing Then
                projectServiceValue = GetProjectService()
            End If
            Return projectServiceValue
        End Get
    End Property

    Friend Property IsSecondPagePopulated As Boolean
    Friend Property IsSandboxed As Boolean
    Friend Property FieldType As String
    Friend Property FieldGroup As String
    Friend Property FieldName As String
    Friend Property CurrentSiteUrl As String
#End Region

#Region "Private methods"

    Private Function GetLocalHostUrl() As String
        Const HttpScheme As String = "http"
        Dim builder As UriBuilder = New UriBuilder(HttpScheme, Environment.MachineName.ToLowerInvariant())
        Return builder.ToString()
    End Function

    Private Function GetProjectService() As ISharePointProjectService
        Dim serviceProvider As ServiceProvider = New ServiceProvider(CType(dteObject, IOleServiceProvider))
        Return CType(serviceProvider.GetService(GetType(ISharePointProjectService)), ISharePointProjectService)
    End Function

    Private Function ShowProgressDialog(ByVal caption As String, ByVal message As String) As IVsThreadedWaitDialog2
        Dim oleServiceProvider As IOleServiceProvider = CType(dteObject, IOleServiceProvider)
        Dim dialogFactory As IVsThreadedWaitDialogFactory = CType(New ServiceProvider(oleServiceProvider).GetService(
            GetType(SVsThreadedWaitDialogFactory)), IVsThreadedWaitDialogFactory)

        If dialogFactory Is Nothing Then
            Throw New InvalidOperationException("The IVsThreadedWaitDialogFactory object could not be retrieved.")
        End If

        Dim vsThreadedWaitDialog As IVsThreadedWaitDialog2 = Nothing
        ErrorHandler.ThrowOnFailure(dialogFactory.CreateInstance(vsThreadedWaitDialog))
        ErrorHandler.ThrowOnFailure(vsThreadedWaitDialog.StartWaitDialog(caption, message,
            Nothing, Nothing, String.Empty, 0, False, True))
        Return vsThreadedWaitDialog
    End Function

    Private Sub CloseProgressDialog(ByVal vsThreadedWaitDialog As IVsThreadedWaitDialog2)
        If vsThreadedWaitDialog Is Nothing Then
            Throw New ArgumentNullException("vsThreadedWaitDialog")
        End If
        Dim canceled As Integer
        ErrorHandler.ThrowOnFailure(vsThreadedWaitDialog.EndWaitDialog(canceled))
    End Sub
#End Region
End Class
'</Snippet6>


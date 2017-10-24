'<Snippet9>
Imports Microsoft.SharePoint
Imports Microsoft.VisualStudio.SharePoint.Commands

Namespace Contoso.SharePoint.Commands

    Friend Class Commands

        <SharePointCommand(CommandIds.ValidateSite)> _
        Private Function ValidateSite(ByVal context As ISharePointCommandContext, ByVal url As Uri) As Boolean
            Using site As SPSite = New SPSite(url.AbsoluteUri)
                Dim webUrl As String = DetermineWebUrl(url.AbsolutePath, site.ServerRelativeUrl)
                If webUrl IsNot Nothing Then
                    Using web As SPWeb = site.OpenWeb(webUrl, True)
                        Return web.Exists
                    End Using
                End If
            End Using
            Return False
        End Function

        ' For simplicity, this command does not check to make sure the provided Uri is valid. 
        ' Use the ValidateSite command to verify that the Uri is valid first.
        <SharePointCommand(CommandIds.GetFieldTypes)> _
        Private Function GetFieldTypes(ByVal context As ISharePointCommandContext, ByVal url As Uri) As String()
            Dim columnDefinitions As List(Of String) = New List(Of String)()
            Using site As SPSite = New SPSite(url.AbsoluteUri)
                Dim webUrl As String = DetermineWebUrl(url.AbsolutePath, site.ServerRelativeUrl)
                Using web As SPWeb = site.OpenWeb(webUrl, True)
                    For Each columnDefinition As SPFieldTypeDefinition In web.FieldTypeDefinitionCollection
                        columnDefinitions.Add(columnDefinition.TypeName)
                    Next
                    ' SharePoint commands cannot serialize List<string>, so return an array.
                    Return columnDefinitions.ToArray()
                End Using
            End Using
        End Function

        Private Function DetermineWebUrl(ByVal serverRelativeInputUrl As String, ByVal serverRelativeSiteUrl As String) As String
            ' Make sure both URLs have a trailing slash.
            serverRelativeInputUrl = EnsureTrailingSlash(serverRelativeInputUrl)
            serverRelativeSiteUrl = EnsureTrailingSlash(serverRelativeSiteUrl)

            Dim webUrl As String = Nothing
            Dim isSubString As Boolean = serverRelativeInputUrl.StartsWith(serverRelativeSiteUrl, StringComparison.OrdinalIgnoreCase)

            If isSubString Then
                ' The Web URL cannot have escaped characters.
                webUrl = Uri.UnescapeDataString(serverRelativeInputUrl.Substring(serverRelativeSiteUrl.Length))
            End If
            Return webUrl
        End Function

        Private Function EnsureTrailingSlash(ByVal url As String)
            If Not String.IsNullOrEmpty(url) AndAlso url(url.Length - 1) <> "/" Then
                url += "/"
            End If
            Return url
        End Function
    End Class
End Namespace
'</Snippet9>

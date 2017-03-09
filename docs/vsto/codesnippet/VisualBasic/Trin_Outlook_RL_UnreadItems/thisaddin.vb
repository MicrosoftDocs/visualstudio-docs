Public Class ThisAddIn

    ' <Snippet1>
    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        Dim inbox As Outlook.MAPIFolder = _
            Me.Application.ActiveExplorer().Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox)

        Dim unreadItems As Outlook.Items = _
        inbox.Items.Restrict("[Unread]=true")

        MsgBox(String.Format("Unread items in Inbox = {0}", unreadItems.Count))
    End Sub
    ' </Snippet1>

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class

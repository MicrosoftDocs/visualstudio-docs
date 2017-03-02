Public Class ThisAddIn

    ' <snippet1>
    Dim outlookNameSpace As Outlook.NameSpace
    Dim inbox As Outlook.MAPIFolder
    Dim WithEvents items As Outlook.Items

    Private Sub ThisAddIn_Startup() Handles Me.Startup

        outlookNameSpace = Me.Application.GetNamespace("MAPI")
        inbox = _
            outlookNameSpace.GetDefaultFolder( _
            Outlook.OlDefaultFolders.olFolderInbox)
        items = inbox.Items

    End Sub

    Private Sub Items_ItemAdd(ByVal item As Object) Handles items.ItemAdd
        Dim filter As String = "USED CARS"
        If TypeOf (item) Is Outlook.MailItem Then
            Dim mail As Outlook.MailItem = item
            If mail.MessageClass = "IPM.Note" And _
     mail.Subject.ToUpper.Contains(filter.ToUpper) Then
                mail.Move(outlookNameSpace.GetDefaultFolder( _
                    Outlook.OlDefaultFolders.olFolderJunk))
            End If
        End If

    End Sub
    ' </snippet1>

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class

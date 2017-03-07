Public Class ThisAddIn

    '<Snippet1>
    Private Sub ThisAddIn_Startup(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles Me.Startup
        AccessContacts("Na")
    End Sub

    Private Sub AccessContacts(ByVal findLastName As String)
        Dim folderContacts As Outlook.MAPIFolder = Me.Application.ActiveExplorer() _
            .Session.GetDefaultFolder(Outlook.OlDefaultFolders _
            .olFolderContacts)
        Dim searchFolder As Outlook.Items = folderContacts.Items
        Dim counter As Integer = 0
        For Each foundContact As Outlook.ContactItem In searchFolder
            If foundContact.LastName.Contains(findLastName) Then
                foundContact.Display(False)
                counter = counter + 1
            End If
        Next
        MsgBox("You have " & counter & _
            " contacts with last names that contain " _
            & findLastName & ".")
    End Sub

    '</Snippet1>

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class

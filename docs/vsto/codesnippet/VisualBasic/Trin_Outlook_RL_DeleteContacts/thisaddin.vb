Public Class ThisAddIn

    ' <Snippet1>
    Private Sub ThisAddIn_Startup(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles Me.Startup
        DeleteContact("Pinto", "Armando")
    End Sub

    Private Sub DeleteContact(ByVal lastName As String, _
    ByVal firstName As String)
        Dim contact As Outlook.ContactItem = _
            TryCast(Me.Application.GetNamespace("MAPI").GetDefaultFolder( _
            Outlook.OlDefaultFolders.olFolderContacts).Items. _
            Find( _
            String.Format("[LastName]='{0}' AND [FirstName]='{1}'", _
            lastName, firstName)),  _
            Outlook.ContactItem)

        If (contact IsNot Nothing) Then
            contact.Delete()
        End If
    End Sub
    ' </Snippet1>

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class

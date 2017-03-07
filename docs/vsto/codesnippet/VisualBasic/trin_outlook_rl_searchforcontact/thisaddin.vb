Public Class ThisAddIn

    ' <Snippet1>
    Private Sub ThisAddIn_Startup(ByVal sender As Object, _
         ByVal e As System.EventArgs) Handles Me.Startup
        FindContactEmailByName("John", "Evans")
    End Sub

    Private Sub FindContactEmailByName(ByVal firstName As String, _
        ByVal lastName As String)
        Dim outlookNameSpace As Outlook.NameSpace = Me.Application.GetNamespace("MAPI")
        Dim contactFolder As Outlook.MAPIFolder = _
            outlookNameSpace.GetDefaultFolder( _
            Outlook.OlDefaultFolders.olFolderContacts)

        Dim contactItems As Outlook.Items = contactFolder.Items

        Try
            Dim contact As Outlook.ContactItem = _
                CType(contactItems.Find(String.Format _
                ("[FirstName]='{0}' and [LastName]={1}", _
                firstName, lastName)), Outlook.ContactItem)

            If contact IsNot Nothing Then
                contact.Display()
            Else
                MsgBox("The contact information was not found.")
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ' </Snippet1>

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class

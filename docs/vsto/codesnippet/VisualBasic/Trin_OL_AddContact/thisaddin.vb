Public Class ThisAddIn

    Private Sub ThisAddIn_Startup() Handles Me.Startup

    End Sub

    '<Snippet1>
    Private Sub AddContact()
        Dim newContact As Outlook.ContactItem = Me.Application.CreateItem(Outlook. _
            OlItemType.olContactItem)
        Try
            With newContact
                .FirstName = "Jo"
                .LastName = "Berry"
                .Email1Address = "somebody@example.com"
                .CustomerID = "123456"
                .PrimaryTelephoneNumber = "(425)555-0111"
                .MailingAddressStreet = "123 Main St."
                .MailingAddressCity = "Redmond"
                .MailingAddressState = "WA"
                .Save()
                .Display(True)
            End With
        Catch
            MsgBox("The new contact was not saved.")
        End Try
    End Sub
    '</Snippet1>

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class


Public Class ThisAddIn

    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup

        'UntrustedCode()
        TrustedCode()

    End Sub

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

    ' <Snippet1>
    Private Sub UntrustedCode()
        Dim application As New Microsoft.Office.Interop.Outlook.Application
        Dim mailItem1 As Microsoft.Office.Interop.Outlook.MailItem = _
            TryCast(application.CreateItem( _
            Microsoft.Office.Interop.Outlook.OlItemType.olMailItem),  _
            Microsoft.Office.Interop.Outlook.MailItem)
        mailItem1.To = "someone@example.com"
        MessageBox.Show(mailItem1.To)
    End Sub
    ' </Snippet1>

    ' <Snippet2>
    Private Sub TrustedCode()
        Dim mailItem1 As Microsoft.Office.Interop.Outlook.MailItem = _
            TryCast(Me.Application.CreateItem( _
            Microsoft.Office.Interop.Outlook.OlItemType.olMailItem),  _
            Microsoft.Office.Interop.Outlook.MailItem)
        mailItem1.To = "someone@example.com"
        MessageBox.Show(mailItem1.To)
    End Sub
    ' </Snippet2>

End Class

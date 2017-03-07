Public Class ThisAddIn

    '<Snippet1>
    Private WithEvents inspectors As Outlook.Inspectors
    '</Snippet1>
    '<Snippet2>
    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        inspectors = Me.Application.Inspectors
    End Sub
    '</Snippet2>
    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub
    '<Snippet3>
    Private Sub inspectors_NewInspector(ByVal Inspector As Microsoft.Office.Interop.Outlook.Inspector) Handles inspectors.NewInspector
        Dim mailItem As Outlook.MailItem = TryCast(Inspector.CurrentItem, Outlook.MailItem)
        If Not (mailItem Is Nothing) Then
            If mailItem.EntryID Is Nothing Then
                mailItem.Subject = "This text was added by using code"
                mailItem.Body = "This text was added by using code"
            End If
        End If
    End Sub
    '</Snippet3>
End Class

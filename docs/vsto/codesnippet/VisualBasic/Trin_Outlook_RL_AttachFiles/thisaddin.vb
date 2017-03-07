Imports System.Windows.Forms

Public Class ThisAddIn

    ' <Snippet1>
    Private Sub ThisAddIn_Startup(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles Me.Startup
        AddAttachment()
    End Sub

    Private Sub AddAttachment()
        Dim mail As Outlook.MailItem = _
        TryCast(Me.Application.CreateItem _
        (Outlook.OlItemType.olMailItem),  _
        Outlook.MailItem)

        mail.Subject = "An attachment for you!"

        Dim attachment As OpenFileDialog = _
            New OpenFileDialog()

        attachment.Title = "Select a file to send"
        attachment.ShowDialog()

        If attachment.FileName.Length > 0 Then
            mail.Attachments.Add( _
                attachment.FileName, _
                Outlook.OlAttachmentType.olByValue, _
                1, _
                attachment.FileName)
            mail.Recipients.Add("Armando Pinto")
            mail.Send()
        End If
    End Sub
    ' </Snippet1>


    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class

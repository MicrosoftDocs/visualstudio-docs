Public Class ThisAddIn

    '<Snippet1>
    Dim WithEvents currentExplorer As Outlook.Explorer = Nothing

    Private Sub ThisAddIn_Startup(ByVal sender As Object, _
         ByVal e As System.EventArgs) Handles Me.Startup
        currentExplorer = Me.Application.Explorers.Application.ActiveExplorer
        AddHandler currentExplorer.SelectionChange, AddressOf _
            currentExplorer_Event
    End Sub

    Public Sub currentExplorer_Event()
        Dim selectedFolder As Outlook.MAPIFolder = _
            Me.Application.ActiveExplorer().CurrentFolder
        Dim expMessage As String = "Your current folder is " _
            & selectedFolder.Name & "." & vbCrLf
        Dim itemMessage As String = "Item is unknown."
        Try
            If Me.Application.ActiveExplorer.Selection.Count > 0 Then
                Dim selObject As Object = Me.Application.ActiveExplorer _
                    .Selection.Item(1)
                If (TypeOf selObject Is Outlook.MailItem) Then
                    Dim mailItem As Outlook.MailItem = _
                        TryCast(selObject, Outlook.MailItem)
                    itemMessage = "The item is an e-mail message." & _
                        " The subject is " & mailItem.Subject & "."
                    mailItem.Display(False)
                ElseIf (TypeOf selObject Is Outlook.ContactItem) Then
                    Dim contactItem As Outlook.ContactItem = _
                       TryCast(selObject, Outlook.ContactItem)
                    itemMessage = "The item is a contact." & _
                        " The full name is " & _
                        contactItem.Subject & "."
                    contactItem.Display(False)
                ElseIf (TypeOf selObject Is Outlook. _
                    AppointmentItem) Then
                    Dim apptItem As Outlook.AppointmentItem = _
                       TryCast(selObject, Outlook.AppointmentItem)
                    itemMessage = "The item is an appointment." _
                        & apptItem.Subject & "."
                ElseIf (TypeOf selObject Is Outlook.TaskItem) Then
                    Dim taskItem As Outlook.TaskItem = _
                        TryCast(selObject, Outlook.TaskItem)
                    itemMessage = "The item is a task." & _
                        " The body is " & taskItem.Body & "."
                ElseIf (TypeOf selObject Is Outlook.MeetingItem) Then
                    Dim meetingItem As Outlook.MeetingItem = _
                        TryCast(selObject, Outlook.MeetingItem)
                    itemMessage = "The item is a meeting item. " & _
                        "The subject is " & meetingItem.Subject & "."
                End If
            End If
            expMessage = expMessage & itemMessage
        Catch ex As Exception
            expMessage = ex.Message
        End Try
        MsgBox(expMessage)
    End Sub
    ' </Snippet1>


    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class

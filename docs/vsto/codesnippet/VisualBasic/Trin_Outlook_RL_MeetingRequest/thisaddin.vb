Public Class ThisAddIn

    ' <snippet1>
    Private Sub ThisAddIn_Startup(ByVal sender As Object, _
     ByVal e As System.EventArgs) Handles Me.Startup
        Dim agendaMeeting As Outlook.AppointmentItem = CType( _
            Me.Application.CreateItem(Outlook.OlItemType.olAppointmentItem),  _
            Outlook.AppointmentItem)

        If agendaMeeting IsNot Nothing Then
            agendaMeeting.MeetingStatus = _
                Outlook.OlMeetingStatus.olMeeting
            agendaMeeting.Location = "Conference Room"
            agendaMeeting.Subject = "Discussing the Agenda"
            agendaMeeting.Body = "Let's get together to discuss the " _
                & "agenda."
            agendaMeeting.Start = New System.DateTime( _
                2005, 5, 5, 5, 0, 0)
            agendaMeeting.Duration = 60
            Dim recipient As Outlook.Recipient = _
                agendaMeeting.Recipients.Add("Nate Sun")
            recipient.Type = Outlook.OlMeetingRecipientType.olRequired

            agendaMeeting.Send()

        End If
    End Sub
    ' </snippet1>


    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class

Public Class ThisAddIn

    ' <Snippet1>
    Private Sub ThisAddIn_Startup(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles Me.Startup

        Dim calendar As Outlook.MAPIFolder = _
            Application.Session.GetDefaultFolder( _
            Outlook.OlDefaultFolders.olFolderCalendar)

        Dim calendarItems As Outlook.Items = calendar.Items

        Dim item As Outlook.AppointmentItem = TryCast( _
            calendarItems("Test Appointment"), Outlook.AppointmentItem)

        Dim pattern As Outlook.RecurrencePattern = _
            item.GetRecurrencePattern()

        Dim itemDelete As Outlook.AppointmentItem = _
            pattern.GetOccurrence(New Date(2006, 6, 28, 8, 0, 0))

        If itemDelete IsNot Nothing Then
            itemDelete.Delete()
        End If
    End Sub
    ' </Snippet1>

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class

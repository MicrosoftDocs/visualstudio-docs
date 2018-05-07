Public Class ThisAddIn

    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup

    End Sub

    '<Snippet1>
    Private utilities As AddInUtilities

    Protected Overrides Function RequestComAddInAutomationService() As Object
        If utilities Is Nothing Then
            utilities = New AddInUtilities()
        End If
        Return utilities
    End Function
    '</Snippet1>

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

End Class

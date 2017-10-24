Public Class ThisAddIn

    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup

    End Sub

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub
    '<Snippet1>
    Protected Overrides Function CreateRibbonExtensibilityObject() As  _
    Microsoft.Office.Core.IRibbonExtensibility
        Return New MyRibbon()
    End Function
    '</Snippet1>
End Class

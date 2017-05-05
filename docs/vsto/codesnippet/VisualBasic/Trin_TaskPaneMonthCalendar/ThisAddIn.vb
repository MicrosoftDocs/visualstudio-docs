Public Class ThisAddIn

    '<Snippet4>
    Private myUserControl1 As MyUserControl
    Private myCustomTaskPane As Microsoft.Office.Tools.CustomTaskPane
    '</Snippet4>

    '<Snippet5>
    Private Sub ThisAddIn_Startup(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles Me.Startup

        myUserControl1 = New MyUserControl
        myCustomTaskPane = Me.CustomTaskPanes.Add(myUserControl1, "Calendar")
        myCustomTaskPane.Visible = True
    End Sub
    '</Snippet5>

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

End Class

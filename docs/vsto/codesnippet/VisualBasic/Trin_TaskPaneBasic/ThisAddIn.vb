Public Class ThisAddIn

    '<Snippet1>
    Private myUserControl1 As MyUserControl
    Private myCustomTaskPane As Microsoft.Office.Tools.CustomTaskPane
    '</Snippet1>

    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        '<Snippet2>
        myUserControl1 = New MyUserControl
        myCustomTaskPane = Me.CustomTaskPanes.Add(myUserControl1, "My Task Pane")
        myCustomTaskPane.Visible = True
        '</Snippet2>
    End Sub

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

End Class

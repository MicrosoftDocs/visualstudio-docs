Public Class ThisAddIn
    '<Snippet1>
    Private taskPaneControl1 As TaskPaneControl
    Private WithEvents taskPaneValue As Microsoft.Office.Tools.CustomTaskPane
    '</Snippet1>

    '<Snippet2>
    Private Sub ThisAddIn_Startup(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles Me.Startup

        taskPaneControl1 = New TaskPaneControl()
        taskPaneValue = Me.CustomTaskPanes.Add( _
            taskPaneControl1, "MyCustomTaskPane")
    End Sub
    '</Snippet2>

    '<Snippet3>
    Private Sub taskPaneValue_VisibleChanged(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles taskPaneValue.VisibleChanged

        Globals.Ribbons.ManageTaskPaneRibbon.ToggleButton1.Checked = taskPaneValue.Visible
    End Sub
    '</Snippet3>

    '<Snippet4>
    Public ReadOnly Property TaskPane() As Microsoft.Office.Tools.CustomTaskPane
        Get
            Return taskPaneValue
        End Get
    End Property
    '</Snippet4>

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

End Class

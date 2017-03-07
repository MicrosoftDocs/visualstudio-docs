Public Class ThisWorkbook

    '--------------------------------------------------------------------------
    '<Snippet7>
    Dim hello As New HelloControl
    '</Snippet7>


    '--------------------------------------------------------------------------
    '<Snippet3>
    Dim actions As New ActionsControl
    '</Snippet3>


    '--------------------------------------------------------------------------
    Sub Test()
        '<Snippet9>
        Me.Application.CommandBars("Task Pane").Visible = False
        '</Snippet9>

        '<Snippet10>
        Me.ActionsPane.StackOrder = Microsoft.Office.Tools.StackStyle.FromTop
        '</Snippet10>

        '<Snippet11>
        Me.Application.DisplayDocumentActionTaskPane = False
        '</Snippet11>
    End Sub


    '--------------------------------------------------------------------------
    Private Sub StartUp1(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Startup

        '<Snippet8>
        Me.ActionsPane.Controls.Add(hello)
        '</Snippet8>
    End Sub



    '--------------------------------------------------------------------------
    '<Snippet4>
    Private Sub ThisWorkbook_Startup(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Startup

        Me.ActionsPane.Controls.Add(actions)
    End Sub
    '</Snippet4>


    Private Sub ThisWorkbook_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
    End Sub

End Class

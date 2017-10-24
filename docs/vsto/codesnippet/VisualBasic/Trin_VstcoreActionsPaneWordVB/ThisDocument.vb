Public Class ThisDocument

    '--------------------------------------------------------------------------
    '<Snippet10>
    Dim insertText As New InsertTextControl
    '</Snippet10>

    '<Snippet6>
    Dim actions As New ActionsControl
    '</Snippet6>

    '<Snippet14>
    Dim hello As New HelloControl
    '</Snippet14>

    '<Snippet16>
    Dim addText As New AddTextControl
    Dim showProperties As New ShowPropertiesControl
    Dim showAll As New ShowAllControl

    Friend WithEvents showCheck As System.Windows.Forms.CheckBox
    '</Snippet16>


    '--------------------------------------------------------------------------
    Sub StartUp1()

        '<Snippet7>
        Me.ActionsPane.Controls.Add(actions)
        '</Snippet7>


        '<Snippet11>
        Me.ActionsPane.Controls.Add(insertText)
        '</Snippet11>


        '<Snippet15>
        Me.ActionsPane.Controls.Add(hello)
        '</Snippet15>


        '<Snippet17>
        Me.ActionsPane.Controls.Add(showAll)
        showCheck = showAll.showCheck
        '</Snippet17>

        '<Snippet34>
        Me.Application.TaskPanes(Word.WdTaskPanes.wdTaskPaneDocumentActions).Visible = False
        '</Snippet34>
    End Sub


    '--------------------------------------------------------------------------
    '<Snippet18>
    Private Sub SampleInsertNode_ContextEnter(ByVal sender As Object, _
        ByVal e As Microsoft.Office.Tools.Word.ContextChangeEventArgs) _
        Handles SampleInsertNode.ContextEnter

        If showAll.showCheck.Checked = False Then
            Me.ActionsPane.Controls.Add(addText)
            Me.ActionsPane.Controls.Remove(showProperties)
        End If
    End Sub
    '</Snippet18>


    '<Snippet19>
    Private Sub SampleInsertNode_ContextLeave(ByVal sender As Object, _
        ByVal e As Microsoft.Office.Tools.Word.ContextChangeEventArgs) _
        Handles SampleInsertNode.ContextLeave

        If showAll.showCheck.Checked = False Then
            Me.ActionsPane.Controls.Remove(addText)
        End If
    End Sub
    '</Snippet19>


    '<Snippet20>
    Private Sub SampleTableNode_ContextEnter(ByVal sender As Object, _
        ByVal e As Microsoft.Office.Tools.Word.ContextChangeEventArgs) _
        Handles SampleTableNode.ContextEnter

        If showAll.showCheck.Checked = False Then
            Me.ActionsPane.Controls.Remove(addText)
            Me.ActionsPane.Controls.Add(showProperties)
        End If

        showProperties.tableProperties.Enabled = True
    End Sub
    '</Snippet20>


    '<Snippet21>
    Private Sub SampleTableNode_ContextLeave(ByVal sender As Object, _
        ByVal e As Microsoft.Office.Tools.Word.ContextChangeEventArgs) _
        Handles SampleTableNode.ContextLeave

        If showAll.showCheck.Checked = False Then
            Me.ActionsPane.Controls.Remove(showProperties)
        End If

        showProperties.tableProperties.Enabled = False
    End Sub
    '</Snippet21>


    '--------------------------------------------------------------------------
    '<Snippet23>
    Private Sub showCheck_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles showCheck.CheckStateChanged

        If showAll.showCheck.Checked = True Then
            Me.ActionsPane.Controls.Add(addText)
            Me.ActionsPane.Controls.Add(showProperties)
        Else
            Me.ActionsPane.Controls.Remove(addText)
            Me.ActionsPane.Controls.Remove(showProperties)
        End If
    End Sub
    '</Snippet23>


    '--------------------------------------------------------------------------
    '<Snippet29>
    '<Snippet30>
    Private Sub ActionsPane_OrientationChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ActionsPane.OrientationChanged

        If Me.ActionsPane.Orientation = Orientation.Horizontal Then
    '</Snippet30>

    '<Snippet31>
            Me.ActionsPane.StackOrder = Microsoft.Office.Tools.StackStyle.FromLeft
        Else
            Me.ActionsPane.StackOrder = Microsoft.Office.Tools.StackStyle.FromTop
        End If
    End Sub
    '</Snippet31>
    '</Snippet29>

    Sub Position()
        '<Snippet100>
        Me.CommandBars("Task Pane").Position = _
            Microsoft.Office.Core.MsoBarPosition.msoBarLeft
        '</Snippet100>
    End Sub

    Sub SetTopandLeft()
        '<Snippet101>
        If Me.CommandBars("Task Pane").Position = _
            Microsoft.Office.Core.MsoBarPosition.msoBarFloating Then

            Me.CommandBars("Task Pane").Top = 0
            Me.CommandBars("Task Pane").Left = 0

        End If
        '</Snippet101>
    End Sub

    Sub SetAPWidth()
        '<Snippet102>
        Me.CommandBars("Task Pane").Width = 200
        '</Snippet102>
    End Sub

End Class

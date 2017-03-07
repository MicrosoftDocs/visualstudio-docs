Public Class MyRibbon
    '<Snippet1>
    Dim actionsPane1 As New ActionsPaneControl1()
    Dim actionsPane2 As New ActionsPaneControl2()
    '</Snippet1>
    
    '<Snippet2>
    Private Sub MyRibbon_Load(ByVal sender As System.Object, ByVal e As Microsoft.Office.Tools.Ribbon.RibbonUIEventArgs) Handles MyBase.Load
        Globals.ThisWorkbook.ActionsPane.Controls.Add(actionsPane1)
        Globals.ThisWorkbook.ActionsPane.Controls.Add(actionsPane2)
        actionsPane1.Hide()
        actionsPane2.Hide()
        Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = False
    End Sub
    '</Snippet2>

    '<Snippet3>
    Private Sub Button1_Click(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) _
            Handles Button1.Click
        Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = True
        actionsPane2.Hide()
        actionsPane1.Show()
        ToggleButton1.Checked = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) _
            Handles Button2.Click

        Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = True
        actionsPane1.Hide()
        actionsPane2.Show()
        ToggleButton1.Checked = False

    End Sub


    Private Sub ToggleButton1_Click(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) _
            Handles ToggleButton1.Click

        If ToggleButton1.Checked Then
            Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = False
        Else
            Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = True
        End If

    End Sub
    '</Snippet3>

End Class

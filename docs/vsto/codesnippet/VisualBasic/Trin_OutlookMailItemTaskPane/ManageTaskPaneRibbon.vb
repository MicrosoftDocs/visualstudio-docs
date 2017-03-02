'<Snippet13>
'<Snippet14>
Imports Microsoft.Office.Tools.Ribbon
Imports Outlook = Microsoft.Office.Interop.Outlook
Imports Microsoft.Office.Tools
'</Snippet14>

Public Class ManageTaskPaneRibbon

    Private Sub ManageTaskPaneRibbon_Load(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonUIEventArgs) Handles MyBase.Load

    End Sub

    '<Snippet15>
    Private Sub ToggleButton1_Click(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) _
        Handles ToggleButton1.Click

        Dim inspector As Outlook.Inspector = e.Control.Context
        Dim inspectorWrapper As InspectorWrapper = Globals.ThisAddIn.InspectorWrappers(inspector)
        Dim taskPane As CustomTaskPane = inspectorWrapper.CustomTaskPane
        If Not (taskPane Is Nothing) Then
            taskPane.Visible = TryCast(sender, RibbonToggleButton).Checked
        End If
    End Sub
    '</Snippet15>
End Class
'</Snippet13>

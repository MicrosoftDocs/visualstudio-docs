Imports Microsoft.Office.Tools.Ribbon

Public Class MyRibbon

    Private Sub MyRibbon_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub

    '<Snippet6>
    Private Sub addButtonCheckBox_Click(ByVal sender As System.Object, _
        ByVal e As RibbonControlEventArgs) Handles addButtonCheckBox.Click
        Globals.ThisAddIn.ToggleButtonOnDocument()
    End Sub

    Private Sub addRichTextCheckBox_Click(ByVal sender As System.Object, _
        ByVal e As RibbonControlEventArgs) Handles addRichTextCheckBox.Click
        Globals.ThisAddIn.ToggleRichTextControlOnDocument()
    End Sub
    '</Snippet6>
End Class

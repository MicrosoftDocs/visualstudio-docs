Public Class ShowPropertiesControl

    '--------------------------------------------------------------------------
    '<Snippet27>
    Private Sub tableProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles tableProperties.Click

        Globals.ThisDocument.Application.Dialogs( _
            Word.WdWordDialog.wdDialogTableProperties).Show()
    End Sub
    '</Snippet27>
End Class

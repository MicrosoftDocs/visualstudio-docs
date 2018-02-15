Public Class InsertTextControl

    '--------------------------------------------------------------------------
    '<Snippet8>
    Private Sub addText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles addText.Click

        If Me.getName.Text <> String.Empty Then
            Globals.ThisDocument.showName.Text = Me.getName.Text
        End If

        If Me.getAddress.Text <> String.Empty Then
            Globals.ThisDocument.showAddress.Text = Me.getAddress.Text
        End If

        Me.getName.Text = String.Empty
        Me.getAddress.Text = String.Empty
    End Sub
    '</Snippet8>

End Class

Public Class ThisAddIn

    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup

    End Sub

    '<Snippet1>
    Private button As Microsoft.Office.Tools.Word.Controls.Button = Nothing
    Private richTextControl As RichTextContentControl = Nothing
    '</Snippet1>

    '<Snippet2>
    Friend Sub ToggleButtonOnDocument()
        Dim vstoDocument As Document = Globals.Factory.GetVstoObject(Me.Application.ActiveDocument)

        Dim name As String = "MyButton"

        If Globals.Ribbons.MyRibbon.addButtonCheckBox.Checked Then
            Dim selection = Me.Application.Selection
            If selection IsNot Nothing AndAlso selection.Range IsNot Nothing Then
                button = vstoDocument.Controls.AddButton( _
                    selection.Range, 100, 30, name)
            End If
        Else
            vstoDocument.Controls.Remove(name)
        End If
    End Sub
    '</Snippet2>

    '<Snippet3>
    Friend Sub ToggleRichTextControlOnDocument()

        Dim vstoDocument As Document = Globals.Factory.GetVstoObject(Me.Application.ActiveDocument)

        Dim name As String = "MyRichTextBoxControl"

        If Globals.Ribbons.MyRibbon.addRichTextCheckBox.Checked Then
            Dim selection = Me.Application.Selection
            If selection IsNot Nothing AndAlso selection.Range IsNot Nothing Then
                richTextControl = vstoDocument.Controls.AddRichTextContentControl( _
                        selection.Range, name)
            End If
        Else
            vstoDocument.Controls.Remove(name)
        End If
    End Sub
    '</Snippet3>

    '<Snippet4>
    Private Sub Application_DocumentBeforeSave(ByVal Doc As Word.Document, _
        ByRef SaveAsUI As Boolean, ByRef Cancel As Boolean) Handles Application.DocumentBeforeSave

        Dim isExtended As Boolean = Globals.Factory.HasVstoObject(Doc)


        If isExtended Then
            Dim vstoDocument As Document = Globals.Factory.GetVstoObject(Doc)


            If vstoDocument.Controls.Contains(button) Then
                vstoDocument.Controls.Remove(button)
                Globals.Ribbons.MyRibbon.addButtonCheckBox.Checked = False
            End If
        End If
    End Sub
    '</Snippet4>

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

End Class

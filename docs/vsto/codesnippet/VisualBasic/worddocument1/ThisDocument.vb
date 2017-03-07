Public Class ThisDocument

    Private Sub ThisDocument_Startup() Handles Me.Startup
        Me.Paragraphs(1).Range.Text = "The blue doll is very blue in the face. Which makes me BLuE too. But not red!"
        Test()
    End Sub

    Sub Test()
        '<Snippet1>
        With Me.Application.ActiveDocument.Content
            .Find.ClearFormatting()
            .Find.Execute(FindText:="blue", ReplaceWith:="red", Replace:=Word.WdReplace.wdReplaceAll)
        End With
        '</Snippet1>
    End Sub

    Private Sub ThisDocument_Shutdown() Handles Me.Shutdown

    End Sub

End Class

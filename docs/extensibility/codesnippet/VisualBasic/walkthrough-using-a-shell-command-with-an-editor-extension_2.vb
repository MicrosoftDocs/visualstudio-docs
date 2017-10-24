    Private Sub OnBufferChanged(ByVal sender As Object, ByVal e As TextContentChangedEventArgs)
        'Make a list of all comments that have a span of at least one character after applying the change. There is no need to raise a changed event for the deleted adornments. The adornments are deleted only if a text change would cause the view to reformat the line and discard the adornments.
        Dim keptComments As IList(Of CommentAdornment) = New List(Of CommentAdornment)(Me.comments.Count)

        For Each comment As CommentAdornment In Me.comments
            Dim span As Span = comment.Span.GetSpan(e.After)
            'if a comment does not span at least one character, its text was deleted.
            If span.Length <> 0 Then
                keptComments.Add(comment)
            End If
        Next comment

        Me.comments = keptComments
    End Sub
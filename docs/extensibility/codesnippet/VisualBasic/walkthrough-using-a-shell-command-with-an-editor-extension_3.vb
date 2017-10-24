    Private Sub DrawComment(ByVal comment As CommentAdornment)
        Dim span As SnapshotSpan = comment.Span.GetSpan(Me.view.TextSnapshot)
        Dim g As Geometry = Me.view.TextViewLines.GetMarkerGeometry(span)

        If g IsNot Nothing Then
            'Find the rightmost coordinate of all the lines that intersect the adornment.
            Dim maxRight As Double = 0.0
            For Each line As ITextViewLine In Me.view.TextViewLines.GetTextViewLinesIntersectingSpan(span)
                maxRight = Math.Max(maxRight, line.Right)
            Next line

            'Create the visualization.
            Dim block As New CommentBlock(maxRight, Me.view.ViewportRight, g, comment.Author, comment.Text)

            'Add it to the layer.
            Me.layer.AddAdornment(span, comment, block)
        End If
    End Sub
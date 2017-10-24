    Private Sub ViewLayoutChanged(ByVal sender As Object, ByVal e As TextViewLayoutChangedEventArgs)
        If e.NewSnapshot IsNot e.OldSnapshot Then
            'make sure that there has really been a change
            UpdateAtCaretPosition(View.Caret.Position)
        End If
    End Sub

    Private Sub CaretPositionChanged(ByVal sender As Object, ByVal e As CaretPositionChangedEventArgs)
        UpdateAtCaretPosition(e.NewPosition)
    End Sub

    Private Sub UpdateAtCaretPosition(ByVal caretPosition As CaretPosition)
        CurrentChar = caretPosition.Point.GetPoint(SourceBuffer, caretPosition.Affinity)

        If Not CurrentChar.HasValue Then
            Exit Sub
        End If

        RaiseEvent TagsChanged(Me, New SnapshotSpanEventArgs(New SnapshotSpan(SourceBuffer.CurrentSnapshot, 0, SourceBuffer.CurrentSnapshot.Length)))
    End Sub
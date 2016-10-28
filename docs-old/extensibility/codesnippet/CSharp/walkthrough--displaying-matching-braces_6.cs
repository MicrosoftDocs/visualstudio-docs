    void ViewLayoutChanged(object sender, TextViewLayoutChangedEventArgs e)
    {
        if (e.NewSnapshot != e.OldSnapshot) //make sure that there has really been a change
        {
            UpdateAtCaretPosition(View.Caret.Position);
        }
    }

    void CaretPositionChanged(object sender, CaretPositionChangedEventArgs e)
    {
        UpdateAtCaretPosition(e.NewPosition);
    }
    void UpdateAtCaretPosition(CaretPosition caretPosition)
    {
        CurrentChar = caretPosition.Point.GetPoint(SourceBuffer, caretPosition.Affinity);

        if (!CurrentChar.HasValue)
            return;

        var tempEvent = TagsChanged;
        if (tempEvent != null)
            tempEvent(this, new SnapshotSpanEventArgs(new SnapshotSpan(SourceBuffer.CurrentSnapshot, 0,
                SourceBuffer.CurrentSnapshot.Length)));
    }
    public IEnumerable<ITagSpan<TextMarkerTag>> GetTags(NormalizedSnapshotSpanCollection spans)
    {
        if (spans.Count == 0)   //there is no content in the buffer
            yield break;

        //don't do anything if the current SnapshotPoint is not initialized or at the end of the buffer
        if (!CurrentChar.HasValue || CurrentChar.Value.Position >= CurrentChar.Value.Snapshot.Length)
            yield break;

        //hold on to a snapshot of the current character
        SnapshotPoint currentChar = CurrentChar.Value;

        //if the requested snapshot isn't the same as the one the brace is on, translate our spans to the expected snapshot
        if (spans[0].Snapshot != currentChar.Snapshot)
        {
            currentChar = currentChar.TranslateTo(spans[0].Snapshot, PointTrackingMode.Positive);
        }

        //get the current char and the previous char
        char currentText = currentChar.GetChar();
        SnapshotPoint lastChar = currentChar == 0 ? currentChar : currentChar - 1; //if currentChar is 0 (beginning of buffer), don't move it back
        char lastText = lastChar.GetChar();
        SnapshotSpan pairSpan = new SnapshotSpan();

        if (m_braceList.ContainsKey(currentText))   //the key is the open brace
        {
            char closeChar;
            m_braceList.TryGetValue(currentText, out closeChar);
            if (BraceMatchingTagger.FindMatchingCloseChar(currentChar, currentText, closeChar, View.TextViewLines.Count, out pairSpan) == true)
            {
                yield return new TagSpan<TextMarkerTag>(new SnapshotSpan(currentChar, 1), new TextMarkerTag("blue"));
                yield return new TagSpan<TextMarkerTag>(pairSpan, new TextMarkerTag("blue"));
            }
        }
        else if (m_braceList.ContainsValue(lastText))    //the value is the close brace, which is the *previous* character 
        {
            var open = from n in m_braceList
                       where n.Value.Equals(lastText)
                       select n.Key;
            if (BraceMatchingTagger.FindMatchingOpenChar(lastChar, (char)open.ElementAt<char>(0), lastText, View.TextViewLines.Count, out pairSpan) == true)
            {
                yield return new TagSpan<TextMarkerTag>(new SnapshotSpan(lastChar, 1), new TextMarkerTag("blue"));
                yield return new TagSpan<TextMarkerTag>(pairSpan, new TextMarkerTag("blue"));
            }
        }
    }
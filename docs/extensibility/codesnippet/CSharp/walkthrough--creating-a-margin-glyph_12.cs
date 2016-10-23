    IEnumerable<ITagSpan<TodoTag>> ITagger<TodoTag>.GetTags(NormalizedSnapshotSpanCollection spans)
    {
        foreach (SnapshotSpan span in spans)
        {
            //look at each classification span \
            foreach (ClassificationSpan classification in m_classifier.GetClassificationSpans(span))
            {
                //if the classification is a comment
                if (classification.ClassificationType.Classification.ToLower().Contains("comment"))
                {
                    //if the word "todo" is in the comment,
                    //create a new TodoTag TagSpan
                    int index = classification.Span.GetText().ToLower().IndexOf(m_searchText);
                    if (index != -1)
                    {
                        yield return new TagSpan<TodoTag>(new SnapshotSpan(classification.Span.Start + index, m_searchText.Length), new TodoTag());
                    }
                }
            }
        }
    }
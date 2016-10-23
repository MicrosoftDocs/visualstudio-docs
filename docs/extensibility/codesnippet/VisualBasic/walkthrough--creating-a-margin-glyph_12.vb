    Private Function GetTags(ByVal spans As NormalizedSnapshotSpanCollection) As IEnumerable(Of ITagSpan(Of TodoTag)) Implements ITagger(Of TodoTag).GetTags
        Dim list As List(Of ITagSpan(Of TodoTag))
        list = New List(Of ITagSpan(Of TodoTag))()

        For Each span As SnapshotSpan In spans
            'look at each classification span \
            For Each classification As ClassificationSpan In m_classifier.GetClassificationSpans(span)
                'if the classification is a comment
                If classification.ClassificationType.Classification.ToLower().Contains("comment") Then
                    'if the word "todo" is in the comment,
                    'create a new TodoTag TagSpan
                    Dim index As Integer = classification.Span.GetText().ToLower().IndexOf(m_searchText)
                    If index <> -1 Then
                        list.Add(New TagSpan(Of TodoTag)(New SnapshotSpan(classification.Span.Start + index, m_searchText.Length), New TodoTag()))
                    End If
                End If
            Next classification
        Next span

        Return list
    End Function
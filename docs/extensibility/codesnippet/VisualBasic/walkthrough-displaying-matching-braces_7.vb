    Public Function GetTags(ByVal spans As NormalizedSnapshotSpanCollection) As IEnumerable(Of ITagSpan(Of TextMarkerTag)) Implements ITagger(Of Microsoft.VisualStudio.Text.Tagging.TextMarkerTag).GetTags
        If spans.Count = 0 Then
            'there is no content in the buffer
            Exit Function
        End If

        'don't do anything if the current SnapshotPoint is not initialized or at the end of the buffer
        If Not CurrentChar.HasValue OrElse CurrentChar.Value.Position >= CurrentChar.Value.Snapshot.Length Then
            Exit Function
        End If

        'hold on to a snapshot of the current character
        Dim currentChar__1 As SnapshotPoint = CurrentChar.Value

        'if the requested snapshot isn't the same as the one the brace is on, translate our spans to the expected snapshot
        If spans(0).Snapshot IsNot currentChar__1.Snapshot Then
            currentChar__1 = currentChar__1.TranslateTo(spans(0).Snapshot, PointTrackingMode.Positive)
        End If

        'get the current char and the previous char
        Dim currentText As Char = currentChar__1.GetChar()
        Dim lastChar As SnapshotPoint = If(CInt(currentChar__1) = 0, currentChar__1, currentChar__1 - 1)
        'if currentChar is 0 (beginning of buffer), don't move it back
        Dim lastText As Char = lastChar.GetChar()
        Dim pairSpan As New SnapshotSpan()

        If m_braceList.ContainsKey(currentText) Then
            'the key is the open brace
            Dim closeChar As Char
            m_braceList.TryGetValue(currentText, closeChar)
            If BraceMatchingTagger.FindMatchingCloseChar(currentChar__1, currentText, closeChar, View.TextViewLines.Count, pairSpan) = True Then
                Exit Function
            End If
        ElseIf m_braceList.ContainsValue(lastText) Then
            'the value is the close brace, which is the *previous* character 
            Dim open = From n In m_braceList _
                Where n.Value.Equals(lastText) _
                Select n.Key
            If BraceMatchingTagger.FindMatchingOpenChar(lastChar, CChar(open.ElementAt(0)), lastText, View.TextViewLines.Count, pairSpan) = True Then
                Exit Function
            End If
        End If
    End Function
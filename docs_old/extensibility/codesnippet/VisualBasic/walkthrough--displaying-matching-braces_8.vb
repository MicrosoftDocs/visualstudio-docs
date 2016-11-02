    Private Shared Function FindMatchingCloseChar(ByVal startPoint As SnapshotPoint, ByVal open As Char, ByVal close As Char, ByVal maxLines As Integer, ByRef pairSpan As SnapshotSpan) As Boolean
        pairSpan = New SnapshotSpan(startPoint.Snapshot, 1, 1)
        Dim line As ITextSnapshotLine = startPoint.GetContainingLine()
        Dim lineText As String = line.GetText()
        Dim lineNumber As Integer = line.LineNumber
        Dim offset As Integer = startPoint.Position - line.Start.Position + 1

        Dim stopLineNumber As Integer = startPoint.Snapshot.LineCount - 1
        If maxLines > 0 Then
            stopLineNumber = Math.Min(stopLineNumber, lineNumber + maxLines)
        End If

        Dim openCount As Integer = 0
        While True
            'walk the entire line
            While offset < line.Length
                Dim currentChar As Char = lineText(offset)
                If currentChar = close Then
                    'found the close character
                    If openCount > 0 Then
                        openCount -= 1
                    Else
                        'found the matching close
                        pairSpan = New SnapshotSpan(startPoint.Snapshot, line.Start + offset, 1)
                        Return True
                    End If
                ElseIf currentChar = open Then
                    ' this is another open
                    openCount += 1
                End If
                offset += 1
            End While

            'move on to the next line
            If System.Threading.Interlocked.Increment(lineNumber) > stopLineNumber Then
                Exit While
            End If

            line = line.Snapshot.GetLineFromLineNumber(lineNumber)
            lineText = line.GetText()
            offset = 0
        End While

        Return False
    End Function
    Private Shared Function FindMatchingOpenChar(ByVal startPoint As SnapshotPoint, ByVal open As Char, ByVal close As Char, ByVal maxLines As Integer, ByRef pairSpan As SnapshotSpan) As Boolean
        pairSpan = New SnapshotSpan(startPoint, startPoint)

        Dim line As ITextSnapshotLine = startPoint.GetContainingLine()

        Dim lineNumber As Integer = line.LineNumber
        Dim offset As Integer = startPoint - line.Start - 1
        'move the offset to the character before this one
        'if the offset is negative, move to the previous line
        If offset < 0 Then
            line = line.Snapshot.GetLineFromLineNumber(System.Threading.Interlocked.Decrement(lineNumber))
            offset = line.Length - 1
        End If

        Dim lineText As String = line.GetText()

        Dim stopLineNumber As Integer = 0
        If maxLines > 0 Then
            stopLineNumber = Math.Max(stopLineNumber, lineNumber - maxLines)
        End If

        Dim closeCount As Integer = 0

        While True
            ' Walk the entire line
            While offset >= 0
                Dim currentChar As Char = lineText(offset)

                If currentChar = open Then
                    If closeCount > 0 Then
                        closeCount -= 1
                    Else
                        ' We've found the open character
                        pairSpan = New SnapshotSpan(line.Start + offset, 1)
                        'we just want the character itself
                        Return True
                    End If
                ElseIf currentChar = close Then
                    closeCount += 1
                End If
                offset -= 1
            End While

            ' Move to the previous line
            If System.Threading.Interlocked.Decrement(lineNumber) < stopLineNumber Then
                Exit While
            End If

            line = line.Snapshot.GetLineFromLineNumber(lineNumber)
            lineText = line.GetText()
            offset = line.Length - 1
        End While
        Return False
    End Function
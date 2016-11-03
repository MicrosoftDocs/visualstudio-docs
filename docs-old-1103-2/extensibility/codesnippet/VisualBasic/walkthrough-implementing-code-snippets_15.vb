        Private Function InsertAnyExpansion(ByVal shortcut As String, ByVal title As String, ByVal path As String) As Boolean
            Dim endColumn As Integer, startLine As Integer
            'get the column number from  the IVsTextView, not the ITextView
            m_vsTextView.GetCaretPos(startLine, endColumn)

            Dim addSpan As New TextSpan()
            addSpan.iStartIndex = endColumn
            addSpan.iEndIndex = endColumn
            addSpan.iStartLine = startLine
            addSpan.iEndLine = startLine

            'get the expansion from the shortcut
            If shortcut IsNot Nothing Then
                'reset the TextSpan to the width of the shortcut, because we're going to replace the shortcut with the expansion
                addSpan.iStartIndex = addSpan.iEndIndex - shortcut.Length

                m_exManager.GetExpansionByShortcut(
                    Me,
                    New Guid(SnippetUtilities.LanguageServiceGuidStr),
                    shortcut,
                    m_vsTextView,
                    New TextSpan() {addSpan},
                    0,
                    path,
                    title)
            End If
            If title IsNot Nothing AndAlso path IsNot Nothing Then
                Dim textLines As IVsTextLines = Nothing
                m_vsTextView.GetBuffer(textLines)
                Dim bufferExpansion As IVsExpansion = DirectCast(textLines, IVsExpansion)

                If bufferExpansion IsNot Nothing Then
                    Dim hr As Integer = bufferExpansion.InsertNamedExpansion(
                        title,
                        path,
                        addSpan,
                        Me,
                        New Guid(SnippetUtilities.LanguageServiceGuidStr),
                        0,
                        m_exSession)
                    If VSConstants.S_OK = hr Then
                        Return True
                    End If
                End If
            End If
            Return False
        End Function
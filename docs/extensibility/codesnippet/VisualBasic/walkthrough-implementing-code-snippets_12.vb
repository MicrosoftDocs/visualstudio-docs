            'neither an expansion session nor a completion session is open, but we got a tab, so check whether the last word typed is a snippet shortcut 
            If m_session Is Nothing AndAlso m_exSession Is Nothing AndAlso nCmdID = CUInt(VSConstants.VSStd2KCmdID.TAB) Then
                'get the word that was just added 
                Dim pos As CaretPosition = m_textView.Caret.Position
                Dim word As TextExtent = m_provider.NavigatorService.GetTextStructureNavigator(m_textView.TextBuffer).GetExtentOfWord(pos.BufferPosition - 1)
                Dim textString As String = word.Span.GetText()
                'if it is a code snippet, insert it, otherwise carry on
                If InsertAnyExpansion(textString, Nothing, Nothing) Then
                    Return VSConstants.S_OK
                End If
            End If
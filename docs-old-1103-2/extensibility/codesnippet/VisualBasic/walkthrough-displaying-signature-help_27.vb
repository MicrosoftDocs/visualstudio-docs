    Public Function Exec(ByRef pguidCmdGroup As Guid, ByVal nCmdID As UInteger, ByVal nCmdexecopt As UInteger, ByVal pvaIn As IntPtr, ByVal pvaOut As IntPtr) As Integer Implements IOleCommandTarget.Exec
        Dim typedChar As Char = Char.MinValue

        If pguidCmdGroup = VSConstants.VSStd2K AndAlso nCmdID = CUInt(VSConstants.VSStd2KCmdID.TYPECHAR) Then
            typedChar = CChar(ChrW(CUShort(Marshal.GetObjectForNativeVariant(pvaIn))))
            If typedChar.Equals("("c) Then
                'move the point back so it's in the preceding word
                Dim point As SnapshotPoint = m_textView.Caret.Position.BufferPosition - 1
                Dim extent As TextExtent = m_navigator.GetExtentOfWord(point)
                Dim word As String = extent.Span.GetText()
                If word.Equals("add") Then
                    m_session = m_broker.TriggerSignatureHelp(m_textView)
                End If

            ElseIf typedChar.Equals(")"c) AndAlso m_session IsNot Nothing Then
                m_session.Dismiss()
                m_session = Nothing
            End If
        End If
        Return m_nextCommandHandler.Exec(pguidCmdGroup, nCmdID, nCmdexecopt, pvaIn, pvaOut)
    End Function
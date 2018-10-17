    Public Function Exec(ByRef pguidCmdGroup As Guid, ByVal nCmdID As UInteger, ByVal nCmdexecopt As UInteger, ByVal pvaIn As IntPtr, ByVal pvaOut As IntPtr) As Integer Implements IOleCommandTarget.Exec
        If VsShellUtilities.IsInAutomationFunction(m_provider.ServiceProvider) Then
            Return m_nextCommandHandler.Exec(pguidCmdGroup, nCmdID, nCmdexecopt, pvaIn, pvaOut)
        End If
        'make a copy of this so we can look at it after forwarding some commands
        Dim commandID As UInteger = nCmdID
        Dim typedChar As Char = Char.MinValue
        'make sure the input is a char before getting it
        If pguidCmdGroup = VSConstants.VSStd2K AndAlso nCmdID = CUInt(VSConstants.VSStd2KCmdID.TYPECHAR) Then
            typedChar = CChar(ChrW(CUShort(Marshal.GetObjectForNativeVariant(pvaIn))))
        End If

        'check for a commit character
        If nCmdID = CUInt(VSConstants.VSStd2KCmdID.RETURN) OrElse nCmdID = CUInt(VSConstants.VSStd2KCmdID.TAB) OrElse (Char.IsWhiteSpace(typedChar) OrElse Char.IsPunctuation(typedChar)) Then
            'check for a selection
            If m_session IsNot Nothing AndAlso (Not m_session.IsDismissed) Then
                'if the selection is fully selected, commit the current session
                If m_session.SelectedCompletionSet.SelectionStatus.IsSelected Then
                    m_session.Commit()
                    'also, don't add the character to the buffer
                    Return VSConstants.S_OK
                Else
                    'if there is no selection, dismiss the session
                    m_session.Dismiss()
                End If
            End If
        End If

        'pass along the command so the char is added to the buffer
        Dim retVal As Integer = m_nextCommandHandler.Exec(pguidCmdGroup, nCmdID, nCmdexecopt, pvaIn, pvaOut)
        Dim handled As Boolean = False
        If (Not typedChar.Equals(Char.MinValue)) AndAlso Char.IsLetterOrDigit(typedChar) Then
            If m_session Is Nothing OrElse m_session.IsDismissed Then ' If there is no active session, bring up completion
                Me.TriggerCompletion()
                m_session.Filter()
            Else 'the completion session is already active, so just filter
                m_session.Filter()
            End If
            handled = True
        ElseIf commandID = CUInt(VSConstants.VSStd2KCmdID.BACKSPACE) OrElse commandID = CUInt(VSConstants.VSStd2KCmdID.DELETE) Then 'redo the filter if there is a deletion
            If m_session IsNot Nothing AndAlso (Not m_session.IsDismissed) Then
                m_session.Filter()
            End If
            handled = True
        End If
        If handled Then
            Return VSConstants.S_OK
        End If
        Return retVal
    End Function
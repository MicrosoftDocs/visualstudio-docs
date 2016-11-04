            'the expansion insertion is handled in OnItemChosen
            'if the expansion session is still active, handle tab/backtab/return/cancel
            If m_exSession IsNot Nothing Then
                If nCmdID = CUInt(VSConstants.VSStd2KCmdID.BACKTAB) Then
                    m_exSession.GoToPreviousExpansionField()
                    Return VSConstants.S_OK
                ElseIf nCmdID = CUInt(VSConstants.VSStd2KCmdID.TAB) Then
                    m_exSession.GoToNextExpansionField(0)
                    'false to support cycling through all the fields
                    Return VSConstants.S_OK
                ElseIf nCmdID = CUInt(VSConstants.VSStd2KCmdID.[RETURN]) OrElse nCmdID = CUInt(VSConstants.VSStd2KCmdID.CANCEL) Then
                    If m_exSession.EndCurrentExpansion(0) = VSConstants.S_OK Then
                        m_exSession = Nothing
                        Return VSConstants.S_OK
                    End If
                End If
            End If
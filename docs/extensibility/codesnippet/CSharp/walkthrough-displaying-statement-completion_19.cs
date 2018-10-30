    public int Exec(ref Guid pguidCmdGroup, uint nCmdID, uint nCmdexecopt, IntPtr pvaIn, IntPtr pvaOut)
    {
        if (VsShellUtilities.IsInAutomationFunction(m_provider.ServiceProvider))
        {
            return m_nextCommandHandler.Exec(ref pguidCmdGroup, nCmdID, nCmdexecopt, pvaIn, pvaOut);
        }
        //make a copy of this so we can look at it after forwarding some commands
        uint commandID = nCmdID;
        char typedChar = char.MinValue;
        //make sure the input is a char before getting it
        if (pguidCmdGroup == VSConstants.VSStd2K && nCmdID == (uint)VSConstants.VSStd2KCmdID.TYPECHAR)
        {
            typedChar = (char)(ushort)Marshal.GetObjectForNativeVariant(pvaIn);
        }

        //check for a commit character
        if (nCmdID == (uint)VSConstants.VSStd2KCmdID.RETURN
            || nCmdID == (uint)VSConstants.VSStd2KCmdID.TAB
            || (char.IsWhiteSpace(typedChar) || char.IsPunctuation(typedChar)))
        {
            //check for a selection
            if (m_session != null && !m_session.IsDismissed)
            {
                //if the selection is fully selected, commit the current session
                if (m_session.SelectedCompletionSet.SelectionStatus.IsSelected)
                {
                    m_session.Commit();
                    //also, don't add the character to the buffer
                    return VSConstants.S_OK;
                }
                else
                {
                    //if there is no selection, dismiss the session
                    m_session.Dismiss();
                }
            }
        }

        //pass along the command so the char is added to the buffer
        int retVal = m_nextCommandHandler.Exec(ref pguidCmdGroup, nCmdID, nCmdexecopt, pvaIn, pvaOut);
        bool handled = false;
        if (!typedChar.Equals(char.MinValue) && char.IsLetterOrDigit(typedChar))
        {
            if (m_session == null || m_session.IsDismissed) // If there is no active session, bring up completion
            {
                this.TriggerCompletion();
                m_session.Filter();
            }
            else    //the completion session is already active, so just filter
            {
                m_session.Filter();
            }
            handled = true;
        }
        else if (commandID == (uint)VSConstants.VSStd2KCmdID.BACKSPACE   //redo the filter if there is a deletion
            || commandID == (uint)VSConstants.VSStd2KCmdID.DELETE)
        {
            if (m_session != null && !m_session.IsDismissed)
                m_session.Filter();
            handled = true;
        }
        if (handled) return VSConstants.S_OK;
        return retVal;
    }
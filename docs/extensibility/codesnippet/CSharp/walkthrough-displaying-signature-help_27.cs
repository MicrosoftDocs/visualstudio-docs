    public int Exec(ref Guid pguidCmdGroup, uint nCmdID, uint nCmdexecopt, IntPtr pvaIn, IntPtr pvaOut)
    {
        char typedChar = char.MinValue;

        if (pguidCmdGroup == VSConstants.VSStd2K && nCmdID == (uint)VSConstants.VSStd2KCmdID.TYPECHAR)
        {
            typedChar = (char)(ushort)Marshal.GetObjectForNativeVariant(pvaIn);
            if (typedChar.Equals('('))
            {
                //move the point back so it's in the preceding word
                SnapshotPoint point = m_textView.Caret.Position.BufferPosition - 1;
                TextExtent extent = m_navigator.GetExtentOfWord(point);
                string word = extent.Span.GetText();
                if (word.Equals("add"))
                    m_session = m_broker.TriggerSignatureHelp(m_textView);

            }
            else if (typedChar.Equals(')') && m_session != null)
            {
                m_session.Dismiss();
                m_session = null;
            }
        }
        return m_nextCommandHandler.Exec(ref pguidCmdGroup, nCmdID, nCmdexecopt, pvaIn, pvaOut);
    }
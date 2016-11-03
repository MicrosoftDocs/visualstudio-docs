            //neither an expansion session nor a completion session is open, but we got a tab, so check whether the last word typed is a snippet shortcut 
            if (m_session == null && m_exSession == null && nCmdID == (uint)VSConstants.VSStd2KCmdID.TAB)
            {
                //get the word that was just added 
                CaretPosition pos = m_textView.Caret.Position;
                TextExtent word = m_provider.NavigatorService.GetTextStructureNavigator(m_textView.TextBuffer).GetExtentOfWord(pos.BufferPosition - 1); //use the position 1 space back
                string textString = word.Span.GetText(); //the word that was just added
                //if it is a code snippet, insert it, otherwise carry on
                if (InsertAnyExpansion(textString, null, null))
                    return VSConstants.S_OK;
            }
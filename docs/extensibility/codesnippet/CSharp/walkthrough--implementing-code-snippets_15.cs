        private bool InsertAnyExpansion(string shortcut, string title, string path)
        {
            //first get the location of the caret, and set up a TextSpan
            int endColumn, startLine;
            //get the column number from  the IVsTextView, not the ITextView
            m_vsTextView.GetCaretPos(out startLine, out endColumn);

            TextSpan addSpan = new TextSpan();
            addSpan.iStartIndex = endColumn;
            addSpan.iEndIndex = endColumn;
            addSpan.iStartLine = startLine;
            addSpan.iEndLine = startLine;

            if (shortcut != null) //get the expansion from the shortcut
            {
                //reset the TextSpan to the width of the shortcut, 
                //because we're going to replace the shortcut with the expansion
                addSpan.iStartIndex = addSpan.iEndIndex - shortcut.Length;

                m_exManager.GetExpansionByShortcut(
                    this,
                    new Guid(SnippetUtilities.LanguageServiceGuidStr),
                    shortcut,
                    m_vsTextView,
                    new TextSpan[] { addSpan },
                    0,
                    out path,
                    out title);

            }
            if (title != null && path != null)
            {
                IVsTextLines textLines;
                m_vsTextView.GetBuffer(out textLines);
                IVsExpansion bufferExpansion = (IVsExpansion)textLines;

                if (bufferExpansion != null)
                {
                    int hr = bufferExpansion.InsertNamedExpansion(
                        title,
                        path,
                        addSpan,
                        this,
                        new Guid(SnippetUtilities.LanguageServiceGuidStr),
                        0,
                       out m_exSession);
                    if (VSConstants.S_OK == hr)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
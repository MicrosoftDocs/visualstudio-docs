            'code previously written for Exec
            If pguidCmdGroup = VSConstants.VSStd2K AndAlso nCmdID = CUInt(VSConstants.VSStd2KCmdID.TYPECHAR) Then
                typedChar = ChrW(CUShort(Marshal.GetObjectForNativeVariant(pvaIn)))
            End If
            'the snippet picker code starts here
            If nCmdID = CUInt(VSConstants.VSStd2KCmdID.INSERTSNIPPET) Then
                Dim textManager As IVsTextManager2 = DirectCast(m_provider.ServiceProvider.GetService(GetType(SVsTextManager)), IVsTextManager2)

                textManager.GetExpansionManager(m_exManager)
                m_exManager.InvokeInsertionUI(
                    m_vsTextView,
                    Me,
                    New Guid(SnippetUtilities.LanguageServiceGuidStr),
                    Nothing,
                    0,
                    0,
                    Nothing,
                    0,
                    0,
                    "TestSnippets",
                    String.Empty)
                Return VSConstants.S_OK
            End If
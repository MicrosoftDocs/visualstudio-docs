            //code previously written for Exec
            if (pguidCmdGroup == VSConstants.VSStd2K && nCmdID == (uint)VSConstants.VSStd2KCmdID.TYPECHAR)
            {
                typedChar = (char)(ushort)Marshal.GetObjectForNativeVariant(pvaIn);
            }
            //the snippet picker code starts here
            if (nCmdID == (uint)VSConstants.VSStd2KCmdID.INSERTSNIPPET)
            {
                IVsTextManager2 textManager = (IVsTextManager2)m_provider.ServiceProvider.GetService(typeof(SVsTextManager));

                textManager.GetExpansionManager(out m_exManager);

                m_exManager.InvokeInsertionUI(
                    m_vsTextView,
                    this,      //the expansion client
                    new Guid(SnippetUtilities.LanguageServiceGuidStr),
                    null,       //use all snippet types
                    0,          //number of types (0 for all)
                    0,          //ignored if iCountTypes == 0
                    null,       //use all snippet kinds
                    0,          //use all snippet kinds
                    0,          //ignored if iCountTypes == 0
                    "TestSnippets", //the text to show in the prompt
                    string.Empty);  //only the ENTER key causes insert 

                return VSConstants.S_OK;
            }
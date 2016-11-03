        public int QueryStatus(ref Guid pguidCmdGroup, uint cCmds, OLECMD[] prgCmds, IntPtr pCmdText)
        {
            if (!VsShellUtilities.IsInAutomationFunction(m_provider.ServiceProvider))
            {
                if (pguidCmdGroup == VSConstants.VSStd2K && cCmds > 0)
                {
                    // make the Insert Snippet command appear on the context menu 
                    if ((uint)prgCmds[0].cmdID == (uint)VSConstants.VSStd2KCmdID.INSERTSNIPPET)
                    {
                        prgCmds[0].cmdf = (int)Constants.MSOCMDF_ENABLED | (int)Constants.MSOCMDF_SUPPORTED;
                        return VSConstants.S_OK;
                    }
                }
            }

            return m_nextCommandHandler.QueryStatus(ref pguidCmdGroup, cCmds, prgCmds, pCmdText);
        }
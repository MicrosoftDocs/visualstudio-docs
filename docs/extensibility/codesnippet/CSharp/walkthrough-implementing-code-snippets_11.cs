            //the expansion insertion is handled in OnItemChosen
            //if the expansion session is still active, handle tab/backtab/return/cancel
            if (m_exSession != null)
            {
                if (nCmdID == (uint)VSConstants.VSStd2KCmdID.BACKTAB)
                {
                    m_exSession.GoToPreviousExpansionField();
                    return VSConstants.S_OK;
                }
                else if (nCmdID == (uint)VSConstants.VSStd2KCmdID.TAB)
                {

                    m_exSession.GoToNextExpansionField(0); //false to support cycling through all the fields
                    return VSConstants.S_OK;
                }
                else if (nCmdID == (uint)VSConstants.VSStd2KCmdID.RETURN || nCmdID == (uint)VSConstants.VSStd2KCmdID.CANCEL)
                {
                    if (m_exSession.EndCurrentExpansion(0) == VSConstants.S_OK)
                    {
                        m_exSession = null;
                        return VSConstants.S_OK;
                    }
                }
            }
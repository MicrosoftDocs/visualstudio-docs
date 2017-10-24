        Public Function QueryStatus(ByRef pguidCmdGroup As Guid, ByVal cCmds As UInteger, ByVal prgCmds As OLECMD(), ByVal pCmdText As IntPtr) As Integer Implements IOleCommandTarget.QueryStatus
            If Not VsShellUtilities.IsInAutomationFunction(m_provider.ServiceProvider) Then
                If pguidCmdGroup = VSConstants.VSStd2K AndAlso cCmds > 0 Then
                    ' make the Insert Snippet command appear on the context menu 
                    If CUInt(prgCmds(0).cmdID) = CUInt(VSConstants.VSStd2KCmdID.INSERTSNIPPET) Then
                        prgCmds(0).cmdf = CInt(Constants.MSOCMDF_ENABLED) Or CInt(Constants.MSOCMDF_SUPPORTED)
                        Return VSConstants.S_OK
                    End If
                End If
            End If

            Return m_nextCommandHandler.QueryStatus(pguidCmdGroup, cCmds, prgCmds, pCmdText)
        End Function
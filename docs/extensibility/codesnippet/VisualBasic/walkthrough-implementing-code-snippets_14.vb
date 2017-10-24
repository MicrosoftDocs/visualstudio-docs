        Public Function OnItemChosen(ByVal pszTitle As String, ByVal pszPath As String) As Integer Implements IVsExpansionClient.OnItemChosen
            InsertAnyExpansion(Nothing, pszTitle, pszPath)
            Return VSConstants.S_OK
        End Function
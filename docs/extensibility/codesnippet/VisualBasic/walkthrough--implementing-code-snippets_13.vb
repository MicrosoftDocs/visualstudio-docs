        Public Function EndExpansion() As Integer Implements IVsExpansionClient.EndExpansion
            m_exSession = Nothing
            Return VSConstants.S_OK
        End Function

        Public Function FormatSpan(ByVal pBuffer As IVsTextLines, ByVal ts As TextSpan()) As Integer Implements IVsExpansionClient.FormatSpan
            Return VSConstants.S_OK
        End Function

        Public Function GetExpansionFunction(ByVal xmlFunctionNode As IXMLDOMNode, ByVal bstrFieldName As String, ByRef pFunc As IVsExpansionFunction) As Integer Implements IVsExpansionClient.GetExpansionFunction
            pFunc = Nothing
            Return VSConstants.S_OK
        End Function

        Public Function IsValidKind(ByVal pBuffer As IVsTextLines, ByVal ts As TextSpan(), ByVal bstrKind As String, ByRef pfIsValidKind As Integer) As Integer Implements IVsExpansionClient.IsValidKind
            pfIsValidKind = 1
            Return VSConstants.S_OK
        End Function

        Public Function IsValidType(ByVal pBuffer As IVsTextLines, ByVal ts() As TextSpan, ByVal rgTypes() As String, ByVal iCountTypes As Integer, ByRef pfIsValidType As Integer) As Integer Implements IVsExpansionClient.IsValidType
            pfIsValidType = 1
            Return VSConstants.S_OK
        End Function

        Public Function OnAfterInsertion(ByVal pSession As IVsExpansionSession) As Integer Implements IVsExpansionClient.OnAfterInsertion
            Return VSConstants.S_OK
        End Function

        Public Function OnBeforeInsertion(ByVal pSession As IVsExpansionSession) As Integer Implements IVsExpansionClient.OnBeforeInsertion
            Return VSConstants.S_OK
        End Function

        Public Function PositionCaretForEditing(ByVal pBuffer As IVsTextLines, ByVal ts As TextSpan()) As Integer Implements IVsExpansionClient.PositionCaretForEditing
            Return VSConstants.S_OK
        End Function
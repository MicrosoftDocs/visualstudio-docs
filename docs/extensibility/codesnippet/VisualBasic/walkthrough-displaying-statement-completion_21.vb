    Private Sub OnSessionDismissed(ByVal sender As Object, ByVal e As EventArgs)
        RemoveHandler m_session.Dismissed, AddressOf OnSessionDismissed
        m_session = Nothing
    End Sub
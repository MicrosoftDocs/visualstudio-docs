    private void OnSessionDismissed(object sender, EventArgs e)
    {
        m_session.Dismissed -= this.OnSessionDismissed;
        m_session = null;
    }
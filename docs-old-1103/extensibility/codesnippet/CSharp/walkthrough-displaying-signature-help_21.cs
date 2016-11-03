    private bool m_isDisposed;
    public void Dispose()
    {
        if (!m_isDisposed)
        {
            GC.SuppressFinalize(this);
            m_isDisposed = true;
        }
    }
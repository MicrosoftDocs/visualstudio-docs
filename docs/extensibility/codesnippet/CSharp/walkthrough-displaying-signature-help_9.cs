    public IParameter CurrentParameter
    {
        get { return m_currentParameter; }
        internal set
        {
            if (m_currentParameter != value)
            {
                IParameter prevCurrentParameter = m_currentParameter;
                m_currentParameter = value;
                this.RaiseCurrentParameterChanged(prevCurrentParameter, m_currentParameter);
            }
        }
    }
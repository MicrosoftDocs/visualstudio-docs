    private void RaiseCurrentParameterChanged(IParameter prevCurrentParameter, IParameter newCurrentParameter)
    {
        EventHandler<CurrentParameterChangedEventArgs> tempHandler = this.CurrentParameterChanged;
        if (tempHandler != null)
        {
            tempHandler(this, new CurrentParameterChangedEventArgs(prevCurrentParameter, newCurrentParameter));
        }
    }
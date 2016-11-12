    void BufferChanged(object sender, TextContentChangedEventArgs e)
    {
        // If this isn't the most up-to-date version of the buffer, then ignore it for now (we'll eventually get another change event).
        if (e.After != buffer.CurrentSnapshot)
            return;
        this.ReParse();
    }
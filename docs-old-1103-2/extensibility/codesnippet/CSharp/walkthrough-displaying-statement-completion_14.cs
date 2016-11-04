    public void VsTextViewCreated(IVsTextView textViewAdapter)
    {
        ITextView textView = AdapterService.GetWpfTextView(textViewAdapter);
        if (textView == null)
            return;

        Func<TestCompletionCommandHandler> createCommandHandler = delegate() { return new TestCompletionCommandHandler(textViewAdapter, textView, this); };
        textView.Properties.GetOrCreateSingletonProperty(createCommandHandler);
    }
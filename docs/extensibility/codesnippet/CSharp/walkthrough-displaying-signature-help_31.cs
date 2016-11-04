    public void VsTextViewCreated(IVsTextView textViewAdapter)
    {
        ITextView textView = AdapterService.GetWpfTextView(textViewAdapter);
        if (textView == null)
            return;

        textView.Properties.GetOrCreateSingletonProperty(
             () => new TestSignatureHelpCommandHandler(textViewAdapter,
                textView,
                NavigatorService.GetTextStructureNavigator(textView.TextBuffer),
                SignatureHelpBroker));
    }
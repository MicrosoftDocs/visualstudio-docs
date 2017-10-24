    [Import]
    internal IVsEditorAdaptersFactoryService AdapterService = null;
    [Import]
    internal ICompletionBroker CompletionBroker { get; set; }
    [Import]
    internal SVsServiceProvider ServiceProvider { get; set; }
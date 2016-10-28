    [Import]
    internal IVsEditorAdaptersFactoryService AdapterService;

    [Import]
    internal ITextStructureNavigatorSelectorService NavigatorService { get; set; }

    [Import]
    internal ISignatureHelpBroker SignatureHelpBroker;
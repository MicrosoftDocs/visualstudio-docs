    <Import()>
    Friend AdapterService As IVsEditorAdaptersFactoryService = Nothing
    <Import()>
    Friend Property CompletionBroker() As ICompletionBroker
    <Import()>
    Friend Property ServiceProvider() As SVsServiceProvider
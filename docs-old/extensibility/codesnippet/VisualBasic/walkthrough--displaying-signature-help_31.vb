    Public Sub VsTextViewCreated(ByVal textViewAdapter As IVsTextView) Implements IVsTextViewCreationListener.VsTextViewCreated
        Dim textView As ITextView = AdapterService.GetWpfTextView(textViewAdapter)
        If textView Is Nothing Then
            Return
        End If

        textView.Properties.GetOrCreateSingletonProperty(Function() New TestSignatureHelpCommandHandler(textViewAdapter, textView, NavigatorService.GetTextStructureNavigator(textView.TextBuffer), SignatureHelpBroker))
    End Sub
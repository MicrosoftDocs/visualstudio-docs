    Public Sub VsTextViewCreated(ByVal textViewAdapter As IVsTextView) Implements IVsTextViewCreationListener.VsTextViewCreated
        Dim textView As ITextView = AdapterService.GetWpfTextView(textViewAdapter)
        If textView Is Nothing Then
            Return
        End If

        Dim createCommandHandler As Func(Of TestCompletionCommandHandler) = Function() New TestCompletionCommandHandler(textViewAdapter, textView, Me)
        textView.Properties.GetOrCreateSingletonProperty(createCommandHandler)
    End Sub
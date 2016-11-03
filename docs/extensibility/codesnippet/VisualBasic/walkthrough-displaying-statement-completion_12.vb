<Export(GetType(IVsTextViewCreationListener))>
<Name("token completion handler")>
<ContentType("plaintext")> <TextViewRole(PredefinedTextViewRoles.Editable)>
Friend Class TestCompletionHandlerProvider
    Implements IVsTextViewCreationListener
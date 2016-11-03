[Export(typeof(IVsTextViewCreationListener))]
[Name("token completion handler")]
[ContentType("plaintext")]
[TextViewRole(PredefinedTextViewRoles.Editable)]
internal class TestCompletionHandlerProvider : IVsTextViewCreationListener
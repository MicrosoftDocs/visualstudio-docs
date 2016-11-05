[Export(typeof(ISignatureHelpSourceProvider))]
[Name("Signature Help source")]
[Order(Before = "default")]
[ContentType("text")]
internal class TestSignatureHelpSourceProvider : ISignatureHelpSourceProvider
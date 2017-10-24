<Export(GetType(ISignatureHelpSourceProvider)), Name("Signature Help source"), Order(Before:="default"), ContentType("text")>
Friend Class TestSignatureHelpSourceProvider
    Implements ISignatureHelpSourceProvider
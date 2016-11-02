<Export(GetType(IQuickInfoSourceProvider))> _
<Name("ToolTip QuickInfo Source")> _
<Order(Before:=" Default Quick Info Presenter")> _
<ContentType("text")> _
Friend Class TestQuickInfoSourceProvider
    Implements IQuickInfoSourceProvider
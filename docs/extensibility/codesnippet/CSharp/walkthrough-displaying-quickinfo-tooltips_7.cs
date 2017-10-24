[Export(typeof(IQuickInfoSourceProvider))]
[Name("ToolTip QuickInfo Source")]
[Order(Before = "Default Quick Info Presenter")]
[ContentType("text")]
internal class TestQuickInfoSourceProvider : IQuickInfoSourceProvider
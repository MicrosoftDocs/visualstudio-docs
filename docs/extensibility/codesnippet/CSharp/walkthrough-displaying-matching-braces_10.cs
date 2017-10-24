[Export(typeof(IViewTaggerProvider))]
[ContentType("text")]
[TagType(typeof(TextMarkerTag))]
internal class BraceMatchingTaggerProvider : IViewTaggerProvider
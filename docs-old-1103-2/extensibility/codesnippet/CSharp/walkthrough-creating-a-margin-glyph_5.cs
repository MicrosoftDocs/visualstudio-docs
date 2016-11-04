[Export(typeof(IGlyphFactoryProvider))]
[Name("TodoGlyph")]
[Order(After = "VsTextMarker")]
[ContentType("code")]
[TagType(typeof(TodoTag))]
internal sealed class TodoGlyphFactoryProvider : IGlyphFactoryProvider
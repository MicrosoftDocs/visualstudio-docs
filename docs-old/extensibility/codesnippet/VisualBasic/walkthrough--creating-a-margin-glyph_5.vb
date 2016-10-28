    <Export(GetType(IGlyphFactoryProvider)), Name("TodoGlyph"), Order(After:="VsTextMarker"), ContentType("code"), TagType(GetType(TodoTag))>
    Friend NotInheritable Class TodoGlyphFactoryProvider
        Implements IGlyphFactoryProvider
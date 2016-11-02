    public UIElement GenerateGlyph(IWpfTextViewLine line, IGlyphTag tag)
    {
        // Ensure we can draw a glyph for this marker.
        if (tag == null || !(tag is TodoTag))
        {
            return null;
        }

        System.Windows.Shapes.Ellipse ellipse = new Ellipse();
        ellipse.Fill = Brushes.LightBlue;
        ellipse.StrokeThickness = 2;
        ellipse.Stroke = Brushes.DarkBlue;
        ellipse.Height = m_glyphSize;
        ellipse.Width = m_glyphSize;

        return ellipse;
    }
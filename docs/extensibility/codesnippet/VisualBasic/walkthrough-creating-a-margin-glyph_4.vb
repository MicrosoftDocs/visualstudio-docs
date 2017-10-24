    Public Function GenerateGlyph(ByVal line As IWpfTextViewLine, ByVal tag As IGlyphTag) As System.Windows.UIElement Implements IGlyphFactory.GenerateGlyph
        ' Ensure we can draw a glyph for this marker.
        If tag Is Nothing OrElse Not (TypeOf tag Is TodoTag) Then
            Return Nothing
        End If

        Dim ellipse As Ellipse = New Ellipse()
        ellipse.Fill = Brushes.LightBlue
        ellipse.StrokeThickness = 2
        ellipse.Stroke = Brushes.DarkBlue
        ellipse.Height = m_glyphSize
        ellipse.Width = m_glyphSize

        Return ellipse

    End Function
    Friend Sub New(ByVal view As ITextView, ByVal sourceBuffer As ITextBuffer)
        'here the keys are the open braces, and the values are the close braces
        m_braceList = New Dictionary(Of Char, Char)()
        m_braceList.Add("{"c, "}"c)
        m_braceList.Add("["c, "]"c)
        m_braceList.Add("("c, ")"c)
        Me.View = view
        Me.SourceBuffer = sourceBuffer
        Me.CurrentChar = Nothing

        AddHandler Me.View.Caret.PositionChanged, AddressOf Me.CaretPositionChanged
        AddHandler Me.View.LayoutChanged, AddressOf Me.ViewLayoutChanged
    End Sub
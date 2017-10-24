    Private _View As ITextView
    Private Property View() As ITextView
        Get
            Return _View
        End Get
        Set(ByVal value As ITextView)
            _View = value
        End Set
    End Property
    Private _SourceBuffer As ITextBuffer
    Private Property SourceBuffer() As ITextBuffer
        Get
            Return _SourceBuffer
        End Get
        Set(ByVal value As ITextBuffer)
            _SourceBuffer = value
        End Set
    End Property
    Private _CurrentChar As System.Nullable(Of SnapshotPoint)
    Private Property CurrentChar() As System.Nullable(Of SnapshotPoint)
        Get
            Return _CurrentChar
        End Get
        Set(ByVal value As System.Nullable(Of SnapshotPoint))
            _CurrentChar = value
        End Set
    End Property
    Private m_braceList As Dictionary(Of Char, Char)
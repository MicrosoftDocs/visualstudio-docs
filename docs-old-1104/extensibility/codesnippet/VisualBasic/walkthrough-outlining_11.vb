    Private Class PartialRegion
        Private _StartLine As Integer
        Public Property StartLine() As Integer
            Get
                Return _StartLine
            End Get
            Set(ByVal value As Integer)
                _StartLine = value
            End Set
        End Property
        Private _StartOffset As Integer
        Public Property StartOffset() As Integer
            Get
                Return _StartOffset
            End Get
            Set(ByVal value As Integer)
                _StartOffset = value
            End Set
        End Property
        Private _Level As Integer
        Public Property Level() As Integer
            Get
                Return _Level
            End Get
            Set(ByVal value As Integer)
                _Level = value
            End Set
        End Property
        Private _PartialParent As PartialRegion
        Public Property PartialParent() As PartialRegion
            Get
                Return _PartialParent
            End Get
            Set(ByVal value As PartialRegion)
                _PartialParent = value
            End Set
        End Property
    End Class

    Private Class Region
        Inherits PartialRegion
        Private _EndLine As Integer
        Public Property EndLine() As Integer
            Get
                Return _EndLine
            End Get
            Set(ByVal value As Integer)
                _EndLine = value
            End Set
        End Property
    End Class
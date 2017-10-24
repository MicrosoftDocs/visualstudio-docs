    Private privateDocumentation As String
    ReadOnly Property Documentation() As String Implements IParameter.Documentation
        Get
            Return privateDocumentation
        End Get

    End Property
    Private privateLocus As Span
    ReadOnly Property Locus() As Span Implements IParameter.Locus
        Get
            Return privateLocus
        End Get
    End Property
    Private privateName As String
    ReadOnly Property Name() As String Implements IParameter.Name
        Get
            Return privateName
        End Get
    End Property
    Private privateSignature As ISignature
    ReadOnly Property Signature() As ISignature Implements IParameter.Signature
        Get
            Return privateSignature
        End Get
    End Property
    Private privatePrettyPrintedLocus As Span
    ReadOnly Property PrettyPrintedLocus() As Span Implements IParameter.PrettyPrintedLocus
        Get
            Return privatePrettyPrintedLocus
        End Get
    End Property
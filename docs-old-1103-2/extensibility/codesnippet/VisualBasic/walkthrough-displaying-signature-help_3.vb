    Public Sub New(ByVal documentation As String, ByVal locus As Span, ByVal name As String, ByVal signature As ISignature)
        Me.privateDocumentation = documentation
        Me.privateLocus = locus
        Me.privateName = name
        Me.privateSignature = signature
    End Sub
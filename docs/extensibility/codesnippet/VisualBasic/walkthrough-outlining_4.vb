    Public Sub New(ByVal buffer As ITextBuffer)
        Me.buffer = buffer
        Me.snapshot = buffer.CurrentSnapshot
        Me.regions = New List(Of Region)()
        Me.ReParse()
        AddHandler Me.buffer.Changed, AddressOf BufferChanged
    End Sub
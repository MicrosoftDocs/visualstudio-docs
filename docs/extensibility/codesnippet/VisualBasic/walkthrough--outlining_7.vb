    Private Sub BufferChanged(ByVal sender As Object, ByVal e As TextContentChangedEventArgs)
        ' If this isn't the most up-to-date version of the buffer, then ignore it for now (we'll eventually get another change event).
        If e.After IsNot buffer.CurrentSnapshot Then
            Exit Sub
        End If
        Me.ReParse()
    End Sub
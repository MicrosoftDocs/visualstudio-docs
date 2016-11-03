    Private m_isDisposed As Boolean

    Public Sub Dispose() Implements IDisposable.Dispose
        If Not m_isDisposed Then
            GC.SuppressFinalize(Me)
            m_isDisposed = True
        End If
    End Sub
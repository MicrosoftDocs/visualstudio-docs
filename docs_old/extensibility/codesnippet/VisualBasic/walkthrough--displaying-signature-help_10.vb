    Private Sub RaiseCurrentParameterChanged(ByVal prevCurrentParameter As IParameter, ByVal newCurrentParameter As IParameter)
        Dim tempHandler As EventHandler(Of CurrentParameterChangedEventArgs) = Me.CurrentParameterChangedEvent
        If tempHandler IsNot Nothing Then
            tempHandler(Me, New CurrentParameterChangedEventArgs(prevCurrentParameter, newCurrentParameter))
        End If
    End Sub
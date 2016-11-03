    Public Class Automobile
        Sub New(ByVal model As String, ByVal topSpeed As Integer)
            _model = model
            _topSpeed = topSpeed
        End Sub
        Sub New()
            ' TODO: Complete member initialization 
        End Sub

        Property Model() As String
        Property TopSpeed As Integer
        Property IsRunning As Boolean
        Sub Start()
            Throw New NotImplementedException
        End Sub
    End Class
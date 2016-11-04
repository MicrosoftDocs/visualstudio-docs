    Public Function GetData(ByVal value As String) As String Implements IService1.GetData
        Return String.Format("You entered: {0}", value)
    End Function
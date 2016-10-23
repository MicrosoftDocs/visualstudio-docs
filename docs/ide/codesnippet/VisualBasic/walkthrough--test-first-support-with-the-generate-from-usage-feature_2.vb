        <TestMethod()> Public Sub AutomobileWithModelNameCanStart()
            Dim model As String = "Contoso"
            Dim topSpeed As Integer = 199
            Dim myAuto As New Automobile(model, topSpeed)
        End Sub
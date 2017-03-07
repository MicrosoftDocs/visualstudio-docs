
Public Class ThisWorkbook

    Dim myCondition As Boolean
    Private Sub ThisWorkbook_Startup() Handles Me.Startup

    End Sub

    Private Sub ThisWorkbook_Shutdown() Handles Me.Shutdown

    End Sub
    '<Snippet1>
    Protected Overrides Function CreateRibbonExtensibilityObject() As  _
        Microsoft.Office.Core.IRibbonExtensibility
        If myCondition = True Then
            Return Globals.Factory.GetRibbonFactory().CreateRibbonManager _
                (New Microsoft.Office.Tools.Ribbon.IRibbonExtension() _
                     {New Ribbon1()})
        Else
            Return Globals.Factory.GetRibbonFactory().CreateRibbonManager _
                (New Microsoft.Office.Tools.Ribbon.IRibbonExtension() _
                     {New Ribbon2()})
        End If
    End Function
    '</Snippet1>
End Class


'<Snippet1>
Public Class TaskPaneHelper
    Implements Office.ICustomTaskPaneConsumer

    Friend taskPane As Office.CustomTaskPane

    Public Sub CTPFactoryAvailable(ByVal CTPFactoryInst As Office.ICTPFactory) _
        Implements Office.ICustomTaskPaneConsumer.CTPFactoryAvailable

        If CTPFactoryInst IsNot Nothing Then
            ' Create a new task pane.
            taskPane = CTPFactoryInst.CreateCTP( _
                "Microsoft.Samples.Vsto.VB.TaskPaneUI", "Contoso")
            taskPane.Visible = True
        End If
    End Sub
End Class

<System.Runtime.InteropServices.ComVisible(True)> _
<System.Runtime.InteropServices.ProgId("Microsoft.Samples.Vsto.VB.TaskPaneUI")> _
<System.Runtime.InteropServices.Guid("FFA0920E-F7A5-453d-8AB2-249F4C25B4B2")> _
Public Class TaskPaneUI
    Inherits UserControl
End Class
'</Snippet1>

'<System.AddIn.AddIn("ThisAddIn", Version:="1.0", Publisher:="", Description:="")> _
Public Class ThisAddIn

    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup

    End Sub

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

    '<Snippet2>
    Friend taskPaneHelper1 As TaskPaneHelper

    Protected Overrides Function RequestService( _
        ByVal serviceGuid As Guid) As Object

        If (serviceGuid = GetType(Office.ICustomTaskPaneConsumer).GUID) Then
            If (taskPaneHelper1 Is Nothing) Then
                taskPaneHelper1 = New TaskPaneHelper()
            End If
            Return taskPaneHelper1
        End If

        Return MyBase.RequestService(serviceGuid)
    End Function
    '</Snippet2>

End Class

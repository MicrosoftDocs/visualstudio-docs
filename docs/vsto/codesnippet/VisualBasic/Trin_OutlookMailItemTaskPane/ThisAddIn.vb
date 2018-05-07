'<Snippet1>
'<Snippet2>
Imports System.Collections.Generic
Imports Microsoft.Office.Tools
Imports Office = Microsoft.Office.Core
Imports Outlook = Microsoft.Office.Interop.Outlook
'</Snippet2>

'<Snippet3>
Public Class InspectorWrapper
    Private inspector As Outlook.Inspector
    Private WithEvents inspectorEvents As Outlook.InspectorEvents_Event
    Private WithEvents taskPane As CustomTaskPane
    '</Snippet3>

    '<Snippet4>
    Public Sub New(ByVal Inspector As Outlook.Inspector)
        Me.inspector = Inspector
        inspectorEvents = TryCast(Me.inspector, Outlook.InspectorEvents_Event)
        taskPane = Globals.ThisAddIn.CustomTaskPanes.Add(New TaskPaneControl(), _
            "My task pane", Inspector)
    End Sub
    '</Snippet4>

    '<Snippet5>
    Private Sub TaskPane_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles taskPane.VisibleChanged
        Globals.Ribbons(inspector).ManageTaskPaneRibbon.ToggleButton1.Checked = taskPane.Visible
    End Sub
    '</Snippet5>

    '<Snippet6>
    Sub InspectorWrapper_Close() Handles inspectorEvents.Close
        If Not (taskPane Is Nothing) Then
            Globals.ThisAddIn.CustomTaskPanes.Remove(taskPane)
        End If

        taskPane = Nothing
        Globals.ThisAddIn.InspectorWrappers.Remove(inspector)
        RemoveHandler inspectorEvents.Close, AddressOf InspectorWrapper_Close
        inspector = Nothing
    End Sub
    '</Snippet6>

    '<Snippet7>
    Public ReadOnly Property CustomTaskPane() As CustomTaskPane
        Get
            Return taskPane
        End Get
    End Property
End Class
'</Snippet7>

Public Class ThisAddIn

    '<Snippet8>
    Private inspectorWrappersValue As New Dictionary(Of Outlook.Inspector, InspectorWrapper)
    Private WithEvents inspectors As Outlook.Inspectors
    '</Snippet8>

    '<Snippet9>
    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Startup

        inspectors = Me.Application.Inspectors
        Dim inspector As Outlook.Inspector
        For Each inspector In inspectors
            Inspectors_NewInspector(inspector)
        Next inspector
    End Sub
    '</Snippet9>

    '<Snippet10>
    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Shutdown

        RemoveHandler inspectors.NewInspector, AddressOf Inspectors_NewInspector
        inspectors = Nothing
        inspectorWrappersValue = Nothing
    End Sub
    '</Snippet10>

    '<Snippet11>
    Sub Inspectors_NewInspector(ByVal Inspector As Outlook.Inspector) _
        Handles inspectors.NewInspector

        If TypeOf Inspector.CurrentItem Is Outlook.MailItem Then
            inspectorWrappersValue.Add(Inspector, New InspectorWrapper(Inspector))
        End If
    End Sub
    '</Snippet11>

    '<Snippet12>
    Public ReadOnly Property InspectorWrappers() As Dictionary(Of Outlook.Inspector, InspectorWrapper)
        Get
            Return inspectorWrappersValue
        End Get
    End Property
    '</Snippet12>
End Class
'</Snippet1>

Partial Class ManageTaskPaneRibbon
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()> _
   Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'This call is required by the Component Designer.
        InitializeComponent()

    End Sub

    'Component overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tab1 = Me.Factory.CreateRibbonTab()
        Me.Group1 = Me.Factory.CreateRibbonGroup()
        Me.ToggleButton1 = Me.Factory.CreateRibbonToggleButton()
        Me.Tab1.SuspendLayout()
        Me.Group1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab1
        '
        Me.Tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
        Me.Tab1.Groups.Add(Me.Group1)
        Me.Tab1.Label = "TabAddIns"
        Me.Tab1.Name = "Tab1"
        '
        'Group1
        '
        Me.Group1.Items.Add(Me.ToggleButton1)
        Me.Group1.Label = "Task Pane Manager"
        Me.Group1.Name = "Group1"
        '
        'ToggleButton1
        '
        Me.ToggleButton1.Label = "Show Task Pane"
        Me.ToggleButton1.Name = "ToggleButton1"
        '
        'ManageTaskPaneRibbon
        '
        Me.Name = "ManageTaskPaneRibbon"
        Me.RibbonType = "Microsoft.Excel.Workbook"
        Me.Tabs.Add(Me.Tab1)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.Group1.ResumeLayout(False)
        Me.Group1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab1 As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Group1 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents ToggleButton1 As Microsoft.Office.Tools.Ribbon.RibbonToggleButton
End Class

Partial Class ThisRibbonCollection
    Inherits Microsoft.Office.Tools.Ribbon.RibbonCollectionBase

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property ManageTaskPaneRibbon() As ManageTaskPaneRibbon
        Get
            Return Me.GetRibbon(Of ManageTaskPaneRibbon)()
        End Get
    End Property
End Class

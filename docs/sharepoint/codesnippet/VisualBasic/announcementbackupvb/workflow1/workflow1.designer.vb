
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Workflow1

    'NOTE: The following procedure is required by the Workflow Designer
    'It can be modified using the Workflow Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Private Sub InitializeComponent()
        Me.CanModifyActivities = True
        Dim correlationtoken1 As System.Workflow.Runtime.CorrelationToken = New System.Workflow.Runtime.CorrelationToken()
        Dim activitybind1 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind()
        Me.class11 = New AnnouncementBackupVB.AnnouncementBackup.Class1()
        Me.onWorkflowActivated1 = New Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated()
        '
        'class11
        '
        Me.class11.Name = "class11"
        '
        'onWorkflowActivated1
        '
        correlationtoken1.Name = "workflowToken"
        correlationtoken1.OwnerActivityName = "Workflow1"
        Me.onWorkflowActivated1.CorrelationToken = correlationtoken1
        Me.onWorkflowActivated1.EventName = "OnWorkflowActivated"
        Me.onWorkflowActivated1.Name = "onWorkflowActivated1"
        activitybind1.Name = "Workflow1"
        activitybind1.Path = "workflowProperties"
        Me.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, CType(activitybind1, System.Workflow.ComponentModel.ActivityBind))
        '
        'Workflow1
        '
        Me.Activities.Add(Me.onWorkflowActivated1)
        Me.Activities.Add(Me.class11)
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private class11 As AnnouncementBackupVB.AnnouncementBackup.Class1
    Private onWorkflowActivated1 As Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated


End Class

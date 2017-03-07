Public Class TaskFormRegion

#Region "Form Region Factory"

    <Microsoft.Office.Tools.Outlook.FormRegionMessageClass("IPM.Task.TaskFormRegion")> _
    <Microsoft.Office.Tools.Outlook.FormRegionName("Trin_Outlook_FR_Import_O12.TaskFormRegion")> _
    Partial Public Class TaskFormRegionFactory

    Private Sub InitializeManifest()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TaskFormRegion))
            Me.Manifest.FormRegionType = Microsoft.Office.Tools.Outlook.FormRegionType.ReplaceAll
            Me.Manifest.Title = resources.GetString("Title")
            Me.Manifest.FormRegionName = resources.GetString("FormRegionName")
            Me.Manifest.Description = resources.GetString("Description")
            Me.Manifest.ShowInspectorCompose = True
            Me.Manifest.ShowInspectorRead = True
            Me.Manifest.ShowReadingPane = True

    End Sub

    ' Occurs before the form region is initialized.
    ' To prevent the form region from appearing, set e.Cancel to true.
    ' Use e.OutlookItem to get a reference to the current Outlook item.
        Private Sub TaskFormRegionFactory_FormRegionInitializing(ByVal sender As Object, ByVal e As Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs) Handles Me.FormRegionInitializing

    End Sub

    End Class

#End Region
    ' Occurs before the form region is displayed.
    ' Use this.OutlookItem to get a reference to the current Outlook item.
    ' Use this.OutlookFormRegion to get a reference to the form region.
    '<Snippet5>
    Private Sub TaskFormRegion_FormRegionShowing(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles MyBase.FormRegionShowing
        populateComboBox()
        RefreshTaskListBox()
    End Sub
    '</Snippet5>
    ' Occurs when the form region is closed.
    ' Use this.OutlookItem to get a reference to the current Outlook item.
    ' Use this.OutlookFormRegion to get a reference to the form region.
    Private Sub TaskFormRegion_FormRegionClosed(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles MyBase.FormRegionClosed

    End Sub
    '<Snippet1>
    Private Sub populateComboBox()
        Dim Application As New Outlook.Application()
        Dim outlookNameSpace As Outlook.NameSpace = _
        Application.GetNamespace("MAPI")
        Dim taskFolder As Outlook.MAPIFolder = _
        outlookNameSpace.GetDefaultFolder _
            (Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderTasks)
        Dim taskItems As Outlook.Items = taskFolder.Items
        Dim task As Outlook.TaskItem
        For Each task In taskItems
            If Not (task.Subject Is Nothing) Then
                comboBox1.AddItem(task.Subject, System.Type.Missing)
            End If
        Next task
        comboBox1.Text = comboBox1.GetItem(0)
    End Sub
    '</Snippet1>
    '<Snippet2>
    Private Sub AddDependentTask_Click1() Handles addDependentTask.Click
        Dim tempTaskItem As Outlook.TaskItem = FindTaskBySubjectName _
            (comboBox1.Text)
        If Not (tempTaskItem Is Nothing) Then
            Me.listBox1.AddItem(tempTaskItem.PercentComplete.ToString() & _
                "% Complete -- " & tempTaskItem.Subject, System.Type.Missing)
            Me.olkTextBox3.Text = Me.olkTextBox3.Text & "|" & tempTaskItem.Subject
        End If
    End Sub
    '</Snippet2>
    '<Snippet3>
    Private Function FindTaskBySubjectName(ByVal subjectName As String) _
        As Outlook.TaskItem
        Dim Application As New Outlook.Application()
        Dim outlookNameSpace As Outlook.NameSpace = _
            Application.GetNamespace("MAPI")
        Dim tasksFolder As Outlook.MAPIFolder = _
            outlookNameSpace.GetDefaultFolder _
                (Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderTasks)
        Dim taskItems As Outlook.Items = tasksFolder.Items
        Dim taskItem As Outlook.TaskItem
        For Each taskItem In taskItems
            If taskItem.Subject = subjectName Then
                Return taskItem
            End If
        Next taskItem
        Return Nothing
    End Function
    '</Snippet3>
    '<Snippet4>
    Private Sub RefreshTaskListBox()
        listBox1.Clear()
        Dim tempTaskItem As Outlook.TaskItem
        Dim tempArray As [String]() = olkTextBox3.Text.Split(New [Char]() {"|"c})

        Dim tempString As String
        For Each tempString In tempArray
            tempTaskItem = FindTaskBySubjectName(tempString)
            If Not (tempTaskItem Is Nothing) Then
                Me.listBox1.AddItem(tempTaskItem.PercentComplete.ToString() & _
                    "% Complete -- " & tempTaskItem.Subject, System.Type.Missing)
            End If
        Next tempString
    End Sub
    '</Snippet4>

End Class

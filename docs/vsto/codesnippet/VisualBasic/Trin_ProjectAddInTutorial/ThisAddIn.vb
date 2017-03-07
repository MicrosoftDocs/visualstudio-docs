Public Class ThisAddIn

    Private Sub ThisAddIn_Startup() Handles Me.Startup

    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub
    '<Snippet1>
    Private Sub Application_NewProject(ByVal pj As Microsoft.Office.Interop.MSProject.Project) Handles Application.NewProject
        Dim newTask As MSProject.Task
        newTask = pj.Tasks.Add _
        ("This text was added by using code")
        newTask.Start = DateTime.Now
        newTask.Duration = "3"
        newTask.ResourceNames = "Rob Caron, Kelly Krout"
    End Sub
    '</Snippet1>

End Class

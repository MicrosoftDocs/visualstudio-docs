Public Class Sheet4

    Dim list1 As Microsoft.Office.Tools.Excel.ListObject
    '--------------------------------------------------------------------------
    '<Snippet20>
    Dim table As DataTable = New DataTable("Employees")
    '</Snippet20>


    '--------------------------------------------------------------------------
    Private Sub Sheet1_Startup(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Startup
        '<Snippet21>
        table.Columns.Add("FirstName", GetType(String))
        table.Columns.Add("LastName", GetType(String))
        table.Columns.Add("Title", GetType(String))

        table.Rows.Add("Nancy", "Anderson", "Sales Representative")
        table.Rows.Add("Robert", "Brown", "Sales Representative")
        '</Snippet21>

        '<Snippet22>
        list1.AutoSetDataBoundColumnHeaders = True
        list1.SetDataBinding(table, Nothing, "LastName", "FirstName")
        '</Snippet22>

        '<Snippet23>
        list1.Disconnect()
        '</Snippet23>
    End Sub
End Class

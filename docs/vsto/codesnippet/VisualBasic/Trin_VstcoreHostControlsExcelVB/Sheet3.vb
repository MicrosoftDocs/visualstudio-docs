Public Class Sheet3

    '--------------------------------------------------------------------------
    Dim WithEvents List1 As Microsoft.Office.Tools.Excel.ListObject


    '--------------------------------------------------------------------------
    '<Snippet16>
    Dim table As System.Data.DataTable = New System.Data.DataTable("Employees")
    '</Snippet16>


    '--------------------------------------------------------------------------
    
    Private Sub Sheet1_Startup(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Startup
        '<Snippet17>
        table.Columns.Add("Id", GetType(Int32))
        table.Columns.Add("FirstName", GetType(String))
        table.Columns.Add("LastName", GetType(String))
        table.Columns.Add("Title", GetType(String))

        table.Rows.Add(1, "Nancy", "Anderson", "Sales Representative")
        table.Rows.Add(2, "Robert", "Brown", "Sales Representative")
        '</Snippet17>

        '<Snippet18>
        Me.List1.AutoSetDataBoundColumnHeaders = True
        Me.List1.SetDataBinding(table, "", "Title", "LastName", "FirstName")
        '</Snippet18>

        '<Snippet19>
        Me.List1.SetDataBinding(table, "", "Title", "", "LastName", "FirstName")
        '</Snippet19>
    End Sub
    


End Class

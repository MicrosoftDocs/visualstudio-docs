Public Class Sheet2

    '--------------------------------------------------------------------------
    Dim WithEvents list1 As Microsoft.Office.Tools.Excel.ListObject


    '--------------------------------------------------------------------------
    '<Snippet12>
    Dim id As Integer = 0
    Dim employeeTable As System.Data.DataTable
    '</Snippet12>


    '--------------------------------------------------------------------------
    Private Sub Sheet1_Startup(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Startup
        '<Snippet13>
        employeeTable = New System.Data.DataTable("Employees")

        Dim column As System.Data.DataColumn = employeeTable.Columns.Add("Id", GetType(Int32))
        column.AllowDBNull = False

        employeeTable.Columns.Add("FirstName", GetType(String))
        employeeTable.Columns.Add("LastName", GetType(String))
        employeeTable.Columns.Add("Age", GetType(Int32))

        employeeTable.Rows.Add(id, "Nancy", "Anderson", 56)
        employeeTable.Rows.Add(id, "Robert", "Brown", 44)
        id += 1

        list1.SetDataBinding(employeeTable, "", "FirstName", "LastName", "Age")
        '</Snippet13>
    End Sub



    '--------------------------------------------------------------------------
    '<Snippet14>
    Private Sub list1_ErrorAddDataBoundRow(ByVal sender As Object, ByVal e As  _
        Microsoft.Office.Tools.Excel.ErrorAddDataBoundRowEventArgs) _
        Handles list1.ErrorAddDataBoundRow

        Dim row As System.Data.DataRow = (CType(e.Item, System.Data.DataRowView)).Row

        If TypeOf (e.InnerException) Is NoNullAllowedException Then
            row("Id") = id
            id += 1
            e.Retry = True
        End If
    End Sub
    '</Snippet14>
End Class

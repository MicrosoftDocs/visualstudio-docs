Public Class Sheet1

    '--------------------------------------------------------------------------
    '<Snippet24>
    Private Sub NamedRange1_BeforeDoubleClick( _
        ByVal Target As Microsoft.Office.Interop.Excel.Range, ByRef Cancel As Boolean) _
        Handles NamedRange1.BeforeDoubleClick

        With Me.NamedRange2
            .Value2 = "The BeforeDoubleClick event occurred."
            .Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
            .Font.Italic = True
        End With
    End Sub
    '</Snippet24>


    '--------------------------------------------------------------------------
    '<Snippet26>
    Private Sub NamedRange1_Change(ByVal Target As Microsoft.Office.Interop.Excel.Range) _
        Handles NamedRange1.Change

        With Me.NamedRange2
            .Value2 = "The Change event occurred."
            .Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)
            .Font.Italic = False
        End With
    End Sub
    '</Snippet26>


    '--------------------------------------------------------------------------
    '<Snippet27>
    Private Sub NamedRange1_SelectionChange(ByVal Target As Microsoft.Office.Interop.Excel.Range) _
        Handles NamedRange1.SelectionChange

        With Me.NamedRange2
            .Value2 = "The SelectionChange event occurred."
            .AddComment("SelectionChange always occurs before BeforeDoubleClick.")
            .Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
        End With
    End Sub
    '</Snippet27>


    '--------------------------------------------------------------------------
    Dim WithEvents List1 As Microsoft.Office.Tools.Excel.ListObject


    '--------------------------------------------------------------------------
    '<Snippet8>
    Dim id As Integer = 0
    Dim employeeTable As System.Data.DataTable
    '</Snippet8>


    '--------------------------------------------------------------------------
    
    Private Sub Sheet1_Startup(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Startup

        '<Snippet9>
        employeeTable = New System.Data.DataTable("Employees")

        Dim column As System.Data.DataColumn = _
            employeeTable.Columns.Add("Id", GetType(Int32))
        column.AllowDBNull = False

        employeeTable.Columns.Add("FirstName", GetType(String))
        employeeTable.Columns.Add("LastName", GetType(String))
        employeeTable.Columns.Add("Age", GetType(Int32))

        employeeTable.Rows.Add(id, "Nancy", "Anderson", 56)
        employeeTable.Rows.Add(id, "Robert", "Brown", 44)
        id += 1

        list1.SetDataBinding(employeeTable, "", "FirstName", "LastName", "Age")
        '</Snippet9>
    End Sub
   


    '--------------------------------------------------------------------------
    '<Snippet10>
    Private Sub list1_BeforeAddDataBoundRow(ByVal sender As Object, ByVal e As  _
        Microsoft.Office.Tools.Excel.BeforeAddDataBoundRowEventArgs) _
        Handles list1.BeforeAddDataBoundRow

        Dim row As System.Data.DataRow = (CType(e.Item, System.Data.DataRowView)).Row

        If Not row("Age") Is Nothing And Not row("Age") Is Convert.DBNull Then

            Dim ageEntered As Integer = CType(row("Age"), Int32)

            If ageEntered < 21 Or ageEntered > 65 Then
                System.Windows.Forms.MessageBox.Show _
                    ("Age must be between 21 and 65. The row cannot be added.")
                e.Cancel = True
                Return
            End If

            row("ID") = id
            id += 1

        Else
            System.Windows.Forms.MessageBox.Show("You must enter an age.")
            e.Cancel = True
        End If
    End Sub
    '</Snippet10>


    '--------------------------------------------------------------------------
    Sub Test2()


        '<Snippet6>
        Dim List1 As Microsoft.Office.Tools.Excel.ListObject = _
            Me.Controls.AddListObject(Me.Range("A1", "B3"), "List1")
        '</Snippet6>


        '<Snippet7>
        List1.Resize(Range.Item("A1", "C5"))
        '</Snippet7>


        '<Snippet4>
        Dim NamedRange1 As Microsoft.Office.Tools.Excel.NamedRange = _
            Me.Controls.AddNamedRange(Me.Range("A1"), "NamedRange1")
        '</Snippet4>


        '<Snippet5>
        NamedRange1.RefersTo = "=Sheet1!$A$1:$B$1"
        '</Snippet5>


        '<Snippet3>
        Dim textInCell As Microsoft.Office.Tools.Excel.NamedRange
        textInCell = Me.Controls.AddNamedRange(Me.Range("A1"), "cellText")

        textInCell.Value2 = "Hello world!"
        '</Snippet3>


        '<Snippet2>
        Dim employeeData As Microsoft.Office.Tools.Excel.ListObject
        employeeData = Me.Controls.AddListObject(Me.Range("$A$1:$D$4"), "employees")
        '</Snippet2>
    End Sub


    '--------------------------------------------------------------------------
    Sub Test1()

        '<Snippet28>
        Me.Range("A1").Value2 = "Monday"
        Me.Range("A2").Value2 = "Tuesday"

        Dim dayRange As Microsoft.Office.Tools.Excel.NamedRange = _
            Me.Controls.AddNamedRange(Me.Range("A1", "A7"), "dayRange")
        Me.Range("A1", "A2").AutoFill(dayRange.InnerObject, Excel.XlAutoFillType.xlFillDays)
        '</Snippet28>


        '<Snippet1>
        Dim employeeData As Microsoft.Office.Tools.Excel.Chart
        employeeData = Me.Controls.AddChart(25, 110, 200, 150, "employees")
        employeeData.ChartType = Excel.XlChartType.xl3DPie

        ' Gets the cells that define the data to be charted.
        Dim chartRange As Excel.Range = Me.Range("A5", "D8")
        employeeData.SetSourceData(chartRange)
        '</Snippet1>
    End Sub

End Class

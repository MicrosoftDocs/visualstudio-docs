Public Class ThisAddIn

    '<Snippet6>
    Sub Application_WorkbookBeforeSave _
        (ByVal workbook As Microsoft.Office.Interop.Excel.Workbook, _
         ByVal SaveAsUI As Boolean, ByRef Cancel As Boolean) _
         Handles Application.WorkbookBeforeSave

        Dim worksheet As Excel.Worksheet = workbook.Worksheets(1)

        If Globals.Factory.HasVstoObject(worksheet) And
            Globals.Factory.GetVstoObject(worksheet).Controls.Count > 0 Then
            Dim vstoWorksheet As Worksheet = Globals.Factory.GetVstoObject(worksheet)

            While vstoWorksheet.Controls.Count > 0
                Dim vstoControl As Object = vstoWorksheet.Controls(0)
                vstoWorksheet.Controls.Remove(vstoControl)
            End While
        End If
    End Sub
    '</Snippet6>

    '<Snippet7>
    Private Sub AddNamedRange()
        Dim textInCell As Microsoft.Office.Tools.Excel.NamedRange

        Dim NativeWorksheet As Microsoft.Office.Interop.Excel.Worksheet =
            Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets(1)

        Dim worksheet As Microsoft.Office.Tools.Excel.Worksheet =
            Globals.Factory.GetVstoObject(NativeWorksheet)

        Dim cell As Excel.Range = worksheet.Range("A1")
        textInCell = worksheet.Controls.AddNamedRange(cell, "MyNamedRange")
        textInCell.Value2 = "Hello World"
    End Sub
    '</Snippet7>

    '<Snippet8>
    Private Sub AddListObject()
        Dim NativeWorksheet As Microsoft.Office.Interop.Excel.Worksheet =
            Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets(1)

        Dim worksheet As Microsoft.Office.Tools.Excel.Worksheet =
            Globals.Factory.GetVstoObject(NativeWorksheet)

        Dim list1 As Microsoft.Office.Tools.Excel.ListObject
        Dim cell As Excel.Range = worksheet.Range("$A$1:$D$4")
        list1 = worksheet.Controls.AddListObject(cell, "MyListObject")
    End Sub
    '</Snippet8>

    '<Snippet9>
    Private Sub AddChart()
        Dim NativeWorksheet As Microsoft.Office.Interop.Excel.Worksheet =
            Globals.ThisAddIn.Application.ActiveWorkbook.ActiveSheet

        Dim worksheet As Microsoft.Office.Tools.Excel.Worksheet =
            Globals.Factory.GetVstoObject(NativeWorksheet)

        Dim cells As Excel.Range = worksheet.Range("A5", "D8")
        Dim chart As Chart = worksheet.Controls.AddChart(cells, "employees")
        chart.ChartType = Excel.XlChartType.xl3DPie
        chart.SetSourceData(cells, Type.Missing)

    End Sub
    '</Snippet9>
    Public Sub AddNamedRange2()
        '<Snippet10>
        Dim NativeWorksheet As Microsoft.Office.Interop.Excel.Worksheet = _
            Application.ActiveSheet

        Dim worksheet As Microsoft.Office.Tools.Excel.Worksheet = _
            Globals.Factory.GetVstoObject(NativeWorksheet)

        Dim namedRange1 As Microsoft.Office.Tools.Excel.NamedRange
        namedRange1 = worksheet.Controls.AddNamedRange(worksheet.Range("A1"), "MyNamedRange")
        '</Snippet10>
        '<Snippet11>
        namedRange1.RefersTo = "=Sheet1!$A$1:$B$1"
        '</Snippet11>
        
    End Sub

    Public Sub AddListObject2()
        '<Snippet12>
        Dim NativeWorksheet As Microsoft.Office.Interop.Excel.Worksheet = _
            Application.ActiveSheet

        Dim worksheet As Microsoft.Office.Tools.Excel.Worksheet = _
            Globals.Factory.GetVstoObject(NativeWorksheet)

        Dim list1 As Microsoft.Office.Tools.Excel.ListObject
        list1 = worksheet.Controls.AddListObject(worksheet.Range("$A$1:$B$3"), "MyListObject")
        '</Snippet12>
        '<Snippet13>
        list1.Resize(worksheet.Range("A1", "C5"))
        '</Snippet13>
        
    End Sub
    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
  
    End Sub

End Class

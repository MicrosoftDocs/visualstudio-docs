Public Class ThisAddIn

    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup

    End Sub

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

    '<Snippet1>
    Private Sub Application_WorkbookBeforeSave(ByVal Wb As Microsoft.Office.Interop.Excel.Workbook, ByVal SaveAsUI As Boolean, ByRef Cancel As Boolean) Handles Application.WorkbookBeforeSave
        Dim activeWorksheet As Excel.Worksheet = CType(Application.ActiveSheet, Excel.Worksheet)
        Dim firstRow As Excel.Range = activeWorksheet.Range("A1")
        firstRow.EntireRow.Insert(Excel.XlInsertShiftDirection.xlShiftDown)
        Dim newFirstRow As Excel.Range = activeWorksheet.Range("A1")
        newFirstRow.Value2 = "This text was added by using code"
    End Sub
    '</Snippet1>
End Class

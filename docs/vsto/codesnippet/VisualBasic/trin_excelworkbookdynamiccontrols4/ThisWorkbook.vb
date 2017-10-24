
Public Class ThisWorkbook

    Private Sub ThisWorkbook_Startup() Handles Me.Startup



    End Sub

    Private Sub ThisWorkbook_Shutdown() Handles Me.Shutdown

    End Sub


    '<snippet1>
    Private Sub ThisWorkbook_SheetActivate2(ByVal Sh As Object)
        Dim vstoWorksheet As Microsoft.Office.Tools.Excel.Worksheet = Nothing
        Dim interopWorksheet As Microsoft.Office.Interop.Excel.Worksheet =
            CType(Sh, Microsoft.Office.Interop.Excel.Worksheet)

        If interopWorksheet IsNot Nothing AndAlso
            Globals.Factory.HasVstoObject(interopWorksheet) Then
            vstoWorksheet = Globals.Factory.GetVstoObject(interopWorksheet)
        End If

        If vstoWorksheet IsNot Nothing Then
            ' Do something with the VSTO worksheet here. 
        End If

    End Sub
    '</snippet1> 
    Sub CreateVstoListObjectForNativeListObject()
        '<Snippet2>
        Dim vstoListObject As Microsoft.Office.Tools.Excel.ListObject = Nothing

        If Globals.Sheet1.ListObjects.Count > 0 Then
            Dim nativeListObject As Excel.ListObject = Globals.Sheet1.ListObjects(1)
            vstoListObject = Globals.Sheet1.Controls.AddListObject(nativeListObject)
        End If
        '</Snippet2>
    End Sub

    Sub CreateNamedRange()
        '<Snippet3>
        Dim range1 As Excel.Range = Globals.Sheet1.Range("A1", "D5")
        Dim namedRange1 As Microsoft.Office.Tools.Excel.NamedRange = _
            Globals.Sheet1.Controls.AddNamedRange(range1, "ChartSource")
        '</Snippet3>

        '<Snippet4>
        Globals.Sheet1.Controls.Remove("ChartSource")
        '</Snippet4>
    End Sub
    '<Snippet5>
    Sub ThisWorkbook_SheetActivate1(ByVal Sh As Object) Handles Me.SheetActivate
        Dim vstoWorksheet As Microsoft.Office.Tools.Excel.Worksheet = Nothing

        If Type.ReferenceEquals(Globals.Sheet1.InnerObject, Sh) Then
            vstoWorksheet = Globals.Sheet1.Base
        ElseIf Type.ReferenceEquals(Globals.Sheet2.InnerObject, Sh) Then
            vstoWorksheet = Globals.Sheet2.Base
        ElseIf Type.ReferenceEquals(Globals.Sheet3.InnerObject, Sh) Then
            vstoWorksheet = Globals.Sheet3.Base
        End If

        If vstoWorksheet IsNot Nothing Then
            ' Do something with the VSTO worksheet here.
        End If
    End Sub
    '</Snippet5>

End Class

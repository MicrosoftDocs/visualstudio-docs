Public Class ThisAddIn

    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup

    End Sub

    Private Sub CloseWorkbook()
        '<Snippet1>
        Me.Application.ActiveWorkbook.Close(SaveChanges:=False)
        '</Snippet1>
    End Sub

    Private Sub CloseWorkbookByName()
        '<Snippet2>
        Me.Application.Workbooks("NewWorkbook.xlsx").Close(SaveChanges:=False)
        '</Snippet2>
    End Sub

    Private Sub SaveWorkbook()
        '<Snippet3>
        Me.Application.ActiveWorkbook.Save()
        '</Snippet3>
    End Sub

    Private Sub SaveWorkbookAs()
        '<Snippet4>
        Me.Application.ActiveWorkbook.SaveAs("C:\Test\Book1.xml")
        '</Snippet4>
    End Sub

    Private Sub SaveWorkbookAsCopy()
        '<Snippet5>
        Me.Application.ActiveWorkbook.SaveCopyAs("C\Book1.xlsx")
        '</Snippet5>
    End Sub

    Private Sub ProtectWorkbook()
        Dim getPasswordFromUser As String
        getPasswordFromUser = "hello"
        '<Snippet6>
        Me.Application.ActiveWorkbook.Unprotect(getPasswordFromUser)
        '</Snippet6>
    End Sub
    
    Private Sub UnProtectWorkbook()
        Dim getPasswordFromUser As String
        getPasswordFromUser = "hello"
        '<Snippet7>
        Me.Application.ActiveWorkbook.Protect(getPasswordFromUser)
        '</Snippet7>
    End Sub
        '<Snippet8>
    Private Sub SetPassword()
        Dim password As String
        Dim confirmPassword As String

        password = Me.Application.InputBox("Enter the new password:").ToString()
        confirmPassword = Me.Application.InputBox("Confirm the password:").ToString()

        If password <> confirmPassword Then
            System.Windows.Forms.MessageBox.Show("The passwords you typed do not match.")
            Me.Application.ActiveWorkbook.Password = ""
        Else
            Me.Application.ActiveWorkbook.Password = password
        End If
    End Sub
    '</Snippet8>
    
    Private Sub ListRecentlyUsedWorkbooks()
        '<Snippet9>
        Dim rng As Excel.Range = Me.Application.Range("A1")

        Dim i As Integer
        For i = 1 To Me.Application.RecentFiles.Count
            rng.Offset(i - 1, 0).Value2 = Me.Application.RecentFiles(i).Name
        Next
        '</Snippet9>
    End Sub

    Private Sub SendMail()
        '<Snippet10>
        Me.Application.ActiveWorkbook.SendMail(Recipients:="someone@example.com", Subject:="July Sales Figures")
        '</Snippet10>
    End Sub
    Private Sub AddWorksheet()
    '<Snippet11>
    Dim newWorksheet As Excel.Worksheet
    newWorksheet = CType(Me.Application.Worksheets.Add(), Excel.Worksheet)
    '</Snippet11>
    End Sub
    Private Sub CopyWorksheet()
        '<Snippet12>
        Dim worksheet1 As Excel.Worksheet = CType(Application.ActiveWorkbook.Worksheets(1),  _
        Excel.Worksheet)
        Dim worksheet3 As Excel.Worksheet = CType(Application.ActiveWorkbook.Worksheets(3),  _
        Excel.Worksheet)
        worksheet1.Copy(After:=worksheet3)
        '</Snippet12>
    End Sub
   '<Snippet13>
    Private Sub ListSheets()
        Dim index As Integer = 0

        Dim rng As Excel.Range = Me.Application.Range("A1")

        For Each displayWorksheet As Excel.Worksheet In Me.Application.Worksheets
            rng.Offset(index, 0).Value2 = displayWorksheet.Name
            index += 1
        Next displayWorksheet
    End Sub
    '</Snippet13>
    Private Sub PrintMethods()
        '<Snippet14>
        CType(Application.ActiveSheet, Excel.Worksheet).PrintOut _
           (From:=1, To:=1, Copies:=2, Preview:=True)
        '</Snippet14>
        '<Snippet15>
        CType(Application.ActiveSheet, Excel.Worksheet).PrintPreview()
        '</Snippet15>
    End Sub
    Private Sub MoveWorksheets()
        '<Snippet16>
        Dim totalSheets As Integer = Application.ActiveWorkbook.Sheets.Count
        CType(Application.ActiveSheet, Excel.Worksheet).Move(After:=Application.Worksheets(totalSheets))
        '</Snippet16>
    End Sub
    Private Sub ProtectWorksheets()
        Dim getPasswordFromUser As String
        getPasswordFromUser = "hello"
        '<Snippet17>
        CType(Application.ActiveSheet, Excel.Worksheet).Protect(getPasswordFromUser, AllowSorting:=True)
        '</Snippet17>
    End Sub
    Private Sub UnProtectWorksheets()
        Dim getPasswordFromUser As String
        getPasswordFromUser = "hello"
        '<Snippet18>
        CType(Application.ActiveSheet, Excel.Worksheet).Unprotect(getPasswordFromUser)
        '</Snippet18>
    End Sub
    Private Sub DeleteComment()
        '<Snippet19>
        Dim dateComment As Excel.Range = Me.Application.Range("A1")
        If Not dateComment.Comment Is Nothing Then
            dateComment.Comment.Delete()
        End If
        '</Snippet19>
    End Sub
    Private Sub AddComment()
        '<Snippet20>
        Dim dateComment As Excel.Range = Me.Application.Range("A1")
        dateComment.AddComment("Comment added " & DateTime.Now)
        '</Snippet20>
    End Sub

        '<Snippet21>
    Private Sub ShowOrHideComments(ByVal show As Boolean)
        Dim worksheet As Excel.Worksheet = CType(Application.ActiveSheet, Excel.Worksheet)
        Dim i As Integer
        For i = 1 To worksheet.Comments.Count
            worksheet.Comments(i).Visible = show
        Next
    End Sub
    '</Snippet21>
    Private Sub CheckSpelling()
        '<Snippet22>
        CType(Application.ActiveSheet, Excel.Worksheet).CheckSpelling()
        '</Snippet22>
    End Sub
    Private Sub test()
        Me.Application.ActiveWorkbook.Sheets.FillAcrossSheets( _
    Me.Application.Range("rangeData"), Excel.XlFillWith.xlFillWithAll)
    End Sub
    Private Sub SortNamedRange()
        '<Snippet23>
        Dim Fruits As Excel.Range = Me.Application.Range("A1", "B2")
        Fruits.Sort( _
            Key1:=Fruits.Columns(1), Order1:=Excel.XlSortOrder.xlAscending, _
            Key2:=Fruits.Columns(2), Order2:=Excel.XlSortOrder.xlAscending, _
            Orientation:=Excel.XlSortOrientation.xlSortColumns, _
            Header:=Excel.XlYesNoGuess.xlNo, _
            SortMethod:=Excel.XlSortMethod.xlPinYin, _
            DataOption1:=Excel.XlSortDataOption.xlSortNormal, _
            DataOption2:=Excel.XlSortDataOption.xlSortNormal, _
            DataOption3:=Excel.XlSortDataOption.xlSortNormal)
        '</Snippet23>
    End Sub
    Private Sub SortListObject()
        '<Snippet24>
        Dim fruitList As Excel.ListObject = CType(Application.ActiveSheet,  _
            Excel.Worksheet).ListObjects.AddEx(Excel.XlListObjectSourceType.xlSrcRange, _
            Application.Range("A1", "B2"))
        fruitList.Range.Sort( _
        Key1:=fruitList.ListColumns(1).Range, Order1:=Excel.XlSortOrder.xlAscending, _
        Key2:=fruitList.ListColumns(2).Range, Order2:=Excel.XlSortOrder.xlAscending, _
        Orientation:=Excel.XlSortOrientation.xlSortColumns, _
        Header:=Excel.XlYesNoGuess.xlYes)
        '</Snippet24>
    End Sub    

    Private Sub StoreAndRetrieveDateInRange()
        '<Snippet25>
        Dim rng As Excel.Range = Me.Application.Range("A1")
        '</Snippet25>
        '<Snippet26>
        Dim dt As DateTime = DateTime.Now
        rng.Value2 = dt
        '</Snippet26>
        '<Snippet27>
        Dim value As Object = rng.Value2

        If Not value Is Nothing Then
            If TypeOf value Is Double Then
                dt = DateTime.FromOADate(CType(value, Double))
            Else
                DateTime.TryParse(CType(value, String), dt)
            End If
        End If
        System.Windows.Forms.MessageBox.Show(dt.ToString())
        '</Snippet27>
    End Sub
    Private Sub ApplyStylesToRanges()
        '<Snippet28>
        Dim style As Excel.Style = Me.Application.ActiveWorkbook.Styles.Add("NewStyle")

        style.Font.Name = "Verdana"
        style.Font.Size = 12
        style.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
        style.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray)
        style.Interior.Pattern = Excel.XlPattern.xlPatternSolid
        '</Snippet28>
        '<Snippet29>
        Dim rangeStyles As Excel.Range = Me.Application.Range("A1")

        rangeStyles.Value2 = "'Style Test"
        rangeStyles.Style = "NewStyle"
        rangeStyles.Columns.AutoFit()
        '</Snippet29>
    End Sub

    Private Sub RunExcelCalculations()
        '<Snippet30>
        Dim rng As Excel.Range = Me.Application.Range("A1")
        '</Snippet30>
        '<Snippet31>
        rng.Calculate()
        '</Snippet31>
    End Sub
    Private Sub SendValuesToWorksheetCells()
        '<Snippet32>
        Dim rng As Excel.Range = Me.Application.Range("A1")
        rng.Value2 = "Hello World"
        '</Snippet32>

    End Sub

    Private Sub DisplayCurrentUsersLogonIDInCell()
        '<Snippet33>
        Dim user As System.Security.Principal.WindowsIdentity
        user = System.Security.Principal.WindowsIdentity.GetCurrent()
        '</Snippet33>

        '<Snippet34>
        Dim userID As Excel.Range = Me.Application.Range("A1")

        userID.Value2 = user.Name
        '</Snippet34>
    End Sub

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

End Class

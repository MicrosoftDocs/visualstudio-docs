Public Class Sheet1

    '--------------------------------------------------------------------------
    '<Snippet83>
    Private Sub Sheet1_Startup(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Startup

    End Sub

    Private Sub Sheet1_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Shutdown

    End Sub
    '</Snippet83>


    '--------------------------------------------------------------------------
    '<Snippet21>
    Private Sub ListSheets()
        Dim index As Integer = 0

        Dim NamedRange1 As Microsoft.Office.Tools.Excel.NamedRange = _
            Globals.Sheet1.Controls.AddNamedRange( _
            Globals.Sheet1.Range("A1"), "NamedRange1")

        For Each displayWorksheet As Excel.Worksheet In Globals.ThisWorkbook.Worksheets
            NamedRange1.Offset(index, 0).Value2 = displayWorksheet.Name
            index += 1
        Next displayWorksheet
    End Sub
    '</Snippet21>


    '--------------------------------------------------------------------------
    '<Snippet31>
    Private Sub ShowOrHideComments(ByVal show As Boolean)
        Dim i As Integer
        For i = 1 To Me.Comments.Count
            Me.Comments(i).Visible = show
        Next
    End Sub
    '</Snippet31>


    '--------------------------------------------------------------------------
    '<Snippet36>
    Private Sub BoldCurrentRow(ByVal ws As Excel.Worksheet)

        ' Keep track of the previously bolded row.
        '<Snippet37>
        Static previousRow As Integer = 0
        '</Snippet37>

        ' Work with the current active cell.
        '<Snippet38>
        Dim currentCell As Excel.Range = Me.Application.ActiveCell
        '</Snippet38>

        ' Bold the current row.
        '<Snippet39>
        currentCell.EntireRow.Font.Bold = True
        '</Snippet39>

        ' If a pass has been done previously, make the old row not bold.
        ' Make sure previousRow is not 0 (otherwise this is your first pass through).
        '<Snippet40>
        If previousRow <> 0 Then
        '</Snippet40>

            ' Make sure the current row is not the same as the previous row.
            '<Snippet41>
            If currentCell.Row <> previousRow Then
            '</Snippet41>

                '<Snippet42>
                Dim rng As Excel.Range = DirectCast(ws.Rows(previousRow), Excel.Range)
                rng.EntireRow.Font.Bold = False
                '</Snippet42>
            End If
        End If

        ' Store the new row number for the next pass.
        '<Snippet43>
        previousRow = currentCell.Row
        '</Snippet43>
    End Sub
    '</Snippet36>


    '--------------------------------------------------------------------------
    '<Snippet49>
    Private Sub AutoFill()
        Dim rng As Excel.Range = Me.Application.Range("B1")
        rng.AutoFill(Me.Application.Range("B1:B5"), Excel.XlAutoFillType.xlFillWeekdays)

        rng = Me.Application.Range("C1")
        rng.AutoFill(Me.Application.Range("C1:C5"), Excel.XlAutoFillType.xlFillMonths)

        rng = Me.Application.Range("D1:D2")
        rng.AutoFill(Me.Application.Range("D1:D5"), Excel.XlAutoFillType.xlFillSeries)
    End Sub
    '</Snippet49>


    '--------------------------------------------------------------------------
    '<Snippet57>
    Private Sub DemoFind()
        '<Snippet58>
        Dim currentFind As Excel.Range = Nothing
        Dim firstFind As Excel.Range = Nothing
        '</Snippet58>

        Dim Fruits As Excel.Range = Me.Application.Range("A1", "B2")
        ' You should specify all these parameters every time you call this method, 
        ' since they can be overridden in the user interface.
        '<Snippet59>
        currentFind = Fruits.Find("apples", , _
            Excel.XlFindLookIn.xlValues, Excel.XlLookAt.xlPart, _
            Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlNext, False)
        '</Snippet59>

        '<Snippet60>
        While Not currentFind Is Nothing
        '</Snippet60>

            ' Keep track of the first range you find.
            '<Snippet61>
            If firstFind Is Nothing Then
                firstFind = currentFind
            '</Snippet61>

            ' If you didn't move to a new range, you are done.
            '<Snippet62>
            ElseIf currentFind.Address = firstFind.Address Then
                Exit While
            End If
            '</Snippet62>

            '<Snippet63>
            With currentFind.Font
                .Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
                .Bold = True
            End With
            '</Snippet63>

            '<Snippet64>
            currentFind = Fruits.FindNext(currentFind)
            '</Snippet64>
        End While
    End Sub
    '</Snippet57>


    '--------------------------------------------------------------------------
    Sub Test5()
        '<Snippet72>
        Dim nr As Microsoft.Office.Tools.Excel.NamedRange
        nr = Me.Controls.AddNamedRange(Me.Range("A1"), "Files")

        Dim i As Integer
        For i = 1 To Me.Application.RecentFiles.Count
            nr.Offset(i - 1, 0).Value2 = Me.Application.RecentFiles(i).Name
        Next
        '</Snippet72>


        '<Snippet68>
        Me.message.Value2 = "Hello world"
        '</Snippet68>

        '<Snippet69>
        Dim rng As Excel.Range = Globals.Sheet1.Range("A1")
        rng.Value2 = "Hello world"
        '</Snippet69>
    End Sub


    '--------------------------------------------------------------------------
    Sub Test4()
        '<Snippet55>
        Me.rangeStyles.Style = "Normal"
        '</Snippet55>

        '<Snippet56>
        Dim rng As Excel.Range = Me.Application.Range("A1")
        rng.Style = "Normal"
        '</Snippet56>
    End Sub


    '--------------------------------------------------------------------------
    Sub Test3()
        '<Snippet45>
        Globals.Sheet1.CheckSpelling()
        '</Snippet45>


        '<Snippet32>
        With Me
            .data2001.Group()
            .data2002.Group()
            .dataAll.Group()
        End With
        '</Snippet32>

        '<Snippet33>
        With Me.Application
            .Range("data2001").Group()
            .Range("data2002").Group()
            .Range("dataAll").Group()
        End With
        '</Snippet33>

        '<Snippet34>
        With Me
            .data2001.Ungroup()
            .data2002.Ungroup()
            .dataAll.Ungroup()
        End With
        '</Snippet34>

        '<Snippet35>
        With Me.Application
            .Range("data2001").Ungroup()
            .Range("data2002").Ungroup()
            .Range("dataAll").Ungroup()
        End With
        '</Snippet35>


        '<Snippet48>
        Dim nr As Microsoft.Office.Tools.Excel.NamedRange = _
            Me.Controls.AddNamedRange(Me.Range("A1"), "NamedRange1")

        nr.Value2 = "Hello World"
        '</Snippet48>


        '<Snippet82>
        Globals.Sheet1.PrintPreview()
        '</Snippet82>


        '<Snippet81>
        Me.Application.Workbooks.OpenXML("C:\Test.xml")
        '</Snippet81>


        '<Snippet80>
        Me.Application.Workbooks.OpenText("C:\Test.txt", _
            StartRow:=3, _
            DataType:=Excel.XlTextParsingType.xlDelimited, _
            TextQualifier:=Excel.XlTextQualifier.xlTextQualifierNone, _
            Comma:=True)
        '</Snippet80>


        '<Snippet79>
        Me.fruitList.Range.Sort( _
            Key1:=Me.fruitList.ListColumns(1).Range, Order1:=Excel.XlSortOrder.xlAscending, _
            Key2:=Me.fruitList.ListColumns(2).Range, Order2:=Excel.XlSortOrder.xlAscending, _
            Orientation:=Excel.XlSortOrientation.xlSortColumns, _
            Header:=Excel.XlYesNoGuess.xlYes)
        '</Snippet79>


        '<Snippet78>
        Me.Fruits.Sort( _
            Key1:=Me.Fruits.Columns(1), Order1:=Excel.XlSortOrder.xlAscending, _
            Key2:=Me.Fruits.Columns(2), Order2:=Excel.XlSortOrder.xlAscending, _
            Orientation:=Excel.XlSortOrientation.xlSortColumns, _
            Header:=Excel.XlYesNoGuess.xlNo, _
            SortMethod:=Excel.XlSortMethod.xlPinYin, _
            DataOption1:=Excel.XlSortDataOption.xlSortNormal, _
            DataOption2:=Excel.XlSortDataOption.xlSortNormal, _
            DataOption3:=Excel.XlSortDataOption.xlSortNormal)
        '</Snippet78>


        '<Snippet77>
        Me.Application.Calculate()
        '</Snippet77>


        '<Snippet75>
        Dim NamedRange1 As Microsoft.Office.Tools.Excel.NamedRange = _
            Me.Controls.AddNamedRange(Me.Range("A1"), "NamedRange1")
        '</Snippet75>


        '<Snippet76>
        NamedRange1.Calculate()
        '</Snippet76>


        '<Snippet74>
        Globals.ThisWorkbook.SendMail(Recipients:="someone@example.com", Subject:="July Sales Figures")
        '</Snippet74>


        '<Snippet73>
        With Me.Application.FileDialog(Microsoft.Office.Core.MsoFileDialogType.msoFileDialogOpen)

            .AllowMultiSelect = True
            .Filters.Clear()
            .Filters.Add("Excel Files", "*.xlsx;*.xlw")
            .Filters.Add("All Files", "*.*")

            If .Show = True Then
                .Execute()
            End If
        End With
        '</Snippet73>


        '<Snippet70>
        Dim user As System.Security.Principal.WindowsIdentity
        user = System.Security.Principal.WindowsIdentity.GetCurrent()
        '</Snippet70>


        '<Snippet71>
        Dim userID As Microsoft.Office.Tools.Excel.NamedRange
        userID = Me.Controls.AddNamedRange(Me.Range("A1"), "userID")

        userID.Value2 = user.Name
        '</Snippet71>


        '<Snippet67>
        Dim rng2 As Excel.Range = Me.Application.Range("A1")
        rng2.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
        '</Snippet67>


        '<Snippet65>
        Dim rng As Microsoft.Office.Tools.Excel.NamedRange = _
            Me.Controls.AddNamedRange(Me.Range("A1"), "NamedRange1")
        '</Snippet65>


        '<Snippet66>
        rng.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
        '</Snippet66>


        '<Snippet54>
        Dim rangeStyles As Microsoft.Office.Tools.Excel.NamedRange = _
            Me.Controls.AddNamedRange(Me.Range("A1"), "rangeStyles")

        rangeStyles.Value2 = "'Style Test"
        rangeStyles.Style = "NewStyle"
        rangeStyles.Columns.AutoFit()
        '</Snippet54>


        '<Snippet53>
        Dim style As Excel.Style = Globals.ThisWorkbook.Styles.Add("NewStyle")

        style.Font.Name = "Verdana"
        style.Font.Size = 12
        style.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
        style.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray)
        style.Interior.Pattern = Excel.XlPattern.xlPatternSolid
        '</Snippet53>
    End Sub


    '--------------------------------------------------------------------------
    Sub Test2()


        '<Snippet50>
        Dim NamedRange1 As Microsoft.Office.Tools.Excel.NamedRange = _
            Me.Controls.AddNamedRange(Me.Range("A1"), "NamedRange1")
        '</Snippet50>


        '<Snippet51>
        Dim dt As DateTime = DateTime.Now
        NamedRange1.Value2 = dt
        '</Snippet51>


        '<Snippet52>
        Dim value As Object = NamedRange1.Value2

        If Not value Is Nothing Then
            If TypeOf value Is Double Then
                dt = DateTime.FromOADate(CType(value, Double))
            Else
                DateTime.TryParse(CType(value, String), dt)
            End If
        End If

        MessageBox.Show(dt.ToString())
        '</Snippet52>
    End Sub


    '--------------------------------------------------------------------------
    Sub Test()
        Dim getPasswordFromUser As String = "password"


        '<Snippet47>
        Dim rng As Excel.Range = Me.Application.Range("A1")

        rng.Value2 = "Range value"
        '</Snippet47>


        '<Snippet46>
        Dim NamedRange1 As Microsoft.Office.Tools.Excel.NamedRange = _
            Me.Controls.AddNamedRange(Me.Range("A1"), "NamedRange1")

        NamedRange1.Value2 = "Range value"
        '</Snippet46>


        '<Snippet44>
        Me.Application.ActiveWorkbook.Sheets.FillAcrossSheets( _
            Me.Application.Range("rangeData"), Excel.XlFillWith.xlFillWithAll)
        '</Snippet44>


        '<Snippet30>
        Me.dateComment.AddComment("Comment added " & DateTime.Now)
        '</Snippet30>


        '<Snippet29>
        If Not Me.dateComment.Comment Is Nothing Then
            Me.dateComment.Comment.Delete()
        End If
        '</Snippet29>


        '<Snippet28>
        Globals.Sheet1.Unprotect(getPasswordFromUser)
        '</Snippet28>


        '<Snippet27>
        Globals.Sheet1.Protect(getPasswordFromUser, AllowSorting:=True)
        '</Snippet27>


        '<Snippet26>
        CType(Globals.ThisWorkbook.Sheets(1), Excel.Worksheet) _
            .Visible = Excel.XlSheetVisibility.xlSheetHidden
        '</Snippet26>


        '<Snippet25>
        Globals.Sheet1.Visible = Excel.XlSheetVisibility.xlSheetHidden
        '</Snippet25>


        '<Snippet24>
        Dim totalSheets As Integer = Application.ActiveWorkbook.Sheets.Count
        Globals.Sheet1.Move(After:=Globals.ThisWorkbook.Sheets(totalSheets))
        '</Snippet24>


        '<Snippet23>
        Globals.Sheet1.PrintPreview()
        '</Snippet23>


        '<Snippet22>
        Globals.Sheet1.PrintOut(From:=1, To:=1, Copies:=2, Preview:=True)
        '</Snippet22>


        '<Snippet20>
        CType(Me.Application.ActiveWorkbook.Sheets(1), Excel.Worksheet).Select()
        '</Snippet20>


        '<Snippet19>
        Globals.Sheet1.Select()
        '</Snippet19>


        '<Snippet18>
        CType(Me.Application.ActiveWorkbook.Sheets(4), Excel.Worksheet).Delete()
        '</Snippet18>


        '<Snippet17>
        Globals.Sheet1.Delete()
        '</Snippet17>


        '<Snippet16>
        Globals.Sheet1.Copy(After:=Globals.ThisWorkbook.Sheets(3))
        '</Snippet16>


        '<Snippet15>
        Dim newWorksheet As Excel.Worksheet
        newWorksheet = CType(Globals.ThisWorkbook.Worksheets.Add(), Excel.Worksheet)
        '</Snippet15>


        '<Snippet14>
        Me.Application.DefaultFilePath = "C:\temp"
        '</Snippet14>
        Me.Application.DefaultFilePath = Me.defaultSavePath.Value2.ToString()

        '<Snippet13>
        System.Windows.Forms.MessageBox.Show(Me.Application.DefaultFilePath)
        '</Snippet13>
        Me.defaultSavePath.Value2 = Me.Application.DefaultFilePath

        '<Snippet9>
        Dim wb As Excel.Workbook = Me.Application.Workbooks(1)

        ' Before Book1 is saved:
        wb = Me.Application.Workbooks("Book1")

        ' After Book1 is saved:
        wb = Me.Application.Workbooks("Book1.xlsx")
        '</Snippet9>


        '<Snippet8>
        Globals.ThisWorkbook.Activate()
        '</Snippet8>

        '<Snippet7>
        Me.Application.Workbooks(1).Activate()
        '</Snippet7>

        '<Snippet3>
        Globals.ThisWorkbook.Close(SaveChanges:=False)
        '</Snippet3>


        '<Snippet2>
        Me.Application.Workbooks.Open("C:\Test\YourWorkbook.xlsx")
        '</Snippet2>


        '<Snippet1>
        Dim newWorkbook As Excel.Workbook = Me.Application.Workbooks.Add()
        '</Snippet1>
    End Sub

End Class

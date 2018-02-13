Imports System.Windows.Forms

Public Class ThisAddIn

    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup

    End Sub

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

    '--------------------------------------------------------------------------
    '<Snippet22>
    Private Sub RangeSelect()
        '<Snippet23>
        Dim rng As Word.Range
        '</Snippet23>

        '<Snippet24>
        Dim document As Word.Document = Me.Application.ActiveDocument
        If document.Sentences.Count >= 2 Then

            Dim startLocation As Object = document.Sentences(2).Start
            Dim endLocation As Object = document.Sentences(2).End

            ' Supply a Start and End value for the Range.
            rng = document.Range(Start:=startLocation, End:=endLocation)

            ' Select the Range
            rng.Select()
        End If
        '</Snippet24>
    End Sub
    '</Snippet22>


    '--------------------------------------------------------------------------
    '<Snippet26>
    Private Sub ReplaceParagraphText()

        '<Snippet27>
        Dim document As Word.Document = Me.Application.ActiveDocument
        Dim firstRange As Word.Range = document.Paragraphs(1).Range
        Dim secondRange As Word.Range = document.Paragraphs(2).Range

        Dim firstString As String = firstRange.Text
        Dim secondString As String = secondRange.Text
        '</Snippet27>

        '<Snippet28>
        firstRange.Text = secondString
        secondRange.Text = firstString
        '</Snippet28>

        '<Snippet29>
        firstRange.Select()
        MessageBox.Show(firstRange.Text)
        secondRange.Select()
        MessageBox.Show(secondRange.Text)
        '</Snippet29>

        '<Snippet30>
        firstRange.MoveEnd(Unit:=Word.WdUnits.wdCharacter, Count:=-1)
        '</Snippet30>

        '<Snippet31>
        firstRange.Text = "New content for paragraph 1."
        '</Snippet31>
        '<Snippet32>
        secondRange.Text = "New content for paragraph 2."
        '</Snippet32>

        '<Snippet33>
        firstRange.Select()
        MessageBox.Show(firstRange.Text)
        secondRange.Select()
        MessageBox.Show(secondRange.Text)
        '</Snippet33>

        '<Snippet34>
        firstRange.MoveEnd(Unit:=Word.WdUnits.wdCharacter, Count:=1)
        '</Snippet34>

        '<Snippet35>
        secondRange.Delete()
        '</Snippet35>

        '<Snippet36>
        firstRange.Text = firstString
        '</Snippet36>

        '<Snippet37>
        firstRange.InsertAfter(secondString)
        firstRange.Select()
        '</Snippet37>
    End Sub
    '</Snippet26>


    '--------------------------------------------------------------------------
    '<Snippet56>
    Friend Sub SelectionInsertText()
        '<Snippet57>
        Dim currentSelection As Word.Selection = Application.Selection
        '</Snippet57>

        ' Store the user's current Overtype selection
        Dim userOvertype As Boolean = Application.Options.Overtype

        ' Make sure Overtype is turned off.
        '<Snippet58>
        If Application.Options.Overtype Then
            Application.Options.Overtype = False
        End If
        '</Snippet58>

        '<Snippet59>
        With currentSelection

            ' Test to see if selection is an insertion point.
            If .Type = Word.WdSelectionType.wdSelectionIP Then
                .TypeText("Inserting at insertion point. ")
                .TypeParagraph()
                '</Snippet59>

                '<Snippet60>
            ElseIf .Type = Word.WdSelectionType.wdSelectionNormal Then
                ' Move to start of selection.
                If Application.Options.ReplaceSelection Then
                    .Collapse(Direction:=Word.WdCollapseDirection.wdCollapseStart)
                End If
                .TypeText("Inserting before a text block. ")
                .TypeParagraph()
                '</Snippet60>

                '<Snippet61>
            Else
                ' Do nothing.
            End If
            '</Snippet61>
        End With

        ' Restore the user's Overtype selection
        Application.Options.Overtype = userOvertype
    End Sub
    '</Snippet56>


    '--------------------------------------------------------------------------
    '<Snippet62>
    Private Sub RangeFormat()

        ' Set the Range to the first paragraph.
        Dim document As Word.Document = Me.Application.ActiveDocument
        Dim rng As Word.Range = document.Paragraphs(1).Range

        ' Change the formatting. To change the font size for a right-to-left language, 
        ' such as Arabic or Hebrew, use the Font.SizeBi property instead of Font.Size.
        rng.Font.Size = 14
        rng.Font.Name = "Arial"
        rng.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter

        rng.Select()
        MessageBox.Show("Formatted Range")

        ' Undo the three previous actions.
        document.Undo(Times:=3)

        rng.Select()
        MessageBox.Show("Undo 3 actions")

        ' Apply the Normal Indent style.
        rng.Style = "Normal Indent"

        rng.Select()
        MessageBox.Show("Normal Indent style applied")

        ' Undo a single action.
        document.Undo()

        rng.Select()
        MessageBox.Show("Undo 1 action")
    End Sub
    '</Snippet62>


    '--------------------------------------------------------------------------
    '<Snippet65>
    Friend Sub BookMarkReplaceNative( _
        ByVal bookmark As Word.Bookmark, _
        ByVal newText As String)
        '</Snippet65>

        '<Snippet66>
        Dim rng As Object = bookmark.Range
        Dim bookmarkName As String = bookmark.Name

        bookmark.Range.Text = newText
        Me.Application.ActiveDocument.Bookmarks.Add(Name:=bookmarkName, Range:=rng)
    End Sub
    '</Snippet66>


    '--------------------------------------------------------------------------
    '<Snippet67>
    Private Sub SelectionFind()
        '<Snippet68>
        Dim findText As Object = "find me"
        '</Snippet68>

        '<Snippet69>
        Application.Selection.Find.ClearFormatting()
        '</Snippet69>

        '<Snippet70>
        If Application.Selection.Find.Execute(findText) = True Then
            MessageBox.Show("Text found.")
        Else
            MessageBox.Show("The text could not be located.")
        End If
        '</Snippet70>
    End Sub
    '</Snippet67>


    '--------------------------------------------------------------------------
    '<Snippet71>
    Private Sub RangeFind()
        Dim findText As Object = "find me"

        '<Snippet72>
        Dim rng As Word.Range = Me.Application.ActiveDocument.Paragraphs(2).Range
        '</Snippet72>

        '<Snippet73>
        rng.Find.ClearFormatting()

        If rng.Find.Execute(findText) Then
            '</Snippet73>
            '<Snippet74>
            MessageBox.Show("Text found.")
        Else
            MessageBox.Show("Text not found.")
        End If

        rng.Select()
        '</Snippet74>
    End Sub
    '</Snippet71>


    '--------------------------------------------------------------------------
    '<Snippet75>
    Private Sub SearchReplace()
        Application.Selection.Find.ClearFormatting()
        Application.Selection.Find.Text = "find me"

        Application.Selection.Find.Replacement.ClearFormatting()
        Application.Selection.Find.Replacement.Text = "Found"

        Application.Selection.Find.Execute(Replace:=Word.WdReplace.wdReplaceAll)
    End Sub
    '</Snippet75>


    '--------------------------------------------------------------------------
    '<Snippet78>
    Private Sub FindLoop()
        Dim intFound As Integer = 0
        '<Snippet79>
        Dim rng As Word.Range = Me.Application.ActiveDocument.Content
        '</Snippet79>

        '<Snippet80>
        rng.Find.ClearFormatting()
        rng.Find.Forward = True
        rng.Find.Text = "find me"

        rng.Find.Execute()

        Do While rng.Find.Found = True
            intFound += 1
            rng.Find.Execute()
        Loop
        '</Snippet80>

        '<Snippet81>
        MessageBox.Show("Strings found: " & intFound.ToString())
        '</Snippet81>
    End Sub
    '</Snippet78>


    '--------------------------------------------------------------------------
    '<Snippet82>
    Friend Sub ReplaceRestoreSelection()
        '<Snippet83>
        Dim start As Word.Range = Application.Selection.Range
        Dim searchArea As Word.Range = Application.ActiveDocument.Range
        '</Snippet83>

        '<Snippet84>
        searchArea.Find.ClearFormatting()
        searchArea.Find.Text = "find me"

        searchArea.Find.Replacement.ClearFormatting()
        searchArea.Find.Replacement.Text = "Found"

        searchArea.Find.Execute(Replace:=Word.WdReplace.wdReplaceAll)
        '</Snippet84>

        '<Snippet85>
        start.Select()
        '</Snippet85>
    End Sub
    '</Snippet82>


    '--------------------------------------------------------------------------
    '<Snippet89>
    Private Sub CreateDocumentPropertyTable()
        '<Snippet90>
        Dim rng As Word.Range = Me.Application.ActiveDocument.Range( _
            Start:=0, End:=0)
        '</Snippet90>

        ' Insert a title for the table and paragraph marks.
        '<Snippet91>
        With rng
            .InsertBefore("Document Statistics")
            .Font.Name = "Verdana"
            .Font.Size = 16
            .InsertParagraphAfter()
            .InsertParagraphAfter()
            .SetRange(rng.End, rng.End)
        End With
        '</Snippet91>

        ' Add the table.
        '<Snippet92>
        rng.Tables.Add(Range:=Me.Application.ActiveDocument.Paragraphs.Item(2).Range, _
            NumRows:=3, NumColumns:=2)
        '</Snippet92>

        ' Format the table and apply a style.
        '<Snippet93>
        With Me.Application.ActiveDocument.Tables.Item(1)
            .Range.Font.Size = 12
            .Columns.DistributeWidth()
            .Style = "Table Professional"
        End With
        '</Snippet93>

        ' Insert document properties into cells.
        '<Snippet94>
        With Me.Application.ActiveDocument.Tables.Item(1)
            .Cell(1, 1).Range.Text = "Document Property"
            .Cell(1, 2).Range.Text = "Value"

            .Cell(2, 1).Range.Text = "Subject"
            .Cell(2, 2).Range.Text = CType( _
                Me.Application.ActiveDocument.BuiltInDocumentProperties,  _
                Office.DocumentProperties) _
                (Word.WdBuiltInProperty.wdPropertySubject).Value.ToString()

            .Cell(3, 1).Range.Text = "Author"
            .Cell(3, 2).Range.Text = CType( _
                Me.Application.ActiveDocument.BuiltInDocumentProperties,  _
                Office.DocumentProperties) _
                (Word.WdBuiltInProperty.wdPropertyAuthor).Value.ToString()
        End With
        '</Snippet94>
    End Sub
    '</Snippet89>


    '--------------------------------------------------------------------------
    '<Snippet104>
    Friend Sub PageSetupDialogHidden()
        Dim dlg As Word.Dialog = Application.Dialogs.Item(Word.WdWordDialog.wdDialogFilePageSetup)

        ' Set the properties of the dialog box.
        ' ControlChars.Quote() is used to represent the symbol for inches.
        With dlg
            .PageWidth = 3.3 & ControlChars.Quote
            .PageHeight = 6 & ControlChars.Quote
            .TopMargin = 0.71 & ControlChars.Quote
            .BottomMargin = 0.81 & ControlChars.Quote
            .LeftMargin = 0.66 & ControlChars.Quote
            .RightMargin = 0.66 & ControlChars.Quote
            .HeaderDistance = 0.28 & ControlChars.Quote
            .Orientation = Word.WdOrientation.wdOrientPortrait
            .DifferentFirstPage = False
            .FirstPage = 0
            .OtherPages = 0

            ' Apply these settings only to the current selection with this line of code:
            .ApplyPropsTo = 3

            ' Apply the settings.
            .Execute()
        End With
    End Sub
    '</Snippet104>


    '--------------------------------------------------------------------------
    '<Snippet105>
    Shared Sub HideText(ByVal rng As Word.Range)
        rng.Font.Hidden = True
    End Sub
    '</Snippet105>

    '<Snippet106>
    Shared Sub UnhideText(ByVal rng As Word.Range)
        rng.Font.Hidden = False
    End Sub
    '</Snippet106>


    '--------------------------------------------------------------------------
    Private Sub Test10()

        '<Snippet14>
        Application.PrintPreview = True
        '</Snippet14>


        '<Snippet12>
        Me.Application.ActiveDocument.PrintOut( _
            Background:=True, _
            Append:=False, _
            Range:=Word.WdPrintOutRange.wdPrintCurrentPage, _
            Item:=Word.WdPrintOutItem.wdPrintDocumentContent, _
            Copies:="1", _
            Pages:="1", _
            PageType:=Word.WdPrintOutPages.wdPrintAllPages, _
            PrintToFile:=False, _
            Collate:=True, _
            ManualDuplexPrint:=False)
        '</Snippet12>


        '<Snippet10>
        Me.Application.ActiveDocument.SaveAs("C:\Test\NewDocument.docx")
        '</Snippet10>


        '<Snippet120>
        Me.Application.ActiveDocument.Paragraphs(1).Range.Select()
        '</Snippet120>


        '<Snippet119>
        Me.Application.ActiveDocument.DeleteAllComments()
        '</Snippet119>


        '<Snippet118>
        Me.Application.ActiveDocument.Comments.Add( _
            Me.Application.ActiveDocument.Paragraphs(1).Range, _
            "Add a comment to the first paragraph.")
        '</Snippet118>


        '<Snippet116>
        For Each section As Word.Section In Me.Application.ActiveDocument.Sections
            Dim headerRange As Word.Range = section.Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range
            headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage)
            headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
        Next
        '</Snippet116>
    End Sub


    '--------------------------------------------------------------------------
    Private Sub Test9()
        '<Snippet114>
        For Each section As Word.Section In Me.Application.ActiveDocument.Sections
            Dim footerRange As Word.Range = section.Footers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range
            footerRange.Font.ColorIndex = Word.WdColorIndex.wdDarkRed
            footerRange.Font.Size = 20
            footerRange.Text = "Confidential"
        Next
        '</Snippet114>


        '<Snippet113>
        Dim result As String = "Spelled incorrectly."
        If Me.Application.CheckSpelling(Me.Application.ActiveDocument.Range.Text) = True Then
            result = "Spelled correctly."
        End If
        MessageBox.Show(result)
        '</Snippet113>

        '<Snippet111>
        Me.Application.ActiveDocument.Protect(Word.WdProtectionType.wdAllowOnlyReading, _
            False, String.Empty, False, False)
        '</Snippet111>

        ' The following lines are left out of the snippet on purpose.
        Dim bookmarkRange As Object = Me.Application.ActiveDocument.Paragraphs(1).Range
        Dim Bookmark1 As Word.Bookmark = Me.Application.ActiveDocument.Bookmarks.Add( _
                "bookmark1", bookmarkRange)
        '<Snippet112>
        bookmark1.Range.Editors.Add(Word.WdEditorType.wdEditorEveryone)
        '</Snippet112>


        '<Snippet109>
        Dim leftPosition As Double = Me.Application.Selection.Information( _
            Word.WdInformation.wdHorizontalPositionRelativeToPage)

        Dim topPosition As Double = Me.Application.Selection.Information( _
            Word.WdInformation.wdVerticalPositionRelativeToPage)
        '</Snippet109>


        '<Snippet110>
        Me.Application.ActiveDocument.Shapes.AddTextEffect( _
            Office.MsoPresetTextEffect.msoTextEffect29, "SampleText", _
            "Arial Black", 24, Office.MsoTriState.msoFalse, _
            Office.MsoTriState.msoFalse, leftPosition, topPosition)
        '</Snippet110>


        '<Snippet108>
        Me.Application.Selection.InlineShapes.AddPicture("C:\SamplePicture.jpg")
        '</Snippet108>


        '<Snippet107>
        HideText(Bookmark1.Range)
        Me.Application.ActiveDocument.PrintOut()
        UnhideText(Bookmark1.Range)
        '</Snippet107>


        '<Snippet102>
        Dim dlg As Word.Dialog = Application.Dialogs(Word.WdWordDialog.wdDialogFileOpen)
        Dim dlgType As Type = GetType(Word.Dialog)

        ' Set the Name property of the dialog box.
        dlgType.InvokeMember("Name", _
            Reflection.BindingFlags.SetProperty Or _
                Reflection.BindingFlags.Public Or _
                Reflection.BindingFlags.Instance, _
            Nothing, dlg, New Object() {"Testing"}, _
            System.Globalization.CultureInfo.InvariantCulture)
        '</Snippet102>


        '<Snippet103>
        ' Display the dialog box.
        dlg.Show()

        ' Show the Name property.
        MessageBox.Show(dlgType.InvokeMember("Name", _
            Reflection.BindingFlags.GetProperty Or _
                Reflection.BindingFlags.Public Or _
                Reflection.BindingFlags.Instance, _
            Nothing, dlg, Nothing, _
            System.Globalization.CultureInfo.InvariantCulture))
        '</Snippet103>
    End Sub


    '--------------------------------------------------------------------------
    Private Sub Test8()
        '<Snippet100>
        Dim dlg As Word.Dialog = Application.Dialogs.Item(Word.WdWordDialog.wdDialogFileNew)
        '</Snippet100>

        '<Snippet101>
        dlg.Show()
        '</Snippet101>


        '<Snippet99>
        MessageBox.Show("Characters: " & Me.Application.ActiveDocument.Characters.Count.ToString())
        '</Snippet99>


        '<Snippet98>
        Dim rng As Word.Range = Me.Application.ActiveDocument.Range( _
            0, Me.Application.ActiveDocument.Characters.Count)
        rng.Select()
        '</Snippet98>


        '<Snippet97>
        With Me.Application.ActiveDocument.Tables.Item(1).Cell(1, 1).Range
            .Text = "Name"
            .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
        End With
        '</Snippet97>


        '<Snippet96>
        Me.Application.ActiveDocument.Tables.Item(1).Columns.Add( _
            BeforeColumn:=Me.Application.ActiveDocument.Tables.Item(1).Columns(1))
        Me.Application.ActiveDocument.Tables.Item(1).Columns.DistributeWidth()
        '</Snippet96>


        '<Snippet95>
        Me.Application.ActiveDocument.Tables.Item(1).Rows.Add()
        '</Snippet95>


        '<Snippet88>
        Me.Application.ActiveDocument.Tables.Item(1).Range.Font.Size = 8
        Me.Application.ActiveDocument.Tables.Item(1).Style = "Table Grid 8"
        '</Snippet88>


        '<Snippet87>
        Dim newTable As Word.Table = Me.Application.ActiveDocument.Tables.Item(1)
        '</Snippet87>


        '<Snippet86>
        Dim tableLocation As Word.Range = Me.Application.ActiveDocument.Range(Start:=0, End:=0)
        Me.Application.ActiveDocument.Tables.Add(Range:=tableLocation, NumRows:=3, NumColumns:=4)
        '</Snippet86>


        '<Snippet77>
        With Application.Selection.Find
            .ClearFormatting()
            .Execute(FindText:="find me", Forward:=True, Wrap:=Word.WdFindWrap.wdFindContinue)
        End With
        '</Snippet77>


        '<Snippet76>
        With Application.Selection.Find
            .ClearFormatting()
            .Forward = True
            .Wrap = Word.WdFindWrap.wdFindContinue
            .Text = "find me"
            .Execute()
        End With
        '</Snippet76>
    End Sub


    '--------------------------------------------------------------------------
    Private Sub Test7()
        '<Snippet53>
        Dim rng As Word.Range = Me.Application.ActiveDocument.Range(Start:=0, End:=12)
        '</Snippet53>

        '<Snippet54>
        rng.Text = " New Text "
        '</Snippet54>

        '<Snippet55>
        rng.Select()
        '</Snippet55>
    End Sub


    '--------------------------------------------------------------------------
    Private Sub Test6()
        '<Snippet51>
        Dim rng As Word.Range = Me.Application.ActiveDocument.Range(Start:=0, End:=0)
        rng.Text = " New Text "
        '</Snippet51>

        '<Snippet52>
        rng.Select()
        '</Snippet52>
    End Sub


    '--------------------------------------------------------------------------
    Private Sub Test5()
        '<Snippet45>
        '<Snippet46>
        Dim rng As Word.Range = Me.Application.ActiveDocument.Paragraphs(1).Range
        '</Snippet46>

        '<Snippet47>
        rng.Collapse(Word.WdCollapseDirection.wdCollapseStart)
        '</Snippet47>

        '<Snippet48>
        rng.Text = " New Text "
        '</Snippet48>
        '<Snippet49>
        rng.Select()
        '</Snippet49>
        '</Snippet45>


        '<Snippet50>
        rng.Collapse(Word.WdCollapseDirection.wdCollapseEnd)
        '</Snippet50>
    End Sub


    '--------------------------------------------------------------------------
    Private Sub Test4()
        '<Snippet42>
        '<Snippet43>
        Dim rng As Word.Range = Me.Application.ActiveDocument.Range(Start:=0, End:=7)
        '</Snippet43>

        ' Reset the existing Range.
        '<Snippet44>
        rng.SetRange(Start:=Me.Application.ActiveDocument.Sentences(2).Start, _
            End:=Me.Application.ActiveDocument.Sentences(5).End)
        '</Snippet44>
        rng.Select()
        '</Snippet42>
    End Sub


    '--------------------------------------------------------------------------
    Private Sub Test3()
        '<Snippet38>
        ' Define a range of 7 characters.
        '<Snippet39>
        Dim rng As Word.Range = Me.Application.ActiveDocument.Range(Start:=0, End:=7)
        '</Snippet39>

        ' Move the start position 7 characters.
        '<Snippet40>
        rng.MoveStart(Unit:=Word.WdUnits.wdCharacter, Count:=7)
        '</Snippet40>

        ' Move the end position 7 characters.
        '<Snippet41>
        rng.MoveEnd(Unit:=Word.WdUnits.wdCharacter, Count:=7)
        '</Snippet41>
        '</Snippet38>
    End Sub


    '--------------------------------------------------------------------------
    Private Sub Test2()
        '<Snippet25>
        Dim rng As Word.Range = Me.Application.ActiveDocument.Sentences(2)

        Dim startPosition As String = rng.Start.ToString()
        Dim endPosition As String = rng.End.ToString()

        MessageBox.Show("Start: " & startPosition & " End: " & endPosition, "Range Information")
        '</Snippet25>
    End Sub


    '--------------------------------------------------------------------------
    Private Sub Test()

        '<Snippet21>
        Dim s2 As Word.Range = Me.Application.ActiveDocument.Sentences(2)
        s2.Select()
        '</Snippet21>


        '<Snippet20>
        Me.Application.ActiveDocument.Content.Select()
        '</Snippet20>


        '<Snippet19>
        Me.Application.ActiveDocument.Range.Select()
        '</Snippet19>


        '<Snippet18>
        Dim rng As Word.Range = Me.Application.ActiveDocument.Range(Start:=0, End:=7)
        rng.Select()
        '</Snippet18>


        '<Snippet16>
        Dim documentName As String = Application.ActiveDocument.Name
        '</Snippet16>


        '<Snippet15>
        Dim doc As Word.Document = CType(Application.Documents("SampleDoc.docx"), Word.Document)
        '</Snippet15>


        '<Snippet13>
        Me.Application.ActiveDocument.PrintPreview()
        '</Snippet13>


        '<Snippet11>
        Me.Application.ActiveDocument.PrintOut()
        '</Snippet11>


        '<Snippet9>
        Me.Application.Documents("C:\Test\NewDocument.docx").Save()
        '</Snippet9>


        '<Snippet8>
        Me.Application.ActiveDocument.Save()
        '</Snippet8>


        '<Snippet6>
        Me.Application.Documents.Open(FileName:="C:\Test\NewDocument.docx", ReadOnly:=True)
        '</Snippet6>


        '<Snippet5>
        Me.Application.Documents.Open("C:\Test\NewDocument.docx")
        '</Snippet5>


        '<Snippet4>
        Application.Documents("NewDocument.docx").Close(Word.WdSaveOptions.wdSaveChanges)
        '</Snippet4>


        '<Snippet3>
        Me.Application.ActiveDocument.Close(Word.WdSaveOptions.wdDoNotSaveChanges)
        '</Snippet3>


        '<Snippet2>
        Me.Application.Documents.Add(Template:="C:\Test\SampleTemplate.dotx")
        '</Snippet2>


        '<Snippet1>
        Me.Application.Documents.Add()
        '</Snippet1>
    End Sub

End Class

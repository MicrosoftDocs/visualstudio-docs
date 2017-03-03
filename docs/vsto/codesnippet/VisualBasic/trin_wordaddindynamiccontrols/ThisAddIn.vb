Public Class ThisAddIn

    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        'AddRichTextControlAtSelection()
        'AddRichTextControlAtRange()
        'AddBookmarkAtRange()
        'AddWindowsFormsControl()
        'CreateDocumentHostItem()

        'Dim document1 As Word.Document = Me.Application.ActiveDocument
        'AddSmartTagToDocument(document1)

        'CreateDocument1()
        'CreateDocument2()
        'AddProtectedContentControls()
        'ProtectFirstParagraph()
        'ResizeBookmark()
    End Sub

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

    '<Snippet1>
    Dim richTextControl1 As Microsoft.Office.Tools.Word.RichTextContentControl

    Private Sub AddRichTextControlAtSelection()
        Dim currentDocument As Word.Document = Me.Application.ActiveDocument
        currentDocument.Paragraphs(1).Range.InsertParagraphBefore()
        currentDocument.Paragraphs(1).Range.Select()

        Dim extendedDocument As Document = Globals.Factory.GetVstoObject(currentDocument)


        richTextControl1 = extendedDocument.Controls.AddRichTextContentControl("richTextControl1")
        richTextControl1.PlaceholderText = "Enter your first name"
    End Sub
    '</Snippet1>

    '<Snippet2>
    Dim richTextControl2 As Microsoft.Office.Tools.Word.RichTextContentControl

    Private Sub AddRichTextControlAtRange()
        Dim currentDocument As Word.Document = Me.Application.ActiveDocument
        currentDocument.Paragraphs(1).Range.InsertParagraphBefore()

        Dim extendedDocument As Document = Globals.Factory.GetVstoObject(currentDocument)

        richTextControl2 = extendedDocument.Controls.AddRichTextContentControl( _
            extendedDocument.Paragraphs(1).Range, "richTextControl2")
        richTextControl2.PlaceholderText = "Enter your first name"
    End Sub
    '</Snippet2>

    '<Snippet3>
    Private richTextControls As New System.Collections.Generic.List _
        (Of Microsoft.Office.Tools.Word.RichTextContentControl)

    Private Sub Application_DocumentOpen(ByVal Doc As Microsoft.Office.Interop.Word.Document) _
        Handles Application.DocumentOpen

        If Doc.ContentControls.Count > 0 Then

            Dim extendedDocument As Document = Globals.Factory.GetVstoObject(Doc)

            Dim count As Integer = 0
            For Each nativeControl As Word.ContentControl In Doc.ContentControls
                If nativeControl.Type = Word.WdContentControlType.wdContentControlRichText Then
                    count += 1
                    Dim tempControl As Microsoft.Office.Tools.Word.RichTextContentControl = _
                        extendedDocument.Controls.AddRichTextContentControl(nativeControl, _
                        "VSTORichTextContentControl" + count.ToString())
                    richTextControls.Add(tempControl)
                End If
            Next nativeControl
        End If
    End Sub
    '</Snippet3>

    Private Sub AddBookmarkAtRange()
        '<Snippet4>
        Dim extendedDocument As Document = Globals.Factory.GetVstoObject(Me.Application.ActiveDocument)


        Dim firstParagraph As Bookmark = extendedDocument.Controls.AddBookmark( _
            extendedDocument.Paragraphs(1).Range, "FirstParagraph")
        '</Snippet4>
    End Sub

    Private Sub Application_DocumentOpen2(ByVal Doc As Microsoft.Office.Interop.Word.Document) _
        Handles Application.DocumentOpen

        '<Snippet5>
        If Me.Application.ActiveDocument.Bookmarks.Count > 0 Then
            Dim firstBookmark As Word.Bookmark = Me.Application.ActiveDocument.Bookmarks(1)

            Dim extendedDocument As Document = Globals.Factory.GetVstoObject(Me.Application.ActiveDocument)

            Dim vstoBookmark As Bookmark = extendedDocument.Controls.AddBookmark( _
                firstBookmark, "VSTOBookmark")
        End If
        '</Snippet5>
    End Sub

    Private Sub AddWindowsFormsControl()
        '<Snippet7>
        Dim salesButton As Microsoft.Office.Tools.Word.Controls.Button

        Dim extendedDocument As Document = Globals.Factory.GetVstoObject(Me.Application.ActiveDocument)

        extendedDocument.Paragraphs(1).Range.InsertParagraphBefore()
        salesButton = extendedDocument.Controls.AddButton( _
            extendedDocument.Paragraphs(1).Range, 75, 18, "salesButton")
        salesButton.Text = "Calculate Sales"
        '</Snippet7>
    End Sub

    Private Sub CreateDocumentHostItem()
        '<Snippet8>
        If Globals.ThisAddIn.Application.Documents.Count > 0 Then
            Dim NativeDocument As Microsoft.Office.Interop.Word.Document = _
                Globals.ThisAddIn.Application.ActiveDocument
            Dim VstoDocument As Microsoft.Office.Tools.Word.Document = _
                Globals.Factory.GetVstoObject(NativeDocument)
        End If
        '</Snippet8>
    End Sub

    '<Snippet9>
    Private WithEvents displayAddress As Microsoft.Office.Tools.Word.Action

    Private Sub AddSmartTagToDocument(ByVal document As Word.Document)
 
        Dim  smartTagDemo As SmartTag = Globals.Factory.CreateSmartTag(
            "www.microsoft.com/Demo#DemoSmartTag",
            "Demonstration Smart Tag")

        ' Specify the terms to recognize.
        smartTagDemo.Terms.Add("term")
        smartTagDemo.Terms.Add("recognize")

        displayAddress = Globals.Factory.CreateAction("To be replaced")

        ' Add the action to the smart tag.
        smartTagDemo.Actions = New Microsoft.Office.Tools.Word.Action() { _
                displayAddress}

        Dim vstoDocument As Microsoft.Office.Tools.Word.Document = _
            Globals.Factory.GetVstoObject(document)

        ' Add the smart tag to the document.
        vstoDocument.VstoSmartTags.Add(smartTagDemo)
    End Sub

    Private Sub DisplayAddress_BeforeCaptionShow(ByVal sender As Object, _
        ByVal e As Microsoft.Office.Tools.Word.ActionEventArgs) _
        Handles displayAddress.BeforeCaptionShow

        Dim clickedAction As Microsoft.Office.Tools.Word.Action = _
            TryCast(sender, Microsoft.Office.Tools.Word.Action)

        If clickedAction IsNot Nothing Then
            clickedAction.Caption = "Display the location of " & e.Text
        End If
    End Sub

    Private Sub DisplayAddress_Click(ByVal sender As Object, _
        ByVal e As Microsoft.Office.Tools.Word.ActionEventArgs) _
        Handles displayAddress.Click

        Dim termStart As Integer = e.Range.Start
        Dim termEnd As Integer = e.Range.End
        MsgBox("The recognized text '" & e.Text & _
                "' begins at position " & termStart & _
                " and ends at position " & termEnd)
    End Sub
    '</Snippet9>

    '<Snippet10>
    Private Sub Application_DocumentBeforeClose(ByVal Doc As Word.Document, _
        ByRef Cancel As Boolean) Handles Application.DocumentBeforeClose

        Dim isExtended As Boolean = Globals.Factory.HasVstoObject(Doc)

        If isExtended Then

            Dim vstoDocument As Document = Globals.Factory.GetVstoObject(Doc)

            Dim controlsToRemove As System.Collections.ArrayList = _
                New System.Collections.ArrayList()

            ' Get all of the Windows Forms controls.
            For Each control As Object In vstoDocument.Controls
                If TypeOf control Is System.Windows.Forms.Control Then
                    controlsToRemove.Add(control)
                End If
            Next

            ' Remove all of the Windows Forms controls from the document.
            For Each control As Object In controlsToRemove
                vstoDocument.Controls.Remove(control)
            Next
        End If
    End Sub
    '</Snippet10>

    '<Snippet11>
    Private Sub Application_DocumentOpen_ClearActiveXWrappers( _
        ByVal Doc As Word.Document) Handles Application.DocumentOpen

        Dim vstoDocument As Document = Globals.Factory.GetVstoObject(Doc)

    End Sub
    '</Snippet11>

    '<Snippet12>
    Private document1 As Word.Document = Nothing

    Private Sub CreateDocument1()
        document1 = Me.Application.Documents.Add()
    End Sub

    Private Sub Application_DocumentBeforeSave(ByVal Doc As Word.Document, _
        ByRef SaveAsUI As Boolean, ByRef Cancel As Boolean) _
        Handles Application.DocumentBeforeSave
        If Type.ReferenceEquals(Doc, document1) Then
            Cancel = True
        End If
    End Sub
    '</Snippet12>

    '<Snippet13>
    Private document2 As Word.Document = Nothing
    Private WithEvents vstoDocument As Microsoft.Office.Tools.Word.Document = Nothing

    Private Sub CreateDocument2()
        document2 = Me.Application.Documents.Add()
        vstoDocument = Globals.Factory.GetVstoObject(document2)
    End Sub

    Private Sub vstoDocument_BeforeSave(ByVal sender As Object, _
        ByVal e As SaveEventArgs) Handles vstoDocument.BeforeSave
        e.Cancel = True
    End Sub
    '</Snippet13>

    '<Snippet14>
    Dim deletableControl As Microsoft.Office.Tools.Word.RichTextContentControl
    Dim editableControl As Microsoft.Office.Tools.Word.RichTextContentControl

    Private Sub AddProtectedContentControls()

        Dim VstoDocument As Microsoft.Office.Tools.Word.Document = _
            Globals.Factory.GetVstoObject(Me.Application.ActiveDocument)

        vstoDocument.Paragraphs(1).Range.InsertParagraphBefore()
        Dim range1 As Word.Range = vstoDocument.Paragraphs(1).Range

        deletableControl = vstoDocument.Controls.AddRichTextContentControl(range1, _
            "deletableControl")
        deletableControl.PlaceholderText = "You can delete this control, " & _
            "but you cannot edit it"
        deletableControl.LockContents = True

        range1.InsertParagraphAfter()
        Dim range2 As Word.Range = vstoDocument.Paragraphs(2).Range

        editableControl = vstoDocument.Controls.AddRichTextContentControl(range2, _
            "editableControl")
        editableControl.PlaceholderText = "You can edit this control, " & _
            "but you cannot delete it"
        editableControl.LockContentControl = True
    End Sub
    '</Snippet14>

    '<Snippet15>
    Dim groupControl1 As Microsoft.Office.Tools.Word.GroupContentControl

    Private Sub ProtectFirstParagraph()

        Dim VstoDocument As Microsoft.Office.Tools.Word.Document = _
            Globals.Factory.GetVstoObject(Me.Application.ActiveDocument)

        VstoDocument.Paragraphs(1).Range.InsertParagraphBefore()

        Dim range1 As Word.Range = VstoDocument.Paragraphs(1).Range
        range1.Text = "You cannot edit or change the formatting of text " & _
                "in this paragraph, because this paragraph is in a GroupContentControl."
        range1.Select()

        groupControl1 = VstoDocument.Controls.AddGroupContentControl("groupControl1")
    End Sub
    '</Snippet15>

    Private Sub ResizeBookmark()
        '<Snippet16>

        Dim VstoDocument As Microsoft.Office.Tools.Word.Document = _
            Globals.Factory.GetVstoObject(Me.Application.ActiveDocument)

        vstoDocument.ActiveWindow.View.ShowBookmarks = True
        vstoDocument.Paragraphs(1).Range.InsertParagraphBefore()

        Dim firstParagraph As Word.Range = vstoDocument.Paragraphs(1).Range
        firstParagraph.Text = "123456789abcdefghijklmnopqrstuvwxyz"

        Dim sampleBookmark As Microsoft.Office.Tools.Word.Bookmark = _
            vstoDocument.Controls.AddBookmark(firstParagraph, "bookmark1")
        sampleBookmark.Start = sampleBookmark.Start + 5
        sampleBookmark.End = sampleBookmark.End - 5
        '</Snippet16>
    End Sub


End Class

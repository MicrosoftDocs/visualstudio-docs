Public Class ThisDocument

    '--------------------------------------------------------------------------
    '<Snippet4>
    Private commandBar As Office.CommandBar
    Private selectedBookmark As Microsoft.Office.Tools.Word.Bookmark
    WithEvents boldText As Office.CommandBarButton
    WithEvents ItalicText As Office.CommandBarButton
    '</Snippet4>


    '--------------------------------------------------------------------------
    '<Snippet6>
    Private Sub ThisDocument_Startup(ByVal sender As Object, ByVal e As _
        System.EventArgs) Handles Me.Startup

        AddPopUp()
    End Sub
    '</Snippet6>


    '--------------------------------------------------------------------------
    '<Snippet5>
    Private Sub AddPopUp()

        commandBar = Application.CommandBars.Add( _
            "FormatText", Office.MsoBarPosition.msoBarPopup, , True)

        ' Add a button and set the style, caption, icon and tag.
        boldText = CType(commandBar.Controls.Add(1), Office.CommandBarButton)

        With boldText
            .Style = Office.MsoButtonStyle.msoButtonIconAndCaption
            .Caption = "Bold"
            .FaceId = 113
            .Tag = "0"
        End With

        ' Add a button and set the style, caption, icon and tag.
        ItalicText = CType(commandBar.Controls.Add(1), Office.CommandBarButton)

        With ItalicText
            .Style = Office.MsoButtonStyle.msoButtonIconAndCaption
            .Caption = "Italic"
            .FaceId = 114
            .Tag = "1"
        End With

        CType(Me.AttachedTemplate, Microsoft.Office.Interop.Word.Template).Saved = True

    End Sub
    '</Snippet5>


    '--------------------------------------------------------------------------
     '<Snippet8>
    Private Sub showPopupMenu(ByVal sender As Object, ByVal e _
        As Microsoft.Office.Tools.Word.ClickEventArgs) _
        Handles Bookmark1.BeforeRightClick, Bookmark2.BeforeRightClick

        Dim startPosition As Integer = 0
        Dim i As Integer

        ' If bookmarks overlap, get bookmark closest to cursor.
        For i = 1 To e.Selection.Bookmarks.Count
            If e.Selection.Bookmarks(i).Start > startPosition Then
                startPosition = e.Selection.Bookmarks(i).Start
            End If
        Next

        ' If closest bookmark is the sender, show the popup.
        If DirectCast(sender, Microsoft.Office.Tools.Word.Bookmark).Start = _
            startPosition Then
            selectedBookmark = DirectCast(sender, Microsoft.Office.Tools.Word.Bookmark)
            commandBar.ShowPopup()
            e.Cancel = True
        End If
    End Sub
    '</Snippet8>


    '--------------------------------------------------------------------------
    '<Snippet9>
    Private Sub ButtonClick(ByVal ctrl As Office.CommandBarButton, _
        ByRef Cancel As Boolean) Handles boldText.Click, ItalicText.Click

        Select Case ctrl.Caption
            Case "Bold"
                selectedBookmark.Bold = Not selectedBookmark.Bold
            Case "Italic"
                selectedBookmark.Italic = Not selectedBookmark.Italic
        End Select

        Me.ActiveWindow.SetFocus()
    End Sub
    '</Snippet9>


    '--------------------------------------------------------------------------
    Sub test1()

        '<Snippet10>
        Dim targetControl As Object
        For Each targetControl In Me.Controls

            If TypeOf (targetControl) Is Microsoft.Office.Tools.Word.Bookmark Then
                Dim bookMark As Microsoft.Office.Tools.Word.Bookmark = _
                    CType(targetControl, Microsoft.Office.Tools.Word.Bookmark)

                ' Do some work with the book mark here.
            End If
        Next
        '</Snippet10>


        '<Snippet2>
        Me.SampleBookmark.Start = Me.SampleBookmark.Start - 5
        '</Snippet2>


        '<Snippet3>
        Me.SampleBookmark.End = Me.SampleBookmark.End + 5
        '</Snippet3>


        '<Snippet1>
        Dim firstParagraph As Microsoft.Office.Tools.Word.Bookmark
        firstParagraph = Me.Controls.AddBookmark(Me.Paragraphs(1).Range, "FirstParagraph")
        '</Snippet1>
    End Sub

End Class

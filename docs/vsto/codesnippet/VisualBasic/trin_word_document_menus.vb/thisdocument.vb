Public Class ThisDocument

    '<Snippet2>
    Public selectedBookmark As Microsoft.Office.Tools.Word.Bookmark
    Public ShowBoldButton As String = False
    Public ShowItalicButton As String = False
    Public WordTrue As Integer = -1
    Public WordFalse As Integer = 0
    '</Snippet2>

    Private Sub ThisDocument_Startup() Handles Me.Startup

    End Sub

    Private Sub ThisDocument_Shutdown() Handles Me.Shutdown

    End Sub

    '<Snippet3>

    Private Sub Bookmark_BeforeRightClick(ByVal sender As Object, ByVal e _
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

        ' If closest bookmark is the sender, show the shortcut menu options.
        If DirectCast(sender, Microsoft.Office.Tools.Word.Bookmark).Start = _
            startPosition Then
            selectedBookmark = DirectCast(sender, Microsoft.Office.Tools.Word.Bookmark)

            ShowBoldButton = True
            ShowItalicButton = True

        End If

    End Sub
    '</Snippet3>

    '<Snippet1>
    Protected Overrides Function CreateRibbonExtensibilityObject() As Microsoft.Office.Core.IRibbonExtensibility
        Return New Ribbon1()
    End Function
    '</Snippet1>
End Class

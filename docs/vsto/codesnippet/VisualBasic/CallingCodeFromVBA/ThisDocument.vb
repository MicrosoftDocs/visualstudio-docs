<Microsoft.VisualBasic.ComClassAttribute()> <System.Runtime.InteropServices.ComVisibleAttribute(True)> Public Class ThisDocument

    Private Sub ThisDocument_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup

    End Sub

    Private Sub ThisDocument_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

    '<Snippet1>
    Public Sub CreateTable(ByVal firstColumnHeader As String, _
        ByVal secondColumnHeader As String)

        Me.Paragraphs(1).Range.InsertParagraphBefore()
        Dim table1 As Word.Table = Me.Tables.Add(Me.Paragraphs(1).Range, 2, 2)

        With table1
            .Style = "Table Professional"
            .Cell(1, 1).Range.Text = firstColumnHeader
            .Cell(1, 2).Range.Text = secondColumnHeader
        End With
    End Sub
    '</Snippet1>

End Class

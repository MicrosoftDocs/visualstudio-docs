Public Class GetInputString

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Button1.Click

        '<Snippet3>
        Globals.ThisWorkbook.WriteStringToCell(Me.TextBox1.Text)
        Me.Dispose()
        '</Snippet3>
    End Sub
End Class
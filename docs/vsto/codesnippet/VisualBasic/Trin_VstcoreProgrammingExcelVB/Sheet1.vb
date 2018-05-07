Public Class Sheet1

    Private Sub Sheet1_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
    End Sub

    Private Sub Sheet1_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
    End Sub


    '<Snippet1>
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Button1.Click
        Globals.Sheet1.NamedRange1.Value2 = Me.TextBox1.Text
    End Sub
    '</Snippet1>


    Sub Test1()
        '<Snippet2>
        Dim NamedRange1 As Microsoft.Office.Tools.Excel.NamedRange = _
            Me.Controls.AddNamedRange(Me.Range("A1"), "NamedRange1")
        '</Snippet2>

        '<Snippet3>
        Dim width As Double = CType(NamedRange1.ColumnWidth, Double)
        '</Snippet3>

        '<Snippet4>
        MessageBox.Show("Column width: " & width.ToString())
        '</Snippet4>
    End Sub

    Sub TestDynamic()
        '<Snippet9>
        Dim castRange As Excel.Range = CType(Globals.Sheet1.Cells(1, 1), Excel.Range)
        '</Snippet9>

        '<Snippet10>
        Dim dynamicRange As Excel.Range = Globals.Sheet1.Cells(1, 1)
        '</Snippet10>
    End Sub
End Class

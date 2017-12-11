
Public Class Sheet1

    '<Snippet1>
    Private Sub Sheet1_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        Dim nr As Microsoft.Office.Tools.Excel.NamedRange = _
            Me.Controls.AddNamedRange(Me.Range("A2"), "NamedRange1")
        nr.Value2 = "This text was added by using code"
    End Sub
    '</Snippet1>

    Private Sub Sheet1_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

End Class

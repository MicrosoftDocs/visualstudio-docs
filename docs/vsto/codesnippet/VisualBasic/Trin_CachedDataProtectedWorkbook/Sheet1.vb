
Public Class Sheet1

    Private Sub Sheet1_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        TextBox1.Text = Globals.ThisWorkbook.CachedString
    End Sub

    Private Sub Sheet1_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show(Globals.ThisWorkbook.CachedString)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Globals.ThisWorkbook.Protect(Globals.ThisWorkbook.securelyStoredPassword, _
            True, True)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Globals.ThisWorkbook.CachedString = TextBox1.Text
    End Sub
End Class

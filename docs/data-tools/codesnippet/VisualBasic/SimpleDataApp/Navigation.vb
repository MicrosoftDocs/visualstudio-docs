Public Class Navigation

    '<Snippet1>
    ''' <summary>
    ''' Opens the NewCustomer form as a dialog box, which returns focus to the calling form when it closes.
    ''' </summary>  
    Private Sub btnGoToAdd_Click(sender As Object, e As EventArgs) Handles btnGoToAdd.Click
        Dim frm As Form = New NewCustomer()
        frm.Show()
    End Sub

    ''' <summary>
    ''' Opens the FillOrCancel form as a dialog box.
    ''' </summary>
    Private Sub btnGoToFillOrCancel_Click(sender As Object, e As EventArgs) Handles btnGoToFillOrCancel.Click
        Dim frm As Form = New FillOrCancel()
        frm.ShowDialog()
    End Sub

    ''' <summary>
    ''' Closes the application (not just the navigation form).
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    '</Snippet1>

End Class
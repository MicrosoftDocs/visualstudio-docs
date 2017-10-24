    Private Sub ProceedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProceedButton.Click
        If ProceedButton.Enabled Then
            accepted = True
            Me.Close()
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        ProceedButton.Enabled = Not ProceedButton.Enabled
    End Sub
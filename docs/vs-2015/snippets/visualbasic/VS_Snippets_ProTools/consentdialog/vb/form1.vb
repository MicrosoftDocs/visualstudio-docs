Public Class Form1

    '<snippet6>
    Public Sub New()
        InitializeComponent()
        ProceedButton.Enabled = False
    End Sub
    '</snippet6>

    '<snippet3>
    Public accepted As Boolean = False
    '</snippet3>

    '<snippet1>
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        ProceedButton.Enabled = Not ProceedButton.Enabled
    End Sub
    '</snippet1>

    '<snippet2>
    Private Sub ProceedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProceedButton.Click
        If ProceedButton.Enabled Then
            accepted = True
            Me.Close()
        End If
    End Sub
    '</snippet2>

    '<snippet4>
    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
    '</snippet4>
End Class

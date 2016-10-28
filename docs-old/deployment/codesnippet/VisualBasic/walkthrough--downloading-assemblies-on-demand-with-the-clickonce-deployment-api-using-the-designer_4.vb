    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim DC As New DynamicClass()
        MessageBox.Show("Message is " & DC.Message)
    End Sub
    Private Sub ShowHelloWorld(ByVal sender As Object, ByVal e As EventArgs)
        Dim hw = TryCast(GetDialogPage(GetType(HelloWorldOptions)), HelloWorldOptions)
        If hw.HelloWorld = True Then
            MessageBox.Show("Hello World!")
        Else
            MessageBox.Show("Goodbye.")
        End If
    End Sub
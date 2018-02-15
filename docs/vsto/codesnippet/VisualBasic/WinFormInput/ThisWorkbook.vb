Public Class ThisWorkbook

    '<Snippet1>
    Private Sub ThisWorkbook_Open() Handles Me.Open
        Dim inputForm As New GetInputString()
        inputForm.ShowDialog()
    End Sub
    '</Snippet1>

    '<Snippet2>
    Public Sub WriteStringToCell(ByVal formData As String)
        Globals.Sheet1.formInput.Value2 = formData
    End Sub
    '</Snippet2>
End Class

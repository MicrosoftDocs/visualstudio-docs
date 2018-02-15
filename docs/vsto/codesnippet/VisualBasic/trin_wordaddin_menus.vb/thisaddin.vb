Public Class ThisAddIn
    '<Snippet1>
    Protected Overrides Function CreateRibbonExtensibilityObject() As Microsoft.Office.Core.IRibbonExtensibility
        Return New Ribbon1()
    End Function
    '</Snippet1>
    '<Snippet3>
    Private Sub ThisAddIn_Startup() Handles Me.Startup

        AddHandler Application.NewDocument, AddressOf WorkWithDocument

    End Sub

    Private Sub WorkWithDocument(ByVal Doc As Microsoft.Office.Interop.Word.Document) _
        Handles Application.DocumentOpen

        Dim rng As Word.Range = Doc.Range(Start:=0, End:=0)
        rng.Text = " New Text "
        rng.Select()

    End Sub
    '</Snippet3>

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class

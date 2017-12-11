Public Class ThisDocument

    Private Sub ThisDocument_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
    End Sub

    Private Sub ThisDocument_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
    End Sub


    Sub TestProperties()
        '<Snippet1>
        Dim properties As Microsoft.Office.Core.DocumentProperties

        properties = DirectCast(Globals.ThisDocument.BuiltInDocumentProperties, _
            Microsoft.Office.Core.DocumentProperties)
        '</Snippet1>

        '<Snippet2>
        ' Set the Subject property.
        properties.Item("Subject").Value = "Whitepaper"
        '</Snippet2>
    End Sub
End Class

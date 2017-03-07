Public Class ThisDocument

    Private Sub ThisDocument_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        CheckSchema()
    End Sub

    '--------------------------------------------------------------------------
    '<Snippet1>
    ' Ensure that the schema is in the library and registered with the document.
    Private Function CheckSchema() As Boolean

        Const namespaceUri As String = "http://schemas.contoso.com/projects"
        Dim namespaceFound As Boolean = False
        Dim namespaceRegistered As Boolean = False

        Dim n As Word.XMLNamespace
        For Each n In Application.XMLNamespaces
            If (n.URI = namespaceUri) Then
                namespaceFound = True
            End If
        Next

        If Not namespaceFound Then
            MessageBox.Show("XML Schema is not in library.")
            Return False
        End If

        Dim r As Word.XMLSchemaReference
        For Each r In Me.XMLSchemaReferences
            If (r.NamespaceURI = namespaceUri) Then
                namespaceRegistered = True
            End If
        Next

        If Not namespaceRegistered Then
            MessageBox.Show("XML Schema is not registered for this document.")
            Return False
        End If

        Return True
    End Function
    '</Snippet1>

End Class

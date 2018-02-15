Public Class ThisWorkbook

    Private Sub ThisWorkbook_Startup(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Startup

        '<Snippet5>
        Dim reportPicker As New ReportPicker
        reportPicker.ShowDialog()
        '</Snippet5>
    End Sub

    Private Sub ThisWorkbook_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
    End Sub


    '--------------------------------------------------------------------------
    '<Snippet6>
    Sub TestProperties()
        Dim properties As Microsoft.Office.Core.DocumentProperties
        properties = CType(Me.CustomDocumentProperties, Office.DocumentProperties)

        If ReadDocumentProperty("Project Name") <> Nothing Then
            properties("Project Name").Delete()
        End If

        properties.Add("Project Name", False, _
            Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeString, _
            "White Papers")
    End Sub

    Private Function ReadDocumentProperty(ByVal propertyName As String) As String
        Dim properties As Office.DocumentProperties
        properties = CType(Me.CustomDocumentProperties, Office.DocumentProperties)

        Dim prop As Office.DocumentProperty

        For Each prop In properties
            If prop.Name = propertyName Then
                Return prop.Value.ToString()
            End If
        Next

        Return Nothing
    End Function
    '</Snippet6>


    '--------------------------------------------------------------------------
    Sub TestPropertyRevision()

        '<Snippet7>
        Dim properties As Microsoft.Office.Core.DocumentProperties

        properties = DirectCast(Globals.ThisWorkbook.BuiltinDocumentProperties, _
            Microsoft.Office.Core.DocumentProperties)

        Dim prop As Microsoft.Office.Core.DocumentProperty
        prop = properties.Item("Revision Number")
        '</Snippet7>


        '<Snippet8>
        If prop.Value Is Nothing Then
            prop.Value = 1
        Else
            Dim revision As Integer
            If Integer.TryParse(prop.Value.ToString(), revision) Then
                prop.Value = revision + 1
                MessageBox.Show("Revision Number = " & revision)
            Else
                MessageBox.Show("Revision Number = invalid value")
            End If
        End If
        '</Snippet8>
    End Sub
End Class

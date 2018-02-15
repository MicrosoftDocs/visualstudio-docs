Public Class ThisDocument

    Private Sub ThisDocument_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup

    End Sub

    '<Snippet1>
    Private Sub AddCustomXmlPartToDocument()
        Dim xmlString As String = _
            "<?xml version=""1.0"" encoding=""utf-8"" ?>" & _
                "<employees xmlns=""http://schemas.microsoft.com/vsto/samples"">" & _
                    "<employee>" & _
                        "<name>Karina Leal</name>" & _
                        "<hireDate>1999-04-01</hireDate>" & _
                        "<title>Manager</title>" & _
                    "</employee>" & _
                "</employees>"

        Dim employeeXMLPart As Office.CustomXMLPart = _
            Me.CustomXMLParts.Add(xmlString)
    End Sub
    '</Snippet1>

    Private Sub ThisDocument_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

End Class

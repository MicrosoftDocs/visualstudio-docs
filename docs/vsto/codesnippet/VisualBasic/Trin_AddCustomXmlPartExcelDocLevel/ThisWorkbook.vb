

Public Class ThisWorkbook

    Private Sub ThisWorkbook_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        AddCustomXmlPartToWorkbook()
    End Sub

    '<Snippet1>
    Private Sub AddCustomXmlPartToWorkbook()
        Dim xmlString As String = _
            "<?xml version=""1.0"" encoding=""utf-8"" ?>" & _
                "<employees xmlns=""http://schemas.microsoft.com/vsto/samples"">" & _
                    "<employee>" & _
                        "<name>Karina Leal</name>" & _
                        "<hireDate>1999-04-01</hireDate>" & _
                        "<title>Manager</title>" & _
                    "</employee>" & _
                "</employees>"
        Dim employeeXMLPart As Office.CustomXMLPart = Me.CustomXMLParts.Add(xmlString)
    End Sub
    '</Snippet1>

    Private Sub ThisWorkbook_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

End Class

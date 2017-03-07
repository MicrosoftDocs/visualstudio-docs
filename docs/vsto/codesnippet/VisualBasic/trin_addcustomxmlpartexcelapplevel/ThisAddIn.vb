Public Class ThisAddIn

    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup

    End Sub

    Private Sub Application_WorkbookOpen(ByVal Wb As Microsoft.Office.Interop.Excel.Workbook) _
        Handles Application.WorkbookOpen
        AddCustomXmlPartToWorkbook(Wb)
    End Sub

    '<Snippet1>
    Private Sub AddCustomXmlPartToWorkbook(ByVal workbook As Excel.Workbook)
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
            workbook.CustomXMLParts.Add(xmlString)
    End Sub
    '</Snippet1>

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

End Class

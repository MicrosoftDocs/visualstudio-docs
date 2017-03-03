Public Class ThisDocument

    '<Snippet1>
    <Cached()> _
    Public employeeXMLPartID As String = String.Empty
    Private employeeXMLPart As Office.CustomXMLPart
    Private Const prefix As String = "xmlns:ns='http://schemas.microsoft.com/vsto/samples'"
    '</Snippet1>

    Private Sub ThisDocument_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        '<Snippet2>
        Dim xmlData As String = GetXmlFromResource()
        If xmlData IsNot Nothing Then
            AddCustomXmlPart(xmlData)
            BindControlsToCustomXmlPart()
        End If
        '</Snippet2>
    End Sub

    '<Snippet3>
    Private Function GetXmlFromResource() As String
        Dim asm As System.Reflection.Assembly = _
            System.Reflection.Assembly.GetExecutingAssembly()
        Dim stream1 As System.IO.Stream = asm.GetManifestResourceStream( _
                "EmployeeControls.employees.xml")

        Using resourceReader As System.IO.StreamReader = _
            New System.IO.StreamReader(stream1)
            If resourceReader IsNot Nothing Then
                Return resourceReader.ReadToEnd()
            End If
        End Using

        Return Nothing
    End Function
    '</Snippet3>

    '<Snippet4>
    Private Sub AddCustomXmlPart(ByVal xmlData As String)
        If xmlData IsNot Nothing Then

            employeeXMLPart = Me.CustomXMLParts.SelectByID(employeeXMLPartID)
            If (employeeXMLPart Is Nothing) Then
                employeeXMLPart = Me.CustomXMLParts.Add(xmlData)
                employeeXMLPart.NamespaceManager.AddNamespace("ns", _
                    "http://schemas.microsoft.com/vsto/samples")
                employeeXMLPartID = employeeXMLPart.Id
            End If
        End If
    End Sub
    '</Snippet4>

    '<Snippet5>
    Private Sub BindControlsToCustomXmlPart()
        Dim xPathName As String = "ns:employees/ns:employee/ns:name"
        Me.PlainTextContentControl1.XMLMapping.SetMapping(xPathName, _
            prefix, employeeXMLPart)

        Dim xPathDate As String = "ns:employees/ns:employee/ns:hireDate"
        Me.DatePickerContentControl1.DateDisplayFormat = "MMMM d, yyyy"
        Me.DatePickerContentControl1.XMLMapping.SetMapping(xPathDate, _
            prefix, employeeXMLPart)

        Dim xPathTitle As String = "ns:employees/ns:employee/ns:title"
        Me.DropDownListContentControl1.XMLMapping.SetMapping(xPathTitle, _
            prefix, employeeXMLPart)
    End Sub
    '</Snippet5>

    '<Snippet6>
    Private Sub plainTextContentControl1_Validating(ByVal sender As Object, _
        ByVal e As System.ComponentModel.CancelEventArgs) _
        Handles PlainTextContentControl1.Validating

        Dim control As Microsoft.Office.Tools.Word.PlainTextContentControl = _
            TryCast(sender, Microsoft.Office.Tools.Word.PlainTextContentControl)

        If control IsNot Nothing Then
            Dim regex As New System.Text.RegularExpressions.Regex("\d")
            If regex.IsMatch(control.Text) Then
                MessageBox.Show("Invalid name. Names cannot contain integers.")
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub plainTextContentControl1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles PlainTextContentControl1.Validated

        MessageBox.Show("The name is valid.")
    End Sub
    '</Snippet6>

    '<Snippet7>
    Private Sub plainTextContentControl1_StoreUpdating(ByVal sender As Object, _
        ByVal e As Microsoft.Office.Tools.Word.ContentControlStoreUpdatingEventArgs) _
        Handles PlainTextContentControl1.StoreUpdating

        MessageBox.Show("The control was changed to the following value: " & vbCrLf & _
            e.Content & vbCrLf & "This value is about to be written to the node that is bound to this control.")
    End Sub

    Private Sub plainTextContentControl1_ContentUpdating(ByVal sender As Object, _
        ByVal e As Microsoft.Office.Tools.Word.ContentControlContentUpdatingEventArgs) _
        Handles PlainTextContentControl1.ContentUpdating

        MessageBox.Show("The node that is bound to this control was changed to the following value: " & vbCrLf & _
            e.Content & vbCrLf & "This value is about to be written to this control.")
    End Sub
    '</Snippet7>

    Private Sub ThisDocument_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

End Class


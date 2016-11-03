    Private Sub ShowSchemaButton_Click() Handles ShowSchemaButton.Click

        Dim swXML As New System.IO.StringWriter()
        AuthorsDataSet.WriteXmlSchema(swXML)
        TextBox1.Text = swXML.ToString
    End Sub
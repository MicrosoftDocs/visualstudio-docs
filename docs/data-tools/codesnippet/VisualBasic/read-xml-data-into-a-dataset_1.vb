    Private Sub ReadXmlButton_Click() Handles ReadXmlButton.Click

        Dim filePath As String = "Complete path where you saved the XML file"

        AuthorsDataSet.ReadXml(filePath)

        DataGridView1.DataSource = AuthorsDataSet
        DataGridView1.DataMember = "authors"
    End Sub
Public Class ThisAddIn
    ' <Snippet1>
    Private adventureWorksDataSet As AdventureWorksLTDataSet
    Private customerTableAdapter As AdventureWorksLTDataSetTableAdapters.CustomerTableAdapter
    Private customerBindingSource As System.Windows.Forms.BindingSource
    Private customerContentControl As Microsoft.Office.Tools.Word.RichTextContentControl
    Private WithEvents button1 As Microsoft.Office.Tools.Word.Controls.Button
    Private WithEvents button2 As Microsoft.Office.Tools.Word.Controls.Button
    ' </Snippet1>

    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        ' <Snippet2>
        Me.adventureWorksDataSet = New AdventureWorksLTDataSet()
        Me.customerTableAdapter = New AdventureWorksLTDataSetTableAdapters.CustomerTableAdapter()
        Me.customerTableAdapter.Fill(Me.adventureWorksDataSet.Customer)
        Me.customerBindingSource = New System.Windows.Forms.BindingSource()
        ' </Snippet2>

        ' <Snippet3>
        Dim currentDocument As Word.Document = Me.Application.ActiveDocument

        Dim extendedDocument As Document = Globals.Factory.GetVstoObject(currentDocument)

        ' </Snippet3>

        ' <Snippet4>
        extendedDocument.Paragraphs(1).Range.InsertParagraphBefore()
        extendedDocument.Paragraphs(1).Range.InsertParagraphBefore()
        extendedDocument.Paragraphs(1).Range.Text = "The companies listed in the AdventureWorksLT database:   "
        extendedDocument.Paragraphs(2).Range.Text = "  "

        Dim range1 As Word.Range = extendedDocument.Paragraphs(2).Range.Characters.First
        Dim range2 As Word.Range = extendedDocument.Paragraphs(2).Range.Characters.Last
        Dim range3 As Word.Range = extendedDocument.Paragraphs(1).Range.Characters.Last
        ' </Snippet4>

        ' <Snippet5>
        Me.button1 = extendedDocument.Controls.AddButton(range1, 60, 15, "1")
        Me.button1.Text = "Previous"
        Me.button2 = extendedDocument.Controls.AddButton(range2, 60, 15, "2")
        Me.button2.Text = "Next"

        Me.customerContentControl = extendedDocument.Controls.AddRichTextContentControl(range3, _
            "richTextContentControl1")
        ' </Snippet5>

        ' <Snippet6>
        Me.customerBindingSource.DataSource = Me.adventureWorksDataSet.Customer
        Me.customerContentControl.DataBindings.Add("Text", Me.customerBindingSource, _
            "CompanyName", True, Me.customerContentControl.DataBindings.DefaultDataSourceUpdateMode)
        ' </Snippet6>

    End Sub

    ' <Snippet7>
    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button1.Click
        Me.customerBindingSource.MovePrevious()
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button2.Click
        Me.customerBindingSource.MoveNext()
    End Sub
    ' </Snippet7>

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

End Class

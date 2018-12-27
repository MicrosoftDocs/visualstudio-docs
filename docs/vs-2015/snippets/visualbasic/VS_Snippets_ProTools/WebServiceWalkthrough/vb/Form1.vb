Public Class Form1
    ' <Snippet1> 
    Private Sub ResultsDataGridView_CellContentClick( _
        ByVal sender As System.Object, _
        ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
        Handles ResultsDataGridView.CellContentClick

        ' When the content in a cell is clicked check to see if it is the Url column.
        ' If it is, pass the url to the Process.Start method to open the web page.
        If ResultsDataGridView.Columns(e.ColumnIndex).DataPropertyName = "Url" Then
            System.Diagnostics.Process.Start(ResultsDataGridView.SelectedCells(0).Value)
        End If
    End Sub
    ' </Snippet1>


    ' <Snippet2>
    Private Sub RunSearchRequest()

        ' Create an instance of the service.
        Dim searchService As New LiveSearchService.MSNSearchPortTypeClient

        ' Instantiate a new SearchRequest.
        Dim searchRequest As New LiveSearchService.SearchRequest

        ' Create a new SourceRequest.
        Dim sourceRequest(1) As LiveSearchService.SourceRequest
        sourceRequest(0) = New LiveSearchService.SourceRequest

        ' To search the web, set the SourceType to Web.
        sourceRequest(0).Source = LiveSearchService.SourceType.Web

        ' Set the columns you want the query to return.
        sourceRequest(0).ResultFields = _
            LiveSearchService.ResultFieldMask.Description And _
            LiveSearchService.ResultFieldMask.Url And _
            LiveSearchService.ResultFieldMask.Title

        ' Search for the text in the textbox.
        searchRequest.Query = searchCriteriaTextBox.Text

        ' Set the SearchRequest to the SourceRequest array.
        searchRequest.Requests = sourceRequest


        ' Replace with a valid AppID. Obtain a free AppID at:
        ' http://search.live.com/developer 
        searchRequest.AppID = "AppID"
        searchRequest.CultureInfo = "en-US"

        ' Create a SearchResponse, then call the Search method
        ' and assign the return value to the response object.
        Dim searchResponse As LiveSearchService.SearchResponse = _
            searchService.Search(searchRequest)

        ' Bind the results to the form's BindingSource.
        ResultsBindingSource.DataSource = searchResponse.Responses(0).Results
    End Sub
    ' </Snippet2>

    ' <Snippet3>
    Private Sub searchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchButton.Click
        RunSearchRequest()
    End Sub
    ' </Snippet3>

End Class

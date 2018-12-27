using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebServiceWalkthrough
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //<Snippet1> 
        private void resultsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // When the content in a cell is clicked check to see if it is the Url column.
            // If it is, pass the url to the Process.Start method to open the web page.
            if (resultsDataGridView.Columns[e.ColumnIndex].DataPropertyName == "Url")
            {
                System.Diagnostics.Process.Start(resultsDataGridView.SelectedCells[0].Value.ToString());
            }
        }
        //</Snippet1>





        //<Snippet2>
        private void RunSearchRequest()
        {
            // Create an instance of the service.
            LiveSearchService.MSNSearchPortTypeClient searchService =
                new LiveSearchService.MSNSearchPortTypeClient();

            // Instantiate a new search request.
            LiveSearchService.SearchRequest searchRequest = new LiveSearchService.SearchRequest();

            // Create a new SourceRequest.
            LiveSearchService.SourceRequest[] sourceRequest = new LiveSearchService.SourceRequest[1];
            sourceRequest[0] = new LiveSearchService.SourceRequest();
    
            // Set the number of results to return.
            sourceRequest[0].Count = 7;
            
            // To search the web, set the SourceType to Web.
            sourceRequest[0].Source = LiveSearchService.SourceType.Web;

            // Set the columns to be returned from the search query.
            sourceRequest[0].ResultFields = LiveSearchService.ResultFieldMask.Description |
                LiveSearchService.ResultFieldMask.Url |
                LiveSearchService.ResultFieldMask.Title;

            // Set the search query to the value in the text box.
            searchRequest.Query = searchCriteriaTextBox.Text;
            
            // Set the search request to the array of source requests.
            searchRequest.Requests = sourceRequest;

            // Replace with a valid AppID. Obtain a free AppID at:
            // http://search.live.com/developer 
            searchRequest.AppID = "AppID";
            searchRequest.CultureInfo = "en-US";

            // Create a SearchResponse, then call the search method
            // and assign the return value to the response object.
            LiveSearchService.SearchResponse searchResponse = searchService.Search(searchRequest);

            // Bind the results from the search query to the form's BindingSource.
            resultsBindingSource.DataSource = searchResponse.Responses[0].Results;
        }
        //</Snippet2>


        //<Snippet3>
        private void searchButton_Click(object sender, EventArgs e)
        {
            RunSearchRequest();
        }
        //</Snippet3>

   }
}

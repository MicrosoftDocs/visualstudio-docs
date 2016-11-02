        private AdventureWorksService.AdventureWorksLTEntities dataServiceClient;
        private System.Data.Services.Client.DataServiceQuery<AdventureWorksService.SalesOrderHeader> salesQuery;
        private CollectionViewSource ordersViewSource;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // TODO: Modify the port number in the following URI as required.
            dataServiceClient = new AdventureWorksService.AdventureWorksLTEntities(
                new Uri("http://localhost:45899/AdventureWorksService.svc"));
            salesQuery = dataServiceClient.SalesOrderHeaders;

            ordersViewSource = ((CollectionViewSource)(this.FindResource("salesOrderHeadersViewSource")));
            ordersViewSource.Source = salesQuery.Execute();
            ordersViewSource.View.MoveCurrentToFirst();
        }
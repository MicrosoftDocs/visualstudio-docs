    Private DataServiceClient As AdventureWorksService.AdventureWorksLTEntities
    Private SalesQuery As System.Data.Services.Client.DataServiceQuery(Of AdventureWorksService.SalesOrderHeader)
    Private OrdersViewSource As CollectionViewSource

    Private Sub Window_Loaded(ByVal Sender As Object, ByVal e As RoutedEventArgs) Handles MyBase.Loaded

        ' TODO: Modify the port number in the following URI as required.
        DataServiceClient = New AdventureWorksService.AdventureWorksLTEntities( _
        New Uri("http://localhost:32415/AdventureWorksService.svc"))
        SalesQuery = DataServiceClient.SalesOrderHeaders

        OrdersViewSource = CType(Me.FindResource("SalesOrderHeadersViewSource"), CollectionViewSource)
        OrdersViewSource.Source = SalesQuery.Execute()
        OrdersViewSource.View.MoveCurrentToFirst()
    End Sub
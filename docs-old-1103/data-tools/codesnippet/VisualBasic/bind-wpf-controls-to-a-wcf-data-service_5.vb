        Dim CurrentOrder As AdventureWorksService.SalesOrderHeader = CType(OrdersViewSource.View.CurrentItem, AdventureWorksService.SalesOrderHeader)

        DataServiceClient.UpdateObject(CurrentOrder)
        DataServiceClient.SaveChanges()
            AdventureWorksService.SalesOrderHeader currentOrder = (AdventureWorksService.SalesOrderHeader)ordersViewSource.View.CurrentItem;
            dataServiceClient.UpdateObject(currentOrder);
            dataServiceClient.SaveChanges();
    Friend Sub LoadOrders(ByVal CustomerID As String)
        OrdersTableAdapter.FillByCustomerID(NorthwindDataSet.Orders, CustomerID)
    End Sub
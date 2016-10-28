        internal void LoadOrders(String CustomerID)
        {
            ordersTableAdapter.FillByCustomerID(northwindDataSet.Orders, CustomerID);
        }
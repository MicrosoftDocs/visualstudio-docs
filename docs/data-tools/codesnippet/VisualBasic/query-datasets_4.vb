        Dim customerID As String = "ALFKI"
        Dim orders() As NorthwindDataSet.OrdersRow

        orders = CType(NorthwindDataSet.Customers.FindByCustomerID(customerID).
            GetChildRows("FK_Orders_Customers"), NorthwindDataSet.OrdersRow())

        MessageBox.Show(orders.Length.ToString())
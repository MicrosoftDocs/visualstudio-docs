        Dim orderID As Integer = 10707
        Dim customer As NorthwindDataSet.CustomersRow

        customer = CType(NorthwindDataSet.Orders.FindByOrderID(orderID).
            GetParentRow("FK_Orders_Customers"), NorthwindDataSet.CustomersRow)

        MessageBox.Show(customer.CompanyName)
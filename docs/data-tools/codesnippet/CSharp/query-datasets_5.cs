            int orderID = 10707;
            NorthwindDataSet.CustomersRow customer;

            customer = (NorthwindDataSet.CustomersRow)northwindDataSet.Orders.
                FindByOrderID(orderID).GetParentRow("FK_Orders_Customers");

            MessageBox.Show(customer.CompanyName); 
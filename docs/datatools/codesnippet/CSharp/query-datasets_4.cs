            string custID = "ALFKI";
            NorthwindDataSet.OrdersRow[] orders;

            orders = (NorthwindDataSet.OrdersRow[])northwindDataSet.Customers.
                FindByCustomerID(custID).GetChildRows("FK_Orders_Customers");

            MessageBox.Show(orders.Length.ToString());
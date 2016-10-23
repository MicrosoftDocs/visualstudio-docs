        private void AddNewOrders()
        {
            NorthwindDataSet.OrdersDataTable newOrders;
            newOrders = (NorthwindDataSet.OrdersDataTable)
                northwindDataSet.Orders.GetChanges(DataRowState.Added);

            if (newOrders != null)
            {
                try
                {
                    ordersTableAdapter.Update(newOrders);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("AddNewOrders Failed");
                }
            }
        }
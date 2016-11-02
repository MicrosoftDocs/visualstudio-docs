        private void DeleteOrders()
        {
            NorthwindDataSet.OrdersDataTable deletedOrders;
            deletedOrders = (NorthwindDataSet.OrdersDataTable)
                northwindDataSet.Orders.GetChanges(DataRowState.Deleted);

            if (deletedOrders != null)
            {
                try
                {
                    ordersTableAdapter.Update(deletedOrders);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("DeleteOrders Failed");
                }
            }
        }
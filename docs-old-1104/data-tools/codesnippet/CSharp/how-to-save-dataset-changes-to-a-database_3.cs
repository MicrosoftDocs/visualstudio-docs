        void UpdateDB()
        {
            NorthwindDataSet.OrdersDataTable deletedChildRecords = 
                (NorthwindDataSet.OrdersDataTable)northwindDataSet.Orders.GetChanges(DataRowState.Deleted);

            NorthwindDataSet.OrdersDataTable newChildRecords = 
                (NorthwindDataSet.OrdersDataTable)northwindDataSet.Orders.GetChanges(DataRowState.Added);

            NorthwindDataSet.OrdersDataTable modifiedChildRecords = 
                (NorthwindDataSet.OrdersDataTable)northwindDataSet.Orders.GetChanges(DataRowState.Modified);

            try
            {
                if (deletedChildRecords != null)
                {
                    ordersTableAdapter.Update(deletedChildRecords);
                }

                customersTableAdapter.Update(northwindDataSet.Customers);

                if (newChildRecords != null)
                {
                    ordersTableAdapter.Update(newChildRecords);
                }

                if (modifiedChildRecords != null)
                {
                    ordersTableAdapter.Update(modifiedChildRecords);
                }

                northwindDataSet.AcceptChanges();
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during the update process");
                // Add code to handle error here.
            }

            finally
            {
                if (deletedChildRecords != null)
                {
                    deletedChildRecords.Dispose();
                }
                if (newChildRecords != null)
                {
                    newChildRecords.Dispose();
                }
                if (modifiedChildRecords != null)
                {
                    modifiedChildRecords.Dispose();
                }
            }
        }
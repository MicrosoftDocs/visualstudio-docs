        void UpdateDB()
        {
            System.Data.DataTable DeletedChildRecords = 
                dsNorthwind1.Orders.GetChanges(System.Data.DataRowState.Deleted);

            System.Data.DataTable NewChildRecords = 
                dsNorthwind1.Orders.GetChanges(System.Data.DataRowState.Added);

            System.Data.DataTable ModifiedChildRecords = 
                dsNorthwind1.Orders.GetChanges(System.Data.DataRowState.Modified);

            try
            {
                if (DeletedChildRecords != null)
                {
                    daOrders.Update(DeletedChildRecords);
                }
                if (NewChildRecords != null)
                {
                    daOrders.Update(NewChildRecords);
                }
                if (ModifiedChildRecords != null)
                {
                    daOrders.Update(ModifiedChildRecords);
                }

                dsNorthwind1.AcceptChanges();
            }

            catch (Exception ex)
            {
                // Update error, resolve and try again
            }

            finally
            {
                if (DeletedChildRecords != null)
                {
                    DeletedChildRecords.Dispose();
                }
                if (NewChildRecords != null)
                {
                    NewChildRecords.Dispose();
                }
                if (ModifiedChildRecords != null)
                {
                    ModifiedChildRecords.Dispose();
                }
            }
        }
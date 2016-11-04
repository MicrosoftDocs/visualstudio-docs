        private void DeleteCustomers()
        {
            NorthwindDataSet.CustomersDataTable deletedCustomers;
            deletedCustomers = (NorthwindDataSet.CustomersDataTable)
                northwindDataSet.Customers.GetChanges(DataRowState.Deleted);

            if (deletedCustomers != null)
            {
                try
                {
                    customersTableAdapter.Update(deletedCustomers);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("DeleteCustomers Failed");
                }
            }
        }
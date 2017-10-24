        private void AddNewCustomers()
        {
            NorthwindDataSet.CustomersDataTable newCustomers;
            newCustomers = (NorthwindDataSet.CustomersDataTable)
                northwindDataSet.Customers.GetChanges(DataRowState.Added);

            if (newCustomers != null)
            {
                try
                {
                    customersTableAdapter.Update(newCustomers);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("AddNewCustomers Failed");
                }
            }
        }
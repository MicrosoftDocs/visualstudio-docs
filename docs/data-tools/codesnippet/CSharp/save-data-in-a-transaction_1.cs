        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.ordersBindingSource.EndEdit();

            using (System.Transactions.TransactionScope updateTransaction = 
                new System.Transactions.TransactionScope())
            {
                DeleteOrders();
                DeleteCustomers();
                AddNewCustomers();
                AddNewOrders();

                updateTransaction.Complete();
                northwindDataSet.AcceptChanges();
            }
        }
        private void customersDataGridView_DoubleClick(object sender, EventArgs e)
        {
            System.Data.DataRowView SelectedRowView;
            NorthwindDataSet.CustomersRow SelectedRow;

            SelectedRowView = (System.Data.DataRowView)customersBindingSource.Current;
            SelectedRow = (NorthwindDataSet.CustomersRow)SelectedRowView.Row;

            Form2 OrdersForm = new Form2();
            OrdersForm.LoadOrders(SelectedRow.CustomerID);
            OrdersForm.Show();
        }
            try
            {
                this.Validate();
                this.customersBindingSource.EndEdit();
                this.customersTableAdapter.Update(this.northwindDataSet.Customers);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        private void UpdateDatabase()
        {
            try
            {
                this.customersTableAdapter.Update(this.northwindDataSet.Customers);
                MessageBox.Show("Update successful");
            }
            catch (DBConcurrencyException dbcx)
            {
                DialogResult response = MessageBox.Show(CreateMessage((NorthwindDataSet.CustomersRow)
                    (dbcx.Row)), "Concurrency Exception", MessageBoxButtons.YesNo);

                ProcessDialogResult(response);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error was thrown while attempting to update the database.");
            }
        }
        // This method takes the DialogResult selected by the user and updates the database 
        // with the new values or cancels the update and resets the Customers table 
        // (in the dataset) with the values currently in the database.

        private void ProcessDialogResult(DialogResult response)
        {
            switch (response)
            {
                case DialogResult.Yes:
                    northwindDataSet.Merge(tempCustomersDataTable, true, MissingSchemaAction.Ignore);
                    UpdateDatabase();
                    break;

                case DialogResult.No:
                    northwindDataSet.Merge(tempCustomersDataTable);
                    MessageBox.Show("Update cancelled");
                    break;
            }
        }
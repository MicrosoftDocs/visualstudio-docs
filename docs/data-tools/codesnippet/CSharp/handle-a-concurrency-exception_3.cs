        private string CreateMessage(NorthwindDataSet.CustomersRow cr)
        {
            return
                "Database: " + GetRowData(GetCurrentRowInDB(cr), DataRowVersion.Default) + "\n" +
                "Original: " + GetRowData(cr, DataRowVersion.Original) + "\n" +
                "Proposed: " + GetRowData(cr, DataRowVersion.Current) + "\n" +
                "Do you still want to update the database with the proposed value?";
        }


        //--------------------------------------------------------------------------
        // This method loads a temporary table with current records from the database
        // and returns the current values from the row that caused the exception.
        //--------------------------------------------------------------------------
        private NorthwindDataSet.CustomersDataTable tempCustomersDataTable = 
            new NorthwindDataSet.CustomersDataTable();

        private NorthwindDataSet.CustomersRow GetCurrentRowInDB(NorthwindDataSet.CustomersRow RowWithError)
        {
            this.customersTableAdapter.Fill(tempCustomersDataTable);

            NorthwindDataSet.CustomersRow currentRowInDb = 
                tempCustomersDataTable.FindByCustomerID(RowWithError.CustomerID);

            return currentRowInDb;
        }


        //--------------------------------------------------------------------------
        // This method takes a CustomersRow and RowVersion 
        // and returns a string of column values to display to the user.
        //--------------------------------------------------------------------------
        private string GetRowData(NorthwindDataSet.CustomersRow custRow, DataRowVersion RowVersion)
        {
            string rowData = "";

            for (int i = 0; i < custRow.ItemArray.Length ; i++ )
            {
                rowData = rowData + custRow[i, RowVersion].ToString() + " ";
            }
            return rowData;
        }
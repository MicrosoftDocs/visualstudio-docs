            NorthwindDataSetTableAdapters.CustomersTableAdapter tableAdapter = 
                new NorthwindDataSetTableAdapters.CustomersTableAdapter();

            int rowsAffected = tableAdapter.UpdateContactTitle("Sales Manager", "ALFKI");
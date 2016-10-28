            NorthwindDataSetTableAdapters.CustomersTableAdapter tableAdapter = 
                new NorthwindDataSetTableAdapters.CustomersTableAdapter();

            int returnValue = (int)tableAdapter.GetCustomerCount();
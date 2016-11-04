            NorthwindDataSet northwindDataSet = new NorthwindDataSet();

            NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter = 
                new NorthwindDataSetTableAdapters.CustomersTableAdapter();

            customersTableAdapter.Fill(northwindDataSet.Customers);
            NorthwindDataSet.CustomersRow customersRow = 
                northwindDataSet1.Customers.FindByCustomerID("ALFKI");

            customersRow.CompanyName = "Updated Company Name";
            customersRow.City = "Seattle";;
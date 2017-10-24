            NorthwindDataSet.CustomersRow newCustomersRow = 
                northwindDataSet1.Customers.NewCustomersRow();

            newCustomersRow.CustomerID = "ALFKI";
            newCustomersRow.CompanyName = "Alfreds Futterkiste";

            northwindDataSet1.Customers.Rows.Add(newCustomersRow);
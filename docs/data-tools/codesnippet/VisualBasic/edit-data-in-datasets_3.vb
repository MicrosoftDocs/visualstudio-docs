        Dim newCustomersRow As NorthwindDataSet.CustomersRow
        newCustomersRow = NorthwindDataSet1.Customers.NewCustomersRow()

        newCustomersRow.CustomerID = "ALFKI"
        newCustomersRow.CompanyName = "Alfreds Futterkiste"

        NorthwindDataSet1.Customers.Rows.Add(newCustomersRow)
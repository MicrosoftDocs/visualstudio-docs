        Dim customersRow As NorthwindDataSet.CustomersRow
        customersRow = NorthwindDataSet1.Customers.FindByCustomerID("ALFKI")

        customersRow.CompanyName = "Updated Company Name"
        customersRow.City = "Seattle"
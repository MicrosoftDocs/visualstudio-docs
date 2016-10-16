        Dim northwindDataSet As New NorthwindDataSet()
        Dim customersTableAdapter As New NorthwindDataSetTableAdapters.CustomersTableAdapter()

        customersTableAdapter.Fill(northwindDataSet.Customers)
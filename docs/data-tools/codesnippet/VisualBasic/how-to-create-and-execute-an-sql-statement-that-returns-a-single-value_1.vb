        Dim tableAdapter As New NorthwindDataSetTableAdapters.CustomersTableAdapter()

        Dim returnValue As Integer
        returnValue = CType(tableAdapter.GetCustomerCount(), Integer)
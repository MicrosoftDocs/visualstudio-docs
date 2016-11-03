    Private Function GetNewRecords() As NorthwindDataSet.CustomersDataTable

        Return CType(NorthwindDataSet1.Customers.GetChanges(Data.DataRowState.Added),
            NorthwindDataSet.CustomersDataTable)
    End Function
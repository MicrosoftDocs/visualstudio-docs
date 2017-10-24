        private NorthwindDataSet.CustomersDataTable GetNewRecords()
        {
            return (NorthwindDataSet.CustomersDataTable)
                northwindDataSet1.Customers.GetChanges(DataRowState.Added);
        }
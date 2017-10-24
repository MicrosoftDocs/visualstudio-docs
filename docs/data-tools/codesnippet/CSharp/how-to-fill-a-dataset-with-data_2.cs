            customersTableAdapter.FillByCity(northwindDataSet.Customers, "Seattle");
            customersTableAdapter.FillByCityAndState(northwindDataSet.Customers, "Seattle", "WA");
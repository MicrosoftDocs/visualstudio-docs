        Dim foundRows() As Data.DataRow
        foundRows = DataSet1.Tables("Customers").Select("CompanyName Like 'A%'")
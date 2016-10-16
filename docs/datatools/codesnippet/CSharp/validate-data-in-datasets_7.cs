            string currentCompanyName;
            currentCompanyName = northwindDataSet1.Customers[0]
                ["CompanyName", DataRowVersion.Current].ToString();
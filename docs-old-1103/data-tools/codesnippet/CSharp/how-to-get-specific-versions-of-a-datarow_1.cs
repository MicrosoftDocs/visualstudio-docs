            string originalCompanyName;
            originalCompanyName = northwindDataSet1.Customers[0]
                ["CompanyName", DataRowVersion.Original].ToString();
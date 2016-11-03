    Private Sub LoadCustomers()
        Dim customerData As NorthwindDataSet.CustomersDataTable =
            CustomersTableAdapter1.GetTop5Customers()

        Dim customerRow As NorthwindDataSet.CustomersRow

        For Each customerRow In customerData
            Dim currentCustomer As New Customer()
            With currentCustomer

                .CustomerID = customerRow.CustomerID
                .CompanyName = customerRow.CompanyName

                If Not customerRow.IsAddressNull Then
                    .Address = customerRow.Address
                End If

                If Not customerRow.IsCityNull Then
                    .City = customerRow.City
                End If

                If Not customerRow.IsContactNameNull Then
                    .ContactName = customerRow.ContactName
                End If

                If Not customerRow.IsContactTitleNull Then
                    .ContactTitle = customerRow.ContactTitle
                End If

                If Not customerRow.IsCountryNull Then
                    .Country = customerRow.Country
                End If

                If Not customerRow.IsFaxNull Then
                    .Fax = customerRow.Fax
                End If

                If Not customerRow.IsPhoneNull Then
                    .Phone = customerRow.Phone
                End If

                If Not customerRow.IsPostalCodeNull Then
                    .PostalCode = customerRow.PostalCode
                End If

                If Not customerRow.Is_RegionNull Then
                    .Region = customerRow._Region
                End If

            End With

            LoadOrders(currentCustomer)
            CustomerBindingSource.Add(currentCustomer)
        Next
    End Sub
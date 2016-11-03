    Private Sub AddNewCustomer(ByVal currentCustomer As Customer)

        CustomersTableAdapter.Insert(
            currentCustomer.CustomerID,
            currentCustomer.CompanyName,
            currentCustomer.ContactName,
            currentCustomer.ContactTitle,
            currentCustomer.Address,
            currentCustomer.City,
            currentCustomer.Region,
            currentCustomer.PostalCode,
            currentCustomer.Country,
            currentCustomer.Phone,
            currentCustomer.Fax)
    End Sub
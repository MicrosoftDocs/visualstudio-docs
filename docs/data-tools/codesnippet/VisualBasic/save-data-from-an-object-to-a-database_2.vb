    Private Sub UpdateCustomer(ByVal cust As Customer)

            CustomersTableAdapter.Update(
            cust.CustomerID,
            cust.CompanyName,
            cust.ContactName,
            cust.ContactTitle,
            cust.Address,
            cust.City,
            cust.Region,
            cust.PostalCode,
            cust.Country,
            cust.Phone,
            cust.Fax,
            cust.origCustomerID,
            cust.origCompanyName,
            cust.origContactName,
            cust.origContactTitle,
            cust.origAddress,
            cust.origCity,
            cust.origRegion,
            cust.origPostalCode,
            cust.origCountry,
            cust.origPhone,
            cust.origFax)
    End Sub
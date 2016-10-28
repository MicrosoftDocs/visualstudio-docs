    Private Sub DeleteCustomer(ByVal cust As Customer)

        CustomersTableAdapter.Delete(
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
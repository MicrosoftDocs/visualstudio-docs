        private void AddNewCustomers(Customer currentCustomer)
        {
            customersTableAdapter.Insert( 
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
                currentCustomer.Fax);
        }
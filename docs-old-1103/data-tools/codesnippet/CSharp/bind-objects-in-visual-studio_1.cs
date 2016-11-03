        private void LoadCustomers()
        {
            NorthwindDataSet.CustomersDataTable customerData = 
                customersTableAdapter1.GetTop5Customers();
            
            foreach (NorthwindDataSet.CustomersRow customerRow in customerData)
            {
                Customer currentCustomer = new Customer();
                currentCustomer.CustomerID = customerRow.CustomerID;
                currentCustomer.CompanyName = customerRow.CompanyName;

                if (customerRow.IsAddressNull() == false)
                {
                    currentCustomer.Address = customerRow.Address;
                }

                if (customerRow.IsCityNull() == false)
                {
                    currentCustomer.City = customerRow.City;
                }

                if (customerRow.IsContactNameNull() == false)
                {
                    currentCustomer.ContactName = customerRow.ContactName;
                }

                if (customerRow.IsContactTitleNull() == false)
                {
                    currentCustomer.ContactTitle = customerRow.ContactTitle;
                }

                if (customerRow.IsCountryNull() == false)
                {
                    currentCustomer.Country = customerRow.Country;
                }

                if (customerRow.IsFaxNull() == false)
                {
                    currentCustomer.Fax = customerRow.Fax;
                }

                if (customerRow.IsPhoneNull() == false)
                {
                    currentCustomer.Phone = customerRow.Phone;
                }

                if (customerRow.IsPostalCodeNull() == false)
                {
                    currentCustomer.PostalCode = customerRow.PostalCode;
                }

                if (customerRow.IsRegionNull() == false)
                {
                    currentCustomer.Region = customerRow.Region;
                }

                LoadOrders(currentCustomer);
                customerBindingSource.Add(currentCustomer);
            }
        }
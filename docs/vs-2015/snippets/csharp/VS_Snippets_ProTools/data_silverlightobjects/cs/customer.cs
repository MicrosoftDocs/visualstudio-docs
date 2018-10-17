using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightObjectBinding
{
    //<Snippet1>
    /// <summary>
    /// A single customer
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Creates a new customer
        /// </summary>
        public Customer()
        {
        }

        /// <summary>
        /// Creates a new customer
        /// </summary>
        /// <param name="customerID"></param>
        /// <param name="companyName"></param>
        /// <param name="city"></param>
        public Customer(string customerID, string companyName,
           string city)
        {
            customerIDValue = customerID;
            companyNameValue = companyName;
            cityValue = city;
        }

        private string customerIDValue;
        /// <summary>
        /// The ID that uniquely identifies this customer
        /// </summary>
        public string CustomerID
        {
            get { return customerIDValue; }
            set { customerIDValue = value; }
        }

        private string companyNameValue;
        /// <summary>
        /// The name for this customer
        /// </summary>
        public string CompanyName
        {
            get { return companyNameValue; }
            set { companyNameValue = value; }
        }

        private string cityValue;
        /// <summary>
        /// The city for this customer
        /// </summary>
        public string City
        {
            get { return cityValue; }
            set { cityValue = value; }
        }

        private Orders ordersValue;
        /// <summary>
        /// The orders for this customer
        /// </summary>
        public Orders Orders
        {
            get { return ordersValue; }
            set { ordersValue = value; }
        }

        public override string ToString()
        {
            return this.CompanyName + " (" + this.CustomerID + ")";
        }
    }

    /// <summary>
    /// A collection of Customer objects
    /// </summary>
    public class Customers : System.Collections.Generic.List<Customer>
    {

    }
    //</Snippet1>
}

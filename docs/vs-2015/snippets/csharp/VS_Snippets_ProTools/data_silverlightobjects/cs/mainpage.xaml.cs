using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightObjectBinding
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //<Snippet4>
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            // Do not load your data at design time.
            if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            {
                //Load your data here and assign the result to the CollectionViewSource.
                System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["customersViewSource"];
                myCollectionViewSource.Source = GetCustomers();
            }
        }
        //</Snippet4>

        //<Snippet3>
        // Create sample data.
        private Customers GetCustomers()
        {
            Customers customers = new Customers();

            // Create 3 sample customers,
            // each with 3 sample orders.
            Customer cust1 = new Customer("1", "A Bike Store", "Seattle");
            Orders cust1Orders = new Orders();
            cust1Orders.Add(new Order(1, cust1.CustomerID));
            cust1Orders.Add(new Order(2, cust1.CustomerID));
            cust1Orders.Add(new Order(3, cust1.CustomerID));
            cust1.Orders = cust1Orders;

            Customer cust2 = new Customer("2", "Progressive Sports", "Renton");
            Orders cust2Orders = new Orders();
            cust2Orders.Add(new Order(4, cust2.CustomerID));
            cust2Orders.Add(new Order(5, cust2.CustomerID));
            cust2Orders.Add(new Order(6, cust2.CustomerID));
            cust2.Orders = cust2Orders;

            Customer cust3 = new Customer("3", "Advanced Bike Components", "Irving");
            Orders cust3Orders = new Orders();
            cust3Orders.Add(new Order(7, cust3.CustomerID));
            cust3Orders.Add(new Order(8, cust3.CustomerID));
            cust3Orders.Add(new Order(9, cust3.CustomerID));
            cust3.Orders = cust3Orders;

            // Add the sample customer objects to the 
            // Customers collection.
            customers.Add(cust1);
            customers.Add(cust2);
            customers.Add(cust3);

            return customers;
        }
        //</Snippet3>
    }
}

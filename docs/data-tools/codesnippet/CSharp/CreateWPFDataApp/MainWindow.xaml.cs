using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    //<Snippet1>
    public partial class MainWindow : Window
    {
        NorthwindEntities context = new NorthwindEntities();
        CollectionViewSource custViewSource;
        CollectionViewSource ordViewSource;

        public MainWindow()
        {
            InitializeComponent();
            custViewSource = ((CollectionViewSource)(FindResource("customerViewSource")));
            ordViewSource = ((CollectionViewSource)(FindResource("customerOrdersViewSource")));
            DataContext = this;
        }
        //</Snippet1>

        //<Snippet2>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Load is an extension method on IQueryable,    
            // defined in the System.Data.Entity namespace.   
            // This method enumerates the results of the query,    
            // similar to ToList but without creating a list.   
            // When used with Linq to Entities, this method    
            // creates entity objects and adds them to the context.   
            context.Customers.Load();

            // After the data is loaded, call the DbSet<T>.Local property    
            // to use the DbSet<T> as a binding source.   
            custViewSource.Source = context.Customers.Local;
        }
        //</Snippet2>

        //<Snippet3>
        private void LastCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            custViewSource.View.MoveCurrentToLast();
        }

        private void PreviousCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            custViewSource.View.MoveCurrentToPrevious();
        }

        private void NextCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            custViewSource.View.MoveCurrentToNext();
        }

        private void FirstCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            custViewSource.View.MoveCurrentToFirst();
        }

        private void DeleteCustomerCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            // If existing window is visible, delete the customer and all their orders.  
            // In a real application, you should add warnings and allow the user to cancel the operation.  
            var cur = custViewSource.View.CurrentItem as Customer;

            var cust = (from c in context.Customers
                        where c.CustomerID == cur.CustomerID
                        select c).FirstOrDefault();

            if (cust != null)
            {
                foreach (var ord in cust.Orders.ToList())
                {
                    Delete_Order(ord);
                }
                context.Customers.Remove(cust);
            }
            context.SaveChanges();
            custViewSource.View.Refresh();
        }

        // Commit changes from the new customer form, the new order form,  
        // or edits made to the existing customer form.  
        private void UpdateCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            if (newCustomerGrid.IsVisible)
            {
                // Create a new object because the old one  
                // is being tracked by EF now.  
                Customer newCustomer = new Customer
                {
                    Address = add_addressTextBox.Text,
                    City = add_cityTextBox.Text,
                    CompanyName = add_companyNameTextBox.Text,
                    ContactName = add_contactNameTextBox.Text,
                    ContactTitle = add_contactTitleTextBox.Text,
                    Country = add_countryTextBox.Text,
                    CustomerID = add_customerIDTextBox.Text,
                    Fax = add_faxTextBox.Text,
                    Phone = add_phoneTextBox.Text,
                    PostalCode = add_postalCodeTextBox.Text,
                    Region = add_regionTextBox.Text
                };

                // Perform very basic validation  
                if (newCustomer.CustomerID.Length == 5)
                {
                    // Insert the new customer at correct position:  
                    int len = context.Customers.Local.Count();
                    int pos = len;
                    for (int i = 0; i < len; ++i)
                    {
                        if (String.CompareOrdinal(newCustomer.CustomerID, context.Customers.Local[i].CustomerID) < 0)
                        {
                            pos = i;
                            break;
                        }
                    }
                    context.Customers.Local.Insert(pos, newCustomer);
                    custViewSource.View.Refresh();
                    custViewSource.View.MoveCurrentTo(newCustomer);
                }
                else
                {
                    MessageBox.Show("CustomerID must have 5 characters.");
                }

                newCustomerGrid.Visibility = Visibility.Collapsed;
                existingCustomerGrid.Visibility = Visibility.Visible;
            }
            else if (newOrderGrid.IsVisible)
            {
                // Order ID is auto-generated so we don't set it here.  
                // For CustomerID, address, etc we use the values from current customer.  
                // User can modify these in the datagrid after the order is entered.  

                Customer currentCustomer = (Customer)custViewSource.View.CurrentItem;

                Order newOrder = new Order()
                {
                    OrderDate = add_orderDatePicker.SelectedDate,
                    RequiredDate = add_requiredDatePicker.SelectedDate,
                    ShippedDate = add_shippedDatePicker.SelectedDate,
                    CustomerID = currentCustomer.CustomerID,
                    ShipAddress = currentCustomer.Address,
                    ShipCity = currentCustomer.City,
                    ShipCountry = currentCustomer.Country,
                    ShipName = currentCustomer.CompanyName,
                    ShipPostalCode = currentCustomer.PostalCode,
                    ShipRegion = currentCustomer.Region
                };

                try
                {
                    newOrder.EmployeeID = Int32.Parse(add_employeeIDTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("EmployeeID must be a valid integer value.");
                    return;
                }

                try
                {
                    // Exercise for the reader if you are using Northwind:  
                    // Add the Northwind Shippers table to the model.
                    
                    // Acceptable ShipperID values are 1, 2, or 3.  
                    if (add_ShipViaTextBox.Text == "1" || add_ShipViaTextBox.Text == "2"
                        || add_ShipViaTextBox.Text == "3")
                    {
                        newOrder.ShipVia = Convert.ToInt32(add_ShipViaTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Shipper ID must be 1, 2, or 3 in Northwind.");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Ship Via must be convertible to int");
                    return;
                }

                try
                {
                    newOrder.Freight = Convert.ToDecimal(add_freightTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Freight must be convertible to decimal.");
                    return;
                }

                // Add the order into the EF model  
                context.Orders.Add(newOrder);
                ordViewSource.View.Refresh();
            }

            // Save the changes, either for a new customer, a new order  
            // or an edit to an existing customer or order.
            context.SaveChanges();
        }

        // Sets up the form so that user can enter data. Data is later  
        // saved when user clicks Commit.  
        private void AddCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            existingCustomerGrid.Visibility = Visibility.Collapsed;
            newOrderGrid.Visibility = Visibility.Collapsed;
            newCustomerGrid.Visibility = Visibility.Visible;

            // Clear all the text boxes before adding a new customer.  
            foreach (var child in newCustomerGrid.Children)
            {
                var tb = child as TextBox;
                if (tb != null)
                {
                    tb.Text = "";
                }
            }
        }

        private void NewOrder_click(object sender, RoutedEventArgs e)
        {
            var cust = custViewSource.View.CurrentItem as Customer;
            if (cust == null)
            {
                MessageBox.Show("No customer selected.");
                return;
            }

            existingCustomerGrid.Visibility = Visibility.Collapsed;
            newCustomerGrid.Visibility = Visibility.Collapsed;
            newOrderGrid.UpdateLayout();
            newOrderGrid.Visibility = Visibility.Visible;
        }

        // Cancels any input into the new customer form  
        private void CancelCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            add_addressTextBox.Text = "";
            add_cityTextBox.Text = "";
            add_companyNameTextBox.Text = "";
            add_contactNameTextBox.Text = "";
            add_contactTitleTextBox.Text = "";
            add_countryTextBox.Text = "";
            add_customerIDTextBox.Text = "";
            add_faxTextBox.Text = "";
            add_phoneTextBox.Text = "";
            add_postalCodeTextBox.Text = "";
            add_regionTextBox.Text = "";

            existingCustomerGrid.Visibility = Visibility.Visible;
            newCustomerGrid.Visibility = Visibility.Collapsed;
            newOrderGrid.Visibility = Visibility.Collapsed;
        }

        private void Delete_Order(Order order)
        {
            // Find the order in the EF model.  
            var ord = (from o in context.Orders.Local
                       where o.OrderID == order.OrderID
                       select o).FirstOrDefault();

            // Delete all the order_details that have  
            // this Order as a foreign key  
            foreach (var detail in ord.Order_Details.ToList())
            {
                context.Order_Details.Remove(detail);
            }

            // Now it's safe to delete the order.  
            context.Orders.Remove(ord);
            context.SaveChanges();

            // Update the data grid.  
            ordViewSource.View.Refresh();
        }

        private void DeleteOrderCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            // Get the Order in the row in which the Delete button was clicked.  
            Order obj = e.Parameter as Order;
            Delete_Order(obj);
        }
        //</Snippet3>
    }
}

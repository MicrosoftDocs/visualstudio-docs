using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
//<Snippet1>
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq.Expressions;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Data;
using System.IO;
using Ribbon_Update_At_Runtime.Northwind40DataSetTableAdapters;
//</Snippet1>

namespace Ribbon_Update_At_Runtime
{
    public partial class CustomerRibbon
    {
        //<Snippet2>
        //Declare the Northwind dataset.
        Northwind40DataSet nwDataSet = new Northwind40DataSet();

        //Declare the data tables.

        Northwind40DataSet.CustomersDataTable customerTable;
        Northwind40DataSet.OrdersDataTable orderTable;
        Northwind40DataSet.Order_DetailsDataTable orderDetailsTable;
        Northwind40DataSet.ProductsDataTable productsTable;

        //Declare the data table adapters for each table.

        CustomersTableAdapter customerTableAdapter = new CustomersTableAdapter();
        OrdersTableAdapter ordersTableAdapter = new OrdersTableAdapter();
        Order_DetailsTableAdapter detailsTableAdapter = new Order_DetailsTableAdapter();
        ProductsTableAdapter productsTableAdapter = new ProductsTableAdapter();
        //</Snippet2>

        //<Snippet3>
        private RibbonDropDownItem CreateRibbonDropDownItem()
        {
            return this.Factory.CreateRibbonDropDownItem();
        }
        private RibbonMenu CreateRibbonMenu()
        {
            return this.Factory.CreateRibbonMenu();
        }
        private RibbonButton CreateRibbonButton()
        {
            RibbonButton button = this.Factory.CreateRibbonButton();
            button.Click += new RibbonControlEventHandler(button_Click);
            return button;
        }
        //</Snippet3>
        //<Snippet4>
        private void CustomerRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            customerTable = nwDataSet.Customers;
            customerTableAdapter.Fill(customerTable);

            var customerQuery = from customers in customerTable.AsEnumerable().Take(20)
                                select new
                                {
                                    CustomerID = customers.Field<string>("Customer ID"),
                                    CustomerName = customers.Field<string>("Contact Name")
                                };


            // Execute the query.
            foreach (var item in customerQuery)
            {
                this.comboBox1.Items.Add(CreateRibbonDropDownItem());
                this.comboBox1.Items.Last().Label =
                item.CustomerName + "|" + item.CustomerID.ToString();
            }
            this.comboBox1.Text = this.comboBox1.Items.First().Label;
            PopulateSalesOrderInfo();
        }
        //</Snippet4>
        //<Snippet5>
        private void comboBox1_TextChanged(object sender,
            RibbonControlEventArgs e)
        {
            PopulateSalesOrderInfo();
            PopulateMailItem(comboBox1.Text);
        }
        //</Snippet5>

        //<Snippet6>
        private void PopulateSalesOrderInfo()
        {
            String[] tempArray = comboBox1.Text.Split(new Char[] { '|' });
            menu1.Items.Clear();

            orderTable = nwDataSet.Orders;
            orderDetailsTable = nwDataSet.Order_Details;
            productsTable = nwDataSet.Products;

            ordersTableAdapter.Fill(orderTable);
            detailsTableAdapter.Fill(orderDetailsTable);
            productsTableAdapter.Fill(productsTable);

            var orderQuery = from orders in orderTable.AsEnumerable()
                             where orders.Field<string>("Customer ID") == tempArray[1]
                             select new { OrderID = orders.Field<int>("Order ID") };

            foreach (var orderItem in orderQuery)
            {
                menu1.Items.Add(CreateRibbonMenu());

                RibbonMenu orderMenu = (RibbonMenu)menu1.Items.Last();
                orderMenu.Dynamic = true;
                orderMenu.Label = orderItem.OrderID.ToString();
                orderMenu.Tag = orderItem.OrderID;

                var productQuery = from orderDetail in orderDetailsTable.AsEnumerable()
                                   join product in productsTable.AsEnumerable() on
                                       orderDetail.Field<int>("Product ID")
                                   equals product.Field<int>("Product ID")
                                   where orderDetail.Field<int>("Order ID") ==
                                       orderItem.OrderID
                                   select new { ProductName = product.Field<string>("Product Name") };

                foreach (var productItem in productQuery)
                {
                    RibbonButton button = CreateRibbonButton();
                    button.Label = productItem.ProductName;
                    orderMenu.Items.Add(button);
                }
            }
        }
        //</Snippet6>

        //<Snippet7>
        private void PopulateMailItem(string addressToLine)
        {
            Outlook.Application application = Globals.ThisAddIn.Application;
            Outlook.Inspector inspector = application.ActiveInspector();
            Outlook.MailItem myMailItem = (Outlook.MailItem)inspector.CurrentItem;

            myMailItem.To = "";
            String[] tempArray = addressToLine.Split(new Char[] { '|' });
            myMailItem.To = tempArray[0] + "@example.com";
            myMailItem.Subject = "Following up on your order";
            myMailItem.Body = "Hello " + tempArray[0] + "," +
                "\n" + "We would like to get your feedback on the " +
                "following products that you recently ordered: ";
        }
        //</Snippet7>
        //<Snippet8>
        void button_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Application application = Globals.ThisAddIn.Application;
            Outlook.Inspector inspector = application.ActiveInspector();
            Outlook.MailItem myMailItem = (Outlook.MailItem)inspector.CurrentItem;
            RibbonButton myCheckBox = (RibbonButton)sender;
            myMailItem.Subject = "Following up on your order";
            myMailItem.Body = myMailItem.Body + "\n" + "* " + myCheckBox.Label;
        }
        //</Snippet8>
    }
}

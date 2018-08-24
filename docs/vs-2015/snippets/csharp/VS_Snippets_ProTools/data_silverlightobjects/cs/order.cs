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
    //<Snippet2>
    /// <summary>
    /// A single order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Creates a new order
        /// </summary>
        /// <param name="orderid"></param>
        /// <param name="customerID"></param>
        public Order(int orderid, string customerID)
        {
            orderIDValue = orderid;
            customerIDValue = customerID;
        }

        private int orderIDValue;
        /// <summary>
        /// The ID that uniquely identifies this order
        /// </summary>
        public int OrderID
        {
            get { return orderIDValue; }
            set { orderIDValue = value; }
        }

        private string customerIDValue;
        /// <summary>
        /// The customer who placed this order
        /// </summary>
        public string CustomerID
        {
            get { return customerIDValue; }
            set { customerIDValue = value; }
        }
    }

    /// <summary>
    /// A collection of Order objects
    /// </summary>
    public class Orders : System.Collections.Generic.List<Order>
    {

    }
    //</Snippet2>
}

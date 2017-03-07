using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SP_BDC;

namespace SP_BDC.BdcModel1
{
    public partial class SalesOrderService
    {
        //<Snippet11>
        public static IEnumerable<SalesOrderHeader> ReadList(DateTime OrderDateParam)
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");

            DateTime NoValuePassedIn = Convert.ToDateTime("1/1/1900 12:00:00 AM");
            DateTime DefaultDateTime = Convert.ToDateTime("2001-09-01 00:00:00.000");

            // If the user does not provide a value for the filter.
            if (OrderDateParam == NoValuePassedIn)
            {
                // Use a default date time value.
                OrderDateParam = DefaultDateTime;
            }

            IEnumerable<SalesOrderHeader> SalesOrderHeader =
                from salesOrderHeaders in dataContext.SalesOrderHeaders
                where salesOrderHeaders.OrderDate == OrderDateParam
                select salesOrderHeaders;
            return SalesOrderHeader;
        }
        //</Snippet11>

        public static SalesOrderHeader ReadItem(int salesOrderID)
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");

            SalesOrderHeader SalesOrderHeader =
                (from SalesOrderHeaders in dataContext.SalesOrderHeaders.AsEnumerable().Take(20)
                 where SalesOrderHeaders.SalesOrderID == salesOrderID
                 select SalesOrderHeaders).Single();
            return SalesOrderHeader;
        }
        //<Snippet8>
        public static IEnumerable<Contact> SalesOrderToContact(int salesOrderID)
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");

            int TempContactID = (from orders in dataContext.SalesOrderHeaders
                             where orders.SalesOrderID == salesOrderID
                             select orders.ContactID).Single();

            IEnumerable<Contact> contactList = from contacts in dataContext.Contacts
                                             where contacts.ContactID == TempContactID
                                             select contacts;
            return contactList;

        }
        //</Snippet8>
        public static SalesOrderHeader Create(SalesOrderHeader newSalesOrder)
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");

            SalesOrderHeader salesOrder = new SalesOrderHeader();

    //        salesOrder.SalesOrderID = newSalesOrder.SalesOrderID;
            salesOrder.ContactID = newSalesOrder.ContactID;
           
            dataContext.SalesOrderHeaders.InsertOnSubmit(salesOrder);
            dataContext.SubmitChanges();
            return salesOrder;

        }
   
    }
}

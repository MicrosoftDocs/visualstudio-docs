using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SP_BDC;

namespace SP_BDC.BdcModel1
{
    public partial class SalesOrderDetailService
    {

        public static IEnumerable<SalesOrderDetail> ReadList()
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");

            IEnumerable<SalesOrderDetail> SalesOrderDetail =
                from salesOrderDetails in dataContext.SalesOrderDetails.Take(20)
                select salesOrderDetails;
            return SalesOrderDetail;
        }
        public static SalesOrderDetail ReadItem(int salesOrderID, int salesOrderDetailID)
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");

            SalesOrderDetail SalesOrderDetail =
                (from SalesOrderDetails in dataContext.SalesOrderDetails.AsEnumerable().Take(20)
                 where SalesOrderDetails.SalesOrderID == salesOrderID &&
                 SalesOrderDetails.SalesOrderDetailID == salesOrderDetailID
                 select SalesOrderDetails).Single();
            return SalesOrderDetail;
        }
        //<Snippet6>
        public static void Delete(int salesOrderID, int salesOrderDetailID)
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");

            SalesOrderDetail SalesOrderDetail =
                   (from SalesOrderDetails in dataContext.SalesOrderDetails.AsEnumerable().Take(20)
                    where SalesOrderDetails.SalesOrderID == salesOrderID &&
                    SalesOrderDetails.SalesOrderDetailID == salesOrderDetailID
                    select SalesOrderDetails).Single();

            dataContext.SalesOrderDetails.DeleteOnSubmit(SalesOrderDetail);
            dataContext.SubmitChanges();
        }
        //</Snippet6>
        //<Snippet10>
        public static IEnumerable<Contact> SalesOrderDetailToContact(int salesOrderID, int salesOrderDetailID)
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
        //</Snippet10>
       
        
        
    }
}

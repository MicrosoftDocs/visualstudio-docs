using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SP_BDC;

namespace SP_BDC.BdcModel1
{
    public partial class ContactService
    {
     //<Snippet1>
//nothing.
     //</Snippet1>
     //<Snippet2>
        public static IEnumerable<Contact> ReadList()
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");

            IEnumerable<Contact> Contacts =
                from contacts in dataContext.Contacts.Take(20)
                select contacts;
            return Contacts;

        }
        //</Snippet2>
        //<Snippet3>
        public static Contact ReadItem(int contactID)
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");

            Contact Contact =
                (from contacts in dataContext.Contacts.AsEnumerable().Take(20)
                 where contacts.ContactID == contactID
                 select contacts).Single();
            return Contact;
        }
        //</Snippet3>
        //<Snippet4>
        public static Contact Create(Contact newContact)
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");

            Contact contact = new Contact();

            contact.FirstName = newContact.FirstName;
            contact.LastName = newContact.LastName;
            contact.EmailAddress = newContact.EmailAddress;
            contact.Phone = newContact.Phone;
            contact.EmailPromotion = newContact.EmailPromotion;
            contact.NameStyle = newContact.NameStyle;
            contact.PasswordHash = newContact.PasswordHash;
            contact.PasswordSalt = newContact.PasswordSalt;
            contact.ModifiedDate = DateTime.Now;
            contact.rowguid = Guid.NewGuid();

            dataContext.Contacts.InsertOnSubmit(contact);
            dataContext.SubmitChanges();
            return contact;

        }
        //</Snippet4>
        //<Snippet5>
        public static void Update(Contact contact)
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");
           
            var contactToUpdate = (from contacts in dataContext.Contacts
                                    where contacts.ContactID == contact.ContactID
                                    select contacts).Single();

            contactToUpdate.FirstName = contact.FirstName;
            contactToUpdate.LastName = contact.LastName;
            contactToUpdate.EmailAddress = contact.EmailAddress;
            contactToUpdate.Phone = contact.Phone;
            contactToUpdate.EmailPromotion = contact.EmailPromotion;
            contactToUpdate.NameStyle = contact.NameStyle;
            contactToUpdate.PasswordHash = contact.PasswordHash;
            contactToUpdate.PasswordSalt = contact.PasswordSalt;
            contactToUpdate.ModifiedDate = DateTime.Now;
            contactToUpdate.rowguid = Guid.NewGuid();
            dataContext.SubmitChanges();

        }
        //</Snippet5>
        //<Snippet7>
        public static IEnumerable<SalesOrderHeader> ContactToSalesOrder(int contactID)
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");

            IEnumerable<SalesOrderHeader> orderList = 
                from orders in dataContext.SalesOrderHeaders
                     where orders.ContactID == contactID
                     select orders;
            return orderList;
        }
        //</Snippet7>
        //<Snippet9>
        public static IEnumerable<SalesOrderDetail> ContactToSalesOrderDetail(int contactID)
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");

            IEnumerable<SalesOrderDetail> orderList =
                from orders in dataContext.SalesOrderHeaders
                join orderDetails in dataContext.SalesOrderDetails on
                    orders.SalesOrderID equals orderDetails.SalesOrderID
                where orders.ContactID == contactID
                select orderDetails;
            return orderList;
        }
        //</Snippet9>

        
        
    }
}

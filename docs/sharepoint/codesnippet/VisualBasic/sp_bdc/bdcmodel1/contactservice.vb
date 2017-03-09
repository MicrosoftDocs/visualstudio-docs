Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Partial Public Class ContactService

    '<Snippet1>
    'Nothing
    '</Snippet1>
    '<Snippet2>
    Public Shared Function ReadList() As IEnumerable(Of Contact)
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim Contacts As IEnumerable(Of Contact) = _
            From TempContacts In dataContext.Contacts.Take(20) _
                  Select TempContacts
        Return Contacts
    End Function
    '</Snippet2>
    '<Snippet3>
    Public Shared Function ReadItem(ByVal contactID As Integer) As Contact
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim Contact As Contact = _
            (From TempContacts In dataContext.Contacts.AsEnumerable().Take(20) _
            Where TempContacts.ContactID = contactID _
            Select TempContacts).[Single]()
        Return Contact
    End Function
    '</Snippet3>
    '<Snippet4>
    Public Shared Function Create(ByVal newContact As Contact) As Contact
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim TempContact As New Contact()

        With TempContact
            .FirstName = newContact.FirstName
            .LastName = newContact.LastName
            .EmailAddress = newContact.EmailAddress
            .Phone = newContact.Phone
            .EmailPromotion = newContact.EmailPromotion
            .NameStyle = newContact.NameStyle
            .PasswordHash = newContact.PasswordHash
            .PasswordSalt = newContact.PasswordSalt
            .ModifiedDate = DateTime.Now
            .rowguid = Guid.NewGuid()
        End With

        dataContext.Contacts.InsertOnSubmit(TempContact)
        dataContext.SubmitChanges()
        Return TempContact

    End Function
    '</Snippet4>
    '<Snippet5>
    Public Shared Sub Update(ByVal contact As Contact)
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim ContactToUpdate As Contact = (From Contacts In dataContext.Contacts.AsEnumerable().Take(20) _
             Where Contacts.ContactID = contact.ContactID _
             Select Contacts).Single()

        With ContactToUpdate
            .FirstName = contact.FirstName
            .LastName = contact.LastName
            .EmailAddress = contact.EmailAddress
            .Phone = contact.Phone
            .EmailPromotion = contact.EmailPromotion
            .NameStyle = contact.NameStyle
            .PasswordHash = contact.PasswordHash
            .PasswordSalt = contact.PasswordSalt
        End With

        dataContext.SubmitChanges()

    End Sub
    '</Snippet5>
    '<Snippet7>
    Public Shared Function ContactToSalesOrder(ByVal contactID As Integer) As IEnumerable(Of SalesOrderHeader)
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim orderList As IEnumerable(Of SalesOrderHeader) = _
            From orders In dataContext.SalesOrderHeaders _
            Where orders.ContactID = contactID _
                  Select orders
        Return orderList

    End Function
    '</Snippet7>
    '<Snippet9>
    Public Shared Function ContactToSalesOrderDetail(ByVal contactID As Integer) As IEnumerable(Of SalesOrderDetail)
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim orderList As IEnumerable(Of SalesOrderDetail) = _
            From orders In dataContext.SalesOrderHeaders _
            Join orderDetails In dataContext.SalesOrderDetails On _
                orders.SalesOrderID Equals orderDetails.SalesOrderID _
            Where orders.ContactID = contactID _
            Select orderDetails
        Return orderList

    End Function
    '</Snippet9>
End Class

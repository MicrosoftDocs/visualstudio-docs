Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Partial Public Class SalesOrderService

    '<Snippet11>
    Public Shared Function ReadList(ByVal OrderDateParam As DateTime) As IEnumerable(Of SalesOrderHeader)
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim NoValuePassedIn As DateTime = Convert.ToDateTime("1/1/1900 12:00:00 AM")
        Dim DefaultDateTime As DateTime = Convert.ToDateTime("2001-09-01 00:00:00.000")

        ' If the user does not provide a value for the filter.
        If OrderDateParam = NoValuePassedIn Then
            ' Use a default date time value.
            OrderDateParam = DefaultDateTime
        End If

        Dim SalesOrderHeader As IEnumerable(Of SalesOrderHeader) = _
            From SalesOrderHeaders In dataContext.SalesOrderHeaders _
            Where SalesOrderHeaders.OrderDate = OrderDateParam _
            Select SalesOrderHeaders
        Return SalesOrderHeader
    End Function
    '</Snippet11>
    Public Shared Function ReadItem(ByVal salesOrderID As Integer) As SalesOrderHeader
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim SalesOrderHeader As SalesOrderHeader = _
            (From SalesOrderHeaders In dataContext.SalesOrderHeaders.AsEnumerable().Take(20) _
            Where SalesOrderHeaders.SalesOrderID = salesOrderID _
            Select SalesOrderHeaders).[Single]()
        Return SalesOrderHeader
    End Function

    '<Snippet8>
    Public Shared Function SalesOrderToContact(ByVal salesOrderID As Integer) As IEnumerable(Of Contact)

        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim TempContactID As Integer = _
            (From orders In dataContext.SalesOrderHeaders _
            Where orders.SalesOrderID = salesOrderID _
            Select orders.ContactID).[Single]()

        Dim contactList As IEnumerable(Of Contact) = _
            From contacts In dataContext.Contacts _
            Where contacts.ContactID = TempContactID _
            Select contacts
        Return contactList

    End Function
    '</Snippet8>
End Class

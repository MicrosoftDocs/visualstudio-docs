Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Partial Public Class SalesOrderDetailService

    Public Shared Function ReadList() As IEnumerable(Of SalesOrderDetail)
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim SalesOrderDetail As IEnumerable(Of SalesOrderDetail) = _
            From SalesOrderDetails In dataContext.SalesOrderDetails.Take(20) _
                  Select SalesOrderDetails
        Return SalesOrderDetail
    End Function

    Public Shared Function ReadItem(ByVal salesOrderID As Integer, ByVal salesOrderDetailID As Integer) As SalesOrderDetail
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim SalesOrderDetail As SalesOrderDetail = _
            (From SalesOrderDetails In dataContext.SalesOrderDetails.AsEnumerable().Take(20) _
            Where SalesOrderDetails.SalesOrderID = salesOrderID And _
                  SalesOrderDetails.SalesOrderDetailID = salesOrderDetailID _
            Select SalesOrderDetails).Single()
        Return SalesOrderDetail
    End Function

    '<Snippet6>
    Public Shared Sub Delete(ByVal salesOrderID As Integer, ByVal salesOrderDetailID As Integer)
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim SalesOrderDetail As SalesOrderDetail = _
            (From SalesOrderDetails In dataContext.SalesOrderDetails.AsEnumerable().Take(20) _
            Where SalesOrderDetails.SalesOrderID = salesOrderID And _
                  SalesOrderDetails.SalesOrderDetailID = salesOrderDetailID _
            Select SalesOrderDetails).Single()

        dataContext.SalesOrderDetails.DeleteOnSubmit(SalesOrderDetail)
        dataContext.SubmitChanges()

    End Sub
    '</Snippet6>
    '<Snippet10>
    Public Shared Function SalesOrderDetailToContact(ByVal salesOrderID As Integer, ByVal salesOrderDetailID As Integer) As IEnumerable(Of Contact)
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
    '</Snippet10>
End Class

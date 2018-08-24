'<Snippet2>
''' <summary>
''' A single order
''' </summary>
Public Class Order

    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new order
    ''' </summary>
    ''' <param name="orderid">The identifier for this order</param>
    ''' <param name="customerID">The customer who placed this order</param>
    Public Sub New(ByVal orderid As Integer,
                   ByVal customerID As String)
        orderIDValue = orderid
        customerIDValue = customerID
    End Sub

    Private orderIDValue As Integer
    ''' <summary>
    ''' Identifier for this order
    ''' </summary>
    Public Property OrderID() As Integer
        Get
            Return orderIDValue
        End Get
        Set(ByVal value As Integer)
            orderIDValue = value
        End Set
    End Property

    Private customerIDValue As String
    ''' <summary>
    ''' The customer who placed this order
    ''' </summary>
    Public Property CustomerID() As String
        Get
            Return customerIDValue
        End Get
        Set(ByVal Value As String)
            customerIDValue = Value
        End Set
    End Property
End Class

''' <summary>
''' A collection of Orders
''' </summary>
Public Class Orders
    Inherits System.Collections.Generic.List(Of Order)

End Class
'</Snippet2>

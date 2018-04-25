'<Snippet1>
''' <summary>
''' A single customer
''' </summary>
Public Class Customer

    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new customer
    ''' </summary>
    ''' <param name="customerId">The ID that uniquely identifies this customer</param>
    ''' <param name="companyName">The name for this customer</param>
    ''' <param name="city">The city for this customer</param>
    Public Sub New(ByVal customerId As String,
                   ByVal companyName As String,
                   ByVal city As String)
        customerIDValue = customerId
        companyNameValue = companyName
        cityValue = city
    End Sub

    Private customerIDValue As String
    ''' <summary>
    ''' The ID that uniquely identifies this customer
    ''' </summary>
    Public Property CustomerID() As String
        Get
            Return customerIDValue
        End Get
        Set(ByVal value As String)
            customerIDValue = value
        End Set
    End Property

    Private companyNameValue As String
    ''' <summary>
    ''' The name for this customer
    ''' </summary>
    Public Property CompanyName() As String
        Get
            Return companyNameValue
        End Get
        Set(ByVal Value As String)
            companyNameValue = Value
        End Set
    End Property

    Private cityValue As String
    ''' <summary>
    ''' The city for this customer
    ''' </summary>
    Public Property City() As String
        Get
            Return cityValue
        End Get
        Set(ByVal Value As String)
            cityValue = Value
        End Set
    End Property

    Private ordersValue As Orders
    ''' <summary>
    ''' The orders for this customer
    ''' </summary>
    Public Property Orders As Orders
        Get
            Return ordersValue
        End Get
        Set(ByVal value As Orders)
            ordersValue = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return Me.CompanyName & " (" & Me.CustomerID & ")"
    End Function
End Class


''' <summary>
''' A collection of Customer objects.
''' </summary>
''' <remarks></remarks>
Public Class Customers
    Inherits System.Collections.Generic.List(Of Customer)

End Class
'</Snippet1>

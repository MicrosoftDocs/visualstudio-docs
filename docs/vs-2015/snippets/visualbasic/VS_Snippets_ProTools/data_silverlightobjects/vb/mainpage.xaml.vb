Partial Public Class MainPage
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    '<Snippet4>
    Private Sub UserControl_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

        'Do not load your data at design time.
        If Not (System.ComponentModel.DesignerProperties.GetIsInDesignMode(Me)) Then
            'Load your data here and assign the result to the CollectionViewSource.
            Dim myCollectionViewSource As System.Windows.Data.CollectionViewSource = CType(Me.Resources("CustomersViewSource"), System.Windows.Data.CollectionViewSource)
            myCollectionViewSource.Source = GetCustomers()
        End If
    End Sub
    '</Snippet4>

    '<Snippet3>
    ' Create sample data.
    Private Function GetCustomers() As Customers

        Dim customers As New Customers

        ' Create 3 sample customers,
        ' each with 3 sample orders.
        Dim cust1 As New Customer("1", "A Bike Store", "Seattle")
        Dim cust1Orders As New Orders
        cust1Orders.Add(New Order(1, cust1.CustomerID))
        cust1Orders.Add(New Order(2, cust1.CustomerID))
        cust1Orders.Add(New Order(3, cust1.CustomerID))
        cust1.Orders = cust1Orders

        Dim cust2 As New Customer("2", "Progressive Sports", "Renton")
        Dim cust2Orders As New Orders
        cust2Orders.Add(New Order(4, cust2.CustomerID))
        cust2Orders.Add(New Order(5, cust2.CustomerID))
        cust2Orders.Add(New Order(6, cust2.CustomerID))
        cust2.Orders = cust2Orders

        Dim cust3 As New Customer("3", "Advanced Bike Components", "Irving")
        Dim cust3Orders As New Orders
        cust3Orders.Add(New Order(7, cust3.CustomerID))
        cust3Orders.Add(New Order(8, cust3.CustomerID))
        cust3Orders.Add(New Order(9, cust3.CustomerID))
        cust3.Orders = cust3Orders

        ' Add the sample customer objects to the 
        ' Customers collection.
        customers.Add(cust1)
        customers.Add(cust2)
        customers.Add(cust3)

        Return customers
    End Function
    '</Snippet3>
End Class
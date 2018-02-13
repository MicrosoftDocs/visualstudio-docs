Imports Microsoft.Office.Tools.Ribbon

'<Snippet1>
Imports System.Data.Linq
Imports System.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq.Expressions
Imports Outlook = Microsoft.Office.Interop.Outlook
Imports Ribbon_Update_At_Runtime.Northwind40DataSetTableAdapters
'</Snippet1>

Public Class CustomerRibbon
    '<Snippet2>
    'Declare the Northwind data set.

    Dim nwDataSet As Northwind40DataSet = New Northwind40DataSet()

    'Declare the data tables.

    Dim customerTable As Northwind40DataSet.CustomersDataTable
    Dim orderTable As Northwind40DataSet.OrdersDataTable
    Dim orderDetailsTable As Northwind40DataSet.Order_DetailsDataTable
    Dim productsTable As Northwind40DataSet.ProductsDataTable

    'Declare the data table adapters for each table.

    Dim customersTableAdapter As CustomersTableAdapter = New CustomersTableAdapter()
    Dim ordersTableAdapter As OrdersTableAdapter = New OrdersTableAdapter()
    Dim detailsTableAdapter As Order_DetailsTableAdapter = New Order_DetailsTableAdapter()
    Dim productsTableAdapter As ProductsTableAdapter = New ProductsTableAdapter()

    '</Snippet2>

    '<Snippet3>

    Private Function CreateRibbonDropDownItem() As RibbonDropDownItem
        Return Me.Factory.CreateRibbonDropDownItem()
    End Function

    Private Function CreateRibbonMenu() As RibbonMenu
        Return Me.Factory.CreateRibbonMenu()
    End Function

    Private Function CreateRibbonButton() As RibbonButton
        Dim button As RibbonButton = Me.Factory.CreateRibbonButton()
        AddHandler (button.Click), AddressOf Button_Click
        Return button
    End Function
    '</Snippet3>

    '<Snippet4>
    Private Sub CustomerRibbon_Load(ByVal sender As System.Object, _
   ByVal e As Microsoft.Office.Tools.Ribbon.RibbonUIEventArgs) _
       Handles MyBase.Load

        customerTable = nwDataSet.Customers
        customersTableAdapter.Fill(customerTable)

        Dim customerQuery = From customers In customerTable.AsEnumerable.Take(20) _
                Select CustomerID = customers.Customer_ID, _
                CustomerName = customers.Contact_Name

        ' Execute the query.
        For Each item In customerQuery
            Me.ComboBox1.Items.Add(CreateRibbonDropDownItem())

            Me.ComboBox1.Items.Last().Label = item.CustomerID.ToString() _
                + "|" + item.CustomerName
        Next item

        Me.ComboBox1.Text = Me.ComboBox1.Items.First().Label
        PopulateSalesOrderInfo()
    End Sub

    '</Snippet4>

    '<Snippet5>
    Private Sub ComboBox1_TextChanged(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) _
            Handles ComboBox1.TextChanged
        PopulateSalesOrderInfo()
        PopulateMailItem(ComboBox1.Text)
    End Sub
    '</Snippet5>

    '<Snippet6>
    Private Sub PopulateSalesOrderInfo()

        Dim tempArray As [String]() = comboBox1.Text.Split(New [Char]() {"|"c})
        Menu1.Items.Clear()

        orderTable = nwDataSet.Orders
        orderDetailsTable = nwDataSet.Order_Details
        productsTable = nwDataSet.Products

        ordersTableAdapter.Fill(orderTable)
        detailsTableAdapter.Fill(orderDetailsTable)
        productsTableAdapter.Fill(productsTable)

        Dim orderQuery = From order In orderTable.AsEnumerable() _
                         Where order.Customer_ID.ToString() = tempArray(0) _
                         Select New With {.SalesOrderID = order.Order_ID}

        For Each orderItem In orderQuery
            Me.Menu1.Items.Add(CreateRibbonMenu())

            Dim orderMenu As RibbonMenu = CType(Menu1.Items.Last(), RibbonMenu)
            orderMenu.Dynamic = True
            orderMenu.Label = orderItem.SalesOrderID.ToString()
            orderMenu.Tag = orderItem.SalesOrderID

            Dim productQuery = From orderDetail In orderDetailsTable.AsEnumerable(), _
                                   product In productsTable.AsEnumerable() _
                               Where orderDetail.Product_ID = _
                                   product.Product_ID _
                               And orderDetail.Order_ID = _
                               orderMenu.Tag _
            Select productName = product.Product_Name

            For Each productItem In productQuery
                Dim button As RibbonButton = CreateRibbonButton()
                button.Label = productItem
                orderMenu.Items.Add(button)
            Next productItem
        Next orderItem
    End Sub
    '</Snippet6>

    '<Snippet7>
    Private Sub PopulateMailItem(ByVal addressToLine As String)
        Dim application As Outlook.Application = Globals.ThisAddIn.Application
        Dim inspector As Outlook.Inspector = application.ActiveInspector()
        Dim myMailItem As Outlook.MailItem = _
            CType(inspector.CurrentItem, Outlook.MailItem)

        myMailItem.To = ""
        Dim tempArray As [String]() = addressToLine.Split(New [Char]() {"|"c})
        myMailItem.To = tempArray(1) + "@example.com"
        myMailItem.Subject = "Following up on your order"
        myMailItem.Body = "Hello " + tempArray(1) + "," _
            + ControlChars.Lf + "We would like to get your feedback" + _
            "on the following products that you recently ordered: "
    End Sub
    '</Snippet7>

    '<Snippet8>
    Private Sub Button_Click(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs)
        Dim application As Outlook.Application = Globals.ThisAddIn.Application
        Dim inspector As Outlook.Inspector = application.ActiveInspector()
        Dim myMailItem As Outlook.MailItem = CType(inspector.CurrentItem,  _
            Outlook.MailItem)
        Dim myButton As RibbonButton = CType(sender, RibbonButton)
        myMailItem.Subject = "Following up on your order"
        myMailItem.Body = myMailItem.Body + ControlChars.Lf + "* " _
            + myButton.Label
    End Sub
    '</Snippet8>
End Class

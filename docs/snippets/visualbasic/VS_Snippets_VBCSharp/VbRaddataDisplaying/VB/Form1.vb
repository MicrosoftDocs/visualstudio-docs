Public Class Form1

    Sub test()
        '<Snippet6>
        CustomersBindingSource.Filter = "CompanyName like 'B'"
        '</Snippet6>

        '<Snippet7>
        CustomersBindingSource.Sort = "CompanyName Desc"
        '</Snippet7>
    End Sub


    '<Snippet2>
    Private Sub CustomersDataGridView_DoubleClick() Handles CustomersDataGridView.DoubleClick

        Dim SelectedRowView As Data.DataRowView
        Dim SelectedRow As northwndDataSet.CustomersRow

        SelectedRowView = CType(CustomersBindingSource.Current, System.Data.DataRowView)
        SelectedRow = CType(SelectedRowView.Row, northwndDataSet.CustomersRow)

        Dim OrdersForm As New Form2
        OrdersForm.LoadOrders(SelectedRow.CustomerID)
        OrdersForm.Show()
    End Sub
    '</Snippet2>


    Private Sub CustomersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.CustomersTableAdapter.Update(Me.northwndDataSet.Customers)
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'northwndDataSet1.Customers' table. You can move, or remove it, as needed.
        'Me.CustomersTableAdapter1.Fill(Me.northwndDataSet1.Customers)
    End Sub
End Class

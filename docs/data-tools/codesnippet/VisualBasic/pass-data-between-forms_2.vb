    Private Sub CustomersDataGridView_DoubleClick() Handles CustomersDataGridView.DoubleClick

        Dim SelectedRowView As Data.DataRowView
        Dim SelectedRow As NorthwindDataSet.CustomersRow

        SelectedRowView = CType(CustomersBindingSource.Current, System.Data.DataRowView)
        SelectedRow = CType(SelectedRowView.Row, NorthwindDataSet.CustomersRow)

        Dim OrdersForm As New Form2
        OrdersForm.LoadOrders(SelectedRow.CustomerID)
        OrdersForm.Show()
    End Sub
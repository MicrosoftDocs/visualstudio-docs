    Private Sub CustomersBindingNavigatorSaveItem_Click() Handles CustomersBindingNavigatorSaveItem.Click
        UpdateData()
    End Sub

    Private Sub UpdateData()
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.OrdersBindingSource.EndEdit()

        Using updateTransaction As New Transactions.TransactionScope

            DeleteOrders()
            DeleteCustomers()
            AddNewCustomers()
            AddNewOrders()

            updateTransaction.Complete()
            NorthwindDataSet.AcceptChanges()
        End Using
    End Sub
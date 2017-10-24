    Private Sub DeleteOrders()

        Dim deletedOrders As NorthwindDataSet.OrdersDataTable
        deletedOrders = CType(NorthwindDataSet.Orders.GetChanges(Data.DataRowState.Deleted),
            NorthwindDataSet.OrdersDataTable)

        If Not IsNothing(deletedOrders) Then
            Try
                OrdersTableAdapter.Update(deletedOrders)

            Catch ex As Exception
                MessageBox.Show("DeleteOrders Failed")
            End Try
        End If
    End Sub
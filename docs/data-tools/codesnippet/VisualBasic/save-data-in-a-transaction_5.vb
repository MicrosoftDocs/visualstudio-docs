    Private Sub AddNewOrders()

        Dim newOrders As NorthwindDataSet.OrdersDataTable
        newOrders = CType(NorthwindDataSet.Orders.GetChanges(Data.DataRowState.Added),
            NorthwindDataSet.OrdersDataTable)

        If Not IsNothing(newOrders) Then
            Try
                OrdersTableAdapter.Update(newOrders)

            Catch ex As Exception
                MessageBox.Show("AddNewOrders Failed" & vbCrLf & ex.Message)
            End Try
        End If
    End Sub
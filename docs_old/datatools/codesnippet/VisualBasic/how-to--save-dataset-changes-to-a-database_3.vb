    Private Sub UpdateDB()
        Dim deletedChildRecords As NorthwindDataSet.OrdersDataTable =
            CType(NorthwindDataSet.Orders.GetChanges(Data.DataRowState.Deleted), NorthwindDataSet.OrdersDataTable)

        Dim newChildRecords As NorthwindDataSet.OrdersDataTable =
            CType(NorthwindDataSet.Orders.GetChanges(Data.DataRowState.Added), NorthwindDataSet.OrdersDataTable)

        Dim modifiedChildRecords As NorthwindDataSet.OrdersDataTable =
            CType(NorthwindDataSet.Orders.GetChanges(Data.DataRowState.Modified), NorthwindDataSet.OrdersDataTable)

        Try
            If deletedChildRecords IsNot Nothing Then
                OrdersTableAdapter.Update(deletedChildRecords)
            End If

            CustomersTableAdapter.Update(NorthwindDataSet.Customers)

            If newChildRecords IsNot Nothing Then
                OrdersTableAdapter.Update(newChildRecords)
            End If

            If modifiedChildRecords IsNot Nothing Then
                OrdersTableAdapter.Update(modifiedChildRecords)
            End If

            NorthwindDataSet.AcceptChanges()

        Catch ex As Exception
            MessageBox.Show("An error occurred during the update process")
            ' Add code to handle error here.

        Finally
            If deletedChildRecords IsNot Nothing Then
                deletedChildRecords.Dispose()
            End If

            If newChildRecords IsNot Nothing Then
                newChildRecords.Dispose()
            End If

            If modifiedChildRecords IsNot Nothing Then
                modifiedChildRecords.Dispose()
            End If

        End Try
    End Sub
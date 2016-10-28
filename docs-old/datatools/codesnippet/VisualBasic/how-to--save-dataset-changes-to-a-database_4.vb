    Private Sub UpdateDB()
        Dim DeletedChildRecords As DataTable =
            dsNorthwind1.Orders.GetChanges(DataRowState.Deleted)

        Dim NewChildRecords As DataTable =
            dsNorthwind1.Orders.GetChanges(DataRowState.Added)

        Dim ModifiedChildRecords As DataTable =
            dsNorthwind1.Orders.GetChanges(DataRowState.Modified)

        Try
            If Not DeletedChildRecords Is Nothing Then
                daOrders.Update(DeletedChildRecords)
            End If

            daCustomers.Update(dsNorthwind1, "Customers")

            If Not NewChildRecords Is Nothing Then
                daOrders.Update(NewChildRecords)
            End If

            If Not ModifiedChildRecords Is Nothing Then
                daOrders.Update(ModifiedChildRecords)
            End If

            dsNorthwind1.AcceptChanges()

        Catch ex As Exception
            ' Update error, resolve and try again

        Finally
            If Not DeletedChildRecords Is Nothing Then
                DeletedChildRecords.Dispose()
            End If

            If Not NewChildRecords Is Nothing Then
                NewChildRecords.Dispose()
            End If

            If Not ModifiedChildRecords Is Nothing Then
                ModifiedChildRecords.Dispose()
            End If
        End Try
    End Sub
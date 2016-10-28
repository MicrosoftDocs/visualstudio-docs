    Private Sub DeleteCustomers()

        Dim deletedCustomers As NorthwindDataSet.CustomersDataTable
        deletedCustomers = CType(NorthwindDataSet.Customers.GetChanges(Data.DataRowState.Deleted),
            NorthwindDataSet.CustomersDataTable)

        If Not IsNothing(deletedCustomers) Then
            Try
                CustomersTableAdapter.Update(deletedCustomers)

            Catch ex As Exception
                MessageBox.Show("DeleteCustomers Failed" & vbCrLf & ex.Message)
            End Try
        End If
    End Sub
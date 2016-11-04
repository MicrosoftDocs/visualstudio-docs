    Private Sub AddNewCustomers()

        Dim newCustomers As NorthwindDataSet.CustomersDataTable
        newCustomers = CType(NorthwindDataSet.Customers.GetChanges(Data.DataRowState.Added),
            NorthwindDataSet.CustomersDataTable)

        If Not IsNothing(newCustomers) Then
            Try
                CustomersTableAdapter.Update(newCustomers)

            Catch ex As Exception
                MessageBox.Show("AddNewCustomers Failed" & vbCrLf & ex.Message)
            End Try
        End If
    End Sub
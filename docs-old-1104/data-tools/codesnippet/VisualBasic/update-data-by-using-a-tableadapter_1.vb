        Try
            Me.Validate()
            Me.CustomersBindingSource.EndEdit()
            Me.CustomersTableAdapter.Update(Me.NorthwindDataSet.Customers)
            MsgBox("Update successful")

        Catch ex As Exception
            MsgBox("Update failed")
        End Try
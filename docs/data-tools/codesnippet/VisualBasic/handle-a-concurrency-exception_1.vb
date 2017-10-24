    Private Sub UpdateDatabase()

        Try
            Me.CustomersTableAdapter.Update(Me.NorthwindDataSet.Customers)
            MsgBox("Update successful")

        Catch dbcx As Data.DBConcurrencyException
            Dim response As Windows.Forms.DialogResult

            response = MessageBox.Show(CreateMessage(CType(dbcx.Row, NorthwindDataSet.CustomersRow)),
                "Concurrency Exception", MessageBoxButtons.YesNo)

            ProcessDialogResult(response)

        Catch ex As Exception
            MsgBox("An error was thrown while attempting to update the database.")
        End Try
    End Sub
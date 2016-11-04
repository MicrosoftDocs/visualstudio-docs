        Using updateTransaction As New Transactions.TransactionScope

            ' Add code to save your data here.
            ' Throw an exception to roll back the transaction.

            ' Call the Complete method to commit the transaction
            updateTransaction.Complete()
        End Using
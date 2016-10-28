            using (System.Transactions.TransactionScope updateTransaction = 
                new System.Transactions.TransactionScope())
            {
                // Add code to save your data here.
                // Throw an exception to roll back the transaction.

                // Call the Complete method to commit the transaction
                updateTransaction.Complete();
            }
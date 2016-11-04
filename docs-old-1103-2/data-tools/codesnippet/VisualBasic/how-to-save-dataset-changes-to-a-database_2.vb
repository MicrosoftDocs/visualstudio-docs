        Try
            SqlDataAdapter1.Update(Dataset1.Tables("Table1"))

        Catch x As Exception
            ' Error during Update, add code to locate error, reconcile 
            ' and try to update again.
        End Try
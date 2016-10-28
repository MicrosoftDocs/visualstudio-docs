            try
            {
                SqlDataAdapter1.Update(Dataset1.Tables["Table1"]);
            }
            catch (Exception e)
            {
                // Error during Update, add code to locate error, reconcile 
                // and try to update again.
            }
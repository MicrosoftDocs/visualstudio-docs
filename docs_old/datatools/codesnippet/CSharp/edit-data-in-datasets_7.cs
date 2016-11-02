        private void FindErrors() 
        {
            if (dataSet1.HasErrors)
            {
                foreach (DataTable table in dataSet1.Tables)
                {
                    if (table.HasErrors)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            if (row.HasErrors)
                            {
                                // Process error here.
                            }
                        }
                    }
                }
            }
        }
            string s = "primaryKeyValue";
            DataRow foundRow = dataSet1.Tables["AnyTable"].Rows.Find(s);

            if (foundRow != null) 
            {
                MessageBox.Show(foundRow[0].ToString());
            }
            else
            {
                MessageBox.Show("A row with the primary key of " + s + " could not be found");
            }
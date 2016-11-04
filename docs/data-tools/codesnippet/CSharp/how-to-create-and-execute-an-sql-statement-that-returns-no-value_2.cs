            SqlConnection sqlConnection1 = new SqlConnection("Your Connection String");
            SqlCommand cmd = new SqlCommand();
            Int32 rowsAffected;
            
            cmd.CommandText = "UPDATE Customers SET ContactTitle = 'Sales Manager' WHERE CustomerID = 'ALFKI'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            rowsAffected = cmd.ExecuteNonQuery();

            sqlConnection1.Close();
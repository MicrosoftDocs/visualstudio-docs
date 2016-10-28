            SqlConnection sqlConnection1 = new SqlConnection("Your Connection String");
            SqlCommand cmd = new SqlCommand();
            Object returnValue;
            
            cmd.CommandText = "SELECT COUNT(*) FROM Customers";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            returnValue = cmd.ExecuteScalar();

            sqlConnection1.Close();
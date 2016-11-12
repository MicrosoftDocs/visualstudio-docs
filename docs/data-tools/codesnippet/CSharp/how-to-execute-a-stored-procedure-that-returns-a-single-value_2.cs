            SqlConnection sqlConnection1 = new SqlConnection("Your Connection String");
            SqlCommand cmd = new SqlCommand();
            Object returnValue;
            
            cmd.CommandText = "StoredProcedureName";
            cmd.CommandType = CommandType. StoredProcedure;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            returnValue = cmd.ExecuteScalar();

            sqlConnection1.Close();
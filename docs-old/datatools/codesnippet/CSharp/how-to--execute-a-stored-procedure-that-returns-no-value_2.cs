            SqlConnection sqlConnection1 = new SqlConnection("Your Connection String");
            SqlCommand cmd = new SqlCommand();
            Int32 rowsAffected;
            
            cmd.CommandText = "StoredProcedureName";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            rowsAffected = cmd.ExecuteNonQuery();

            sqlConnection1.Close();
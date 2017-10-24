            System.Data.SqlClient.SqlConnection sqlConnection1 = 
                new System.Data.SqlClient.SqlConnection("YOUR CONNECTION STRING ");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "DELETE Region WHERE RegionID = 5 AND RegionDescription = 'NorthWestern'";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
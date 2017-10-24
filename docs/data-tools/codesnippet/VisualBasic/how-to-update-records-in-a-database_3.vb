        Dim sqlConnection1 As New System.Data.SqlClient.SqlConnection("YOUR CONNECTION STRING")

        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "UPDATE Region SET [RegionDescription] = @RegionDescription WHERE [RegionID] = @RegionID"
        cmd.Parameters.AddWithValue("@RegionDescription", "East")
        cmd.Parameters.AddWithValue("@RegionID", "1")
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()
        cmd.ExecuteNonQuery()
        sqlConnection1.Close()
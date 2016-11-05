        Dim sqlConnection1 As New System.Data.SqlClient.SqlConnection("YOUR CONNECTION STRING")

        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "INSERT Region (RegionID, RegionDescription) VALUES (5, 'NorthWestern')"
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()
        cmd.ExecuteNonQuery()
        sqlConnection1.Close()
        Dim sqlConnection1 As New SqlConnection("Your Connection String")
        Dim cmd As New SqlCommand
        Dim rowsAffected As Integer

        cmd.CommandText = "StoredProcedureName"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()

        rowsAffected = cmd.ExecuteNonQuery()

        sqlConnection1.Close()
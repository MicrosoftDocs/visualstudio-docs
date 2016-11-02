        Dim sqlConnection1 As New SqlConnection("Your Connection String")
        Dim cmd As New SqlCommand
        Dim returnValue As Object

        cmd.CommandText = "StoredProcedureName"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()

        returnValue = cmd.ExecuteScalar()

        sqlConnection1.Close()
        Dim sqlConnection1 As New SqlConnection("Your Connection String")
        Dim cmd As New SqlCommand
        Dim rowsAffected As Integer

        cmd.CommandText = "UPDATE Customers SET ContactTitle = 'Sales Manager' WHERE CustomerID = 'ALFKI'"
        cmd.CommandType = CommandType.Text
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()

        rowsAffected = cmd.ExecuteNonQuery()

        sqlConnection1.Close()
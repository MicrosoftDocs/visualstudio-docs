Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FillOrCancel

    '<Snippet1>
    ' Storage for OrderID.  
    Private parsedOrderID As Integer

    ''' <summary>
    ''' Verifies that OrderID is valid.
    ''' </summary>
    Private Function IsOrderIDValid() As Boolean

        ' Check for input in the Order ID text box.  
        If txtOrderID.Text = "" Then
            MessageBox.Show("Please specify the Order ID.")
            Return False

            ' Check for characters other than integers.  
        ElseIf Regex.IsMatch(txtOrderID.Text, "^\D*$") Then
            ' Show message and clear input.  
            MessageBox.Show("Please specify integers only.")
            txtOrderID.Clear()
            Return False
        Else
            ' Convert the text in the text box to an integer to send to the database.  
            parsedOrderID = Int32.Parse(txtOrderID.Text)
            Return True
        End If
    End Function
    '</Snippet1>

    '<Snippet2>
    ''' <summary>
    ''' Executes a t-SQL SELECT query on the database to
    ''' obtain order data for a specified order ID.
    ''' </summary>
    Private Sub btnFindByOrderID_Click(sender As Object, e As EventArgs) Handles btnFindByOrderID.Click

        ' Prepare the connection and the command.
        If IsOrderIDValid() Then

            ' Create the connection.  
            Using connection As New SqlConnection(My.Settings.connString)

                ' Define the query string that has a parameter for orderID.  
                Const sql As String = "select * from Sales.Orders where orderID = @orderID"

                ' Create a SqlCommand object.  
                Using sqlCommand As New SqlCommand(sql, connection)

                    ' Define the @orderID parameter and its value.  
                    sqlCommand.Parameters.Add(New SqlParameter("@orderID", SqlDbType.Int))
                    sqlCommand.Parameters("@orderID").Value = parsedOrderID

                    Try
                        ' Open connection.  
                        connection.Open()

                        ' Execute the query.  
                        Dim dataReader As SqlDataReader = sqlCommand.ExecuteReader()

                        ' Create a data table to hold the retrieved data.  
                        Dim dataTable As New DataTable()

                        ' Load the data from SqlDataReader into the data table.  
                        dataTable.Load(dataReader)

                        ' Display the data from the data table in the data grid view.  
                        Me.dgvCustomerOrders.DataSource = dataTable

                        ' Close the SqlDataReader.  
                        dataReader.Close()
                    Catch
                        MessageBox.Show("The requested order could not be loaded into the form.")
                    Finally
                        ' Close the connection.  
                        connection.Close()
                    End Try
                End Using
            End Using
        End If
    End Sub

    ''' <summary>
    ''' Fills an order by running the Sales.uspFillOrder stored procedure on the database.
    ''' </summary>
    Private Sub btnFillOrder_Click(sender As Object, e As EventArgs) Handles btnFillOrder.Click

        ' Set up and run stored procedure only if OrderID is valid.  
        If IsOrderIDValid() Then

            ' Create the connection. 
            Using connection As New SqlConnection(My.Settings.connString)

                ' Create command and identify it as a stored procedure.  
                Using sqlCommand As New SqlCommand("Sales.uspFillOrder", connection)

                    sqlCommand.CommandType = CommandType.StoredProcedure

                    ' Add input parameter for the stored procedure.  
                    sqlCommand.Parameters.Add(New SqlParameter("@orderID", SqlDbType.Int))
                    sqlCommand.Parameters("@orderID").Value = parsedOrderID

                    ' Add second input parameter.  
                    sqlCommand.Parameters.Add(New SqlParameter("@FilledDate", SqlDbType.DateTime, 8))
                    sqlCommand.Parameters("@FilledDate").Value = dtpFillDate.Value

                    Try
                        ' Open the connection.  
                        connection.Open()

                        ' Run the SqlCommand.   
                        sqlCommand.ExecuteNonQuery()
                    Catch
                        ' A simple catch.  
                        MessageBox.Show("The fill operation was not completed.")
                    Finally
                        ' Close the connection.  
                        connection.Close()
                    End Try
                End Using
            End Using
        End If
    End Sub

    ''' <summary>
    ''' Cancels an order by running the Sales.uspCancelOrder stored procedure on the database.
    ''' </summary>
    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click

        ' Set up and run the stored procedure only if OrderID is ready.  
        If IsOrderIDValid() Then

            ' Create the connection. 
            Using connection As New SqlConnection(My.Settings.connString)

                ' Create the command and identify it as a stored procedure.  
                Using sqlCommand As New SqlCommand("Sales.uspCancelOrder", connection)
                    sqlCommand.CommandType = CommandType.StoredProcedure

                    ' Add input parameter for the stored procedure.  
                    sqlCommand.Parameters.Add(New SqlParameter("@orderID", SqlDbType.Int))
                    sqlCommand.Parameters("@orderID").Value = parsedOrderID

                    Try
                        ' Open the connection.  
                        connection.Open()

                        ' Run the SqlCommand.  
                        sqlCommand.ExecuteNonQuery()
                    Catch
                        ' A simple catch.  
                        MessageBox.Show("The cancel operation was not completed.")
                    Finally
                        ' Close connection.  
                        connection.Close()
                    End Try
                End Using
            End Using
        End If
    End Sub

    ''' <summary>
    ''' Closes the form and returns focus to the Navigation form.
    ''' </summary>
    Private Sub btnFinishUpdates_Click(sender As Object, e As EventArgs) Handles btnFinishUpdates.Click
        Me.Close()
    End Sub
    '</Snippet2>
End Class
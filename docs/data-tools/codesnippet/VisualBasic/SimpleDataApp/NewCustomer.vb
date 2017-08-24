Imports System.Data.SqlClient

Public Class NewCustomer

    '<Snippet1>
    ' Storage for ID values returned from the database.  
    Private parsedCustomerID As Integer
    Private orderID As Integer

    ''' <summary>
    ''' Verifies that the customer name text box is not empty.
    ''' </summary>
    Private ReadOnly Property IsCustomerNameValid As Boolean
        Get
            If txtCustomerName.Text = "" Then
                MessageBox.Show("Please enter a name.")
                Return False
            Else
                Return True
            End If
        End Get
    End Property

    ''' <summary>
    ''' Verifies the order data is valid. 
    ''' </summary>
    Private Function IsOrderDataValid() As Boolean

        ' Verify that CustomerID is present.  
        If txtCustomerID.Text = "" Then
            MessageBox.Show("Please create a customer account before placing order.")
            Return False

            ' Verify that order amount isn't 0.   
        ElseIf (numOrderAmount.Value < 1) Then
            MessageBox.Show("Please specify an order amount.")
            Return False
        Else
            ' Order can be submitted.  
            Return True
        End If
    End Function

    ''' <summary>
    ''' Clears values from controls.
    ''' </summary>
    Private Sub ClearForm()
        txtCustomerName.Clear()
        txtCustomerID.Clear()
        dtpOrderDate.Value = DateTime.Now
        numOrderAmount.Value = 0
        Me.parsedCustomerID = 0
    End Sub
    '</Snippet1>

    '<Snippet2>
    ''' <summary>
    ''' Creates a new account by executing the Sales.uspNewCustomer
    ''' stored procedure on the database.
    ''' </summary>
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        ' Ensure a customer name has been entered.
        If IsCustomerNameValid Then

            ' Create the SqlConnection object. 
            Using connection As New SqlConnection(My.Settings.connString)

                ' Create a SqlCommand, and identify the command type as a stored procedure.  
                Using sqlCommand As New SqlCommand("Sales.uspNewCustomer", connection)
                    sqlCommand.CommandType = CommandType.StoredProcedure

                    ' Add the customer name input parameter for the stored procedure.  
                    sqlCommand.Parameters.Add(New SqlParameter("@CustomerName", SqlDbType.NVarChar, 40))
                    sqlCommand.Parameters("@CustomerName").Value = txtCustomerName.Text

                    ' Add the customer ID output parameter.  
                    sqlCommand.Parameters.Add(New SqlParameter("@CustomerID", SqlDbType.Int))
                    sqlCommand.Parameters("@CustomerID").Direction = ParameterDirection.Output

                    Try
                        ' Open the connection.  
                        connection.Open()

                        ' Run the stored procedure.  
                        sqlCommand.ExecuteNonQuery()

                        ' Convert the Customer ID value to an Integer.   
                        Me.parsedCustomerID = CInt(sqlCommand.Parameters("@CustomerID").Value)

                        ' Insert the customer ID into the corresponding text box.
                        Me.txtCustomerID.Text = Convert.ToString(parsedCustomerID)
                    Catch
                        MessageBox.Show("Customer ID was not returned. Account could not be created.")
                    Finally
                        ' Close the connection.  
                        connection.Close()
                    End Try
                End Using
            End Using
        End If
    End Sub

    ''' <summary>
    ''' Places the order by executing the Sales.uspPlaceNewOrder
    ''' stored procedure on the database.
    ''' </summary>
    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click

        If IsOrderDataValid() Then

            ' Create the connection.  
            Using connection As New SqlConnection(My.Settings.connString)

                ' Create SqlCommand and identify it as a stored procedure.  
                Using sqlCommand As New SqlCommand("Sales.uspPlaceNewOrder", connection)
                    sqlCommand.CommandType = CommandType.StoredProcedure

                    ' Add the @CustomerID parameter, which was an output parameter from uspNewCustomer.  
                    sqlCommand.Parameters.Add(New SqlParameter("@CustomerID", SqlDbType.Int))
                    sqlCommand.Parameters("@CustomerID").Value = Me.parsedCustomerID

                    ' Add the @OrderDate parameter.  
                    sqlCommand.Parameters.Add(New SqlParameter("@OrderDate", SqlDbType.DateTime, 8))
                    sqlCommand.Parameters("@OrderDate").Value = dtpOrderDate.Value

                    ' Add the @Amount parameter.  
                    sqlCommand.Parameters.Add(New SqlParameter("@Amount", SqlDbType.Int))
                    sqlCommand.Parameters("@Amount").Value = numOrderAmount.Value

                    ' Add the @Status parameter. For a new order, the status is always O (open).  
                    sqlCommand.Parameters.Add(New SqlParameter("@Status", SqlDbType.[Char], 1))
                    sqlCommand.Parameters("@Status").Value = "O"

                    ' Add a return value parameter for the stored procedure, which is the orderID.  
                    sqlCommand.Parameters.Add(New SqlParameter("@RC", SqlDbType.Int))
                    sqlCommand.Parameters("@RC").Direction = ParameterDirection.ReturnValue

                    Try
                        ' Open connection.  
                        connection.Open()

                        ' Run the stored procedure.  
                        sqlCommand.ExecuteNonQuery()

                        ' Display the order number.  
                        Me.orderID = CInt(sqlCommand.Parameters("@RC").Value)
                        MessageBox.Show("Order number " & (Me.orderID).ToString & " has been submitted.")
                    Catch
                        ' A simple catch.  
                        MessageBox.Show("Order could  not be placed.")
                    Finally
                        ' Always close a connection after you finish using it,
                        ' so that it can be released to the connection pool.
                        connection.Close()
                    End Try
                End Using
            End Using
        End If
    End Sub

    ''' <summary>
    ''' Resets the form for another new account.
    ''' </summary>
    Private Sub btnAddAnotherAccount_Click(sender As Object, e As EventArgs) Handles btnAddAnotherAccount.Click
        Me.ClearForm()
    End Sub

    ''' <summary>
    ''' Closes the NewCustomer form and returns focus to the Navigation form.
    ''' </summary>
    Private Sub btnAddFinish_Click(sender As Object, e As EventArgs) Handles btnAddFinish.Click
        Me.Close()
    End Sub
    '</Snippet2>
End Class
'<Snippet1>
Imports System.Data.SqlClient

Public Class NewCustomer

    ' Storage for identity values returned from the database.  
    Private parsedCustomerID As Integer
    Private orderID As Integer

    ''' <summary>
    ''' Verifies that the customer name text box is not empty.
    ''' </summary>
    Private ReadOnly Property HasCustomerName As Boolean
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
    ''' Creates a new account.
    ''' </summary>
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        ' Only run uspNewCustomer on the database if a customer name has been entered.
        If HasCustomerName Then

            ' Create the SqlConnection object. 
            Dim conn As New SqlConnection(My.Settings.connString)

            ' Create a SqlCommand, and identify the command type as a stored procedure.  
            Dim cmdNewCustomer As New SqlCommand("Sales.uspNewCustomer", conn)
            cmdNewCustomer.CommandType = CommandType.StoredProcedure

            ' Add the customer name input parameter for the stored procedure.  
            cmdNewCustomer.Parameters.Add(New SqlParameter("@CustomerName", SqlDbType.NVarChar, 40))
            cmdNewCustomer.Parameters("@CustomerName").Value = txtCustomerName.Text

            ' NAdd the customer ID output parameter.  
            cmdNewCustomer.Parameters.Add(New SqlParameter("@CustomerID", SqlDbType.Int))
            cmdNewCustomer.Parameters("@CustomerID").Direction = ParameterDirection.Output

            ' Open the connection, run the stored procedure, handle exceptions, and then close the connection.
            Try
                ' Open the connection.  
                conn.Open()

                ' Run the stored procedure.  
                cmdNewCustomer.ExecuteNonQuery()

                ' Convert the Customer ID value to an Integer.   
                Me.parsedCustomerID = CInt(cmdNewCustomer.Parameters("@CustomerID").Value)

                ' Insert the customer ID into the corresponding text box.
                Me.txtCustomerID.Text = Convert.ToString(parsedCustomerID)

            Catch
                MessageBox.Show("Customer ID was not returned. Account could not be created.")
            Finally
                ' Close the connection.  
                conn.Close()
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Places the order.
    ''' </summary>
    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        ' Set up and run the stored procedure on the database
        ' only if the necessary input is present.  
        If ReadyToPlaceOrder() Then

            ' Create the connection.  
            Dim conn As New SqlConnection(My.Settings.connString)

            ' Create SqlCommand and identify it as a stored procedure.  
            Dim cmdNewOrder As New SqlCommand("Sales.uspPlaceNewOrder", conn)
            cmdNewOrder.CommandType = CommandType.StoredProcedure

            ' Add the @CustomerID parameter, which was an output parameter from uspNewCustomer.  
            cmdNewOrder.Parameters.Add(New SqlParameter("@CustomerID", SqlDbType.Int))
            cmdNewOrder.Parameters("@CustomerID").Value = Me.parsedCustomerID

            ' Add the @OrderDate parameter.  
            cmdNewOrder.Parameters.Add(New SqlParameter("@OrderDate", SqlDbType.DateTime, 8))
            cmdNewOrder.Parameters("@OrderDate").Value = dtpOrderDate.Value

            ' Add the @Amount parameter.  
            cmdNewOrder.Parameters.Add(New SqlParameter("@Amount", SqlDbType.Int))
            cmdNewOrder.Parameters("@Amount").Value = numOrderAmount.Value

            ' Add the @Status parameter. For a new order, the status is always O (open).  
            cmdNewOrder.Parameters.Add(New SqlParameter("@Status", SqlDbType.[Char], 1))
            cmdNewOrder.Parameters("@Status").Value = "O"

            ' Add a return value parameter for the stored procedure, which is the orderID.  
            cmdNewOrder.Parameters.Add(New SqlParameter("@RC", SqlDbType.Int))
            cmdNewOrder.Parameters("@RC").Direction = ParameterDirection.ReturnValue

            Try
                ' Open connection.  
                conn.Open()

                ' Run the stored procedure.  
                cmdNewOrder.ExecuteNonQuery()

                ' Display the order number.  
                Me.orderID = CInt(cmdNewOrder.Parameters("@RC").Value)
                MessageBox.Show("Order number " & (Me.orderID).ToString & " has been submitted.")
            Catch
                ' A simple catch.  
                MessageBox.Show("Order could  not be placed.")
            Finally
                ' Always close a connection after you finish using it,
                ' so that it can be released to the connection pool.
                conn.Close()
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Verifies the order data is valid. 
    ''' </summary>
    Private Function ReadyToPlaceOrder() As Boolean

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
    ''' Resets the form for another new account.
    ''' </summary>
    Private Sub btnAddAnotherAccount_Click(sender As Object, e As EventArgs) Handles btnAddAnotherAccount.Click
        Me.ClearForm()
    End Sub

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

    ''' <summary>
    ''' Closes the NewCustomer form and returns focus to the Navigation form.
    ''' </summary>
    Private Sub btnAddFinish_Click(sender As Object, e As EventArgs) Handles btnAddFinish.Click
        Me.Close()
    End Sub
End Class
'</Snippet1>
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SimpleDataApp
{
    public partial class FillOrCancel : Form
    {
        public FillOrCancel()
        {
            InitializeComponent();
        }

        //<Snippet1>
        // Storage for the order ID value.
        private int parsedOrderID;

        /// <summary>
        /// Verifies that an order ID is present and contains valid characters.
        /// </summary>
        private bool IsOrderIDValid()
        {
            // Check for input in the Order ID text box.
            if (txtOrderID.Text == "")
            {
                MessageBox.Show("Please specify the Order ID.");
                return false;
            }

            // Check for characters other than integers.
            else if (Regex.IsMatch(txtOrderID.Text, @"^\D*$"))
            {
                // Show message and clear input.
                MessageBox.Show("Customer ID must contain only numbers.");
                txtOrderID.Clear();
                return false;
            }
            else
            {
                // Convert the text in the text box to an integer to send to the database.
                parsedOrderID = Int32.Parse(txtOrderID.Text);
                return true;
            }
        }
        //</Snippet1>

        //<Snippet2>
        /// <summary>
        /// Executes a t-SQL SELECT statement to obtain order data for a specified
        /// order ID, then displays it in the DataGridView on the form.
        /// </summary>
        private void btnFindByOrderID_Click(object sender, EventArgs e)
        {
            if (IsOrderIDValid())
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    // Define a t-SQL query string that has a parameter for orderID.
                    const string sql = "SELECT * FROM Sales.Orders WHERE orderID = @orderID";

                    // Create a SqlCommand object.
                    using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        // Define the @orderID parameter and set its value.
                        sqlCommand.Parameters.Add(new SqlParameter("@orderID", SqlDbType.Int));
                        sqlCommand.Parameters["@orderID"].Value = parsedOrderID;

                        try
                        {
                            connection.Open();

                            // Run the query by calling ExecuteReader().
                            using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                            {
                                // Create a data table to hold the retrieved data.
                                DataTable dataTable = new DataTable();

                                // Load the data from SqlDataReader into the data table.
                                dataTable.Load(dataReader);

                                // Display the data from the data table in the data grid view.
                                this.dgvCustomerOrders.DataSource = dataTable;

                                // Close the SqlDataReader.
                                dataReader.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("The requested order could not be loaded into the form.");
                        }
                        finally
                        {
                            // Close the connection.
                            connection.Close();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Cancels an order by calling the Sales.uspCancelOrder
        /// stored procedure on the database.
        /// </summary>
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (IsOrderIDValid())
            {
                // Create the connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    // Create the SqlCommand object and identify it as a stored procedure.
                    using (SqlCommand sqlCommand = new SqlCommand("Sales.uspCancelOrder", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // Add the order ID input parameter for the stored procedure.
                        sqlCommand.Parameters.Add(new SqlParameter("@orderID", SqlDbType.Int));
                        sqlCommand.Parameters["@orderID"].Value = parsedOrderID;

                        try
                        {
                            // Open the connection.
                            connection.Open();

                            // Run the command to execute the stored procedure.
                            sqlCommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("The cancel operation was not completed.");
                        }
                        finally
                        {
                            // Close connection.
                            connection.Close();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Fills an order by calling the Sales.uspFillOrder stored
        /// procedure on the database.
        /// </summary>
        private void btnFillOrder_Click(object sender, EventArgs e)
        {
            if (IsOrderIDValid())
            {
                // Create the connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    // Create command and identify it as a stored procedure.
                    using (SqlCommand sqlCommand = new SqlCommand("Sales.uspFillOrder", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // Add the order ID input parameter for the stored procedure.
                        sqlCommand.Parameters.Add(new SqlParameter("@orderID", SqlDbType.Int));
                        sqlCommand.Parameters["@orderID"].Value = parsedOrderID;

                        // Add the filled date input parameter for the stored procedure.
                        sqlCommand.Parameters.Add(new SqlParameter("@FilledDate", SqlDbType.DateTime, 8));
                        sqlCommand.Parameters["@FilledDate"].Value = dtpFillDate.Value;

                        try
                        {
                            connection.Open();

                            // Execute the stored procedure.
                            sqlCommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("The fill operation was not completed.");
                        }
                        finally
                        {
                            // Close the connection.
                            connection.Close();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Closes the form.
        /// </summary>
        private void btnFinishUpdates_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //</Snippet2>
    }
}

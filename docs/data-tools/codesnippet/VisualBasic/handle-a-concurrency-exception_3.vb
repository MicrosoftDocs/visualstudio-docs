    Private Function CreateMessage(ByVal cr As NorthwindDataSet.CustomersRow) As String
        Return "Database: " & GetRowData(GetCurrentRowInDB(cr), 
                                         Data.DataRowVersion.Default) & vbCrLf &
               "Original: " & GetRowData(cr, Data.DataRowVersion.Original) & vbCrLf &
               "Proposed: " & GetRowData(cr, Data.DataRowVersion.Current) & vbCrLf &
               "Do you still want to update the database with the proposed value?"
    End Function


    '--------------------------------------------------------------------------
    ' This method loads a temporary table with current records from the database
    ' and returns the current values from the row that caused the exception.
    '--------------------------------------------------------------------------
    Private TempCustomersDataTable As New NorthwindDataSet.CustomersDataTable

    Private Function GetCurrentRowInDB(
        ByVal RowWithError As NorthwindDataSet.CustomersRow
        ) As NorthwindDataSet.CustomersRow

        Me.CustomersTableAdapter.Fill(TempCustomersDataTable)

        Dim currentRowInDb As NorthwindDataSet.CustomersRow =
            TempCustomersDataTable.FindByCustomerID(RowWithError.CustomerID)

        Return currentRowInDb
    End Function


    '--------------------------------------------------------------------------
    ' This method takes a CustomersRow and RowVersion 
    ' and returns a string of column values to display to the user.
    '--------------------------------------------------------------------------
    Private Function GetRowData(ByVal custRow As NorthwindDataSet.CustomersRow,
        ByVal RowVersion As Data.DataRowVersion) As String

        Dim rowData As String = ""

        For i As Integer = 0 To custRow.ItemArray.Length - 1
            rowData &= custRow.Item(i, RowVersion).ToString() & " "
        Next

        Return rowData
    End Function
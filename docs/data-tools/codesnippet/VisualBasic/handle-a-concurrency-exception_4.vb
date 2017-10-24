    ' This method takes the DialogResult selected by the user and updates the database 
    ' with the new values or cancels the update and resets the Customers table 
    ' (in the dataset) with the values currently in the database.

    Private Sub ProcessDialogResult(ByVal response As Windows.Forms.DialogResult)

        Select Case response

            Case Windows.Forms.DialogResult.Yes
                NorthwindDataSet.Customers.Merge(TempCustomersDataTable, True)
                UpdateDatabase()

            Case Windows.Forms.DialogResult.No
                NorthwindDataSet.Customers.Merge(TempCustomersDataTable)
                MsgBox("Update cancelled")
        End Select
    End Sub